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
Class: NewsIT.IPTC.NewsMLG2.v217.KIpwrXML = NewsML-G2 Knowledge Item

Current date / persID / change log (most current at top)
StartDate: 2010-12 -> 2014-02-22 mws
******************************************************************************/
using System;
using System.Globalization;
using System.IO;
using System.Collections;
using System.Collections.Specialized;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;
using System.Text;

namespace NewsIT.IPTC.NewsMLG2.v217
{
	
    //**************************************************************************
    //**************************************************************************
    //**************************************************************************
    /// <summary>
    /// IPTC NewsML-G2 Knowledge Item class
	/// </summary>
	public class KnowledgeItemPwrXml : AnyItemXml
    {

        // Defines the sequence of QNames of the children of the root element
        public const string NameSeqKiRoot =
            NameSeqAnyRoot + " nar:contentMeta nar:partMeta nar:assert nar:inlineRef " +
            "nar:derivedFrom nar:conceptSet nar:schemeMeta";

        public const string NameSeqKiConceptSet = "nar:concept";

        public const string NameSeqSchemeMeta = "nar:sameAsScheme nar:name nar:definition nar:note nar:related nar:schemeMetaExtProperty";


		//**************************************************************************
		/// <summary>
		/// Constructor for a blank G2 Knowledge Item object - has to be initialised before being used
		/// </summary>
        public KnowledgeItemPwrXml()
		{
            RootElemName = "knowledgeItem";
        }

        // *******************************************************************************
        // *******************************************************************************
        #region ***** BASIC METHODS

        // *******************************************************************************
        public override void InitEmptyXMLDoc()
        {
            InitEmptyXMLDoc(string.Empty, 0);
        } // InitEmptyXMLDoc

        public override void InitEmptyXMLDoc(string guid, int version)
        {
            ItemXdoc.RemoveAll();
            ItemXdoc.LoadXml("<?xml version='1.0' encoding='utf-8' standalone='yes'?> <knowledgeItem xmlns='http://iptc.org/std/nar/2006-10-01/'></knowledgeItem>");
            XmlNode rootXN = ItemXdoc.SelectSingleNode("/nar:" + RootElemName, NsMngr);
            XmlElement docelement = (XmlElement)rootXN;
            docelement.SetAttribute("standard", "NewsML-G2");
            docelement.SetAttribute("standardversion", Newsmlg2VersionCs);
            docelement.SetAttribute("conformance", ConformanceLevelCs);
            if (!string.IsNullOrEmpty(guid))
                docelement.SetAttribute("guid", guid);
            if (version > 0)
                docelement.SetAttribute("version", version.ToString());
        } // InitEmptyXMLDoc

        #endregion

        // *******************************************************************************
        // *******************************************************************************
        #region ***** WRITE METHODS

        /// <summary>
        /// Adds a conceptSet element as child to the root element
        /// </summary>
        public void AddConceptSet()
        // Code History:
        // 2010-12-12/2014-02-22 mws
        {           
            CheckAddNarWrapper1(PropsWrapping1.ConceptSet);
        } // AddContentSet


        // ******************************************************************************
        /// <summary>
        /// Adds a concept property as child to the conceptSet wrapper
        /// </summary>
        /// <param name="conceptElementId"></param>
        public void AddCSconcept(string conceptElementId)
        // Code History:
        // 2010-12-12,2014-02-22 mws
        {           
            var concept = new Concept();
            concept.id = conceptElementId;
            AddNarPropertyToWrapper1(PropsWrapping1.ConceptSet, concept);
        } // AddCSconcept


        #endregion

        // ******************************************************************************
        // ******************************************************************************
        // ***** SIMPLE (& constrained) WRITE  METHODS *************************************************
        #region ***** SIMPLE (& constrained) WRITE  METHODS

        // ******************************************************************************
        public void ScAddCSCconceptId(string conceptElementId, ConceptId conceptId)
        // Code History:
        // 2010-12-12 mws
        {
            XmlNode parentXN = ItemXdoc.SelectSingleNode("/nar:" + RootElemName + "/nar:conceptSet/nar:concept[@id='" + conceptElementId + "']", NsMngr);
            if (parentXN == null)
                AddCSconcept(conceptElementId);
            parentXN = ItemXdoc.SelectSingleNode("/nar:" + RootElemName + "/nar:conceptSet/nar:concept[@id='" + conceptElementId + "']", NsMngr);
            XmlElement newXElement = ItemXdoc.CreateElement("conceptId", G2NsCs);
            if (!string.IsNullOrEmpty(conceptId.qcode))
                newXElement.SetAttribute("qcode", conceptId.qcode);
            if (!string.IsNullOrEmpty(conceptId.created))
                newXElement.SetAttribute("created", conceptId.created);
            if (!string.IsNullOrEmpty(conceptId.retired))
                newXElement.SetAttribute("retired", conceptId.retired);
            parentXN.PrependChild(newXElement);
        } // ScAddCSCconceptId

