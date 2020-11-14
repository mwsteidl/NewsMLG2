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
Class: NewsIT.IPTC.NewsMLG2.v218.NIpwrXML = NewsML-G2 News Item

Current date / persID / change log (most current at top)
 * 2014-08-27 mws: moved from v217 to v218
StartDate: 2014-03-05 mws
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

namespace NewsIT.IPTC.NewsMLG2.v218
{
	
    //**************************************************************************
    //**************************************************************************
    //**************************************************************************
    /// <summary>
	/// IPTC NewsML-G2 Package Item class
	/// </summary>
	public class PackageItemPwrXml : AnyItemXml
    {

        // Defines the sequence of QNames of the children of the root element
        public const string NameSeqPkiRoot =
            NameSeqAnyRoot + " nar:contentMeta nar:partMeta nar:assert nar:inlineRef " +
            "nar:derivedFrom nar:groupSet";

        public const string NameSeqPkiGroup =
            "nar:groupRef nar:itemRef nar:conceptRef nar:title nar:signal nar:edNote nar:groupExtProperty";

		//**************************************************************************
		/// <summary>
		/// Constructor for a blank G2 Package Item object - has to be initialised before being used
		/// </summary>
        public PackageItemPwrXml()
		{
            RootElemName = "packageItem";
		    _idSequence = 0;
		}

        // *******************************************************************************
        // *******************************************************************************
        #region ***** PROPERTIES

        private int _idSequence;

        public int NewIdSequence
        {
            get {_idSequence++; return _idSequence; }
        }

        #endregion

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
            XmlDoc.RemoveAll();
            XmlDoc.LoadXml("<?xml version='1.0' encoding='utf-8' standalone='yes'?> <packageItem xmlns='http://iptc.org/std/nar/2006-10-01/'></packageItem>");
            XmlNode rootXN = XmlDoc.SelectSingleNode("/nar:" + RootElemName, NsMngr);
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
        /// Adds a GroupSet element as child to the root element
        /// </summary>
        public void AddGroupSet()
        // Code History:
        // 2014-03-05mws
        {           
            CheckAddNarWrapper1(PropsWrapping1.GroupSet);
        } // AddGroupSet


        #endregion

        // ******************************************************************************
        // ******************************************************************************
        // ***** SIMPLE (& constrained) WRITE  METHODS *************************************************
        #region ***** SIMPLE (& constrained) WRITE  METHODS



        #endregion

        // *******************************************************************************
        // *******************************************************************************
        #region ***** UTILITIES

        #endregion

    }
}
