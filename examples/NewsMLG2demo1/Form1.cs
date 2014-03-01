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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GenerateQuickStartTextExample1()
        {
            // variables global only to this method
            XmlNode foundNode = null;

            // *** create an object for the NewsML-G2 News Item
            var g2NI = new NIpwrXml();
            // * add the GUID and the version number to it
            g2NI.InitEmptyXMLDoc("urn:newsml:acmenews.com:20131121:US-FINANCE-FED", 3);
            
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
            var copyrightHolderSe = new ConceptGenericStruElem();
            copyrightHolderSe.Uri = "http://www.acmenews.com/about.html#copyright";
            var crName = new Name();
            // * property with a value in the text node
            crName.thisValue = "Acme News and Media LLC";
            copyrightHolderSe.Names.Add(crName);
            // * apply this structure to the already created copyrightHolder element
            copyrightHolderSe.ApplyToElement(g2NI, copyrightHolderXe);
            // * property with a value in the text node
            var copyrightNotice = new CopyrightNotice();
            copyrightNotice.thisValue = "(c) 2013 Copyright Acme News and Media LLC";
            g2NI.AddNarPropertyToWrapper1(AnyItemXml.PropsWrapping1.RightsInfo, copyrightNotice);

            // ** add an itemMeta element as wrapper of properties
            g2NI.CheckAddNarWrapper1(AnyItemXml.PropsWrapping1.ItemMeta);

            // ** add a sequence of properties as children of itemMeta
            // * property using the qcode attribute
            var itemClass = new ItemClass();
            itemClass.qcode = "ninat:text";
            g2NI.AddNarPropertyToWrapper1(AnyItemXml.PropsWrapping1.ItemMeta, itemClass);
            // * property using the uri attribute
            var provider = new Provider();
            provider.uri = "http://www.acmenews.com/about/";
            g2NI.AddNarPropertyToWrapper1(AnyItemXml.PropsWrapping1.ItemMeta, provider);
            var versionCreated = new VersionCreated();
            versionCreated.thisValue = "2013-11-21T16:25:32-05:00";
            g2NI.AddNarPropertyToWrapper1(AnyItemXml.PropsWrapping1.ItemMeta, versionCreated);
            var embargoed = new Embargoed();
            embargoed.thisValue = "2013-11-26T12:00:00-05:00";
            g2NI.AddNarPropertyToWrapper1(AnyItemXml.PropsWrapping1.ItemMeta, embargoed);
            var pubStatus = new PubStatus();
            pubStatus.qcode = "stat:usable";
            g2NI.AddNarPropertyToWrapper1(AnyItemXml.PropsWrapping1.ItemMeta, pubStatus);


            // ** add a contentMeta element as wrapper of properties
            g2NI.CheckAddNarWrapper1(AnyItemXml.PropsWrapping1.ContentMeta);

            // ** add a sequence of properties as children of itemMeta
            var contentCreated = new ContentCreated();
            contentCreated.thisValue = "2013-11-21T15:21:06-05:00";
            g2NI.AddNarPropertyToWrapper1(AnyItemXml.PropsWrapping1.ContentMeta, contentCreated);

            var contentModified = new ContentModified();
            contentModified.thisValue = "2013-11-21T16:22:45-05:00";
            g2NI.AddNarPropertyToWrapper1(AnyItemXml.PropsWrapping1.ContentMeta, contentModified);

            // * a structured property
            var located = new Located();
            located.qcode = "geoloc:NYC";
            XmlElement locatedXe = null;
            g2NI.AddNarPropertyToWrapper1(AnyItemXml.PropsWrapping1.ContentMeta, located, out locatedXe);
            var locatedSe = new ConceptGenericStruElem();
            var locName = new Name();
            locName.thisValue = "New York, NY";
            locatedSe.Names.Add(locName);
            locatedSe.ApplyToElement(g2NI, locatedXe);

            var creator = new Creator();
            creator.uri = "http://www.acmenews.com/staff/mjameson";
            XmlElement creatorXe = null;
            g2NI.AddNarPropertyToWrapper1(AnyItemXml.PropsWrapping1.ContentMeta, creator, out creatorXe);
            var creatorSe = new ConceptGenericStruElem();
            var creaName = new Name();
            creaName.thisValue = "Meredith Jameson";
            creatorSe.Names.Add(creaName);
            creatorSe.ApplyToElement(g2NI, creatorXe);

            var infoSource = new InfoSource();
            infoSource.qcode = "is:AP";
            XmlElement infoSourceXe = null;
            g2NI.AddNarPropertyToWrapper1(AnyItemXml.PropsWrapping1.ContentMeta, infoSource, out infoSourceXe);
            var infoSourceSe = new ConceptGenericStruElem();
            var isName = new Name();
            isName.thisValue = "Associated Press";
            infoSourceSe.Names.Add(isName);
            infoSourceSe.ApplyToElement(g2NI, infoSourceXe);

            var language = new Language();
            language.tag = "en-US";
            g2NI.AddNarPropertyToWrapper1(AnyItemXml.PropsWrapping1.ContentMeta, language);

            var subject = new Subject();
            subject.qcode = "medtop:04000000";
            XmlElement subjectXe = null;
            g2NI.AddNarPropertyToWrapper1(AnyItemXml.PropsWrapping1.ContentMeta, subject, out subjectXe);
            var subjectSe = new ConceptGenericStruElem();
            var subjectName = new Name();
            subjectName.thisValue = "economy, business and finance";
            subjectSe.Names.Add(subjectName);
            subjectSe.ApplyToElement(g2NI, subjectXe);

            // * note: as this is another subject the type definitions of the variables have been removed
            subject = new Subject();
            subject.qcode = "medtop:20000350";
            subjectXe = null;
            g2NI.AddNarPropertyToWrapper1(AnyItemXml.PropsWrapping1.ContentMeta, subject, out subjectXe);
            subjectSe = new ConceptGenericStruElem();
            subjectName = new Name();
            subjectName.thisValue = "central bank";
            subjectSe.Names.Add(subjectName);
            subjectSe.ApplyToElement(g2NI, subjectXe);

            subject = new Subject();
            subject.qcode = "medtop:20000379";
            subjectXe = null;
            g2NI.AddNarPropertyToWrapper1(AnyItemXml.PropsWrapping1.ContentMeta, subject, out subjectXe);
            subjectSe = new ConceptGenericStruElem();
            subjectName = new Name();
            subjectName.thisValue = "money and monetary policy";
            subjectSe.Names.Add(subjectName);
            subjectSe.ApplyToElement(g2NI, subjectXe);

            var slugline = new Slugline();
            slugline.thisValue = "US-Finance-Fed";
            g2NI.AddNarPropertyToWrapper1(AnyItemXml.PropsWrapping1.ContentMeta, slugline);

            var headline = new Headline();
            headline.thisValue = "Fed to halt QE to avert \"bubble\"";
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
