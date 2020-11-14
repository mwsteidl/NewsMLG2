/******************************************************************************
Company: NewsIT-M.W.Steidl, 1180 Wien/Österreich (Vienna/Austria)

Copyright 2014..2020 NewsIT-M.W.Steidl (www.newsit.biz)

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
Class: NewsIT.IPTC.NewsMLG2.v229.GroupStructProp
  

Current date / persID / change log (most current at top)
2020-11-14 mws: moved from v218 to v229 
2014-08-27 mws: moved from v217 to v218
StartDate: 2014-03-17
******************************************************************************/
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Xml;

namespace NewsIT.IPTC.NewsMLG2.v229
{
    //**************************************************************************
    /// <summary>
    /// Class for a NewsML-G2 Group in a Package Item
    /// </summary>
    public class GroupStructProp
    {
        public string PblPath;
        public Group CoreGroup;
        public List<GroupRef> GroupRefs;
        public List<ItemRef> ItemRefs;
        public List<ConceptRef> ConceptRefs;
        public List<Title> Titles;
        public List<Signal> Signals;
        public List<EdNote> EdNotes;
        public List<GroupExtProperty> GroupExtProperties;

        public GroupStructProp()
        {
            CoreGroup = new Group();
            GroupRefs = new List<GroupRef>();
            ItemRefs = new List<ItemRef>();
            ConceptRefs = new List<ConceptRef>();
            Titles = new List<Title>();
            Signals = new List<Signal>();
            EdNotes = new List<EdNote>();
            GroupExtProperties = new List<GroupExtProperty>();
        }

        public GroupStructProp(Group coreGroup)
        {
            CoreGroup = coreGroup;
            GroupRefs = new List<GroupRef>();
            ItemRefs = new List<ItemRef>();
            ConceptRefs = new List<ConceptRef>();
            Titles = new List<Title>();
            Signals = new List<Signal>();
            EdNotes = new List<EdNote>();
            GroupExtProperties = new List<GroupExtProperty>();
        }

        public GroupStructProp(Group coreGroup, string pblPath)
        {
            PblPath = pblPath;
            CoreGroup = coreGroup;
            GroupRefs = new List<GroupRef>();
            ItemRefs = new List<ItemRef>();
            ConceptRefs = new List<ConceptRef>();
            Titles = new List<Title>();
            Signals = new List<Signal>();
            EdNotes = new List<EdNote>();
            GroupExtProperties = new List<GroupExtProperty>();
        }


        // ******************************************************************************
        /// <summary>
        /// Adds this instance of GroupStructProp as group element and its children 
        /// to a NewsML-G2 Package Item. The location in the group structure is
        /// defined by the PblPath property if this instance.
        /// </summary>
        /// <param name="pkgItem">The Package Item to which the group should be added</param>
        /// <returns>A PropProcStatus</returns>
        public virtual PropProcStatus AddGroupToPackage(PackageItemPwrXml pkgItem)
        {
            if (string.IsNullOrEmpty(PblPath))
                return PropProcStatus.ErrPkgNoPblPath;
            if (string.IsNullOrEmpty(CoreGroup.role))
                return PropProcStatus.ErrPkgNoGroupRole;

            var pblPathParsed = PblTools.ParsePblPath(PblPath);
            if ((pblPathParsed.EndNodeType == PblNodeType.ParseError)
                || (pblPathParsed.EndNodeType == PblNodeType.Undefined))
                return PropProcStatus.ErrPkgNoPblPath;

            string pblPath4Testing = string.Empty;
            // check if the hierarchical parent group(s) exist, skipped for the root group
            for (var idx = 0; idx < pblPathParsed.GroupRoles.Count - 1; idx++)
            {
                pblPath4Testing += "/" + pblPathParsed.GroupRoles[idx];
                if (!PblTools.PblNodeExists(pkgItem, pblPath4Testing))
                    return PropProcStatus.ErrPkgNoPblParentNode;
            }

            pkgItem.AddGroupSet(); // try to add it, skips action if it already exists

            if (string.IsNullOrEmpty(CoreGroup.id)) // take care that the group@id is not empty.
                CoreGroup.id = pkgItem.NewIdSequence.ToString();
            // adds the new group element
            pkgItem.AddNarPropertyToParent("/nar:packageItem/nar:groupSet", "", CoreGroup);

            ReadFromItemResultEnum readResult;

            if (pblPathParsed.GroupRoles.Count == 1) // this is the root group!
            {
                // apply the id of the root group to the root attribute of groupSet
                XmlElement groupSetXe = null;
                pkgItem.GetElemAsXE("/nar:packageItem/nar:groupSet", out groupSetXe, out readResult);
                if (readResult == ReadFromItemResultEnum.ok)
                {
                    groupSetXe.SetAttribute("root", CoreGroup.id);
                }
                // return PropProcStatus.ok; // exits here
            }
            else // ++2014-11-27
            {   
                // for groups below the root in the hierarchy: add a groupRef element to the parent group
                var parentRole = pblPathParsed.GroupRoles[pblPathParsed.GroupRoles.Count - 2];
                var newGroupRef = new GroupRef();
                newGroupRef.idref = CoreGroup.id;
                pkgItem.AddNarPropertyToParent("/nar:packageItem/nar:groupSet/nar:group[@role='" + parentRole + "']", "",
                    newGroupRef);                
            }

            // add all the child elements of the new group
            foreach (var itemRef in ItemRefs)
            {
                pkgItem.AddNarPropertyToParent("/nar:packageItem/nar:groupSet/nar:group[@id='" + CoreGroup.id + "']", "",
                itemRef);
            }
            foreach (var conceptRef in ConceptRefs)
            {
                pkgItem.AddNarPropertyToParent("/nar:packageItem/nar:groupSet/nar:group[@id='" + CoreGroup.id + "']", "",
                conceptRef);
            }
            foreach (var title in Titles)
            {
                pkgItem.AddNarPropertyToParent("/nar:packageItem/nar:groupSet/nar:group[@id='" + CoreGroup.id + "']", "",
                title);
            }
            foreach (var signal in Signals)
            {
                pkgItem.AddNarPropertyToParent("/nar:packageItem/nar:groupSet/nar:group[@id='" + CoreGroup.id + "']", "",
                signal);
            }
            foreach (var edNote in EdNotes)
            {
                pkgItem.AddNarPropertyToParent("/nar:packageItem/nar:groupSet/nar:group[@id='" + CoreGroup.id + "']", "",
                edNote);
            }
            foreach (var groupExtProperty in GroupExtProperties)
            {
                pkgItem.AddNarPropertyToParent("/nar:packageItem/nar:groupSet/nar:group[@id='" + CoreGroup.id + "']", "",
                groupExtProperty);
            }

            return PropProcStatus.ok;
        } // AddGroupToPackage



    } //class GroupStructProp
}
