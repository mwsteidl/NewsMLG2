/******************************************************************************
Company: NewsIT-M.W.Steidl, 1180 Wien/Österreich (Vienna/Austria)

Copyright 2014 NewsIT-M.W.Steidl (www.newsit.biz)

Permission is hereby granted, free of charge, to any person obtaining a copy 
of this software and associated documentation files (the "Software"), to deal 
in the Software without restriction, including without limitation the rights 
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies 
of the Software, and to permit persons to whom the Software is furnished 
to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included 
in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS 
OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS 
IN THE SOFTWARE.
(see also http://www.opensource.org/licenses/MIT) 
 
Project: IPTC NewsML-G2 library
Program: no specific / Common Unit
Class: NewsIT.IPTC.NewsMLG2.v217.AnyItemPwrXML = shared framework for all NewsML-G2 items

Current date / persID / change log (most current at top)
StartDate: 2010-12 -> 2014-02-22 mws
******************************************************************************/
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Collections;
using System.Collections.Specialized;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;
using System.Text;
using System.Reflection;

namespace NewsIT.IPTC.NewsMLG2.v217
{
	// *************************************************************************
	#region **** GENERIC ENUMERATIONS

    //**************************************************************************
    public enum ReadFromItemResultEnum { ok, unknown, firstFromMultiple, emptyXPath, emptyAttribname, targetNotFound,
                                        valuetypeConversionFailed };
    public enum ElementTextvalueTypeEnum { innerText, innerXML };

    public enum ItemProcStateEnum { ok, error, unknown };

    public enum ItemProcErrEnum
    {
        NoError,
        PropNotFromNarNamespace,
        NoWrapperIdAvailable,
        NoPropNameAvailable,
        NoXPathAvailable,
        XmlNodeNotFound,
    };

    public enum PropProcStatus
    {
        ok,
        ErrNoParentXmlElement,
        ErrNoXPath,
        ErrElementNotFound,
        ErrElementsToManyFound
    }

	#endregion

    //**************************************************************************
    //**************************************************************************
    //**************************************************************************
    /// <summary>
    /// The class represents the base of all NewsML-G2 item classes
    /// </summary>
    public abstract class AnyItemXml
    {
        // the version of the corresponding NewsML-G2 specification:
        public const string Newsmlg2VersionCs = "2.17";
        // namespace URI of the NewsML-G2/News Architecture:
        public const string G2NsCs = "http://iptc.org/std/nar/2006-10-01/"; 
        // the namespace prefix of this News ARchitecture (=nar) namespace.
        // all elements of this NewsML-G2 namespace are attributed as "nar: elements"
        public const string G2NsPrefixCs = "nar";
        // NewsML-G2 Conformance Level: set to "power"
        public const string ConformanceLevelCs = "power";

        public XmlDocument ItemXdoc; // the XML document representing the G2 Item
        protected string RootElemName = ""; // well be provided by the item-specific classes

        public XmlNamespaceManager NsMngr;

        // ##############################################################################
        // ##### For the automated adding of properties

        // These are all child properties/elements of the root in NewsML-G2 items 
        //      they are wrappers of other properties
        public enum PropsWrapping1
        {
            Catalog, RightsInfo, ItemMeta, ContentMeta, PartMeta, ConceptSet, ContentSet, GroupSet, NewsConverageSet, NMHeader
        };

        /* These strings define the sequence of child element names of wrapping elements - see above
        | Each sequence reflects the NewsML-G2 XML Schema
        | These sequences are only used for adding properties
        */
        public const string NameSeqAnyRoot = "nar:catalogRef nar:catalog nar:hopHistory nar:rightsInfo nar:itemMeta";

        public const string NameSeqExtRoot = NameSeqAnyRoot
            + " nar:contentMeta nar:partMeta nar:assert nar:inlineRef nar:derivedFrom";

        public const string NameSeqFullRoot = NameSeqExtRoot
            + " nar:concept nar:conceptSet nar:schemeMeta nar:contentSet nar:groupSet nar:newsCoverageSet";

        public const string NameSeqHopHistory = "nar:hop";

        public const string NameSeqRightsInfo =
            "nar:accountable nar:copyrightHolder nar:copyrightNotice nar:usageTerms nar:link nar:rightsExtProperty";

        public const string NameSeqItemMeta =
            "nar:itemClass nar:provider nar:versionCreated nar:firstCreated "
            + "nar:embargoed nar:pubStatus nar:role nar:fileName nar:generator nar:profile nar:service nar:title "
            + "nar:edNote nar:memberOf nar:instanceOf nar:signal nar:altRep nar:deliverableOf nar:hash nar:expires";

        public const string NameSeqContentMetaAdmGroup =
            "nar:urgency nar:contentCreated nar:contentModified nar:located nar:infoSource nar:creator "
            + "nar:contributor nar:audience nar:exclAudience nar:altId nar:rating nar:userInteraction";

        public const string NameSeqContentMetaDescrCoreGroup =
            "nar:language nar:keyword nar:subject nar:slugline nar:headline nar:description";

        public const string NameSeqContentMetaDescrFullGroup =
            "nar:language nar:genre nar:keyword nar:subject nar:slugline nar:headline nar:dateline nar:by nar:creditline nar:description";

        public const string NameSeqContentMetaAcD =
            "nar:icon " + NameSeqContentMetaAdmGroup + " " + NameSeqContentMetaDescrCoreGroup +
            " nar:contentMetaExtProperty";

        public const string NameSeqContentMetaAfD =
            "nar:icon " + NameSeqContentMetaAdmGroup + " " + NameSeqContentMetaDescrFullGroup +
            " nar:contentMetaExtProperty";

        public const string NameSeqPartMeta = "nar:icon nar:timeDelim nar:regionDelim " 
            + NameSeqContentMetaAdmGroup + " " + NameSeqContentMetaDescrFullGroup + " nar:partMetaExtProperty";

        public const string NameSeqContentSet = "nar:inlineXML nar:inlineData nar:remoteContent";

        public const string NameSeqConceptRel = "nar:sameAs nar:broader nar:narrower nar:related ";

        public const string NameSeqConcept =
            "nar:conceptId nar:type nar:name nar:definition nar:note nar:remoteInfo "
            + "nar:hierarchyInfo " + NameSeqConceptRel +
            " nar:personDetails nar:organisationDetails nar:geoAreaDetails "
            + "nar:POIDetails nar:objectDetails nar:eventDetails";

        public const string NameSeqNMHeader = "nar:sent nar:catalogRef nar:catalog nar:sender nar:transmitId nar:origin "
            + "nar:timestamp nar:destination nar:channel nar:signal nar:headerExtProperty";

