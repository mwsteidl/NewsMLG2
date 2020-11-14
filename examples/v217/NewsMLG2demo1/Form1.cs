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
 * 2014-03-19 mws: Package Item example added
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
        private const string PgmVersion = " v1.0 [2014-03-19]";

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
            g2NI.CheckAddNarWrapper1(NarDocXml.PropsWrapping1.RightsInfo);

            // ** add a copyrightHolder
            // * create a plain object for the copyrightHolder property
            var copyrightHolder = new CopyrightHolder();
            // * create a placeholder for the copyrightHolder element
            XmlElement copyrightHolderXe = null;
            // * add the copyrightHolder property to the rightsInfo wrapper and get the new XML element returned
            g2NI.AddNarPropertyToWrapper1(NarDocXml.PropsWrapping1.RightsInfo, copyrightHolder, out copyrightHolderXe);
            // * create a structured object for the copyrightHolder element
            var copyrightHolderSe = new ConceptStructProp() {Uri = "http://www.acmenews.com/about.html#copyright"};
            // * property with a value in the text node
            var crName = new Name("Acme News and Media LLC");
            copyrightHolderSe.Names.Add(crName);
            // * apply this structure to the already created copyrightHolder element
            copyrightHolderSe.ApplyToElement(g2NI, copyrightHolderXe);
            // * property with a value in the text node
            var copyrightNotice = new CopyrightNotice("(c) 2013 Copyright Acme News and Media LLC");
            g2NI.AddNarPropertyToWrapper1(NarDocXml.PropsWrapping1.RightsInfo, copyrightNotice);

            // ** add an itemMeta element as wrapper of properties
            g2NI.CheckAddNarWrapper1(NarDocXml.PropsWrapping1.ItemMeta);

            // ** add a sequence of properties as children of itemMeta
            // * property using the qcode attribute
            var itemClass = new ItemClass {qcode = "ninat:text"};
            g2NI.AddNarPropertyToWrapper1(NarDocXml.PropsWrapping1.ItemMeta, itemClass);
            // * property using the uri attribute
            var provider = new Provider {uri = "http://www.acmenews.com/about/"};
            g2NI.AddNarPropertyToWrapper1(NarDocXml.PropsWrapping1.ItemMeta, provider);
            var versionCreated = new VersionCreated("2013-11-21T16:25:32-05:00");
            g2NI.AddNarPropertyToWrapper1(NarDocXml.PropsWrapping1.ItemMeta, versionCreated);
            var embargoed = new Embargoed("2013-11-26T12:00:00-05:00");
            g2NI.AddNarPropertyToWrapper1(NarDocXml.PropsWrapping1.ItemMeta, embargoed);
            var pubStatus = new PubStatus {qcode = "stat:usable"};
            g2NI.AddNarPropertyToWrapper1(NarDocXml.PropsWrapping1.ItemMeta, pubStatus);


            // ** add a contentMeta element as wrapper of properties
            g2NI.CheckAddNarWrapper1(NarDocXml.PropsWrapping1.ContentMeta);

            // ** add a sequence of properties as children of itemMeta
            var contentCreated = new ContentCreated("2013-11-21T15:21:06-05:00");
            g2NI.AddNarPropertyToWrapper1(NarDocXml.PropsWrapping1.ContentMeta, contentCreated);

            var contentModified = new ContentModified("2013-11-21T16:22:45-05:00");
            g2NI.AddNarPropertyToWrapper1(NarDocXml.PropsWrapping1.ContentMeta, contentModified);

            // * a structured property
            var located = new Located {qcode = "geoloc:NYC"};
            XmlElement locatedXe = null;
            g2NI.AddNarPropertyToWrapper1(NarDocXml.PropsWrapping1.ContentMeta, located, out locatedXe);
            var locatedSe = new ConceptStructProp();
            locatedSe.Names.Add(new Name("New York, NY"));
            locatedSe.ApplyToElement(g2NI, locatedXe);

            var creator = new Creator {uri = "http://www.acmenews.com/staff/mjameson"};
            XmlElement creatorXe = null;
            g2NI.AddNarPropertyToWrapper1(NarDocXml.PropsWrapping1.ContentMeta, creator, out creatorXe);
            var creatorSe = new ConceptStructProp();
            creatorSe.Names.Add(new Name("Meredith Jameson"));
            creatorSe.ApplyToElement(g2NI, creatorXe);

            var infoSource = new InfoSource {qcode = "is:AP"};
            XmlElement infoSourceXe = null;
            g2NI.AddNarPropertyToWrapper1(NarDocXml.PropsWrapping1.ContentMeta, infoSource, out infoSourceXe);
            var infoSourceSe = new ConceptStructProp();
            infoSourceSe.Names.Add(new Name("Associated Press"));
            infoSourceSe.ApplyToElement(g2NI, infoSourceXe);

            var language = new Language {tag = "en-US"};
            g2NI.AddNarPropertyToWrapper1(NarDocXml.PropsWrapping1.ContentMeta, language);

            var subject = new Subject {qcode = "medtop:04000000"};
            XmlElement subjectXe = null;
            g2NI.AddNarPropertyToWrapper1(NarDocXml.PropsWrapping1.ContentMeta, subject, out subjectXe);
            var subjectSe = new ConceptStructProp();
            subjectSe.Names.Add(new Name("economy, business and finance"));
            subjectSe.ApplyToElement(g2NI, subjectXe);

            // * note: as this is another subject the type definitions of the variables have been removed
            subject = new Subject {qcode = "medtop:20000350"};
            subjectXe = null;
            g2NI.AddNarPropertyToWrapper1(NarDocXml.PropsWrapping1.ContentMeta, subject, out subjectXe);
            subjectSe = new ConceptStructProp();
            subjectSe.Names.Add(new Name("central bank"));
            subjectSe.ApplyToElement(g2NI, subjectXe);

            subject = new Subject {qcode = "medtop:20000379"};
            subjectXe = null;
            g2NI.AddNarPropertyToWrapper1(NarDocXml.PropsWrapping1.ContentMeta, subject, out subjectXe);
            subjectSe = new ConceptStructProp();
            subjectSe.Names.Add(new Name("money and monetary policy"));
            subjectSe.ApplyToElement(g2NI, subjectXe);

            var slugline = new Slugline("US-Finance-Fed");
            g2NI.AddNarPropertyToWrapper1(NarDocXml.PropsWrapping1.ContentMeta, slugline);

            var headline = new Headline("Fed to halt QE to avert \"bubble\"");
            g2NI.AddNarPropertyToWrapper1(NarDocXml.PropsWrapping1.ContentMeta, headline);

            // ** add a contentMeta element as wrapper of properties representing the content of the News Item
            g2NI.CheckAddNarWrapper1(NarDocXml.PropsWrapping1.ContentSet);

            // ** an inlineXML holds any kind of XML - in its own namespace.
            var inlineXML = new InlineXML();
            XmlElement inlineXmlXe = null;
            g2NI.AddNarPropertyToWrapper1(NarDocXml.PropsWrapping1.ContentSet, inlineXML, out inlineXmlXe);
            // * the XML content of inlineXML goes into the inner XML of the element
            inlineXmlXe.InnerXml = 
                "<nitf xmlns='http://iptc.org/std/NITF/2006-10-18/'> <body> <body.head> <hedline> <hl1>Fed to halt QE to avert \"bubble\"</hl1> </hedline> <byline>By Meredith Jameson, <byttl>Staff Reporter</byttl> </byline> </body.head> <body.content> <p>(New York, NY - November 21) Et, sent luptat luptat, commy Nim zzriureet vendreetue modo dolenis ex euisis nosto et lan ullandit lum doloreet vulla. </p> <p>Ugiating ea feugait utat, venim velent nim quis nulluptat num Volorem inci enim dolobor eetuer sendre ercin utpatio dolorpercing. </p> </body.content> </body> </nitf>";
            g2NI.AddNarPropertyToWrapper1(NarDocXml.PropsWrapping1.ContentSet, inlineXML);

            // *** all metadata properties and elements providing the news content have been added

            // *** Save the serialized XML document
            g2NI.SaveToFile("QS-Text_1.0-ExampleFull1-generated.xml", true);
            qsTextEx1Lbl.Text = "Example News Item created.";

        } // GenerateQuickStartTextExample1

        /// <summary>
        /// This examples creates a NewsML-G2 News Item as shown in the QuickStart NewsML-G2 Package 
        /// document in this package http://www.iptc.org/std/NewsML-G2/2.15/documentation/IPTC-NewsML-G2-QuickStartGuides_2014.zip
        /// </summary>
        private void GenerateQuickStartPackageExample1()
        {
            // variables global only to this method
            XmlNode foundNode = null;

            // *** create an object for the NewsML-G2 News Item
            var g2PkgI = new PackageItemPwrXml();
            // * add the GUID and the version number to it
            g2PkgI.InitEmptyXMLDoc("tag:example.com,2008:UK-NEWS-TOPTEN:UK20081220098658", 18);
            g2PkgI.SetRootXmlLang("en-US");

            // * add the catalogRefs to it
            g2PkgI.AddCatalogRef("http://www.iptc.org/std/catalog/catalog.IPTC-G2-Standards_22.xml");
            g2PkgI.AddCatalogRef("http:/www.example.com/customer/cv/catalog4customers-1.xml");

            // ** add an itemMeta element as wrapper of properties
            g2PkgI.CheckAddNarWrapper1(NarDocXml.PropsWrapping1.ItemMeta);

            // ** add a sequence of properties as children of itemMeta
            // * property using the qcode attribute
            var itemClass = new ItemClass { qcode = "ninat:composite" };
            g2PkgI.AddNarPropertyToWrapper1(NarDocXml.PropsWrapping1.ItemMeta, itemClass);
            // * property using the uri attribute
            var provider = new Provider { qcode = "nprov:REUTERS" };
            g2PkgI.AddNarPropertyToWrapper1(NarDocXml.PropsWrapping1.ItemMeta, provider);
            var versionCreated = new VersionCreated("2012-11-07T12:30:00Z");
            g2PkgI.AddNarPropertyToWrapper1(NarDocXml.PropsWrapping1.ItemMeta, versionCreated);
            var firstCreated = new FirstCreated("2008-12-20T12:25:35Z");
            g2PkgI.AddNarPropertyToWrapper1(NarDocXml.PropsWrapping1.ItemMeta, firstCreated);
            var pubStatus = new PubStatus { qcode = "stat:usable" };
            g2PkgI.AddNarPropertyToWrapper1(NarDocXml.PropsWrapping1.ItemMeta, pubStatus);
            var profile = new Profile();
            profile.versioninfo = "1.0.0.2";
            g2PkgI.AddNarPropertyToWrapper1(NarDocXml.PropsWrapping1.ItemMeta, profile);
            var service = new Service();
            XmlElement serviceXe = null;
            service.qcode = "svc:uktop";
            g2PkgI.AddNarPropertyToWrapper1(NarDocXml.PropsWrapping1.ItemMeta, service, out serviceXe);
            var svcName = new ConceptStructProp();
            svcName.Names.Add(new Name("Top UK News stories hourly"));
            svcName.ApplyToElement(g2PkgI, serviceXe);
            var title = new Title("UK-TOPNEWS");
            g2PkgI.AddNarPropertyToWrapper1(NarDocXml.PropsWrapping1.ItemMeta, title);
            var edNote = new EdNote("Updates the previous version");
            g2PkgI.AddNarPropertyToWrapper1(NarDocXml.PropsWrapping1.ItemMeta, edNote);
            var signal2 = new Signal();
            signal2.qcode = "sig:update";
            g2PkgI.AddNarPropertyToWrapper1(NarDocXml.PropsWrapping1.ItemMeta, signal2);


            // ** add a contentMeta element as wrapper of properties
            g2PkgI.CheckAddNarWrapper1(NarDocXml.PropsWrapping1.ContentMeta);

            // ** add a sequence of properties as children of itemMeta
            var contentCreated = new ContentCreated("2013-11-21T15:21:06-05:00");
            var contributor = new Contributor();
            XmlElement contributorXe = null;
            g2PkgI.AddNarPropertyToWrapper1(NarDocXml.PropsWrapping1.ContentMeta, contributor, out contributorXe);
            var contribSp = new ConceptStructProp();
            var name1 = new Name("Maurice Dancer");
            contribSp.Names.Add(name1);
            var name2 = new Name("Chief Packaging Editor");
            contribSp.Names.Add(name2);
            var definition = new Definition("Duty Packaging Editor");
            definition.validto = "2008-12-20T17:30:00Z";
            contribSp.Definitions.Add(definition);
            var note = new Note("Available on +44 207 345 4567 until 17:30 GMT today");
            note.validto = "2008-12-20T17:30:00Z";
            contribSp.Notes.Add(note);
            contribSp.ApplyToElement(g2PkgI, contributorXe);
            var headline = new Headline("UK");
            headline.xmllang = "en";
            g2PkgI.AddNarPropertyToWrapper1(NarDocXml.PropsWrapping1.ContentMeta, headline);

            var irCtr = 1;
            // The package
            PropProcStatus procStatus;
            var newGroup = new GroupStructProp();
            newGroup.CoreGroup.role = "group:main";
            newGroup.CoreGroup.id = "G" + g2PkgI.NewIdSequence.ToString();
            newGroup.CoreGroup.mode = "pgrmode:seq";
            newGroup.PblPath = "/group:main";
            newGroup.AddGroupToPackage(g2PkgI);

            // Group 2
            newGroup = new GroupStructProp();
            newGroup.CoreGroup.role = "group:top";
            newGroup.CoreGroup.id = "G" + g2PkgI.NewIdSequence.ToString();
            newGroup.PblPath = "/group:main/group:top";
            var itemRef1 = new ItemRef();
            itemRef1.id = "IR0" + irCtr++.ToString();
            itemRef1.residref = "urn:newsml:iptc.org:20081007:tutorial-item-A";
            itemRef1.contenttype = "application/vnd.iptc.g2.newsitem+xml";
            itemRef1.size = "3452";
            newGroup.ItemRefs.Add(itemRef1);
            var itemRef2 = new ItemRef();
            itemRef2.id = "IR0" + irCtr++.ToString();
            itemRef2.residref = "urn:newsml:iptc.org:20081007:tutorial—item-B";
            itemRef2.contenttype = "application/vnd.iptc.g2.newsitem+xml";
            itemRef2.size = "230003";
            newGroup.ItemRefs.Add(itemRef2);
            newGroup.AddGroupToPackage(g2PkgI);
            // add children of itemRef 1
            var parentPath = "/nar:packageItem/nar:groupSet/nar:group[@id='"
                             + newGroup.CoreGroup.id + "']/nar:itemRef[@id='" + itemRef1.id + "']";
            itemClass = new ItemClass { qcode = "ninat:text" };
            g2PkgI.AddNarPropertyToParent(parentPath, "", itemClass);
            provider = new Provider { qcode = "nprov:REUTERS" };
            g2PkgI.AddNarPropertyToParent(parentPath, "", provider);
            pubStatus = new PubStatus { qcode = "stat:usable" };
            g2PkgI.AddNarPropertyToParent(parentPath, "", pubStatus);
            title = new Title("Bank cuts interest rates to record low");
            g2PkgI.AddNarPropertyToParent(parentPath, "", title);
            var description = new Description("London (Reuters) - The Bank of England cut interest rates by half a percentage point on Thursday to a record low of  ....") { role = "drol:summary" };
            g2PkgI.AddNarPropertyToParent(parentPath, "", description);
            // add children of itemRef 2
            parentPath = "/nar:packageItem/nar:groupSet/nar:group[@id='"
                 + newGroup.CoreGroup.id + "']/nar:itemRef[@id='" + itemRef2.id + "']";
            itemClass = new ItemClass { qcode = "ninat:picture" };
            g2PkgI.AddNarPropertyToParent(parentPath, "", itemClass);
            provider = new Provider { qcode = "nprov:REUTERS" };
            g2PkgI.AddNarPropertyToParent(parentPath, "", provider);
            pubStatus = new PubStatus { qcode = "stat:usable" };
            g2PkgI.AddNarPropertyToParent(parentPath, "", pubStatus);
            title = new Title("BoE Rate Decision");
            g2PkgI.AddNarPropertyToParent(parentPath, "", title);

            // Group 3
            newGroup = new GroupStructProp();
            newGroup.CoreGroup.role = "group:two";
            newGroup.CoreGroup.id = "G" + g2PkgI.NewIdSequence.ToString();
            newGroup.PblPath = "/group:main/group:two";
            itemRef1 = new ItemRef();
            itemRef1.id = "IR0" + irCtr++.ToString();
            itemRef1.residref = "urn:newsml:iptc.org:20081007:tutorial-item-C";
            itemRef1.contenttype = "application/vnd.iptc.g2.newsitem+xml";
            itemRef1.size = "2345";
            newGroup.ItemRefs.Add(itemRef1);
            itemRef2 = new ItemRef();
            itemRef2.id = "IR0" + irCtr++.ToString();
            itemRef2.residref = "urn:newsml:iptc.org:20081007:tutorial—item-D";
            itemRef2.contenttype = "application/vnd.iptc.g2.newsitem+xml";
            itemRef2.size = "24065";
            newGroup.ItemRefs.Add(itemRef2);
            newGroup.AddGroupToPackage(g2PkgI);
            // add children of itemRef 1
            parentPath = "/nar:packageItem/nar:groupSet/nar:group[@id='"
                             + newGroup.CoreGroup.id + "']/nar:itemRef[@id='" + itemRef1.id + "']";
            itemClass = new ItemClass { qcode = "ninat:text" };
            g2PkgI.AddNarPropertyToParent(parentPath, "", itemClass);
            provider = new Provider { qcode = "nprov:REUTERS" };
            g2PkgI.AddNarPropertyToParent(parentPath, "", provider);
            pubStatus = new PubStatus { qcode = "stat:usable" };
            g2PkgI.AddNarPropertyToParent(parentPath, "", pubStatus);
            title = new Title("Government denies it will print more cash");
            g2PkgI.AddNarPropertyToParent(parentPath, "", title);
            description = new Description("London (Reuters) – Chancellor Alistair Darling dismissed reports on Thursday that the government was about ...") { role = "drol:summary" };
            g2PkgI.AddNarPropertyToParent(parentPath, "", description);
            // add children of itemRef 2
            parentPath = "/nar:packageItem/nar:groupSet/nar:group[@id='"
                 + newGroup.CoreGroup.id + "']/nar:itemRef[@id='" + itemRef2.id + "']";
            itemClass = new ItemClass { qcode = "ninat:picture" };
            g2PkgI.AddNarPropertyToParent(parentPath, "", itemClass);
            provider = new Provider { qcode = "nprov:REUTERS" };
            g2PkgI.AddNarPropertyToParent(parentPath, "", provider);
            pubStatus = new PubStatus { qcode = "stat:usable" };
            g2PkgI.AddNarPropertyToParent(parentPath, "", pubStatus);
            title = new Title("Sterling notes and coin");
            g2PkgI.AddNarPropertyToParent(parentPath, "", title);


            // Group 4, compressed C#
            newGroup = new GroupStructProp { CoreGroup = { role = "group:three", id = "G" + g2PkgI.NewIdSequence.ToString() } };
            newGroup.PblPath = "/group:main/group:three";
            itemRef1 = new ItemRef
            {
                id = "IR0" + irCtr++.ToString(),
                residref = "urn:newsml:iptc.org:20081007:tutorial-item-E",
                contenttype = "application/vnd.iptc.g2.newsitem+xml",
                size = "2345"
            };
            newGroup.ItemRefs.Add(itemRef1);
            itemRef2 = new ItemRef
            {
                id = "IR0" + irCtr++.ToString(),
                residref = "urn:newsml:iptc.org:20081007:tutorial—item-F",
                contenttype = "application/vnd.iptc.g2.newsitem+xml",
                size = "25346"
            };
            newGroup.ItemRefs.Add(itemRef2);
            newGroup.AddGroupToPackage(g2PkgI);
            // add children of itemRef 1
            parentPath = "/nar:packageItem/nar:groupSet/nar:group[@id='"
                             + newGroup.CoreGroup.id + "']/nar:itemRef[@id='" + itemRef1.id + "']";
            g2PkgI.AddNarPropertyToParent(parentPath, "", new ItemClass { qcode = "ninat:text" });
            g2PkgI.AddNarPropertyToParent(parentPath, "", new Provider { qcode = "nprov:REUTERS" });
            g2PkgI.AddNarPropertyToParent(parentPath, "", new PubStatus { qcode = "stat:usable" });
            g2PkgI.AddNarPropertyToParent(parentPath, "", new Title("Rugby's Mike Tindall banned for drink-driving"));
            g2PkgI.AddNarPropertyToParent(parentPath, "",
                new Description("London (Reuters) - England rugby player Mike Tindall was banned from driving for three years and fined £500 on Thursday ...") { role = "drol:summary" });
            // add children of itemRef 2
            parentPath = "/nar:packageItem/nar:groupSet/nar:group[@id='"
                 + newGroup.CoreGroup.id + "']/nar:itemRef[@id='" + itemRef2.id + "']";
            g2PkgI.AddNarPropertyToParent(parentPath, "", new ItemClass { qcode = "ninat:picture" });
            g2PkgI.AddNarPropertyToParent(parentPath, "", new Provider { qcode = "nprov:REUTERS" });
            g2PkgI.AddNarPropertyToParent(parentPath, "", new PubStatus { qcode = "stat:usable" });
            g2PkgI.AddNarPropertyToParent(parentPath, "", new Title("Mike Tindall in rugby action for England"));


            g2PkgI.SaveToFile("QS-Package_1.0-ExampleSequStruct1-generated.xml", true);
            qsPkgEx1Lbl.Text = "Example Package Item created.";

        } // GenerateQuickStartPackageExample1


        private void qsTextEx1_Click(object sender, EventArgs e)
        {
            GenerateQuickStartTextExample1();
        }

        private void qsPackageEx1_Click(object sender, EventArgs e)
        {
            GenerateQuickStartPackageExample1();
        }
    }
}
