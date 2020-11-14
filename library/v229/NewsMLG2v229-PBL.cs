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
Class: NewsIT.IPTC.NewsMLG2.v229.PblTools
  

Current date / persID / change log (most current at top)
2020-11-14 mws: moved from v218 to v229 
2014-08-27 mws: moved from v217 to v218
StartDate: 2014-03-18
******************************************************************************/
using System;
using System.Collections.Specialized;

namespace NewsIT.IPTC.NewsMLG2.v229
{

    /// <summary>
    /// Enumeration of the types of the rightmost nodes in a PBL-Path, includes indicators of errors in the path
    /// </summary>
    public enum PblNodeType {Group, ItemRef, ContentRef, Undefined, ParseError};

    /// <summary>
    /// Class to represent a PBL-Path in a structured way
    /// </summary>
    public class ParsedPblPath
    {
        /// <summary>
        /// Type of the rightmost node in the PBL-Path
        /// </summary>
        public PblNodeType EndNodeType;
        /// <summary>
        /// Ordered list of roles. An entry for each one, top level as first entry
        /// </summary>
        public StringCollection GroupRoles; 
        /// <summary>
        /// if part of the PBL-Path: an attribute name and the value separated by a = sign
        /// </summary>
        public string RefId; // 
        public ParsedPblPath() { GroupRoles = new StringCollection(); EndNodeType = PblNodeType.Undefined; }
    }

    /// <summary>
    /// Static tools for handling PBL (Package Builder Language)
    ///  * Package Builder Language - PBL
    ///  * 
    ///  * PBL helps creating NewsML-G2 packages by supporting a structured PBL-Path:
    ///  * By NewsML-G2 specifications each group of a package must have a role (attribute).
    ///  * As groups can appear in a hierarchical structure in a package their roles 
    ///  could be represented by a string conforming to XPath in XML:
    ///  * the roles are appended from left to right and separated by a slash for
    ///  going down one hierarchical level.
    ///  * In addition itemRefs and contentRefs can be targeted:
    ///  * itemRef and contentRef are separated by @ at the end of a sequence of roles 
    ///  and appends one of theses attribute names
    ///  *      - for itemRef: residref or href only!
    ///  *      - for contentRef: qcode or uri only!
    ///  *      and appends a = sign and the value of this attribute
    ///  * Examples for PBL-Paths:
    ///  *  /grr:main ... the root group of a package, group role="main"
    ///  *  /grr:main/grr:sidebar/grr:text ... a third level group, group role="text"
    ///  *  /grr:main/grr:sidebar/grr:text@residref=urn:newsml:example.com:20140101:textNI134132 ... itemRef
    ///  *  /grr:main/grr:sidebar/grr:pics@href=http://example.com/pics/p13413243.jpg ... itemRef
    ///  *  /grr:main/grr:themes@uri=http://cv.iptc.org/newscodes/mediatopic/01000000 ... conceptRef
    ///  *  /grr:main/grr:themes@qcode=medtop:01000000 ... conceptRef
    /// </summary>
    public class PblTools
    {