        //********************************************************************************
        /// <summary>
        /// Constructor for a blank G2 Item object - has to be initialised before being used
        /// </summary>
        public AnyItemXml()
        {
            ItemXdoc = new XmlDocument();
            NsMngr = new XmlNamespaceManager(ItemXdoc.NameTable);
            NsMngr.AddNamespace("nar", G2NsCs);
        }

        //********************************************************************************
        //********************************************************************************

        #region ***** CLASS P R O P E R T I E S

        //********************************************************************************

        private ItemProcStateEnum _ItemPropState;

        protected ItemProcStateEnum ItemPropState
        {
            get { return _ItemPropState; }
            set { _ItemPropState = value; }
        }

        private ItemProcErrEnum _Err = ItemProcErrEnum.NoError;

        public ItemProcErrEnum Err
        {
            get { return _Err; }
            set { _Err = value; }
        }

        private string _ErrStr = "";

        public string ErrStr
        {
            get { return _ErrStr; }
            set { _ErrStr = value; }
        }

        public string RootName
        {
            get { return RootElemName; }
        }

        #endregion

        // *******************************************************************************
        // *******************************************************************************

        #region ***** BASIC METHODS

        // *******************************************************************************
        /// <summary>
        /// Initializes an empty XML document with the required basic XML nodes.
        /// </summary>
        public abstract void InitEmptyXMLDoc();

        /// <summary>
        /// Initializes an empty XML document with the required basic XML nodes and
        /// adds key attributes to the root element
        /// </summary>
        /// <param name="guid">The item's GUID</param>
        /// <param name="version">The version number</param>
        public abstract void InitEmptyXMLDoc(string guid, int version);

        /// <summary>
        /// Initialized an item from a template file.
        /// </summary>
        /// <param name="fileName"></param>
        public void InitDocFromTemplateFile(string fileName)
            // Code History:
            // 2010-12-10 mws
        {
            if (string.IsNullOrEmpty(fileName))
                return;
            if (!File.Exists(fileName))
                return;
            ItemXdoc.RemoveAll();
            ItemXdoc.Load(fileName);
        }

        /// <summary>
        /// Initialized an item from a string
        /// </summary>
        /// <param name="xMLtemplate">A string representing the template XML document</param>
        public void InitDocFromTemplateString(string xMLtemplate)
            // Code History:
            // 2010-12-10 mws
        {
            ItemXdoc.RemoveAll();
            ItemXdoc.LoadXml(xMLtemplate);
        }


        #endregion

        // *******************************************************************************
        // *******************************************************************************

        #region ***** WRITE DOCUMENT METHODS

        // *******************************************************************************
        /// <summary>
        /// Saves the serialized XML of the item of a file
        /// </summary>
        /// <param name="fileName">Filename (optionally including path)</param>
        /// <param name="saveWithBOM">Set to true if a BOM shold be added to the file</param>
        public void SaveToFile(string fileName, bool saveWithBOM)
            // Code History:
            // 2010-12-09 mws, ~2010-12-15
        {
            if (saveWithBOM)
                ItemXdoc.Save(fileName);
            else
            {
                var uTF8NoPreamble = new UTF8Encoding(false);
                var xdocSw = new StreamWriter(fileName, false, uTF8NoPreamble);
                ItemXdoc.Save(xdocSw);
                xdocSw.Close();
                xdocSw.Dispose();
            }
        } // SaveToFile

        #endregion

        // ***** WRITE TO ITEM METHODS ***************************************************
        #region ***** WRITE TO ITEM METHODS

        // ******************************************************************************
        // ***** G E N E R I C

        // *******************************************************************************
        /// <summary>
        /// Adds a nar: element which is a member of the PropsWrapping1 enumeration 
        /// as child of the root element. Checks first if the element already exists.
        /// </summary>
        /// <param name="wrapper">The wrapping element which should be added</param>
        /// <param name="wrapperId">The @id value of the wrapping element 
        /// - used for elements with unbounded cardinality</param>
        /// <returns>True if successfully executed</returns>
        public bool CheckAddNarWrapper1(PropsWrapping1 wrapper, string wrapperId)
            // Code History:
            // 2014-02-26 mws
        {
            ResetErrState();
            string wrapperParentXPath, wrapperParentChildNameSeq;
            var wrapperXPath = string.Empty;
            var wrapperLocalName = string.Empty;
            var  wrapperChildNameSeq = string.Empty;
            if (!GetNarWrapper1Details(wrapper, wrapperId, out wrapperParentXPath, out wrapperParentChildNameSeq,
                out wrapperXPath, out wrapperLocalName, out wrapperChildNameSeq))
            {
                return false;
            }
            if (!ExistsXN(wrapperXPath))
            {
                XmlElement newWrapperXElement = ItemXdoc.CreateElement(wrapperLocalName, G2NsCs);
                if (!string.IsNullOrEmpty(wrapperId))
                {
                    if (wrapperLocalName == "partMeta")
                        newWrapperXElement.SetAttribute("partid", wrapperId);
                    else
                        newWrapperXElement.SetAttribute("id", wrapperId);
                }
                AddNarPropertyToParent(wrapperParentXPath, wrapperParentChildNameSeq, newWrapperXElement);
            }
            return true;
        }
        // no-id variant
        public bool CheckAddNarWrapper1(PropsWrapping1 wrapper)
        {
            return CheckAddNarWrapper1(wrapper, string.Empty);
        }

        // *******************************************************************************
        /// <summary>
        /// Adds a child nar: element to a wrapping element (member of the PropsWrapping1 enumeration)
        /// </summary>
        /// <param name="wrapper">Wrapping element</param>
        /// <param name="wrapperId">If required: the @id value of the wrapping element</param>
        /// <param name="newProperty">Object representing the element/property to be added</param>
        /// <param name="propertyXe">Return the XmlElement of the added element</param>
        /// <returns>True if successfully executed</returns>
        public bool AddNarPropertyToWrapper1(PropsWrapping1 wrapper, string wrapperId, object newProperty, out XmlElement propertyXe)
            // Code History:
            // 2014-02-25 mws
        {
            ResetErrState();
            propertyXe = null;
            var wrapperXPath = string.Empty;
            var wrapperLocalName = string.Empty;
            var wrapperChildNameSeq = string.Empty;
            if (!GetNarWrapper1Details(wrapper, wrapperId, out wrapperXPath, out wrapperLocalName, out wrapperChildNameSeq))
            {
                return false;
            }

            var newPropName = string.Empty;
            var newPropUsageCode = string.Empty;
            var newPropCard = string.Empty;

            FieldInfo[] fi = newProperty.GetType().GetFields(BindingFlags.Public | BindingFlags.Instance);
            foreach (FieldInfo info in fi)
            {
                if (info.Name == "Xname")
                {
                    try { newPropName = info.GetValue(newProperty).ToString(); }
                    catch (NullReferenceException ex) { continue; }
                    continue;
                }
                if (info.Name == "Xusagecode")
                {
                    try { newPropUsageCode = info.GetValue(newProperty).ToString(); }
                    catch (NullReferenceException ex) { continue; }
                    continue;
                }
                if (info.Name == "Xcard")
                {
                    try { newPropCard = info.GetValue(newProperty).ToString(); }
                    catch (NullReferenceException ex) { continue; }
                    continue;
                }
            }

            // check if the wrapper element exists, if not: add it.
            if (!CheckAddNarWrapper1(wrapper, wrapperId))
                return false;

            // create a new XmlElement from the property class
            propertyXe = ItemXdoc.CreateElement(newPropName, G2NsCs);
            NarProperty2XmlElement(newProperty, propertyXe);
            // add the new XmlElement as a child of the wrapper
            AddNarPropertyToParent(wrapperXPath, wrapperChildNameSeq, propertyXe);
            return true;
        } // AddNarPropertyToWrapper1

