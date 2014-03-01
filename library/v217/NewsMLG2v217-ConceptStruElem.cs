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
Class: NewsIT.IPTC.NewsMLG2.v217.ConceptStruElem
  

Current date / persID / change log (most current at top)
StartDate: 2014-02-27
******************************************************************************/
using System;
using System.Collections.Generic;
using System.Xml;

namespace NewsIT.IPTC.NewsMLG2.v217
{
    //**************************************************************************
    /// <summary>
    /// Class for a basic structured NewsML-G2 Concept
    /// </summary>
    public class ConceptGenericStruElem
    {
        public string Uri;
        public string QCode;
        public string TypeQc;
        public Concept CoreConcept;
        public ConceptId ConceptId;
        public Type Type;
        public List<Name> Names;
        public List<Definition> Definitions;
        public List<Note> Notes;
        public List<RemoteInfo> RemoteInfos;
        public List<HierarchyInfo> HierarchyInfos;
        public List<SameAs> SameAsses;
        public List<Broader> Broaders;
        public List<Narrower> Narrowers;
        public List<Related> Relateds; 

        public ConceptGenericStruElem()
        {
            CoreConcept = new Concept();
            ConceptId = new ConceptId();
            Type = new Type();
            Names = new List<Name>();
            Definitions = new List<Definition>();
            Notes = new List<Note>();
            RemoteInfos = new List<RemoteInfo>();
            HierarchyInfos = new List<HierarchyInfo>();
            SameAsses = new List<SameAs>();
            Broaders = new List<Broader>();
            Narrowers = new List<Narrower>();
            Relateds = new List<Related>();
        }

        // ******************************************************************************
        public virtual PropProcStatus AppendAsChildOf(AnyItemXml NG2Item, string parentXPath)
            // Code History:
            // 2014-02-27 mws
        {
            if (string.IsNullOrEmpty(parentXPath))
                return PropProcStatus.ErrNoXPath;

            XmlNodeList parentXNL = NG2Item.ItemXdoc.SelectNodes(parentXPath, NG2Item.NsMngr);
            if (parentXNL.Count == 0)
                return PropProcStatus.ErrElementNotFound;
            if (parentXNL.Count > 1)
                return PropProcStatus.ErrElementsToManyFound;

            XmlElement cptElement = NG2Item.ItemXdoc.CreateElement("concept", AnyItemXml.G2NsCs);
            parentXNL[0].AppendChild(cptElement);

            return ApplyToElementInternal(NG2Item, cptElement, true);
        } // AppendAsChildOf

        public PropProcStatus ApplyToElement(AnyItemXml NG2Item, XmlElement applyElement)
        {
            return ApplyToElementInternal(NG2Item, applyElement, false);
        }

        // ******************************************************************************
        protected virtual PropProcStatus ApplyToElementInternal(AnyItemXml NG2Item, XmlElement applyElement, bool fullConceptMode)
        // Code History:
        // 2014-02-27 mws
        {
            NG2Item.NarProperty2XmlElement(CoreConcept, applyElement);

            if (fullConceptMode)
            {
                XmlElement newElement = NG2Item.ItemXdoc.CreateElement("conceptId", AnyItemXml.G2NsCs);
                NG2Item.NarProperty2XmlElement(ConceptId, newElement);
                applyElement.AppendChild(newElement);
                newElement = NG2Item.ItemXdoc.CreateElement("type", AnyItemXml.G2NsCs);
                NG2Item.NarProperty2XmlElement(Type, newElement);
                applyElement.AppendChild(newElement);
            }
            else
            {
                if (!string.IsNullOrEmpty(ConceptId.qcode))
                {
                    applyElement.SetAttribute("qcode", ConceptId.qcode);
                }
                else
                {
                    if (!string.IsNullOrEmpty(QCode))
                        applyElement.SetAttribute("qcode", QCode);
                }
                if (!string.IsNullOrEmpty(ConceptId.uri))
                {
                    applyElement.SetAttribute("uri", ConceptId.uri);
                }
                else
                {
                    if (!string.IsNullOrEmpty(Uri))
                        applyElement.SetAttribute("uri", Uri);
                }
                if (!string.IsNullOrEmpty(Type.qcode))
                {
                    applyElement.SetAttribute("type", Type.qcode);
                }
                else
                {
                    if (!string.IsNullOrEmpty(TypeQc))
                        applyElement.SetAttribute("type", TypeQc);
                }
            }
            foreach (var name in Names)
            {
                XmlElement newElement = NG2Item.ItemXdoc.CreateElement("name", AnyItemXml.G2NsCs);
                NG2Item.NarProperty2XmlElement(name, newElement);
                applyElement.AppendChild(newElement);
            }
            foreach (var definition in Definitions)
            {
                XmlElement newElement = NG2Item.ItemXdoc.CreateElement("definition", AnyItemXml.G2NsCs);
                NG2Item.NarProperty2XmlElement(definition, newElement);
                applyElement.AppendChild(newElement);
            }
            foreach (var note in Notes)
            {
                XmlElement newElement = NG2Item.ItemXdoc.CreateElement("note", AnyItemXml.G2NsCs);
                NG2Item.NarProperty2XmlElement(note, newElement);
                applyElement.AppendChild(newElement);
            }
            foreach (var remoteInfo in RemoteInfos)
            {
                XmlElement newElement = NG2Item.ItemXdoc.CreateElement("remoteInfo", AnyItemXml.G2NsCs);
                NG2Item.NarProperty2XmlElement(remoteInfo, newElement);
                applyElement.AppendChild(newElement);
            }
            foreach (var hierarchyInfo in HierarchyInfos)
            {
                XmlElement newElement = NG2Item.ItemXdoc.CreateElement("hierarchyInfo", AnyItemXml.G2NsCs);
                NG2Item.NarProperty2XmlElement(hierarchyInfo, newElement);
                applyElement.AppendChild(newElement);
            }
            foreach (var sameAs in SameAsses)
            {
                XmlElement newElement = NG2Item.ItemXdoc.CreateElement("sameAs", AnyItemXml.G2NsCs);
                NG2Item.NarProperty2XmlElement(sameAs, newElement);
                applyElement.AppendChild(newElement);
            }
            foreach (var broader in Broaders)
            {
                XmlElement newElement = NG2Item.ItemXdoc.CreateElement("broader", AnyItemXml.G2NsCs);
                NG2Item.NarProperty2XmlElement(broader, newElement);
                applyElement.AppendChild(newElement);
            }
            foreach (var narrower in Narrowers)
            {
                XmlElement newElement = NG2Item.ItemXdoc.CreateElement("narrower", AnyItemXml.G2NsCs);
                NG2Item.NarProperty2XmlElement(narrower, newElement);
                applyElement.AppendChild(newElement);
            }
            foreach (var related in Relateds)
            {
                XmlElement newElement = NG2Item.ItemXdoc.CreateElement("related", AnyItemXml.G2NsCs);
                NG2Item.NarProperty2XmlElement(related, newElement);
                applyElement.AppendChild(newElement);
            }

            return PropProcStatus.ok;
        } // ApplyToElement

    } //class ConceptGenericStruElem