        // ******************************************************************************
        /// <summary>
        /// Parses a PBL-Path string and creates a structured version of it
        /// </summary>
        /// <param name="pblPath">The PBL-Path as string</param>
        /// <returns>The PBL-Path as structure</returns>
        public static ParsedPblPath ParsePblPath(string pblPath)
            // Code History:
            // 2014-03-18, ~2014-03-20 mws
        {
            var parsedPath = new ParsedPblPath();
            if (string.IsNullOrEmpty(pblPath))
            {
                parsedPath.EndNodeType = PblNodeType.ParseError;
                return parsedPath;
            }
            parsedPath.EndNodeType = PblNodeType.Undefined;
            
            string[] pathParts = { "" }; // dummy initializer
            if (pblPath.Contains("@")) 
            {   // process the separator
                pathParts = pblPath.Split('@'); // pathParts[0] = group roles, others: the reference
                if (pathParts.Length < 2) // there must be at least the group roles and a reference part
                {
                    parsedPath.EndNodeType = PblNodeType.ParseError;
                    return parsedPath;
                }
                parsedPath.RefId = pathParts[1];
                if (pathParts.Length > 2)
                {
                    for (int idx = 2; idx <= pathParts.Length; idx++)
                    {
                        parsedPath.RefId += "@" + pathParts[idx];
                    }
                }
                // test the RefId for typical attribute names
                if (parsedPath.RefId.StartsWith("residref="))
                    parsedPath.EndNodeType = PblNodeType.ItemRef;
                if (parsedPath.RefId.StartsWith("href="))
                    parsedPath.EndNodeType = PblNodeType.ItemRef;
                if (parsedPath.RefId.StartsWith("qcode="))
                    parsedPath.EndNodeType = PblNodeType.ContentRef;
                if (parsedPath.RefId.StartsWith("uri="))
                    parsedPath.EndNodeType = PblNodeType.ContentRef;
            }
            else 
                parsedPath.EndNodeType = PblNodeType.Group;
            // process the string representing the group roles
            string basePath;
            if (parsedPath.EndNodeType == PblNodeType.ItemRef || parsedPath.EndNodeType == PblNodeType.ContentRef)
                basePath = pathParts[0];
            else
                basePath = pblPath;
            pathParts = basePath.Split('/');
            foreach (string pathPart in pathParts) // split up the group roles to an ordered sequence
            {
                if (!string.IsNullOrEmpty(pathPart)) // take out the empty parts; in any case the one at the start
                    parsedPath.GroupRoles.Add(pathPart);
            }
            return parsedPath;
        } // ParsePblPath

        // ******************************************************************************
        /// <summary>
        /// Checks if the node addressed by the PBL-Path exists in a NewsML-G2 Package Item
        /// </summary>
        /// <param name="pkgItem">The Package Item</param>
        /// <param name="pblPath">The PBL-Path</param>
        /// <returns>True if the node exists</returns>
        public static bool PblNodeExists(PackageItemPwrXml pkgItem, string pblPath)
        {
            if (string.IsNullOrEmpty(pblPath))
                return false;
            var pblPathParsed = ParsePblPath(pblPath);
            if ((pblPathParsed.EndNodeType == PblNodeType.ParseError)
                || (pblPathParsed.EndNodeType == PblNodeType.Undefined))
                return false;
            // first check for the groups by their roles
            var groupFound = true;
            var lastGroupRole = string.Empty;
            foreach (var groupRole in pblPathParsed.GroupRoles)
            {
                lastGroupRole = groupRole;
                if (!pkgItem.ExistsRelXN("/nar:groupSet/nar:group[@role='" + groupRole + "']"))
                    groupFound = false;
                if (!groupFound)
                    break;
            }
            if (!groupFound)
                return false;

            // second: check for itemRef and contentRef - if included into the PBL-Path
            string[] refIdParts = {""};
            if (!string.IsNullOrEmpty(pblPathParsed.RefId))
                refIdParts = pblPathParsed.RefId.Split('='); // part[0] = attribute name, [1] = value
            if (pblPathParsed.EndNodeType == PblNodeType.ItemRef)
            {
                if (!pkgItem.ExistsRelXN("/nar:groupSet/nar:group[@role='" + lastGroupRole 
                    + "']/nar:itemRef[@" + refIdParts[0] + "='" + refIdParts[0] + "']"))
                    return false;
            }
            if (pblPathParsed.EndNodeType == PblNodeType.ContentRef)
            {
                if (!pkgItem.ExistsRelXN("/nar:groupSet/nar:group[@role='" + lastGroupRole 
                    + "']/nar:conceptRef[@" + refIdParts[0] + "='" + refIdParts[0] + "']"))
                    return false;
            }

            return true;
        } // PblNodeExists

        // ******************************************************************************
        // ***** ACTIONS FOR CHANGING THE STRUCTURE

        /* Outline of planned actions
         * MoveGroup(fromPblPath, toPblPath)
         * MoveItemRef/ContentRef(fromPblPath, toPblPath)
         * DeleteGroup(pblPath)
         * DeleteItemRef/ContentRef(pblPath)
         */
    }
}