        public bool AddNarPropertyToWrapper1(PropsWrapping1 wrapper, string wrapperId, object newProperty)
        {
            XmlElement dummyXe;
            return AddNarPropertyToWrapper1(wrapper, wrapperId, newProperty, out dummyXe);
        }

        // no-id variant
        public bool AddNarPropertyToWrapper1(PropsWrapping1 wrapper, object newProperty, out XmlElement propertyXe)
        {
            return AddNarPropertyToWrapper1(wrapper, string.Empty, newProperty, out propertyXe);
        }

        public bool AddNarPropertyToWrapper1(PropsWrapping1 wrapper, object newProperty)
        {
            return AddNarPropertyToWrapper1(wrapper, string.Empty, newProperty);
        }


        // *******************************************************************************
        /// <summary>
        /// Adds a nar: element/property (provided as Object) to a parent element
        /// </summary>
        /// <param name="parentXPath">XPath for the parent element - should select only one</param>
        /// <param name="childnameSeq">Sequence of QNames of all child elements, separated by a space</param>
        /// <param name="newProperty">Object representing the property to be added</param>
        /// <returns>True if successfully executed</returns>
        public bool AddNarPropertyToParent(string parentXPath, string childnameSeq, object newProperty)
        // Code History:
        // 2014-02-23 mws
        {
            ResetErrState();
            XmlElement newElement;
            if (!NarProperty2XmlElement(newProperty, out newElement))
                return false;
            string newPropertyName = string.Empty;
            if (newElement.NamespaceURI == G2NsCs)
                newPropertyName = "nar:" + newElement.Name;
            else
            {
                SetErrState(ItemProcErrEnum.PropNotFromNarNamespace);
                return false;
            }
            return AddPropertyToParent(parentXPath, childnameSeq, newPropertyName, newElement);
        } // AddNarPropertyToParent

        // *******************************************************************************
        /// <summary>
        /// Adds a nar: element/property (provided as XmlElement) to a parent element
        /// </summary>
        /// <param name="parentXPath">XPath for the parent element - should select only one</param>
        /// <param name="childnameSeq">Sequence of QNames of all child elements, separated by a space</param>
        /// <param name="newProperty">XmlElement represeting the property to be added</param>
        /// <returns>True if successfully executed</returns>
        public bool AddNarPropertyToParent(string parentXPath, string childnameSeq, XmlElement newProperty)
        // Code History:
        // 2014-02-23 mws
        {
            ResetErrState();
            string newPropertyName = string.Empty;
            if (newProperty.NamespaceURI == G2NsCs)
                newPropertyName = "nar:" + newProperty.Name;
            else
            {
                SetErrState(ItemProcErrEnum.PropNotFromNarNamespace);
                return false;
            }
            return AddPropertyToParent(parentXPath, childnameSeq, newPropertyName, newProperty);
        } // AddNarPropertyToParent

        // *******************************************************************************
        /// <summary>
        /// Adds a nar: element/property (provided as XmlElement) to a parent element
        /// </summary>
        /// <param name="parentXPath">XPath for the parent element - should select only one</param>
        /// <param name="childnameSeq">Sequence of QNames of all child elements, separated by a space</param>
        /// <param name="newPropertyName">QName of the property to be added</param>
        /// <param name="newProperty">XmlElement of the property to be added</param>
        /// <returns>True if successfully executed</returns>
        public bool AddPropertyToParent(string parentXPath, string childnameSeq, string newPropertyName, XmlElement newProperty)
        // Code History:
        // 2014-02-22 mws
        {
            ResetErrState();
            XmlNode parentXN;
            if (!FindXE(parentXPath, out parentXN))
                return false;

            XmlNode priorNode = FindPriorXNbubbleup(parentXPath, childnameSeq, newPropertyName);
            if (priorNode == null)
                parentXN.PrependChild(newProperty);
            else
                parentXN.InsertAfter(newProperty, priorNode);
            return true;
        } // AddPropertyToParent

        public bool AddPropertyToParent(string parentXPath, string childnameSeq, XmlElement newProperty)
        // NAR-specific version: retrieves the QName from the property
        {
            // 2014-02-25: forwarding to a renamed method
            return AddNarPropertyToParent(parentXPath, childnameSeq, newProperty);
        }

        // ******************************************************************************
        // ***** S P E C I F I C

        // ******************************************************************************
        /// <summary>
        /// Set the GUID and version number of a NewsML-G2 item
        /// </summary>
        /// <param name="guid"></param>
        /// <param name="version"></param>
        public void SetGuidAndVersion(string guid, long version)
        // Code History:
        // 2010-12-11 mws
        {
            XmlNode rootXN = ItemXdoc.SelectSingleNode("/nar:" + RootElemName, NsMngr);
            XmlElement docelement = (XmlElement)rootXN;
            if (!string.IsNullOrEmpty(guid))
                docelement.SetAttribute("guid", guid);
            if (version > 0)
                docelement.SetAttribute("version", version.ToString());

        } // SetGuidAndVersion

        /// <summary>
        /// Sets the xml:lang attribute of the root element
        /// </summary>
        /// <param name="xmllang">IETF BCP 47 compliant language tag</param>
        public void SetRootXmlLang(string xmllang)
        // Code History:
        // 2010-12-11 mws
        {
            XmlNode rootXN = ItemXdoc.SelectSingleNode("/nar:" + RootElemName, NsMngr);
            XmlElement docelement = (XmlElement)rootXN;
            if (!string.IsNullOrEmpty(xmllang))
                docelement.SetAttribute("xml:lang", xmllang);
        } // SetXmlLang

        // ******************************************************************************
        /// <summary>
        /// Adds a catalogRef element with href attribute
        /// </summary>
        /// <param name="href">URL of the catalog</param>
        public void AddCatalogRef(string href)
        // Code History:
        // 2010-12-09 mws
        {
            XmlElement catalogRef = ItemXdoc.CreateElement("catalogRef", G2NsCs);
            catalogRef.SetAttribute("href", href);
            ItemXdoc.DocumentElement.PrependChild(catalogRef);
        }


