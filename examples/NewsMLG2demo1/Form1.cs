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
 
Project: IPTC NewsML-G2 demos/examples
Program: NewsMLG2demo1
Class: NewsMLG2demo1
  

Current date / persID / change log (most current at top)
 * 2014-03-03 mws: use of classes with propValue parameter in constructor
StartDate: 2014-03-01 mws
******************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using NewsIT.IPTC.NewsMLG2;
using NewsIT.IPTC.NewsMLG2.v217;

namespace NewsMLG2demo1
{
    public partial class Form1 : Form
    {
        private const string PgmVersion = " v1.0 [2014-03-03]";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text += PgmVersion;
        }

        /// <summary>
        /// This examples creates a NewsML-G2 News Item as shown in the QuickStart NewsML-G2 Text
        /// document in this package http://www.iptc.org/std/NewsML-G2/2.15/documentation/IPTC-NewsML-G2-QuickStartGuides_2014.zip
        /// </summary>
        private void GenerateQuickStartTextExample1()
            // Code History:
            // 2014-03-03 mws
        {
            // variables global only to this method
            XmlNode foundNode = null;

            // *** create an object for the NewsML-G2 News Item
            var g2NI = new NewsItemPwrXml();
            // * add the GUID and the version number to it
            g2NI.InitEmptyXMLDoc("urn:newsml:acmenews.com:20131121:US-FINANCE-FED", 3);
            g2NI.SetRootXmlLang("en-US");
            
            // * add the catalogRefs to it
            g2NI.AddCatalogRef("http://www.iptc.org/std/catalog/catalog.IPTC-G2-Standards_22.xml");
            g2NI.AddCatalogRef("http://catalog.acmenews.com/news/ANM_G2_CODES_2.xml");
            
            // ** add a rightsInfo element as wrapper of properties
            g2NI.CheckAddNarWrapper1(AnyItemXml.PropsWrapping1.RightsInfo);

            // ** add a copyrightHolder
            // * create a plain object for the copyrightHolder property
            var copyrightHolder = new CopyrightHolder();
            // * create a placeholder for the copyrightHolder element
            XmlElement copyrightHolderXe = null;
            // * add the copyrightHolder property to the rightsInfo wrapper and get the new XML element returned
            g2NI.AddNarPropertyToWrapper1(AnyItemXml.PropsWrapping1.RightsInfo, copyrightHolder, out copyrightHolderXe);
            // * create a structured object for the copyrightHolder element
            var copyrightHolderSe = new ConceptGenericStruElem {Uri = "http://www.acmenews.com/about.html#copyright"};
            // * property with a value in the text node
            var crName = new Name("Acme News and Media LLC");
            copyrightHolderSe.Names.Add(crName);
            // * apply this structure to the already created copyrightHolder element
            copyrightHolderSe.ApplyToElement(g2NI, copyrightHolderXe);
            // * property with a value in the text node
            var copyrightNotice = new CopyrightNotice("(c) 2013 Copyright Acme News and Media LLC");
            g2NI.AddNarPropertyToWrapper1(AnyItemXml.PropsWrapping1.RightsInfo, copyrightNotice);

            // ** add an itemMeta element as wrapper of properties
            g2NI.CheckAddNarWrapper1(AnyItemXml.PropsWrapping1.ItemMeta);

            // ** add a sequence of properties as children of itemMeta
            // * property using the qcode attribute
            var itemClass = new ItemClass {qcode = "ninat:text"};
            g2NI.AddNarPropertyToWrapper1(AnyItemXml.PropsWrapping1.ItemMeta, itemClass);
            // * property using the uri attribute
            var provider = new Provider {uri = "http://www.acmenews.com/about/"};
            g2NI.AddNarPropertyToWrapper1(AnyItemXml.PropsWrapping1.ItemMeta, provider);
            var versionCreated = new VersionCreated("2013-11-21T16:25:32-05:00");
            g2NI.AddNarPropertyToWrapper1(AnyItemXml.PropsWrapping1.ItemMeta, versionCreated);
            var embargoed = new Embargoed("2013-11-26T12:00:00-05:00");
            g2NI.AddNarPropertyToWrapper1(AnyItemXml.PropsWrapping1.ItemMeta, embargoed);
            var pubStatus = new PubStatus {qcode = "stat:usable"};
            g2NI.AddNarPropertyToWrapper1(AnyItemXml.PropsWrapping1.ItemMeta, pubStatus);


            // ** add a contentMeta element as wrapper of properties
            g2NI.CheckAddNarWrapper1(AnyItemXml.PropsWrapping1.ContentMeta);

            // ** add a sequence of properties as children of itemMeta
            var contentCreated = new ContentCreated("2013-11-21T15:21:06-05:00");
            g2NI.AddNarPropertyToWrapper1(AnyItemXml.PropsWrapping1.ContentMeta, contentCreated);

            var contentModified = new ContentModified("2013-11-21T16:22:45-05:00");
            g2NI.AddNarPropertyToWrapper1(AnyItemXml.PropsWrapping1.ContentMeta, contentModified);

            // * a structured property
            var located = new Located {qcode = "geoloc:NYC"};
            XmlElement locatedXe = null;
            g2NI.AddNarPropertyToWrapper1(AnyItemXml.PropsWrapping1.ContentMeta, located, out locatedXe);
            var locatedSe = new ConceptGenericStruElem();
            locatedSe.Names.Add(new Name("New York, NY"));
            locatedSe.ApplyToElement(g2NI, locatedXe);

            var creator = new Creator {uri = "http://www.acmenews.com/staff/mjameson"};
            XmlElement creatorXe = null;
            g2NI.AddNarPropertyToWrapper1(AnyItemXml.PropsWrapping1.ContentMeta, creator, out creatorXe);
            var creatorSe = new ConceptGenericStruElem();
            creatorSe.Names.Add(new Name("Meredith Jameson"));
            creatorSe.ApplyToElement(g2NI, creatorXe);

            var infoSource = new InfoSource {qcode = "is:AP"};
            XmlElement infoSourceXe = null;
            g2NI.AddNarPropertyToWrapper1(AnyItemXml.PropsWrapping1.ContentMeta, infoSource, out infoSourceXe);
            var infoSourceSe = new ConceptGenericStruElem();
            infoSourceSe.Names.Add(new Name("Associated Press"));
            infoSourceSe.ApplyToElement(g2NI, infoSourceXe);

            var language = new Language {tag = "en-US"};
            g2NI.AddNarPropertyToWrapper1(AnyItemXml.PropsWrapping1.ContentMeta, language);

            var subject = new Subject {qcode = "medtop:04000000"};
            XmlElement subjectXe = null;
            g2NI.AddNarPropertyToWrapper1(AnyItemXml.PropsWrapping1.ContentMeta, subject, out subjectXe);
            var subjectSe = new ConceptGenericStruElem();
            subjectSe.Names.Add(new Name("economy, business and finance"));
            subjectSe.ApplyToElement(g2NI, subjectXe);

            // * note: as this is another subject the type definitions of the variables have been removed
            subject = new Subject {qcode = "medtop:20000350"};
            subjectXe = null;
            g2NI.AddNarPropertyToWrapper1(AnyItemXml.PropsWrapping1.ContentMeta, subject, out subjectXe);
            subjectSe = new ConceptGenericStruElem();
            subjectSe.Names.Add(new Name("central bank"));
            subjectSe.ApplyToElement(g2NI, subjectXe);

            subject = new Subject {qcode = "medtop:20000379"};
            subjectXe = null;
            g2NI.AddNarPropertyToWrapper1(AnyItemXml.PropsWrapping1.ContentMeta, subject, out subjectXe);
            subjectSe = new ConceptGenericStruElem();
            subjectSe.Names.Add(new Name("money and monetary policy"));
            subjectSe.ApplyToElement(g2NI, subjectXe);

            var slugline = new Slugline("US-Finance-Fed");
            g2NI.AddNarPropertyToWrapper1(AnyItemXml.PropsWrapping1.ContentMeta, slugline);

            var headline = new Headline("Fed to halt QE to avert \"bubble\"");
            g2NI.AddNarPropertyToWrapper1(AnyItemXml.PropsWrapping1.ContentMeta, headline);

            // ** add a contentMeta element as wrapper of properties representing the content of the News Item
            g2NI.CheckAddNarWrapper1(AnyItemXml.PropsWrapping1.ContentSet);

            // ** an inlineXML holds any kind of XML - in its own namespace.
            var inlineXML = new InlineXML();
            XmlElement inlineXmlXe = null;
            g2NI.AddNarPropertyToWrapper1(AnyItemXml.PropsWrapping1.ContentSet, inlineXML, out inlineXmlXe);
            // * the XML content of inlineXML goes into the inner XML of the element
            inlineXmlXe.InnerXml = 
                "<nitf xmlns='http://iptc.org/std/NITF/2006-10-18/'> <body> <body.head> <hedline> <hl1>Fed to halt QE to avert \"bubble\"</hl1> </hedline> <byline>By Meredith Jameson, <byttl>Staff Reporter</byttl> </byline> </body.head> <body.content> <p>(New York, NY - November 21) Et, sent luptat luptat, commy Nim zzriureet vendreetue modo dolenis ex euisis nosto et lan ullandit lum doloreet vulla. </p> <p>Ugiating ea feugait utat, venim velent nim quis nulluptat num Volorem inci enim dolobor eetuer sendre ercin utpatio dolorpercing. </p> </body.content> </body> </nitf>";
            g2NI.AddNarPropertyToWrapper1(AnyItemXml.PropsWrapping1.ContentSet, inlineXML);

            // *** all metadata properties and elements providing the news content have been added

            // *** Save the serialized XML document
            g2NI.SaveToFile("QS-Text_1.0-ExampleFull1-generated.xml", true);
            qsTextEx1Lbl.Text = "Example News Item created.";

        } // GenerateQuickStartTextExample1

        private void qsTextEx1_Click(object sender, EventArgs e)
        {
            GenerateQuickStartTextExample1();
        }
    }
}