        // ******************************************************************************
        public void ScAddCSCtype(string conceptElementId, string qcType)
        // Code History:
        // 2010-12-13 mws
        {
            string parentXPath = "/nar:" + RootElemName + "/nar:conceptSet/nar:concept[@id='" + conceptElementId + "']";
            XmlNode parentXN = ItemXdoc.SelectSingleNode(parentXPath, NsMngr);
            if (parentXN == null)
                AddCSconcept(conceptElementId);

            XmlElement newXElement = ItemXdoc.CreateElement("type", G2NsCs);
            if (!string.IsNullOrEmpty(qcType))
                newXElement.SetAttribute("qcode", qcType);
            AddPropertyToParent(parentXPath, NameSeqConcept, newXElement);
        } // ScAddCSCtype

        // ******************************************************************************
        public void ScAddCSCname(string conceptElementId, Name name)
        // Code History:
        // 2010-12-13, 2014-02-22 mws
        {
            string parentXPath = "/nar:" + RootElemName + "/nar:conceptSet/nar:concept[@id='" + conceptElementId + "']";
            XmlNode parentXN = ItemXdoc.SelectSingleNode(parentXPath, NsMngr);
            if (parentXN == null)
                AddCSconcept(conceptElementId);

            XmlElement newXElement = ItemXdoc.CreateElement("name", G2NsCs);
            NarProperty2XmlElement(name, newXElement);
            AddPropertyToParent(parentXPath, NameSeqConcept, newXElement);
        } // ScAddCSCname

        // ******************************************************************************
        public void ScAddCSCdefinition(string conceptElementId, Definition definition)
        // Code History:
        // 2010-12-13 mws
        {
            string parentXPath = "/nar:" + RootElemName + "/nar:conceptSet/nar:concept[@id='" + conceptElementId + "']";
            XmlNode parentXN = ItemXdoc.SelectSingleNode(parentXPath, NsMngr);
            if (parentXN == null)
                AddCSconcept(conceptElementId);

            XmlElement newXElement = ItemXdoc.CreateElement("definition", G2NsCs);
            NarProperty2XmlElement(definition, newXElement);
            AddPropertyToParent(parentXPath, NameSeqConcept, newXElement);
        } // ScAddCSCdefinition

        // ******************************************************************************
        public void ScAddCSCnote(string conceptElementId, Note note)
        // Code History:
        // 2010-12-13 mws
        {
            string parentXPath = "/nar:" + RootElemName + "/nar:conceptSet/nar:concept[@id='" + conceptElementId + "']";
            XmlNode parentXN = ItemXdoc.SelectSingleNode(parentXPath, NsMngr);
            if (parentXN == null)
                AddCSconcept(conceptElementId);

            XmlElement newXElement = ItemXdoc.CreateElement("note", G2NsCs);
            NarProperty2XmlElement(note, newXElement);
            AddPropertyToParent(parentXPath, NameSeqConcept, newXElement);
        } // ScAddCSCnote

        // ******************************************************************************
        // ***** CONCEPT RELATIONSHIPS

        // ******************************************************************************
        public void ScAddCSCsameAs(string conceptElementId, SameAs sameAs)
        // Code History:
        // 2010-12-13 mws
        {
            string parentXPath = "/nar:" + RootElemName + "/nar:conceptSet/nar:concept[@id='" + conceptElementId + "']";
            XmlNode parentXN = ItemXdoc.SelectSingleNode(parentXPath, NsMngr);
            if (parentXN == null)
                AddCSconcept(conceptElementId);

            XmlElement newXElement = ItemXdoc.CreateElement("sameAs", G2NsCs);
            NarProperty2XmlElement(sameAs, newXElement);
            AddPropertyToParent(parentXPath, NameSeqConcept, newXElement);
        } // ScAddCSCsameAs