        #endregion

        // ***** SIMPLE (& constrained) WRITE METHODS ***********************************
        #region ***** SIMPLE (& constrained) WRITE METHODS

        // ******************************************************************************
        // ***** I T E M   M E T A
        // ******************************************************************************

        public void ScAddItemMeta()
        // Code History:
        // 2010-12-09, 2014-02-26 mws
        {
            CheckAddNarWrapper1(PropsWrapping1.ItemMeta);
        } // ScAddItemMeta

        public void ScAddIMitemClass(ItemClass itemClass)
        // Code History:
        // 2014-02-26 mws
        {
            AddNarPropertyToWrapper1(PropsWrapping1.ItemMeta, string.Empty, new ItemClass());
        }

        public void ScAddIMitemClass(string classQC)
        // Code History:
        // 2010-12-09; 2014-02-26 mws
        {
            var itemClass = new ItemClass();
            itemClass.qcode = classQC;
            AddNarPropertyToWrapper1(PropsWrapping1.ItemMeta, itemClass);
        } // ScAddIMitemClass

        // ******************************************************************************
        public void ScAddIMversionCreated(string dtValueAsStr)
        // Code History:
        // 2010-12-11, 2014-02-26 mws
        {
            var versionCreated = new VersionCreated();
            versionCreated.thisValue = dtValueAsStr;
            AddNarPropertyToWrapper1(PropsWrapping1.ItemMeta, versionCreated);
        } // ScAddIMversionCreated

        // ******************************************************************************
        public void ScAddIMfirstCreated(string dtValueAsStr)
        // Code History:
        // 2010-12-11, 2014-02-26 mws
        {
            var firstCreated = new FirstCreated();
            firstCreated.thisValue = dtValueAsStr;
            AddNarPropertyToWrapper1(PropsWrapping1.ItemMeta, firstCreated);
        } // ScAddIMfirstCreated

        // ******************************************************************************
        public void ScAddIMedNote(string text, string roleQC)
        // Code History:
        // 2010-12-09,2014-02-26 mws
        {
            var edNote = new EdNote();
            edNote.role = roleQC;
            edNote.thisValue = text;
            AddNarPropertyToWrapper1(PropsWrapping1.ItemMeta, edNote);
        } // ScAddIMedNote

        // ******************************************************************************
        // ***** C O N T E N T   M E T A 
        // ******************************************************************************
        public void ScAddContentMeta()
        // Code History:
        // 2010-12-11, 2014-02-26 mws
        {
            CheckAddNarWrapper1(PropsWrapping1.ContentMeta);
        } // ScAddContentMeta

        // ******************************************************************************
        public void ScAddCMurgency(int urgencyValue)
        // Code History:
        // 2014-02-26 mws
        {
            if (urgencyValue < 1)
                return;
            if (urgencyValue < 9)
                return;
            var urgency = new Urgency();
            urgency.thisValue = urgencyValue.ToString();
            AddNarPropertyToWrapper1(PropsWrapping1.ContentMeta, urgency);
        } // ScAddCMurgency

        // ******************************************************************************
        public void ScAddCMcontentCreated(string dtValueAsStr)
        // Code History:
        // 2010-12-11, 2014-02-26 mws
        {
            var contentCreated = new ContentCreated();
            contentCreated.thisValue = dtValueAsStr;
            AddNarPropertyToWrapper1(PropsWrapping1.ContentMeta, contentCreated);
        } // ScAddCMcontentCreated

        // ******************************************************************************
        public void ScAddCMcontentModified(string dtValueAsStr)
        // Code History:
        // 2010-12-11, 2014-02-26 mws
        {
            var contentModified = new ContentModified();
            contentModified.thisValue = dtValueAsStr;
            AddNarPropertyToWrapper1(PropsWrapping1.ContentMeta, contentModified);
        } // ScAddCMcontentModified

        // ******************************************************************************
        public void ScAddCMdescription(string text, string langTag)
        // Code History:
        // 2010-12-11, 2014-02-26 mws
        {
            var description = new Description();
            description.thisValue = text;
            description.xmllang = langTag;
            AddNarPropertyToWrapper1(PropsWrapping1.ContentMeta, description);
        } // ScAddCMdescription

        // ******************************************************************************
        // ***** P A R T   M E T A 
        // ******************************************************************************
        public void ScAddPartMeta(string partId)
        // Code History:
        // 2010-12-11, 2014-02-26 mws
        {
            CheckAddNarWrapper1(PropsWrapping1.PartMeta, partId);
        } // ScAddPartMeta

        public void ScAddPartMeta(string partId, int seq, string contentrefs)
        // Code History:
        // 2010-12-14, 2014-02-26 mws
        {
            CheckAddNarWrapper1(PropsWrapping1.PartMeta, partId);
            XmlElement partMetaXE = null;
            ReadFromItemResultEnum readResult;
            GetElemAsXE("/nar:" + RootElemName + "/nar:partMeta[@partid='" + partId + "']", out partMetaXE, out readResult);
            if (readResult == ReadFromItemResultEnum.ok)
            {
                if (seq > -1)
                    partMetaXE.SetAttribute("seq", seq.ToString());
                partMetaXE.SetAttribute("contentrefs", contentrefs);
            }

        } // ScAddPartMeta

        // ******************************************************************************
        public void ScAddPMcontentCreated(string partId, string dtValueAsStr)
        // Code History:
        // 2010-12-11,2014-02-26 mws
        {
            var contentCreated = new ContentCreated();
            contentCreated.thisValue = dtValueAsStr;
            AddNarPropertyToWrapper1(PropsWrapping1.PartMeta, partId, contentCreated);
        } // ScAddPMcontentCreated

        // ******************************************************************************
        public void ScAddPMcontentModified(string partId, string dtValueAsStr)
        // Code History:
        // 2010-12-11,2014-02-26 mws
        {
            var contentModified = new ContentModified();
            contentModified.thisValue = dtValueAsStr;
            AddNarPropertyToWrapper1(PropsWrapping1.PartMeta, partId, contentModified);
        } // ScAddPMcontentModified

        // ******************************************************************************
        public void ScAddPMdescription(string partId, string text, string roleQC)
        // Code History:
        // 2010-12-11,2014-02-26 mws
        {
            var description = new Description();
            description.thisValue = text;
            // description.xmllang = langTag;
            description.role = roleQC;
            AddNarPropertyToWrapper1(PropsWrapping1.PartMeta, partId, description);
        } // ScAddPMdescription


        #endregion

        // ***** READ FROM ITEM METHODS *************************************************
        #region ***** READ FROM ITEM METHODS