    //**************************************************************************
    //**************************************************************************
    //**************************************************************************
    /// <summary>
    /// Class for a basic structured NewsML-G2 Concept
    /// </summary>
    public class ConceptEntityStruElem : ConceptGenericStruElem
    {
        public List<PersonDetails> PersonDetailses;
        public List<OrganisationDetails> OrganisationDetailses;
        public List<GeoAreaDetails> GeoAreaDetailses;
        public List<POIDetails> PoiDetailses;
        public List<ObjectDetails> ObjectDetailses;

        public ConceptEntityStruElem() : base()
        {
            PersonDetailses = new List<PersonDetails>();
            OrganisationDetailses = new List<OrganisationDetails>();
            GeoAreaDetailses = new List<GeoAreaDetails>();
            PoiDetailses = new List<POIDetails>();
            ObjectDetailses = new List<ObjectDetails>();
        }

        // ******************************************************************************
        protected virtual PropProcStatus ApplyToElementInternal(AnyItemXml NG2Item, XmlElement applyElement,
            bool fullConceptMode)
        // Code History:
        // 2014-02-27 mws
        {
            var baseResult = base.ApplyToElementInternal(NG2Item, applyElement, fullConceptMode);
            if (baseResult != PropProcStatus.ok)
                return baseResult;

            foreach (var personDetails in PersonDetailses)
            {
                XmlElement newElement = NG2Item.ItemXdoc.CreateElement("personDetails", AnyItemXml.G2NsCs);
                NG2Item.NarProperty2XmlElement(personDetails, newElement);
                applyElement.AppendChild(newElement);
            }
            foreach (var organisationDetails in OrganisationDetailses)
            {
                XmlElement newElement = NG2Item.ItemXdoc.CreateElement("organisationDetails", AnyItemXml.G2NsCs);
                NG2Item.NarProperty2XmlElement(organisationDetails, newElement);
                applyElement.AppendChild(newElement);
            }
            foreach (var geoAreaDetails in GeoAreaDetailses)
            {
                XmlElement newElement = NG2Item.ItemXdoc.CreateElement("geoAreaDetails", AnyItemXml.G2NsCs);
                NG2Item.NarProperty2XmlElement(geoAreaDetails, newElement);
                applyElement.AppendChild(newElement);
            }
            foreach (var poiDetails in PoiDetailses)
            {
                XmlElement newElement = NG2Item.ItemXdoc.CreateElement("POIDetails", AnyItemXml.G2NsCs);
                NG2Item.NarProperty2XmlElement(poiDetails, newElement);
                applyElement.AppendChild(newElement);
            }
            foreach (var objectDetails in ObjectDetailses)
            {
                XmlElement newElement = NG2Item.ItemXdoc.CreateElement("objectDetails", AnyItemXml.G2NsCs);
                NG2Item.NarProperty2XmlElement(objectDetails, newElement);
                applyElement.AppendChild(newElement);
            }
            return PropProcStatus.ok;
        }
    } // class ConceptEntityStruElem

    //**************************************************************************
    //**************************************************************************
    //**************************************************************************
    /// <summary>
    /// Class for a structured NewsML-G2 Concept representing an event
    /// </summary>
    public class ConceptEventStruElem : ConceptGenericStruElem
    {
        public List<EventDetails> EventDetailses;

        public ConceptEventStruElem() : base()
        {
            EventDetailses = new List<EventDetails>();
        }

        // ******************************************************************************
        protected virtual PropProcStatus ApplyToElementInternal(AnyItemXml NG2Item, XmlElement applyElement,
            bool fullConceptMode)
        // Code History:
        // 2014-02-27 mws
        {
            var baseResult = base.ApplyToElementInternal(NG2Item, applyElement, fullConceptMode);
            if (baseResult != PropProcStatus.ok)
                return baseResult;

            foreach (var eventDetails in EventDetailses)
            {
                XmlElement newElement = NG2Item.ItemXdoc.CreateElement("eventDetails", AnyItemXml.G2NsCs);
                NG2Item.NarProperty2XmlElement(eventDetails, newElement);
                applyElement.AppendChild(newElement);
            }
            return PropProcStatus.ok;
        }
    } // class ConceptEventStruElem

}