        // ******************************************************************************
        public void ScAddCSCbroader(string conceptElementId, Broader broader)
        // Code History:
        // 2010-12-13 mws
        {
            string parentXPath = "/nar:" + RootElemName + "/nar:conceptSet/nar:concept[@id='" + conceptElementId + "']";
            XmlNode parentXN = ItemXdoc.SelectSingleNode(parentXPath, NsMngr);
            if (parentXN == null)
                AddCSconcept(conceptElementId);

            XmlElement newXElement = ItemXdoc.CreateElement("broader", G2NsCs);
            NarProperty2XmlElement(broader, newXElement);
            AddPropertyToParent(parentXPath, NameSeqConcept, newXElement);
        } // ScAddCSCbroader


        // ******************************************************************************
        public void ScAddCSCrelated(string conceptElementId, Related related)
        // Code History:
        // 2010-12-13 mws
        {
            string parentXPath = "/nar:" + RootElemName + "/nar:conceptSet/nar:concept[@id='" + conceptElementId + "']";
            XmlNode parentXN = ItemXdoc.SelectSingleNode(parentXPath, NsMngr);
            if (parentXN == null)
                AddCSconcept(conceptElementId);

            XmlElement newXElement = ItemXdoc.CreateElement("related", G2NsCs);
            NarProperty2XmlElement(related, newXElement);
            AddPropertyToParent(parentXPath, NameSeqConcept, newXElement);
        } // ScAddCSCrelated

        // ******************************************************************************
        // ***** SCHEME META 
        // ******************************************************************************
        public void ScAddSchemeMeta(SchemeMeta schemeMeta)
        // Code History:
        // 2014-02-12,2014-02-23 mws
        {
            // check if this element already exists
            XmlNode thisXN =
            ItemXdoc.SelectSingleNode("/nar:" + RootElemName + "/nar:schemeMeta", NsMngr);
            if (thisXN != null)
                return;

            AddNarPropertyToParent("/nar:" + RootElemName, NameSeqKiRoot, schemeMeta);
        } // ScAddSchemeMeta

        public void ScCheckSchemeMeta(SchemeMeta schemeMeta)
        // Code History:
        // 2014-02-22 mws
        {
            string thisXPath = "/nar:" + RootElemName + "/nar:schemeMeta";
            XmlNode thisXN = ItemXdoc.SelectSingleNode(thisXPath, NsMngr);
            if (thisXN == null)
                ScAddSchemeMeta(schemeMeta);
        }

        // ***** Note: as the children of schemeMeta is an unordered list 
        //          it is not required to use the AddPropertyToParent method
        // ******************************************************************************
        public void ScAddSMname(Name name)
        // Code History:
        // 2014-02-12 mws
        {
            XmlNode parentXN = ItemXdoc.SelectSingleNode("/nar:" + RootElemName + "/nar:schemeMeta", NsMngr);
            if (parentXN == null)
                return;
            XmlElement newXElement = ItemXdoc.CreateElement("name", G2NsCs);
            NarProperty2XmlElement(name, newXElement);
            parentXN.AppendChild(newXElement);
        } // ScAddSMname

        // ******************************************************************************
        public void ScAddSMdefinition(Definition definition)
        // Code History:
        // 2014-02-12 mws
        {
            XmlNode parentXN = ItemXdoc.SelectSingleNode("/nar:" + RootElemName + "/nar:schemeMeta", NsMngr);
            if (parentXN == null)
                return;
            XmlElement newXElement = ItemXdoc.CreateElement("definition", G2NsCs);
            NarProperty2XmlElement(definition, newXElement);
            parentXN.AppendChild(newXElement);
        } // ScAddSMdefinition

        // ******************************************************************************
        public void ScAddSMnote(Note note)
        // Code History:
        // 2014-02-12 mws
        {
            XmlNode parentXN = ItemXdoc.SelectSingleNode("/nar:" + RootElemName + "/nar:schemeMeta", NsMngr);
            if (parentXN == null)
                return;
            XmlElement newXElement = ItemXdoc.CreateElement("note", G2NsCs);
            NarProperty2XmlElement(note, newXElement);
            parentXN.AppendChild(newXElement);
        } // ScAddSMnote

        // ******************************************************************************
        public void ScAddSMrelated(Related related)
        // Code History:
        // 2014-02-12 mws
        {
            XmlNode parentXN = ItemXdoc.SelectSingleNode("/nar:" + RootElemName + "/nar:schemeMeta", NsMngr);
            if (parentXN == null)
                return;
            XmlElement newXElement = ItemXdoc.CreateElement("related", G2NsCs);
            NarProperty2XmlElement(related, newXElement);
            parentXN.AppendChild(newXElement);
        } // ScAddSMrelated


        #endregion

        // *******************************************************************************
        // *******************************************************************************
        #region ***** UTILITIES

        #endregion

    }
}