        // ******************************************************************************
        /// <summary>
        /// Gets an element/property as XmlElement
        /// </summary>
        /// <param name="xPath">XPath selecting the element</param>
        /// <param name="resultXE">Returned XmlElement</param>
        /// <param name="result">Returns a ReadFromItemResultEnum value</param>
        public void GetElemAsXE(
            string xPath,
            out XmlElement resultXE,
            out ReadFromItemResultEnum result)
        // Code History:
        // 2014-02-24 mws
        {
            resultXE = null;
            result = ReadFromItemResultEnum.ok;
            if (string.IsNullOrEmpty(xPath))
            {
                result = ReadFromItemResultEnum.emptyXPath;
                return;
            }
            XmlNodeList foundXNL = ItemXdoc.SelectNodes(xPath, NsMngr);
            if (foundXNL.Count == 0)
            {
                result = ReadFromItemResultEnum.targetNotFound;
                return;
            }
            if (foundXNL.Count > 1)
                result = ReadFromItemResultEnum.firstFromMultiple;

            resultXE = (XmlElement)foundXNL[0];
        } // GetElemAsXE

        // ******************************************************************************
        /// <summary>
        /// Gets one or more element(s)/property(ies) as XmlNodeList
        /// </summary>
        /// <param name="xPath">XPath selecting the element(s)</param>
        /// <param name="resultXNL">Returned XmlNodeList</param>
        /// <param name="result">Returns a ReadFromItemResultEnum value</param>
        public void GetElemsAsXNodeList(
            string xPath,
            out XmlNodeList resultXNL,
            out ReadFromItemResultEnum result)
        // Code History:
        // 2014-02-24 mws
        {
            resultXNL = null;
            result = ReadFromItemResultEnum.ok;
            if (string.IsNullOrEmpty(xPath))
            {
                result = ReadFromItemResultEnum.emptyXPath;
                return;
            }
            resultXNL = ItemXdoc.SelectNodes(xPath, NsMngr);
        } // GetElemsAsXNodeList

        // ******************************************************************************
        /// <summary>
        /// Gets inner value of an element/property as string
        /// </summary>
        /// <param name="xPath">XPath selecting the element</param>
        /// <param name="textvalueType">Select innerText or innerXML</param>
        /// <param name="value">Returned string value</param>
        /// <param name="result">Returns a ReadFromItemResultEnum value</param>
        public void GetElemValueAsString(
            string xPath,
            ElementTextvalueTypeEnum textvalueType,
            out string value,
            out ReadFromItemResultEnum result)
            // Code History:
            // 2010-12-31 mws
        {
            value = string.Empty;
            result = ReadFromItemResultEnum.ok;
            if (string.IsNullOrEmpty(xPath))
            {
                result = ReadFromItemResultEnum.emptyXPath;
                return;
            }
            XmlNodeList foundXNL = ItemXdoc.SelectNodes(xPath, NsMngr);
            if (foundXNL.Count == 0)
            {
                result = ReadFromItemResultEnum.targetNotFound;
                return;
            }
            if (foundXNL.Count > 1)
                result = ReadFromItemResultEnum.firstFromMultiple;

            switch (textvalueType)
            {
                case ElementTextvalueTypeEnum.innerText:
                    value = foundXNL[0].InnerText;
                    break;
                case ElementTextvalueTypeEnum.innerXML:
                    value = foundXNL[0].InnerXml;
                    break;
            }
        } // GetElemValueAsString

        // ******************************************************************************
        /// <summary>
        /// Gets textnode value of an element/property as int64
        /// </summary>
        /// <param name="xPath">XPath selecting the element</param>
        /// <param name="value">Returned int64 value</param>
        /// <param name="result">Returns a ReadFromItemResultEnum value</param>
        public void GetElemValueAsInt64(
            string xPath,
            out Int64 value,
            out ReadFromItemResultEnum result)
            // Code History:
            // 2010-12-31 mws
        {
            value = 0;
            result = ReadFromItemResultEnum.ok;
            if (string.IsNullOrEmpty(xPath))
            {
                result = ReadFromItemResultEnum.emptyXPath;
                return;
            }

            string valueStr;
            GetElemValueAsString(xPath, ElementTextvalueTypeEnum.innerText, out valueStr, out result);
            if ((result == ReadFromItemResultEnum.ok) || (result == ReadFromItemResultEnum.firstFromMultiple))
            {
                try
                {
                    value = Convert.ToInt64(valueStr);
                }
                catch
                {
                    result = ReadFromItemResultEnum.valuetypeConversionFailed;
                    value = 0;
                }
            }
            else
                return;
        } // GetElemValueAsInt64

        // ******************************************************************************
        /// <summary>
        /// Gets textnode value of an element/property as DateTime
        /// </summary>
        /// <param name="xPath">XPath selecting the element</param>
        /// <param name="value">Retured DateTime value</param>
        /// <param name="result">Returns a ReadFromItemResultEnum value</param>
        public void GetElemValueAsDateTime(
            string xPath,
            out DateTime value,
            out ReadFromItemResultEnum result)
            // Code History:
            // 2010-12-31 mws
        {
            value = DateTime.MinValue;
            result = ReadFromItemResultEnum.ok;
            if (string.IsNullOrEmpty(xPath))
            {
                result = ReadFromItemResultEnum.emptyXPath;
                return;
            }
            string valueStr;
            GetElemValueAsString(xPath, ElementTextvalueTypeEnum.innerText, out valueStr, out result);
            if ((result == ReadFromItemResultEnum.ok) || (result == ReadFromItemResultEnum.firstFromMultiple))
            {
                try
                {
                    value = Convert.ToDateTime(valueStr);
                }
                catch
                {
                    result = ReadFromItemResultEnum.valuetypeConversionFailed;
                    value = DateTime.MinValue;
                }
            }
            else
                return;
        } // GetElemValueAsDateTime

            

        // ******************************************************************************
        // ******************************************************************************
        /// <summary>
        /// Gets an attribute's value of an element/property as string
        /// </summary>
        /// <param name="xPath">XPath selecting the element</param>
        /// <param name="attribname">Name of the attributes</param>
        /// <param name="value">Returned string value</param>
        /// <param name="result">Returns a ReadFromItemResultEnum value</param>
        public void GetAttribValueAsString(
            string xPath,
            string attribname,
            out string value,
            out ReadFromItemResultEnum result)
            // Code History:
            // 2010-12-31 mws
        {
            value = string.Empty;
            result = ReadFromItemResultEnum.ok;
            if (string.IsNullOrEmpty(xPath))
            {
                result = ReadFromItemResultEnum.emptyXPath;
                return;
            }
            if (string.IsNullOrEmpty(attribname))
            {
                result = ReadFromItemResultEnum.emptyXPath;
                return;
            }
            XmlNodeList foundXNL = ItemXdoc.SelectNodes(xPath, NsMngr);
            if (foundXNL.Count == 0)
            {
                result = ReadFromItemResultEnum.targetNotFound;
                return;
            }
            if (foundXNL.Count > 1)
                result = ReadFromItemResultEnum.firstFromMultiple;
            value = ((XmlElement) foundXNL[0]).GetAttribute(attribname);
        } // GetAttribValueAsString

