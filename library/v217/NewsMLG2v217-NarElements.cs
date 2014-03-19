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
 
Project: IPTC NewsML-G2
Program: no specific / Common Unit
Class: NewsIT.IPTC.NewsMLG2.v217. ... A class for each element in the nar namespace  

Current date / persID / change log (most current at top)
 * 2014-03-03 mws: properties with a value in the textnode got a
 *          constructur with a propValue param to set thisValue
 * 2014-02-26 mws: G2 struct matrix updated and transformed
 * 2014-02-25 mws: struct -> class
StartDate: 2014-02-24 mws
******************************************************************************/
using System;

namespace NewsIT.IPTC.NewsMLG2.v217
{
    /*********************************************************************
     * This is a set of classes corresponding to each element/property
     * defined by NewsML-G2 in a specific version.
     * A class can be transformed into an XML Element 
     * by the NarProperty2XmlElement method of the NewsML-G2 item classes.
     * 
     * The class name corresponds to the local name of the element,
     * only the first character is different: in upper case
     * A class provides a field for each defined attribute:
     * the field names are identical to the attribute names 
     *  except field names starting with Y: the Y was prefixed as the attribute
     *  name is identical to a C# keyword (e.g. class).
     * In addition these fields for managing the corresponding XML element are available:
     * Xname: the local name of the element
     * XnsURI: the namespace URI - in fact the one of the nar: namespace
     * XnsPrefix: the prefix as used by this library - in fact "nar"
     * Xusagecode: r = root element, p = property, d = detail of a property
     *      w = wrapping element, m = text markup, 
     * Xcard: a code for the cardinality: s = single, u = unbounded occurence
     * These X... fields are readonly, initialized on creating a class instance
     * Note: the classes below are auto-generated from the Structure Matrix
     * document (Excel sheet) of the corresponding NewsML-G2 version
     * It is strongly recommended not to modify them
     *********************************************************************/
    public class A
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string Yclass;
        public string href;
        public string hreflang;
        public string rel;
        public string rev;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public A() { Xname = "a"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "m"; Xcard = "u"; }
    }

    public class Access
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string media;
        public string role;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Access() { Xname = "access"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class AccessStatus
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public AccessStatus() { Xname = "accessStatus"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class Accountable
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Accountable() { Xname = "accountable"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class Action
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string target;
        public string timestamp;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Action() { Xname = "action"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "d"; Xcard = "u"; }
    }

    public class Address
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string role;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Address() { Xname = "address"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class Affiliation
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string validfrom;
        public string validto;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Affiliation() { Xname = "affiliation"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class AltId
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string type;
        public string environment;
        public string idformat;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public AltId() { Xname = "altId"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public AltId(string propValue) { Xname = "altId"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    public class AltLoc
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string type;
        public string role;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public AltLoc() { Xname = "altLoc"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class AltRep
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string contenttype;
        public string format;
        public string representation;
        public string size;
        public string validfrom;
        public string validto;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public AltRep() { Xname = "altRep"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class Area
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Area() { Xname = "area"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "d"; Xcard = "u"; }
    }

    public class Assert
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Assert() { Xname = "assert"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class AssignedTo
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string role;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public AssignedTo() { Xname = "assignedTo"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class Audience
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string confidence;
        public string derivedfrom;
        public string relevance;
        public string significance;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Audience() { Xname = "audience"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class Bag
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Bag() { Xname = "bag"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "s"; }
    }

    public class Bit
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string qcode;
        public string uri;
        public string type;
        public string confidence;
        public string derivedfrom;
        public string relevance;
        public string significance;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Bit() { Xname = "bit"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class Born
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Born() { Xname = "born"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
        public Born(string propValue) { Xname = "born"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; thisValue = propValue; }
    }

    public class Br
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Br() { Xname = "br"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "m"; Xcard = "u"; }
    }

    public class Broader
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string rank;
        public string rel;
        public string validfrom;
        public string validto;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Broader() { Xname = "broader"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class By
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string media;
        public string rank;
        public string role;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public By() { Xname = "by"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public By(string propValue) { Xname = "by"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    public class Capacity
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string media;
        public string role;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Capacity() { Xname = "capacity"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public Capacity(string propValue) { Xname = "capacity"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    public class Catalog
    {
        public string guid;
        public string version;
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string additionalInfo;
        public string authority;
        public string url;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Catalog() { Xname = "catalog"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "u"; }
    }

    public class CatalogContainer
    {
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public CatalogContainer() { Xname = "catalogContainer"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "s"; }
    }

    public class CatalogItem
    {
        public string standard;
        public string standardversion;
        public string conformance;
        public string guid;
        public string version;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public CatalogItem() { Xname = "catalogItem"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "r"; Xcard = "s"; }
    }

    public class CatalogRef
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string href;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public CatalogRef() { Xname = "catalogRef"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class CeasedToExist
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public CeasedToExist() { Xname = "ceasedToExist"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
        public CeasedToExist(string propValue) { Xname = "ceasedToExist"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; thisValue = propValue; }
    }

    public class ChannelXxNMSG
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string role;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public ChannelXxNMSG() { Xname = "channel"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public ChannelXxNMSG(string propValue) { Xname = "channel"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    public class ChannelXxREMCONT
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string type;
        public string audiobitrate;
        public string audiochannels;
        public string audiocodec;
        public string audiosamplerate;
        public string audiosamplesize;
        public string audiovbr;
        public string chnlid;
        public string colourdepth;
        public string colourindicator;
        public string colourspace;
        public string contenttype;
        public string duration;
        public string durationunit;
        public string format;
        public string height;
        public string heightunit;
        public string language;
        public string orientation;
        public string resolution;
        public string role;
        public string videoaspectratio;
        public string videoavgbitrate;
        public string videocodec;
        public string videodefinition;
        public string videoframerate;
        public string videosampling;
        public string videoscaling;
        public string videoscan;
        public string videovbr;
        public string width;
        public string widthunit;
        public string wordcount;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public ChannelXxREMCONT() { Xname = "channel"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public ChannelXxREMCONT(string propValue) { Xname = "channel"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    public class Circle
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Circle() { Xname = "circle"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class Concept
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Concept() { Xname = "concept"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "u"; }
    }

    public class ConceptExtProperty
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string rel;
        public string validfrom;
        public string validto;
        public string value;
        public string valuedatatype;
        public string valueunit;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public ConceptExtProperty() { Xname = "conceptExtProperty"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class ConceptId
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string qcode;
        public string uri;
        public string created;
        public string retired;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public ConceptId() { Xname = "conceptId"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
    }

    public class ConceptItem
    {
        public string standard;
        public string standardversion;
        public string conformance;
        public string guid;
        public string version;
        public string xmllang;
        public string dir;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public ConceptItem() { Xname = "conceptItem"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "r"; Xcard = "s"; }
    }

    public class ConceptRef
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public ConceptRef() { Xname = "conceptRef"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class ConceptSet
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public ConceptSet() { Xname = "conceptSet"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "s"; }
    }

    public class Confirmation
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string qcode;
        public string uri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Confirmation() { Xname = "confirmation"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
    }

    public class ContactInfo
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string role;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public ContactInfo() { Xname = "contactInfo"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "u"; }
    }

    public class ContentCreated
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public ContentCreated() { Xname = "contentCreated"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
        public ContentCreated(string propValue) { Xname = "contentCreated"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; thisValue = propValue; }
    }

    public class ContentMeta
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public ContentMeta() { Xname = "contentMeta"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "s"; }
    }

    public class ContentMetaExtProperty
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string rel;
        public string validfrom;
        public string validto;
        public string value;
        public string valuedatatype;
        public string valueunit;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public ContentMetaExtProperty() { Xname = "contentMetaExtProperty"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class ContentModified
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public ContentModified() { Xname = "contentModified"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
        public ContentModified(string propValue) { Xname = "contentModified"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; thisValue = propValue; }
    }

    public class ContentSet
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string original;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public ContentSet() { Xname = "contentSet"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "s"; }
    }

    public class Contributor
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string jobtitle;
        public string role;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Contributor() { Xname = "contributor"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class CopyrightHolder
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public CopyrightHolder() { Xname = "copyrightHolder"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class CopyrightNotice
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string href;
        public string media;
        public string role;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public CopyrightNotice() { Xname = "copyrightNotice"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public CopyrightNotice(string propValue) { Xname = "copyrightNotice"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    public class Country
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Country() { Xname = "country"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "d"; Xcard = "s"; }
    }

    public class Created
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Created() { Xname = "created"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
        public Created(string propValue) { Xname = "created"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; thisValue = propValue; }
    }

    public class Creator
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string jobtitle;
        public string role;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Creator() { Xname = "creator"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class Creditline
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string rank;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Creditline() { Xname = "creditline"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public Creditline(string propValue) { Xname = "creditline"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    public class Dateline
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string media;
        public string rank;
        public string role;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Dateline() { Xname = "dateline"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public Dateline(string propValue) { Xname = "dateline"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    public class Dates
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Dates() { Xname = "dates"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "s"; }
    }

    public class Definition
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string media;
        public string role;
        public string roleuri;
        public string validfrom;
        public string validto;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Definition() { Xname = "definition"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public Definition(string propValue) { Xname = "definition"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    public class DeliverableOf
    {
        public string version;
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string contenttype;
        public string format;
        public string guidref;
        public string href;
        public string hreftype;
        public string persistidref;
        public string rank;
        public string rel;
        public string residref;
        public string size;
        public string title;
        public string validfrom;
        public string validto;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public DeliverableOf() { Xname = "deliverableOf"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class DeliveredItemRef
    {
        public string version;
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string contenttype;
        public string format;
        public string guidref;
        public string href;
        public string hreftype;
        public string persistidref;
        public string rank;
        public string rel;
        public string residref;
        public string size;
        public string title;
        public string validfrom;
        public string validto;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public DeliveredItemRef() { Xname = "deliveredItemRef"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class Delivery
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Delivery() { Xname = "delivery"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "s"; }
    }

    public class DerivedFrom
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public DerivedFrom() { Xname = "derivedFrom"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class Description
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string media;
        public string rank;
        public string role;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Description() { Xname = "description"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public Description(string propValue) { Xname = "description"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    public class Destination
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string role;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Destination() { Xname = "destination"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public Destination(string propValue) { Xname = "destination"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    public class Details
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string media;
        public string role;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Details() { Xname = "details"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public Details(string propValue) { Xname = "details"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    public class Died
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Died() { Xname = "died"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
        public Died(string propValue) { Xname = "died"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; thisValue = propValue; }
    }

    public class Dissolved
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Dissolved() { Xname = "dissolved"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
        public Dissolved(string propValue) { Xname = "dissolved"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; thisValue = propValue; }
    }

    public class Duration
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Duration() { Xname = "duration"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
        public Duration(string propValue) { Xname = "duration"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; thisValue = propValue; }
    }

    public class EdNote
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string media;
        public string role;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public EdNote() { Xname = "edNote"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public EdNote(string propValue) { Xname = "edNote"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    public class Email
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string role;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Email() { Xname = "email"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "d"; Xcard = "u"; }
        public Email(string propValue) { Xname = "email"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "d"; Xcard = "u"; thisValue = propValue; }
    }

    public class Embargoed
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Embargoed() { Xname = "embargoed"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
        public Embargoed(string propValue) { Xname = "embargoed"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; thisValue = propValue; }
    }

    public class End
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string approxend;
        public string approxstart;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public End() { Xname = "end"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
        public End(string propValue) { Xname = "end"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; thisValue = propValue; }
    }

    public class Event
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Event() { Xname = "event"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class EventDetails
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public EventDetails() { Xname = "eventDetails"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "s"; }
    }

    public class Events
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Events() { Xname = "events"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "s"; }
    }

    public class ExclAudience
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string confidence;
        public string derivedfrom;
        public string relevance;
        public string significance;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public ExclAudience() { Xname = "exclAudience"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class ExDate
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public ExDate() { Xname = "exDate"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public ExDate(string propValue) { Xname = "exDate"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    public class ExRule
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string byday;
        public string byhour;
        public string byminute;
        public string bymonth;
        public string bymonthday;
        public string bysecond;
        public string bysetpos;
        public string byweekno;
        public string byyearday;
        public string count;
        public string freq;
        public string interval;
        public string until;
        public string wkst;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public ExRule() { Xname = "exRule"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class Fax
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string role;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Fax() { Xname = "fax"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "d"; Xcard = "u"; }
        public Fax(string propValue) { Xname = "fax"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "d"; Xcard = "u"; thisValue = propValue; }
    }

    public class FileName
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public FileName() { Xname = "fileName"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
        public FileName(string propValue) { Xname = "fileName"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; thisValue = propValue; }
    }

    public class FirstCreated
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public FirstCreated() { Xname = "firstCreated"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
        public FirstCreated(string propValue) { Xname = "firstCreated"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; thisValue = propValue; }
    }

    public class Founded
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Founded() { Xname = "founded"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
        public Founded(string propValue) { Xname = "founded"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; thisValue = propValue; }
    }

    public class G2contentType
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public G2contentType() { Xname = "g2contentType"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
    }

    public class Generator
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string role;
        public string versioninfo;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Generator() { Xname = "generator"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
        public Generator(string propValue) { Xname = "generator"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; thisValue = propValue; }
    }

    public class Genre
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string confidence;
        public string derivedfrom;
        public string rank;
        public string relevance;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Genre() { Xname = "genre"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class GeoAreaDetails
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public GeoAreaDetails() { Xname = "geoAreaDetails"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "s"; }
    }

    public class Group
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string mode;
        public string role;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Group() { Xname = "group"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "u"; }
    }

    public class GroupRef
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string idref;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public GroupRef() { Xname = "groupRef"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class GroupSet
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string root;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public GroupSet() { Xname = "groupSet"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "s"; }
    }

    public class GroupExtProperty
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string rel;
        public string validfrom;
        public string validto;
        public string value;
        public string valuedatatype;
        public string valueunit;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public GroupExtProperty() { Xname = "groupExtProperty"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class Hash
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string hashtype;
        public string scope;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Hash() { Xname = "hash"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class HasInstrument
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string type;
        public string market;
        public string marketlabel;
        public string marketlabelsrc;
        public string symbol;
        public string symbolsrc;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public HasInstrument() { Xname = "hasInstrument"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class Header
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Header() { Xname = "header"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "s"; }
    }

    public class HeaderExtProperty
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string rel;
        public string validfrom;
        public string validto;
        public string value;
        public string valuedatatype;
        public string valueunit;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public HeaderExtProperty() { Xname = "headerExtProperty"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class Headline
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string media;
        public string rank;
        public string role;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Headline() { Xname = "headline"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public Headline(string propValue) { Xname = "headline"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    public class HierarchyInfo
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public HierarchyInfo() { Xname = "hierarchyInfo"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public HierarchyInfo(string propValue) { Xname = "hierarchyInfo"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    public class Hop
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string seq;
        public string timestamp;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Hop() { Xname = "hop"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class HopHistory
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public HopHistory() { Xname = "hopHistory"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "s"; }
    }

    public class Icon
    {
        public string version;
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string colourdepth;
        public string colourindicator;
        public string colourspace;
        public string contenttype;
        public string format;
        public string height;
        public string heightunit;
        public string href;
        public string orientation;
        public string persistidref;
        public string rendition;
        public string residref;
        public string size;
        public string title;
        public string videocodec;
        public string width;
        public string widthunit;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Icon() { Xname = "icon"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class Im
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string role;
        public string tech;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Im() { Xname = "im"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "d"; Xcard = "u"; }
        public Im(string propValue) { Xname = "im"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "d"; Xcard = "u"; thisValue = propValue; }
    }

    public class InfoSource
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string role;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public InfoSource() { Xname = "infoSource"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class Inline
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string Yclass;
        public string confidence;
        public string derivedfrom;
        public string relevance;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Inline() { Xname = "inline"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "m"; Xcard = "u"; }
    }

    public class InlineData
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string audiobitrate;
        public string audiochannels;
        public string audiocodec;
        public string audiosamplerate;
        public string audiosamplesize;
        public string audiovbr;
        public string colourdepth;
        public string colourindicator;
        public string colourspace;
        public string contenttype;
        public string duration;
        public string durationunit;
        public string encoding;
        public string format;
        public string generated;
        public string generator;
        public string hascontent;
        public string height;
        public string heightunit;
        public string orientation;
        public string rendition;
        public string resolution;
        public string videoaspectratio;
        public string videoavgbitrate;
        public string videocodec;
        public string videodefinition;
        public string videoframerate;
        public string videosampling;
        public string videoscaling;
        public string videoscan;
        public string videovbr;
        public string width;
        public string widthunit;
        public string wordcount;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public InlineData() { Xname = "inlineData"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public InlineData(string propValue) { Xname = "inlineData"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    public class InlineRef
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string confidence;
        public string derivedfrom;
        public string idrefs;
        public string relevance;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public InlineRef() { Xname = "inlineRef"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class InlineXML
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string audiobitrate;
        public string audiochannels;
        public string audiocodec;
        public string audiosamplerate;
        public string audiosamplesize;
        public string audiovbr;
        public string colourdepth;
        public string colourindicator;
        public string colourspace;
        public string contenttype;
        public string duration;
        public string durationunit;
        public string format;
        public string generated;
        public string generator;
        public string hascontent;
        public string height;
        public string heightunit;
        public string orientation;
        public string rendition;
        public string resolution;
        public string videoaspectratio;
        public string videoavgbitrate;
        public string videocodec;
        public string videodefinition;
        public string videoframerate;
        public string videosampling;
        public string videoscaling;
        public string videoscan;
        public string videovbr;
        public string width;
        public string widthunit;
        public string wordcount;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public InlineXML() { Xname = "inlineXML"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class InstanceOf
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public InstanceOf() { Xname = "instanceOf"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class ItemClass
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public ItemClass() { Xname = "itemClass"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
    }

    public class ItemCount
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string rangefrom;
        public string rangeto;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public ItemCount() { Xname = "itemCount"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
        public ItemCount(string propValue) { Xname = "itemCount"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; thisValue = propValue; }
    }

    public class ItemMeta
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public ItemMeta() { Xname = "itemMeta"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "s"; }
    }

    public class ItemMetaExtProperty
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string rel;
        public string validfrom;
        public string validto;
        public string value;
        public string valuedatatype;
        public string valueunit;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public ItemMetaExtProperty() { Xname = "itemMetaExtProperty"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class ItemRef
    {
        public string version;
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string contenttype;
        public string format;
        public string guidref;
        public string href;
        public string hreftype;
        public string persistidref;
        public string rank;
        public string rel;
        public string residref;
        public string size;
        public string title;
        public string validfrom;
        public string validto;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public ItemRef() { Xname = "itemRef"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class ItemSet
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public ItemSet() { Xname = "itemSet"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "s"; }
    }

    public class Keyword
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string confidence;
        public string rank;
        public string relevance;
        public string role;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Keyword() { Xname = "keyword"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public Keyword(string propValue) { Xname = "keyword"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    public class KnowledgeItem
    {
        public string standard;
        public string standardversion;
        public string conformance;
        public string guid;
        public string version;
        public string xmllang;
        public string dir;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public KnowledgeItem() { Xname = "knowledgeItem"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "r"; Xcard = "s"; }
    }

    public class Language
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string rank;
        public string role;
        public string tag;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Language() { Xname = "language"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public Language(string propValue) { Xname = "language"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    public class LineXxADDR
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public LineXxADDR() { Xname = "line"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "d"; Xcard = "u"; }
        public LineXxADDR(string propValue) { Xname = "line"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "d"; Xcard = "u"; thisValue = propValue; }
    }

    public class LineXxGEOAREA
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public LineXxGEOAREA() { Xname = "line"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class Link
    {
        public string version;
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string contenttype;
        public string format;
        public string guidref;
        public string href;
        public string hreftype;
        public string persistidref;
        public string rank;
        public string rel;
        public string residref;
        public string size;
        public string title;
        public string validfrom;
        public string validto;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Link() { Xname = "link"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class Locality
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Locality() { Xname = "locality"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "d"; Xcard = "u"; }
    }

    public class Located
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Located() { Xname = "located"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class Location
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Location() { Xname = "location"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class MemberOf
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public MemberOf() { Xname = "memberOf"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class Name
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string part;
        public string role;
        public string roleuri;
        public string validfrom;
        public string validto;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Name() { Xname = "name"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public Name(string propValue) { Xname = "name"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    public class Narrower
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string rank;
        public string rel;
        public string validfrom;
        public string validto;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Narrower() { Xname = "narrower"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class NewsCoverage
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string role;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public NewsCoverage() { Xname = "newsCoverage"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "s"; }
    }

    public class NewsCoverageExtProperty
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string rel;
        public string validfrom;
        public string validto;
        public string value;
        public string valuedatatype;
        public string valueunit;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public NewsCoverageExtProperty() { Xname = "newsCoverageExtProperty"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class NewsCoverageSet
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public NewsCoverageSet() { Xname = "newsCoverageSet"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "s"; }
    }

    public class NewsCoverageStatus
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public NewsCoverageStatus() { Xname = "newsCoverageStatus"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
    }

    public class NewsItem
    {
        public string standard;
        public string standardversion;
        public string conformance;
        public string guid;
        public string version;
        public string xmllang;
        public string dir;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public NewsItem() { Xname = "newsItem"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "r"; Xcard = "s"; }
    }

    public class NewsMessage
    {
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public NewsMessage() { Xname = "newsMessage"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "r"; Xcard = "s"; }
    }

    public class Note
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string media;
        public string role;
        public string roleuri;
        public string validfrom;
        public string validto;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Note() { Xname = "note"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public Note(string propValue) { Xname = "note"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    public class ObjectDetails
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public ObjectDetails() { Xname = "objectDetails"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "s"; }
    }

    public class OccurStatus
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public OccurStatus() { Xname = "occurStatus"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
    }

    public class OpenHours
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string media;
        public string role;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public OpenHours() { Xname = "openHours"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public OpenHours(string propValue) { Xname = "openHours"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    public class OrganisationDetails
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public OrganisationDetails() { Xname = "organisationDetails"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "s"; }
    }

    public class Organiser
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string role;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Organiser() { Xname = "organiser"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class Origin
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string role;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Origin() { Xname = "origin"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
        public Origin(string propValue) { Xname = "origin"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; thisValue = propValue; }
    }

    public class PackageItem
    {
        public string standard;
        public string standardversion;
        public string conformance;
        public string guid;
        public string version;
        public string xmllang;
        public string dir;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public PackageItem() { Xname = "packageItem"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "r"; Xcard = "s"; }
    }

    public class Participant
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string role;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Participant() { Xname = "participant"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class ParticipationRequirement
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string role;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public ParticipationRequirement() { Xname = "participationRequirement"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class PartMeta
    {
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string contentrefs;
        public string partid;
        public string seq;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public PartMeta() { Xname = "partMeta"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "u"; }
    }

    public class PartMetaExtProperty
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string rel;
        public string validfrom;
        public string validto;
        public string value;
        public string valuedatatype;
        public string valueunit;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public PartMetaExtProperty() { Xname = "partMetaExtProperty"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class Party
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Party() { Xname = "party"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "d"; Xcard = "u"; }
    }

    public class PersonDetails
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public PersonDetails() { Xname = "personDetails"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "s"; }
    }

    public class Phone
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string role;
        public string tech;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Phone() { Xname = "phone"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "d"; Xcard = "u"; }
        public Phone(string propValue) { Xname = "phone"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "d"; Xcard = "u"; thisValue = propValue; }
    }

    public class Planning
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Planning() { Xname = "planning"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "s"; }
    }

    public class PlanningItem
    {
        public string standard;
        public string standardversion;
        public string conformance;
        public string guid;
        public string version;
        public string xmllang;
        public string dir;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public PlanningItem() { Xname = "planningItem"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "r"; Xcard = "s"; }
    }

    public class POIDetails
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public POIDetails() { Xname = "POIDetails"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "s"; }
    }

    public class Polygon
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Polygon() { Xname = "polygon"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class Position
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string altitude;
        public string gpsdatum;
        public string latitude;
        public string longitude;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Position() { Xname = "position"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class PostalCode
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public PostalCode() { Xname = "postalCode"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "d"; Xcard = "s"; }
        public PostalCode(string propValue) { Xname = "postalCode"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "d"; Xcard = "s"; thisValue = propValue; }
    }

    public class Priority
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Priority() { Xname = "priority"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
        public Priority(string propValue) { Xname = "priority"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; thisValue = propValue; }
    }

    public class Profile
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string versioninfo;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Profile() { Xname = "profile"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
    }

    public class Provider
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Provider() { Xname = "provider"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
    }

    public class PubStatus
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public PubStatus() { Xname = "pubStatus"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
    }

    public class Rating
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string raters;
        public string ratertype;
        public string ratingtype;
        public string scalemax;
        public string scalemin;
        public string scaleunit;
        public string valcalctype;
        public string value;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Rating() { Xname = "rating"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public Rating(string propValue) { Xname = "rating"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    public class Rb
    {
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Rb() { Xname = "rb"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "m"; Xcard = "u"; }
    }

    public class RDate
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public RDate() { Xname = "rDate"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public RDate(string propValue) { Xname = "rDate"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    public class RegionDelim
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string height;
        public string width;
        public string x;
        public string y;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public RegionDelim() { Xname = "regionDelim"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
    }

    public class Registration
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string media;
        public string role;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Registration() { Xname = "registration"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public Registration(string propValue) { Xname = "registration"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    public class Related
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string rank;
        public string rel;
        public string validfrom;
        public string validto;
        public string value;
        public string valuedatatype;
        public string valueunit;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Related() { Xname = "related"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class RemoteContent
    {
        public string version;
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string audiobitrate;
        public string audiochannels;
        public string audiocodec;
        public string audiosamplerate;
        public string audiosamplesize;
        public string audiovbr;
        public string colourdepth;
        public string colourindicator;
        public string colourspace;
        public string contenttype;
        public string duration;
        public string durationunit;
        public string format;
        public string generated;
        public string generator;
        public string hascontent;
        public string height;
        public string heightunit;
        public string href;
        public string language;
        public string orientation;
        public string persistidref;
        public string rendition;
        public string residref;
        public string resolution;
        public string size;
        public string title;
        public string validfrom;
        public string validto;
        public string videoaspectratio;
        public string videoavgbitrate;
        public string videocodec;
        public string videodefinition;
        public string videoframerate;
        public string videosampling;
        public string videoscaling;
        public string videoscan;
        public string videovbr;
        public string width;
        public string widthunit;
        public string wordcount;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public RemoteContent() { Xname = "remoteContent"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class RemoteContentExtProperty
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string rel;
        public string validfrom;
        public string validto;
        public string value;
        public string valuedatatype;
        public string valueunit;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public RemoteContentExtProperty() { Xname = "remoteContentExtProperty"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class RemoteInfo
    {
        public string version;
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string contenttype;
        public string format;
        public string guidref;
        public string href;
        public string hreftype;
        public string persistidref;
        public string rank;
        public string rel;
        public string residref;
        public string size;
        public string title;
        public string validfrom;
        public string validto;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public RemoteInfo() { Xname = "remoteInfo"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class RightsInfo
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string aspect;
        public string idrefs;
        public string scope;
        public string validfrom;
        public string validto;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public RightsInfo() { Xname = "rightsInfo"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "s"; }
    }

    public class RightsInfoExtProperty
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string rel;
        public string validfrom;
        public string validto;
        public string value;
        public string valuedatatype;
        public string valueunit;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public RightsInfoExtProperty() { Xname = "rightsInfoExtProperty"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class Role
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Role() { Xname = "role"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
    }

    public class Rp
    {
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Rp() { Xname = "rp"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "m"; Xcard = "u"; }
    }

    public class RRule
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string byday;
        public string byhour;
        public string byminute;
        public string bymonth;
        public string bymonthday;
        public string bysecond;
        public string bysetpos;
        public string byweekno;
        public string byyearday;
        public string count;
        public string freq;
        public string interval;
        public string until;
        public string wkst;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public RRule() { Xname = "rRule"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class Rt
    {
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Rt() { Xname = "rt"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "m"; Xcard = "u"; }
    }

    public class Ruby
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Ruby() { Xname = "ruby"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "m"; Xcard = "u"; }
    }

    public class SameAs
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string validfrom;
        public string validto;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public SameAs() { Xname = "sameAs"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class SameAsScheme
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public SameAsScheme() { Xname = "sameAsScheme"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "d"; Xcard = "u"; }
    }

    public class Scheduled
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string approxend;
        public string approxstart;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Scheduled() { Xname = "scheduled"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
        public Scheduled(string propValue) { Xname = "scheduled"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; thisValue = propValue; }
    }

    public class Scheme
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string uri;
        public string alias;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Scheme() { Xname = "scheme"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class SchemeMeta
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string uri;
        public string authority;
        public string preferredalias;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public SchemeMeta() { Xname = "schemeMeta"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "s"; }
    }

    public class SchemeMetaExtProperty
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string rel;
        public string validfrom;
        public string validto;
        public string value;
        public string valuedatatype;
        public string valueunit;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public SchemeMetaExtProperty() { Xname = "schemeMetaExtProperty"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class Sender
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string role;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Sender() { Xname = "sender"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
        public Sender(string propValue) { Xname = "sender"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; thisValue = propValue; }
    }

    public class Sent
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Sent() { Xname = "sent"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
        public Sent(string propValue) { Xname = "sent"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; thisValue = propValue; }
    }

    public class Service
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Service() { Xname = "service"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class Signal
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string severity;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Signal() { Xname = "signal"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class Slugline
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string rank;
        public string role;
        public string separator;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Slugline() { Xname = "slugline"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public Slugline(string propValue) { Xname = "slugline"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    public class Span
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string Yclass;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Span() { Xname = "span"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "m"; Xcard = "u"; }
    }

    public class Start
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string approxend;
        public string approxstart;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Start() { Xname = "start"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
        public Start(string propValue) { Xname = "start"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; thisValue = propValue; }
    }

    public class Subject
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string confidence;
        public string derivedfrom;
        public string rank;
        public string relevance;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Subject() { Xname = "subject"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    public class TimeDelim
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string end;
        public string start;
        public string timeunit;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public TimeDelim() { Xname = "timeDelim"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
        public TimeDelim(string propValue) { Xname = "timeDelim"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; thisValue = propValue; }
    }

    public class Timestamp
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string role;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Timestamp() { Xname = "timestamp"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public Timestamp(string propValue) { Xname = "timestamp"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    public class Title
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string media;
        public string role;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Title() { Xname = "title"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public Title(string propValue) { Xname = "title"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    public class TransmitId
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public TransmitId() { Xname = "transmitId"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
        public TransmitId(string propValue) { Xname = "transmitId"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; thisValue = propValue; }
    }

    public class Type
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Type() { Xname = "type"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
    }

    public class Urgency
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Urgency() { Xname = "urgency"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
        public Urgency(string propValue) { Xname = "urgency"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; thisValue = propValue; }
    }

    public class UsageTerms
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string href;
        public string media;
        public string role;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public UsageTerms() { Xname = "usageTerms"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public UsageTerms(string propValue) { Xname = "usageTerms"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    public class UserInteraction
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string interactions;
        public string interactiontype;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public UserInteraction() { Xname = "userInteraction"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public UserInteraction(string propValue) { Xname = "userInteraction"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    public class VersionCreated
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public VersionCreated() { Xname = "versionCreated"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
        public VersionCreated(string propValue) { Xname = "versionCreated"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; thisValue = propValue; }
    }

    public class Web
    {
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string role;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Web() { Xname = "web"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "d"; Xcard = "u"; }
        public Web(string propValue) { Xname = "web"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "d"; Xcard = "u"; thisValue = propValue; }
    }

    public class GenericProperty
    {
        public string standard;
        public string standardversion;
        public string conformance;
        public string guid;
        public string version;
        public string id;
        public string creator;
        public string modified;
        public string custom;
        public string how;
        public string why;
        public string pubconstraint;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string additionalInfo;
        public string alias;
        public string altitude;
        public string approxend;
        public string approxstart;
        public string aspect;
        public string audiobitrate;
        public string audiochannels;
        public string audiocodec;
        public string audiosamplerate;
        public string audiosamplesize;
        public string audiovbr;
        public string authority;
        public string byday;
        public string byhour;
        public string byminute;
        public string bymonth;
        public string bymonthday;
        public string bysecond;
        public string bysetpos;
        public string byweekno;
        public string byyearday;
        public string chnlid;
        public string Yclass;
        public string colourdepth;
        public string colourindicator;
        public string colourspace;
        public string confidence;
        public string contentrefs;
        public string contenttype;
        public string count;
        public string created;
        public string derivedfrom;
        public string duration;
        public string durationunit;
        public string encoding;
        public string end;
        public string environment;
        public string format;
        public string freq;
        public string generated;
        public string generator;
        public string gpsdatum;
        public string guidref;
        public string hascontent;
        public string hashtype;
        public string height;
        public string heightunit;
        public string href;
        public string hreflang;
        public string hreftype;
        public string idformat;
        public string idref;
        public string idrefs;
        public string interactions;
        public string interactiontype;
        public string interval;
        public string jobtitle;
        public string language;
        public string latitude;
        public string longitude;
        public string market;
        public string marketlabel;
        public string marketlabelsrc;
        public string media;
        public string mode;
        public string orientation;
        public string original;
        public string part;
        public string partid;
        public string persistidref;
        public string preferredalias;
        public string rangefrom;
        public string rangeto;
        public string rank;
        public string raters;
        public string ratertype;
        public string ratingtype;
        public string rel;
        public string relevance;
        public string rendition;
        public string representation;
        public string residref;
        public string resolution;
        public string retired;
        public string rev;
        public string role;
        public string roleuri;
        public string root;
        public string scalemax;
        public string scalemin;
        public string scaleunit;
        public string scope;
        public string separator;
        public string seq;
        public string severity;
        public string significance;
        public string size;
        public string start;
        public string symbol;
        public string symbolsrc;
        public string tag;
        public string target;
        public string tech;
        public string timestamp;
        public string timeunit;
        public string title;
        public string until;
        public string url;
        public string valcalctype;
        public string validfrom;
        public string validto;
        public string value;
        public string valuedatatype;
        public string valueunit;
        public string versioninfo;
        public string videoaspectratio;
        public string videoavgbitrate;
        public string videocodec;
        public string videodefinition;
        public string videoframerate;
        public string videosampling;
        public string videoscaling;
        public string videoscan;
        public string videovbr;
        public string width;
        public string widthunit;
        public string wkst;
        public string wordcount;
        public string x;
        public string y;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public GenericProperty() { Xname = "genericProperty"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = " "; Xcard = "u"; }
    }



}