        // ******************************************************************************
        /// <summary>
        /// Gets an attribute's value of an element/property as int64
        /// </summary>
        /// <param name="xPath">XPath selecting the element</param>
        /// <param name="attribname">Name of the attributes</param>
        /// <param name="value">Returned int64 value</param>
        /// <param name="result">Returns a ReadFromItemResultEnum value</param>
        public void GetAttribValueAsInt64(
            string xPath,
            string attribname,
            out Int64 value,
            out ReadFromItemResultEnum result)
            // Code History:
            // 2010-12-31 mws
        {
            value = 0;
            string valueStr;
            GetAttribValueAsString(xPath, attribname, out valueStr, out result);
            if ((result == ReadFromItemResultEnum.ok) || (result == ReadFromItemResultEnum.firstFromMultiple))
            {
                try
                {
                    value = Convert.ToInt64(valueStr);
                }
                catch
                {
                    result = ReadFromItemResultEnum.valuetypeConversionFailed;
                    value = 0;
                }
            }
            else
                return;
        } // GetAttribValueAsInt64

        // ******************************************************************************
        /// <summary>
        /// Gets an attribute's value of an element/property as DateTime
        /// </summary>
        /// <param name="xPath">XPath selecting the element</param>
        /// <param name="attribname">Name of the attributes</param>
        /// <param name="value">Returned DateTime value</param>
        /// <param name="result">Returns a ReadFromItemResultEnum value</param>
        public void GetAttribValueAsDateTime(
            string xPath,
            string attribname,
            out DateTime value,
            out ReadFromItemResultEnum result)
            // Code History:
            // 2010-12-31 mws
        {
            value = DateTime.MinValue;
            string valueStr;
            GetAttribValueAsString(xPath, attribname, out valueStr, out result);
            if ((result == ReadFromItemResultEnum.ok) || (result == ReadFromItemResultEnum.firstFromMultiple))
            {
                try
                {
                    value = Convert.ToDateTime(valueStr);
                }
                catch
                {
                    result = ReadFromItemResultEnum.valuetypeConversionFailed;
                    value = DateTime.MinValue;
                }
            }
            else
                return;
        } // GetAttribValueAsDateTime

        // ******************************************************************************
        /// <summary>
        /// Gets all attributes of an element/property as Dictionary
        /// </summary>
        /// <param name="xPath">XPath selecting the element</param>
        /// <param name="dictionary">Returns the attributes as Dictionary of string key/value pairs</param>
        /// <param name="result">Returns a ReadFromItemResultEnum value</param>
        public void GetElemAttribsAsDictionary(
            string xPath,
            out Dictionary<string, string> dictionary,
            out ReadFromItemResultEnum result)
        // Code History:
        // 2014-02-26 mws
        {
            dictionary = new Dictionary<string, string>();
            result = ReadFromItemResultEnum.ok;
            if (string.IsNullOrEmpty(xPath))
            {
                result = ReadFromItemResultEnum.emptyXPath;
                return;
            }
            XmlNodeList foundXNL = ItemXdoc.SelectNodes(xPath, NsMngr);
            if (foundXNL.Count == 0)
            {
                result = ReadFromItemResultEnum.targetNotFound;
                return;
            }
            if (foundXNL.Count > 1)
                result = ReadFromItemResultEnum.firstFromMultiple;

            XmlElement foundXE = (XmlElement)foundXNL[0];
            for (int idx = 0; idx < foundXE.Attributes.Count; idx++)
            {
                string attrName = foundXE.Attributes[idx].LocalName;
                string attrValue = foundXE.Attributes[idx].Value;
                dictionary.Add(attrName, attrValue);
            }
            if (!string.IsNullOrEmpty(foundXE.InnerText))
                dictionary.Add("thisValue", foundXE.InnerText);
        } // GetElemAttribsAsDictionary

        #endregion

        // ***** SPECIAL PROPERTY ACCESS METHODS ****************************************
        #region ***** SPECIAL PROPERTY ACCESS METHODS

        // *******************************************************************************
        /// <summary>
        /// Searches for an existing element prior to the reference element,
        /// both are children of the same parent,
        /// as defined by a sequence of element names
        /// </summary>
        /// <param name="parentXPath">XPath of the parent element</param>
        /// <param name="childnameSeq">Sequence of QNames of all child elements, separated by a space</param>
        /// <param name="refXEname">The QName of the reference element</param>
        /// <returns></returns>
        public XmlNode FindPriorXNbubbleup(string parentXPath, string childnameSeq, string refXEname)
        // Code History:
        // 2014-02-22 mws
        {
            XmlNode foundXnode;
            if (!FindXE(parentXPath, out foundXnode))
            {
                return foundXnode;
            }
            foundXnode = null;
            string[] nameSeq = childnameSeq.Split(' '); // split by space character
            bool doFinding = false;
            for (int idx = nameSeq.Length - 1; idx > -1; idx--)
            {
                // Elements post the refXEname in the sequence must be ignored
                // "finding" starts if the current name in the sequence = refXEname
                if (!doFinding && (nameSeq[idx] == refXEname))
                    doFinding = true;
                if (doFinding)
                {
                    if (FindXE(parentXPath + "/" + nameSeq[idx], out foundXnode))
                    {
                        return foundXnode;
                    }
                }
            }
            return foundXnode; // should be null
        } // FindPriorXNbubbleup

        // *******************************************************************************
        /// <summary>
        /// Searches for an XML Node and returns it if found
        /// </summary>
        /// <param name="checkXPath">XPath of the node to be searched for</param>
        /// <param name="foundXnode">Returns a found XML Node</param>
        /// <returns>True if the node was found</returns>
        public bool FindXE(string checkXPath, out XmlNode foundXnode)
        // Code History:
        // 2014-02-22 mws
        {
            ResetErrState();
            foundXnode = null;
            if (string.IsNullOrEmpty(checkXPath))
            {
                SetErrState(ItemProcErrEnum.NoXPathAvailable);
                return false;
            }
            XmlNodeList tempXNL;
            tempXNL = ItemXdoc.SelectNodes(checkXPath, NsMngr);
            if ((tempXNL == null) || (tempXNL.Count == 0))
            {
                SetErrState(ItemProcErrEnum.XmlNodeNotFound);
                return false;
            }
            else
            {
                foundXnode = tempXNL[tempXNL.Count - 1]; // use the last one in a sequence
                return true;
            }
        } // findXE

        /// <summary>
        /// Searches for an XML Node by an XPath relative to the root element and returns it if found
        /// </summary>
        /// <param name="checkRelativeXPath">XPath relative to the item's root element of the node to be searched for</param>
        /// <param name="foundXnode">Returns a found XML Node</param>
        /// <returns>True if the node was found</returns>
        public bool FindRelXE(string checkRelativeXPath, out XmlNode foundXnode)
        // Code History:
        // 2014-02-22 mws
        {
            ResetErrState();
            foundXnode = null;
            if (string.IsNullOrEmpty(checkRelativeXPath))
            {
                SetErrState(ItemProcErrEnum.NoXPathAvailable);
                return false;
            }
            XmlNodeList tempXNL;
            string checkXPath = "/nar:" + RootElemName + checkRelativeXPath;
            tempXNL = ItemXdoc.SelectNodes(checkXPath, NsMngr);
            if ((tempXNL == null) || (tempXNL.Count == 0))
            {
                SetErrState(ItemProcErrEnum.XmlNodeNotFound);
                return false;
            }
            else
            {
                foundXnode = tempXNL[tempXNL.Count - 1]; // use the last one in a sequence
                return true;
            }
        } // findXE

        // *******************************************************************************
        /// <summary>
        /// Checks if an XML Node exists
        /// </summary>
        /// <param name="checkXPath">XPath of the node to be checked</param>
        /// <returns>True if the node exists</returns>
        public bool ExistsXN(string checkXPath)
        // Code History:
        // 2014-02-23 mws
        {
            if (string.IsNullOrEmpty(checkXPath))
            {
                SetErrState(ItemProcErrEnum.NoXPathAvailable);
                return false;
            }
            XmlNodeList tempXNL;
            tempXNL = ItemXdoc.SelectNodes(checkXPath, NsMngr);
            if ((tempXNL == null) || (tempXNL.Count == 0))
            {
                return false;
            }
            else
                return true;
        } // existsXE

        // *******************************************************************************
        /// <summary>
        /// Checks if an XML Node exists by an XPath relative to the root element
        /// </summary>
        /// <param name="checkRelativeXPath">XPath relative to the item's root element of the node to be searched for</param>
        /// <returns>True if the node exists</returns>
        public bool ExistsRelXN(string checkRelativeXPath)
        // Code History:
        // 2014-03-01 mws
        {
            if (string.IsNullOrEmpty(checkRelativeXPath))
            {
                SetErrState(ItemProcErrEnum.NoXPathAvailable);
                return false;
            }
            XmlNodeList tempXNL;
            string checkXPath = "/nar:" + RootElemName + checkRelativeXPath;
            tempXNL = ItemXdoc.SelectNodes(checkXPath, NsMngr);
            if ((tempXNL == null) || (tempXNL.Count == 0))
            {
                return false;
            }
            else
                return true;
        } // existsXE

        // *******************************************************************************
        /// <summary>
        /// Transforms a nar: property object to an existing XML Element
        /// </summary>
        /// <param name="aProperty">Object representing a nar: property</param>
        /// <param name="newElement">Target element</param>
        public void NarProperty2XmlElement(object aProperty, XmlElement newElement)
        // Code History:
        // 2014-02-25 mws
        {
            // retrieve information about the structure fields by NET Reflection
            FieldInfo[] fi = aProperty.GetType().GetFields(BindingFlags.Public | BindingFlags.Instance);
            string fieldName, fieldValue;
            foreach (FieldInfo info in fi)
            {
                try { fieldValue = info.GetValue(aProperty).ToString(); }
                catch (NullReferenceException ex) // exception is thrown if the field is empty.
                {
                    continue;
                }
                if (!string.IsNullOrEmpty(fieldValue))
                {
                    fieldName = info.Name;
                    if (fieldName[0] == 'X') // eXcluded field
                        continue;
                    if (fieldName[0] == 'Y') // name of field collided with C# keyword, Y was prefixed
                        fieldName = fieldName.Substring(1); // strip off first character
                    if (fieldName == "thisValue") // the value for the element's text node
                    {
                        newElement.InnerText = fieldValue;
                        continue; // skip adding an attribute
                    }
                    if (fieldName == "xmllang") // 
                        fieldName = "xml:lang";
                    newElement.SetAttribute(fieldName, fieldValue);
                }
            }
        } // NarProperty2XmlElement

        // *******************************************************************************
        /// <summary>
        /// Transforms a nar: property object to an XML Element
        /// </summary>
        /// <param name="aProperty">Object representing a nar: property</param>
        /// <param name="newElement">Returns the element after the transform action</param>
        /// <returns>True if successfully executed</returns>
        public bool NarProperty2XmlElement(object aProperty, out XmlElement newElement)
        // Code History:
        // 2014-02-26 mws
        {
            newElement = null;
            // retrieve information about the structure fields by NET Reflection
            FieldInfo[] fi = aProperty.GetType().GetFields(BindingFlags.Public | BindingFlags.Instance);
            string fieldName, fieldValue;
            string newPropName = string.Empty;
            foreach (FieldInfo info in fi)
            {
                try { fieldValue = info.GetValue(aProperty).ToString(); }
                catch (NullReferenceException ex) // exception is thrown if the field is empty.
                {
                    continue;
                }
                if (!string.IsNullOrEmpty(fieldValue))
                {
                    if (info.Name == "Xname")
                        newPropName = fieldValue;
                }
            }

            if (string.IsNullOrEmpty(newPropName))
            {
                SetErrState(ItemProcErrEnum.NoPropNameAvailable);
                return false;
            }

            newElement = ItemXdoc.CreateElement(newPropName, G2NsCs);
            foreach (FieldInfo info in fi)
            {
                try { fieldValue = info.GetValue(aProperty).ToString(); }
                catch (NullReferenceException ex) // exception is thrown if the field is empty.
                {
                    continue;
                }
                if (!string.IsNullOrEmpty(fieldValue))
                {
                    fieldName = info.Name;
                    if (fieldName[0] == 'X') // eXcluded field
                        continue;
                    if (fieldName[0] == 'Y') // name of field collided with C# keyword, Y was prefixed
                        fieldName = fieldName.Substring(1); // strip off first character
                    if (fieldName == "thisValue") // the value for the element's text node
                    {
                        newElement.InnerText = fieldValue;
                        continue; // skip adding an attribute
                    }
                    if (fieldName == "xmllang") // 
                        fieldName = "xml:lang";
                    newElement.SetAttribute(fieldName, fieldValue);
                }
            }
            return true;
        } // NarProperty2XmlElement


        // ******************************************************************************
        /// <summary>
        /// Returns a set of data about a member of the PropsWrapping1 enumeration 
        /// = top level elements of a NewsML-G2 item wrapping other properties
        /// </summary>
        /// <param name="wrapper">Wrapping property about which the details are requested</param>
        /// <param name="wrapperId">The @id of the wrapping element</param>
        /// <param name="wrapperParentXPath">Returned XPath of the parent of the wrapping element</param>
        /// <param name="wrapperParentChildNameSeq">Returned child name sequence of the wrapping element's parent</param>
        /// <param name="wrapperXPath">Returned XPath of the wrapping element</param>
        /// <param name="wrapperLocalName">Local name of the wrapping element</param>
        /// <param name="wrapperChildNameSeq">Child name sequence of the wrapping element</param>
        /// <returns>True if successfully executed</returns>
        public bool GetNarWrapper1Details(PropsWrapping1 wrapper, string wrapperId,
            out string wrapperParentXPath, out string wrapperParentChildNameSeq, 
            out string wrapperXPath, out string wrapperLocalName, out string wrapperChildNameSeq )
            // Code History:
            // 2014-02-26 mws
        {
            ResetErrState();
            wrapperParentXPath = "/nar:" + RootElemName;
            wrapperParentChildNameSeq = NameSeqFullRoot;
            wrapperXPath = string.Empty;
            wrapperLocalName = string.Empty;
            wrapperChildNameSeq = string.Empty;
            switch (wrapper)
            {
                case PropsWrapping1.Catalog:
                    if (string.IsNullOrEmpty(wrapperId))
                    {
                        SetErrState(ItemProcErrEnum.NoWrapperIdAvailable);
                        return false;
                    }
                    wrapperLocalName = "catalog";
                    wrapperXPath = wrapperParentXPath + "/nar:catalog[@id='" + wrapperId + "']";
                    wrapperChildNameSeq = "nar:tile nar:scheme";
                    break;
                case PropsWrapping1.ConceptSet:
                    wrapperLocalName = "conceptSet";
                    wrapperXPath = wrapperParentXPath + "/nar:" + wrapperLocalName;
                    wrapperChildNameSeq = "nar:concept";
                    break;
                case PropsWrapping1.ContentMeta:
                    wrapperLocalName = "contentMeta";
                    wrapperXPath = wrapperParentXPath + "/nar:" + wrapperLocalName;
                    if ((RootElemName == "newsItem") || (RootElemName == "packageItem"))
                        wrapperChildNameSeq = NameSeqContentMetaAfD;
                    else wrapperChildNameSeq = NameSeqContentMetaAcD;
                    break;
                case PropsWrapping1.ContentSet:
                    wrapperLocalName = "contentSet";
                    wrapperXPath = wrapperParentXPath + "/nar:" + wrapperLocalName;
                    wrapperChildNameSeq = NameSeqContentSet;
                    break;
                case PropsWrapping1.GroupSet:
                    wrapperLocalName = "groupSet";
                    wrapperXPath = wrapperParentXPath + "/nar:" + wrapperLocalName;
                    wrapperChildNameSeq = "nar:group";
                    break;
                case PropsWrapping1.ItemMeta:
                    wrapperLocalName = "itemMeta";
                    wrapperXPath = wrapperParentXPath + "/nar:" + wrapperLocalName;
                    wrapperChildNameSeq = NameSeqItemMeta;
                    break;
                case PropsWrapping1.NMHeader:
                    wrapperLocalName = "header";
                    wrapperXPath = wrapperParentXPath + "/nar:" + wrapperLocalName;
                    wrapperChildNameSeq = NameSeqNMHeader;
                    break;
                case PropsWrapping1.NewsConverageSet:
                    wrapperLocalName = "newsCoverageSet";
                    wrapperXPath = wrapperParentXPath + "/nar:" + wrapperLocalName;
                    wrapperChildNameSeq = "nar:newsCoverage";
                    break;
                case PropsWrapping1.PartMeta:
                    if (string.IsNullOrEmpty(wrapperId))
                    {
                        SetErrState(ItemProcErrEnum.NoWrapperIdAvailable);
                        return false;
                    }
                    wrapperLocalName = "partMeta";
                    wrapperXPath = wrapperParentXPath + "/nar:partMeta[@partid='" + wrapperId + "']";
                    wrapperChildNameSeq = NameSeqPartMeta;
                    break;
                case PropsWrapping1.RightsInfo:
                    wrapperLocalName = "rightsInfo";
                    wrapperXPath = wrapperParentXPath + "/nar:" + wrapperLocalName;
                    wrapperChildNameSeq = NameSeqRightsInfo;
                    break;
            }
            return true;
        } // GetNarWrapper1Details

        /// <summary>
        /// Returns a set of data about a member of the PropsWrapping1 enumeration 
        /// = top level elements of a NewsML-G2 item wrapping other properties
        /// </summary>
        /// <param name="wrapper">Wrapping property about which the details are requested</param>
        /// <param name="wrapperId">The @id of the wrapping element</param>
        /// <param name="wrapperXPath">Returned XPath of the wrapping element</param>
        /// <param name="wrapperLocalName">Local name of the wrapping element</param>
        /// <param name="wrapperChildNameSeq">Child name sequence of the wrapping element</param>
        /// <returns>True if successfully executed</returns>
        public bool GetNarWrapper1Details(PropsWrapping1 wrapper, string wrapperId,
            out string wrapperXPath, out string wrapperLocalName, out string wrapperChildNameSeq)
        {
            string dummy1, dummy2;
            return GetNarWrapper1Details(wrapper, wrapperId, out dummy1, out dummy2, 
                out wrapperXPath, out wrapperLocalName, out wrapperChildNameSeq);
        } // GetNarWrapper1Details



        #endregion

        // ******************************************************************************
        // ******************************************************************************
        // ***** private HELPER METHODS *************************************************
        #region ***** private HELPER METHODS
        // ******************************************************************************

        //*******************************************************************************
		protected void SetErrState(ItemProcErrEnum IPErr, string errStr)
            // Code History:
            // 2010-12-11 mws
		{
            _ItemPropState = ItemProcStateEnum.error;
		    _Err = IPErr;
			_ErrStr = errStr;
        }

        protected void SetErrState(ItemProcErrEnum IPErr)
        {
            SetErrState(IPErr, string.Empty);
        }

        //*******************************************************************************
        protected void ResetErrState()
            // Code History:
            // 2010-12-11 mws
        {
            _ItemPropState = ItemProcStateEnum.ok;
            _Err = ItemProcErrEnum.NoError;
			_ErrStr = string.Empty;
        }

        #endregion

        // ******************************************************************************
        // ******************************************************************************
        // ***** DEPRECATED STUFF *******************************************************
        #region ***** DEPRECATED STUFF
        // ******************************************************************************


        #endregion
    }
}
