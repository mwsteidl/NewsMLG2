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
Class: NewsIT.IPTC.NewsMLG2.v218. ... A class for each element in the nar namespace  

Current date / persID / change log (most current at top)
 * 2014-08-27 mws: moved from v217 to v218
 * 2014-03-03 mws: properties with a value in the textnode got a
 *          constructur with a propValue param to set thisValue
 * 2014-02-26 mws: G2 struct matrix updated and transformed
 * 2014-02-25 mws: struct -> class
StartDate: 2014-02-24 mws
******************************************************************************/
using System;

namespace NewsIT.IPTC.NewsMLG2.v218
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:a (without child elements)
    /// <summary>
    public class A
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string Yclass;
        public string href;
        public string hreflang;
        public string rel;
        public string reluri;
        public string rev;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public A() { Xname = "a"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "m"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:access (without child elements)
    /// <summary>
    public class Access
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string media;
        public string role;
        public string roleuri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Access() { Xname = "access"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:accessStatus (without child elements)
    /// <summary>
    public class AccessStatus
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:accountable (without child elements)
    /// <summary>
    public class Accountable
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string typeuri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Accountable() { Xname = "accountable"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:action (without child elements)
    /// <summary>
    public class Action
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string target;
        public string targeturi;
        public string timestamp;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Action() { Xname = "action"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "d"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:address (without child elements)
    /// <summary>
    public class Address
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string role;
        public string roleuri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Address() { Xname = "address"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:affiliation (without child elements)
    /// <summary>
    public class Affiliation
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string typeuri;
        public string validfrom;
        public string validto;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Affiliation() { Xname = "affiliation"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:altId (without child elements)
    /// <summary>
    public class AltId
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string type;
        public string typeuri;
        public string environment;
        public string environmenturi;
        public string idformat;
        public string idformaturi;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public AltId() { Xname = "altId"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public AltId(string propValue) { Xname = "altId"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:altLoc (without child elements)
    /// <summary>
    public class AltLoc
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string type;
        public string typeuri;
        public string role;
        public string roleuri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public AltLoc() { Xname = "altLoc"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:altRep (without child elements)
    /// <summary>
    public class AltRep
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string contenttype;
        public string format;
        public string formaturi;
        public string representation;
        public string representationuri;
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:area (without child elements)
    /// <summary>
    public class Area
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string typeuri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Area() { Xname = "area"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "d"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:assert (without child elements)
    /// <summary>
    public class Assert
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:assignedTo (without child elements)
    /// <summary>
    public class AssignedTo
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string typeuri;
        public string role;
        public string roleuri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public AssignedTo() { Xname = "assignedTo"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:audience (without child elements)
    /// <summary>
    public class Audience
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string typeuri;
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:bag (without child elements)
    /// <summary>
    public class Bag
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Bag() { Xname = "bag"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "s"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:bit (without child elements)
    /// <summary>
    public class Bit
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string qcode;
        public string uri;
        public string type;
        public string typeuri;
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:born (without child elements)
    /// <summary>
    public class Born
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Born() { Xname = "born"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
        public Born(string propValue) { Xname = "born"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; thisValue = propValue; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:br (without child elements)
    /// <summary>
    public class Br
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Br() { Xname = "br"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "m"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:broader (without child elements)
    /// <summary>
    public class Broader
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string typeuri;
        public string rank;
        public string rel;
        public string reluri;
        public string validfrom;
        public string validto;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Broader() { Xname = "broader"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:by (without child elements)
    /// <summary>
    public class By
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string media;
        public string rank;
        public string role;
        public string roleuri;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public By() { Xname = "by"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public By(string propValue) { Xname = "by"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:capacity (without child elements)
    /// <summary>
    public class Capacity
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string media;
        public string role;
        public string roleuri;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Capacity() { Xname = "capacity"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public Capacity(string propValue) { Xname = "capacity"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:catalog (without child elements)
    /// <summary>
    public class Catalog
    {
        public string guid;
        public string version;
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:catalogContainer (without child elements)
    /// <summary>
    public class CatalogContainer
    {
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public CatalogContainer() { Xname = "catalogContainer"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "s"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:catalogItem (without child elements)
    /// <summary>
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:catalogRef (without child elements)
    /// <summary>
    public class CatalogRef
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string href;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public CatalogRef() { Xname = "catalogRef"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:ceasedToExist (without child elements)
    /// <summary>
    public class CeasedToExist
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public CeasedToExist() { Xname = "ceasedToExist"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
        public CeasedToExist(string propValue) { Xname = "ceasedToExist"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; thisValue = propValue; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:channelXxNMSG (without child elements)
    /// <summary>
    public class ChannelXxNMSG
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string typeuri;
        public string role;
        public string roleuri;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public ChannelXxNMSG() { Xname = "channel"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public ChannelXxNMSG(string propValue) { Xname = "channel"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:channelXxREMCONT (without child elements)
    /// <summary>
    public class ChannelXxREMCONT
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string type;
        public string typeuri;
        public string audiobitrate;
        public string audiochannels;
        public string audiochannelsuri;
        public string audiocodec;
        public string audiocodecuri;
        public string audiosamplerate;
        public string audiosamplesize;
        public string audiovbr;
        public string chnlid;
        public string colourdepth;
        public string colourindicator;
        public string colourindicatoruri;
        public string colourspace;
        public string colourspaceuri;
        public string contenttype;
        public string duration;
        public string durationunit;
        public string durationunituri;
        public string format;
        public string formaturi;
        public string height;
        public string heightunit;
        public string heightunituri;
        public string language;
        public string layoutorientation;
        public string layoutorientationuri;
        public string orientation;
        public string resolution;
        public string role;
        public string roleuri;
        public string videoaspectratio;
        public string videoavgbitrate;
        public string videocodec;
        public string videocodecuri;
        public string videodefinition;
        public string videodefinitionuri;
        public string videoframerate;
        public string videosampling;
        public string videoscaling;
        public string videoscalinguri;
        public string videoscan;
        public string videovbr;
        public string width;
        public string widthunit;
        public string widthunituri;
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:circle (without child elements)
    /// <summary>
    public class Circle
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string radunit;
        public string radunituri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Circle() { Xname = "circle"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:concept (without child elements)
    /// <summary>
    public class Concept
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Concept() { Xname = "concept"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:conceptExtProperty (without child elements)
    /// <summary>
    public class ConceptExtProperty
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string typeuri;
        public string rel;
        public string reluri;
        public string validfrom;
        public string validto;
        public string value;
        public string valuedatatype;
        public string valueunit;
        public string valueunituri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public ConceptExtProperty() { Xname = "conceptExtProperty"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:conceptId (without child elements)
    /// <summary>
    public class ConceptId
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:conceptItem (without child elements)
    /// <summary>
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:conceptRef (without child elements)
    /// <summary>
    public class ConceptRef
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string typeuri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public ConceptRef() { Xname = "conceptRef"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:conceptSet (without child elements)
    /// <summary>
    public class ConceptSet
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public ConceptSet() { Xname = "conceptSet"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "s"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:confirmation (without child elements)
    /// <summary>
    public class Confirmation
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string qcode;
        public string uri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Confirmation() { Xname = "confirmation"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:contactInfo (without child elements)
    /// <summary>
    public class ContactInfo
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string role;
        public string roleuri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public ContactInfo() { Xname = "contactInfo"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:contentCreated (without child elements)
    /// <summary>
    public class ContentCreated
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public ContentCreated() { Xname = "contentCreated"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
        public ContentCreated(string propValue) { Xname = "contentCreated"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; thisValue = propValue; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:contentMeta (without child elements)
    /// <summary>
    public class ContentMeta
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public ContentMeta() { Xname = "contentMeta"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "s"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:contentMetaExtProperty (without child elements)
    /// <summary>
    public class ContentMetaExtProperty
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string typeuri;
        public string rel;
        public string reluri;
        public string validfrom;
        public string validto;
        public string value;
        public string valuedatatype;
        public string valueunit;
        public string valueunituri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public ContentMetaExtProperty() { Xname = "contentMetaExtProperty"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:contentModified (without child elements)
    /// <summary>
    public class ContentModified
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public ContentModified() { Xname = "contentModified"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
        public ContentModified(string propValue) { Xname = "contentModified"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; thisValue = propValue; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:contentSet (without child elements)
    /// <summary>
    public class ContentSet
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string original;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public ContentSet() { Xname = "contentSet"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "s"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:contributor (without child elements)
    /// <summary>
    public class Contributor
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string typeuri;
        public string jobtitle;
        public string jobtitleuri;
        public string role;
        public string roleuri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Contributor() { Xname = "contributor"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:copyrightHolder (without child elements)
    /// <summary>
    public class CopyrightHolder
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string typeuri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public CopyrightHolder() { Xname = "copyrightHolder"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:copyrightNotice (without child elements)
    /// <summary>
    public class CopyrightNotice
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string href;
        public string media;
        public string role;
        public string roleuri;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public CopyrightNotice() { Xname = "copyrightNotice"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public CopyrightNotice(string propValue) { Xname = "copyrightNotice"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:country (without child elements)
    /// <summary>
    public class Country
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string typeuri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Country() { Xname = "country"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "d"; Xcard = "s"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:created (without child elements)
    /// <summary>
    public class Created
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Created() { Xname = "created"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
        public Created(string propValue) { Xname = "created"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; thisValue = propValue; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:creator (without child elements)
    /// <summary>
    public class Creator
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string typeuri;
        public string jobtitle;
        public string jobtitleuri;
        public string role;
        public string roleuri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Creator() { Xname = "creator"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:creditline (without child elements)
    /// <summary>
    public class Creditline
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:dateline (without child elements)
    /// <summary>
    public class Dateline
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string media;
        public string rank;
        public string role;
        public string roleuri;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Dateline() { Xname = "dateline"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public Dateline(string propValue) { Xname = "dateline"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:dates (without child elements)
    /// <summary>
    public class Dates
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Dates() { Xname = "dates"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "s"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:definition (without child elements)
    /// <summary>
    public class Definition
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:deliverableOf (without child elements)
    /// <summary>
    public class DeliverableOf
    {
        public string version;
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string contenttype;
        public string format;
        public string formaturi;
        public string guidref;
        public string href;
        public string hreftype;
        public string persistidref;
        public string rank;
        public string rel;
        public string reluri;
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:deliveredItemRef (without child elements)
    /// <summary>
    public class DeliveredItemRef
    {
        public string version;
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string contenttype;
        public string format;
        public string formaturi;
        public string guidref;
        public string href;
        public string hreftype;
        public string persistidref;
        public string rank;
        public string rel;
        public string reluri;
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:delivery (without child elements)
    /// <summary>
    public class Delivery
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Delivery() { Xname = "delivery"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "s"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:derivedFrom (without child elements)
    /// <summary>
    public class DerivedFrom
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string typeuri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public DerivedFrom() { Xname = "derivedFrom"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:description (without child elements)
    /// <summary>
    public class Description
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string media;
        public string rank;
        public string role;
        public string roleuri;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Description() { Xname = "description"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public Description(string propValue) { Xname = "description"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:destination (without child elements)
    /// <summary>
    public class Destination
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string typeuri;
        public string role;
        public string roleuri;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Destination() { Xname = "destination"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public Destination(string propValue) { Xname = "destination"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:details (without child elements)
    /// <summary>
    public class Details
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string media;
        public string role;
        public string roleuri;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Details() { Xname = "details"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public Details(string propValue) { Xname = "details"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:died (without child elements)
    /// <summary>
    public class Died
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Died() { Xname = "died"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
        public Died(string propValue) { Xname = "died"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; thisValue = propValue; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:dissolved (without child elements)
    /// <summary>
    public class Dissolved
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Dissolved() { Xname = "dissolved"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
        public Dissolved(string propValue) { Xname = "dissolved"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; thisValue = propValue; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:duration (without child elements)
    /// <summary>
    public class Duration
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Duration() { Xname = "duration"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
        public Duration(string propValue) { Xname = "duration"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; thisValue = propValue; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:edNote (without child elements)
    /// <summary>
    public class EdNote
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string media;
        public string role;
        public string roleuri;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public EdNote() { Xname = "edNote"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public EdNote(string propValue) { Xname = "edNote"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:email (without child elements)
    /// <summary>
    public class Email
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string role;
        public string roleuri;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Email() { Xname = "email"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "d"; Xcard = "u"; }
        public Email(string propValue) { Xname = "email"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "d"; Xcard = "u"; thisValue = propValue; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:embargoed (without child elements)
    /// <summary>
    public class Embargoed
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Embargoed() { Xname = "embargoed"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
        public Embargoed(string propValue) { Xname = "embargoed"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; thisValue = propValue; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:end (without child elements)
    /// <summary>
    public class End
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:event (without child elements)
    /// <summary>
    public class Event
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Event() { Xname = "event"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:eventDetails (without child elements)
    /// <summary>
    public class EventDetails
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public EventDetails() { Xname = "eventDetails"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "s"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:events (without child elements)
    /// <summary>
    public class Events
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Events() { Xname = "events"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "s"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:exclAudience (without child elements)
    /// <summary>
    public class ExclAudience
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string typeuri;
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:exDate (without child elements)
    /// <summary>
    public class ExDate
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public ExDate() { Xname = "exDate"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public ExDate(string propValue) { Xname = "exDate"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:exRule (without child elements)
    /// <summary>
    public class ExRule
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:fax (without child elements)
    /// <summary>
    public class Fax
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string role;
        public string roleuri;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Fax() { Xname = "fax"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "d"; Xcard = "u"; }
        public Fax(string propValue) { Xname = "fax"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "d"; Xcard = "u"; thisValue = propValue; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:fileName (without child elements)
    /// <summary>
    public class FileName
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public FileName() { Xname = "fileName"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
        public FileName(string propValue) { Xname = "fileName"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; thisValue = propValue; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:firstCreated (without child elements)
    /// <summary>
    public class FirstCreated
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public FirstCreated() { Xname = "firstCreated"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
        public FirstCreated(string propValue) { Xname = "firstCreated"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; thisValue = propValue; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:founded (without child elements)
    /// <summary>
    public class Founded
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Founded() { Xname = "founded"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
        public Founded(string propValue) { Xname = "founded"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; thisValue = propValue; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:g2contentType (without child elements)
    /// <summary>
    public class G2contentType
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public G2contentType() { Xname = "g2contentType"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:generator (without child elements)
    /// <summary>
    public class Generator
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string role;
        public string roleuri;
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:genre (without child elements)
    /// <summary>
    public class Genre
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string typeuri;
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:geoAreaDetails (without child elements)
    /// <summary>
    public class GeoAreaDetails
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public GeoAreaDetails() { Xname = "geoAreaDetails"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "s"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:group (without child elements)
    /// <summary>
    public class Group
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string mode;
        public string modeuri;
        public string role;
        public string roleuri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Group() { Xname = "group"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:groupExtProperty (without child elements)
    /// <summary>
    public class GroupExtProperty
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string typeuri;
        public string rel;
        public string reluri;
        public string validfrom;
        public string validto;
        public string value;
        public string valuedatatype;
        public string valueunit;
        public string valueunituri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public GroupExtProperty() { Xname = "groupExtProperty"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }


    /// <summary>
    /// Class for the NewsML-G2 element nar:groupRef (without child elements)
    /// <summary>
    public class GroupRef
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string idref;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public GroupRef() { Xname = "groupRef"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:groupSet (without child elements)
    /// <summary>
    public class GroupSet
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string root;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public GroupSet() { Xname = "groupSet"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "s"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:hash (without child elements)
    /// <summary>
    public class Hash
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string hashtype;
        public string hashtypeuri;
        public string scope;
        public string scopeuri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Hash() { Xname = "hash"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:hasInstrument (without child elements)
    /// <summary>
    public class HasInstrument
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string type;
        public string typeuri;
        public string market;
        public string marketuri;
        public string marketlabel;
        public string marketlabelsrc;
        public string marketlabelsrcuri;
        public string symbol;
        public string symbolsrc;
        public string symbolsrcuri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public HasInstrument() { Xname = "hasInstrument"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:header (without child elements)
    /// <summary>
    public class Header
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Header() { Xname = "header"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "s"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:headerExtProperty (without child elements)
    /// <summary>
    public class HeaderExtProperty
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string typeuri;
        public string rel;
        public string reluri;
        public string validfrom;
        public string validto;
        public string value;
        public string valuedatatype;
        public string valueunit;
        public string valueunituri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public HeaderExtProperty() { Xname = "headerExtProperty"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:headline (without child elements)
    /// <summary>
    public class Headline
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string media;
        public string rank;
        public string role;
        public string roleuri;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Headline() { Xname = "headline"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public Headline(string propValue) { Xname = "headline"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:hierarchyInfo (without child elements)
    /// <summary>
    public class HierarchyInfo
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public HierarchyInfo() { Xname = "hierarchyInfo"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public HierarchyInfo(string propValue) { Xname = "hierarchyInfo"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:hop (without child elements)
    /// <summary>
    public class Hop
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string seq;
        public string timestamp;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Hop() { Xname = "hop"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:hopHistory (without child elements)
    /// <summary>
    public class HopHistory
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public HopHistory() { Xname = "hopHistory"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "s"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:icon (without child elements)
    /// <summary>
    public class Icon
    {
        public string version;
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string colourdepth;
        public string colourindicator;
        public string colourindicatoruri;
        public string colourspace;
        public string colourspaceuri;
        public string contenttype;
        public string format;
        public string formaturi;
        public string height;
        public string heightunit;
        public string heightunituri;
        public string href;
        public string orientation;
        public string persistidref;
        public string rendition;
        public string renditionuri;
        public string residref;
        public string size;
        public string title;
        public string videocodec;
        public string videocodecuri;
        public string width;
        public string widthunit;
        public string widthunituri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Icon() { Xname = "icon"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:im (without child elements)
    /// <summary>
    public class Im
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string role;
        public string roleuri;
        public string tech;
        public string techuri;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Im() { Xname = "im"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "d"; Xcard = "u"; }
        public Im(string propValue) { Xname = "im"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "d"; Xcard = "u"; thisValue = propValue; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:infoSource (without child elements)
    /// <summary>
    public class InfoSource
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string typeuri;
        public string role;
        public string roleuri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public InfoSource() { Xname = "infoSource"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:inline (without child elements)
    /// <summary>
    public class Inline
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string typeuri;
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:inlineData (without child elements)
    /// <summary>
    public class InlineData
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string audiobitrate;
        public string audiochannels;
        public string audiochannelsuri;
        public string audiocodec;
        public string audiocodecuri;
        public string audiosamplerate;
        public string audiosamplesize;
        public string audiovbr;
        public string colourdepth;
        public string colourindicator;
        public string colourindicatoruri;
        public string colourspace;
        public string colourspaceuri;
        public string contenttype;
        public string duration;
        public string durationunit;
        public string durationunituri;
        public string encoding;
        public string encodinguri;
        public string format;
        public string formaturi;
        public string generated;
        public string generator;
        public string hascontent;
        public string height;
        public string heightunit;
        public string heightunituri;
        public string layoutorientation;
        public string layoutorientationuri;
        public string orientation;
        public string rendition;
        public string renditionuri;
        public string resolution;
        public string videoaspectratio;
        public string videoavgbitrate;
        public string videocodec;
        public string videocodecuri;
        public string videodefinition;
        public string videodefinitionuri;
        public string videoframerate;
        public string videosampling;
        public string videoscaling;
        public string videoscalinguri;
        public string videoscan;
        public string videovbr;
        public string width;
        public string widthunit;
        public string widthunituri;
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:inlineRef (without child elements)
    /// <summary>
    public class InlineRef
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string typeuri;
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:inlineXML (without child elements)
    /// <summary>
    public class InlineXML
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string audiobitrate;
        public string audiochannels;
        public string audiochannelsuri;
        public string audiocodec;
        public string audiocodecuri;
        public string audiosamplerate;
        public string audiosamplesize;
        public string audiovbr;
        public string colourdepth;
        public string colourindicator;
        public string colourindicatoruri;
        public string colourspace;
        public string colourspaceuri;
        public string contenttype;
        public string duration;
        public string durationunit;
        public string durationunituri;
        public string format;
        public string formaturi;
        public string generated;
        public string generator;
        public string hascontent;
        public string height;
        public string heightunit;
        public string heightunituri;
        public string layoutorientation;
        public string layoutorientationuri;
        public string orientation;
        public string rendition;
        public string renditionuri;
        public string resolution;
        public string videoaspectratio;
        public string videoavgbitrate;
        public string videocodec;
        public string videocodecuri;
        public string videodefinition;
        public string videodefinitionuri;
        public string videoframerate;
        public string videosampling;
        public string videoscaling;
        public string videoscalinguri;
        public string videoscan;
        public string videovbr;
        public string width;
        public string widthunit;
        public string widthunituri;
        public string wordcount;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public InlineXML() { Xname = "inlineXML"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:instanceOf (without child elements)
    /// <summary>
    public class InstanceOf
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string typeuri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public InstanceOf() { Xname = "instanceOf"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:itemClass (without child elements)
    /// <summary>
    public class ItemClass
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:itemCount (without child elements)
    /// <summary>
    public class ItemCount
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:itemMeta (without child elements)
    /// <summary>
    public class ItemMeta
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public ItemMeta() { Xname = "itemMeta"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "s"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:itemMetaExtProperty (without child elements)
    /// <summary>
    public class ItemMetaExtProperty
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string typeuri;
        public string rel;
        public string reluri;
        public string validfrom;
        public string validto;
        public string value;
        public string valuedatatype;
        public string valueunit;
        public string valueunituri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public ItemMetaExtProperty() { Xname = "itemMetaExtProperty"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:itemRef (without child elements)
    /// <summary>
    public class ItemRef
    {
        public string version;
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string contenttype;
        public string format;
        public string formaturi;
        public string guidref;
        public string href;
        public string hreftype;
        public string persistidref;
        public string rank;
        public string rel;
        public string reluri;
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:itemSet (without child elements)
    /// <summary>
    public class ItemSet
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public ItemSet() { Xname = "itemSet"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "s"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:keyword (without child elements)
    /// <summary>
    public class Keyword
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string confidence;
        public string rank;
        public string relevance;
        public string role;
        public string roleuri;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Keyword() { Xname = "keyword"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public Keyword(string propValue) { Xname = "keyword"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:knowledgeItem (without child elements)
    /// <summary>
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:language (without child elements)
    /// <summary>
    public class Language
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string rank;
        public string role;
        public string roleuri;
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:lineXxADDR (without child elements)
    /// <summary>
    public class LineXxADDR
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:lineXxGEOAREA (without child elements)
    /// <summary>
    public class LineXxGEOAREA
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public LineXxGEOAREA() { Xname = "line"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:link (without child elements)
    /// <summary>
    public class Link
    {
        public string version;
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string contenttype;
        public string format;
        public string formaturi;
        public string guidref;
        public string href;
        public string hreftype;
        public string persistidref;
        public string rank;
        public string rel;
        public string reluri;
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:locality (without child elements)
    /// <summary>
    public class Locality
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string typeuri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Locality() { Xname = "locality"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "d"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:located (without child elements)
    /// <summary>
    public class Located
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string typeuri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Located() { Xname = "located"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:location (without child elements)
    /// <summary>
    public class Location
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string typeuri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Location() { Xname = "location"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:memberOf (without child elements)
    /// <summary>
    public class MemberOf
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string typeuri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public MemberOf() { Xname = "memberOf"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:name (without child elements)
    /// <summary>
    public class Name
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string part;
        public string parturi;
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:narrower (without child elements)
    /// <summary>
    public class Narrower
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string typeuri;
        public string rank;
        public string rel;
        public string reluri;
        public string validfrom;
        public string validto;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Narrower() { Xname = "narrower"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:newsContentCharacteristics (without child elements)
    /// <summary>
    public class NewsContentCharacteristics
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string audiobitrate;
        public string audiochannels;
        public string audiochannelsuri;
        public string audiocodec;
        public string audiocodecuri;
        public string audiosamplerate;
        public string audiosamplesize;
        public string audiovbr;
        public string colourdepth;
        public string colourindicator;
        public string colourindicatoruri;
        public string colourspace;
        public string colourspaceuri;
        public string contenttype;
        public string duration;
        public string durationunit;
        public string durationunituri;
        public string format;
        public string formaturi;
        public string height;
        public string heightunit;
        public string heightunituri;
        public string layoutorientation;
        public string layoutorientationuri;
        public string orientation;
        public string resolution;
        public string videoaspectratio;
        public string videoavgbitrate;
        public string videocodec;
        public string videocodecuri;
        public string videodefinition;
        public string videodefinitionuri;
        public string videoframerate;
        public string videosampling;
        public string videoscaling;
        public string videoscalinguri;
        public string videoscan;
        public string videovbr;
        public string width;
        public string widthunit;
        public string widthunituri;
        public string wordcount;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public NewsContentCharacteristics() { Xname = "newsContentCharacteristics"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:newsCoverage (without child elements)
    /// <summary>
    public class NewsCoverage
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string role;
        public string roleuri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public NewsCoverage() { Xname = "newsCoverage"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "s"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:newsCoverageExtProperty (without child elements)
    /// <summary>
    public class NewsCoverageExtProperty
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string typeuri;
        public string rel;
        public string reluri;
        public string validfrom;
        public string validto;
        public string value;
        public string valuedatatype;
        public string valueunit;
        public string valueunituri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public NewsCoverageExtProperty() { Xname = "newsCoverageExtProperty"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:newsCoverageSet (without child elements)
    /// <summary>
    public class NewsCoverageSet
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public NewsCoverageSet() { Xname = "newsCoverageSet"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "s"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:newsCoverageStatus (without child elements)
    /// <summary>
    public class NewsCoverageStatus
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:newsItem (without child elements)
    /// <summary>
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:newsMessage (without child elements)
    /// <summary>
    public class NewsMessage
    {
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public NewsMessage() { Xname = "newsMessage"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "r"; Xcard = "s"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:note (without child elements)
    /// <summary>
    public class Note
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:objectDetails (without child elements)
    /// <summary>
    public class ObjectDetails
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public ObjectDetails() { Xname = "objectDetails"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "s"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:occurStatus (without child elements)
    /// <summary>
    public class OccurStatus
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:openHours (without child elements)
    /// <summary>
    public class OpenHours
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string media;
        public string role;
        public string roleuri;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public OpenHours() { Xname = "openHours"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public OpenHours(string propValue) { Xname = "openHours"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:organisationDetails (without child elements)
    /// <summary>
    public class OrganisationDetails
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public OrganisationDetails() { Xname = "organisationDetails"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "s"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:organiser (without child elements)
    /// <summary>
    public class Organiser
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string typeuri;
        public string role;
        public string roleuri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Organiser() { Xname = "organiser"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:origin (without child elements)
    /// <summary>
    public class Origin
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string typeuri;
        public string role;
        public string roleuri;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Origin() { Xname = "origin"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
        public Origin(string propValue) { Xname = "origin"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; thisValue = propValue; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:packageItem (without child elements)
    /// <summary>
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:participant (without child elements)
    /// <summary>
    public class Participant
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string typeuri;
        public string role;
        public string roleuri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Participant() { Xname = "participant"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:participationRequirement (without child elements)
    /// <summary>
    public class ParticipationRequirement
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string typeuri;
        public string role;
        public string roleuri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public ParticipationRequirement() { Xname = "participationRequirement"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:partMeta (without child elements)
    /// <summary>
    public class PartMeta
    {
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:partMetaExtProperty (without child elements)
    /// <summary>
    public class PartMetaExtProperty
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string typeuri;
        public string rel;
        public string reluri;
        public string validfrom;
        public string validto;
        public string value;
        public string valuedatatype;
        public string valueunit;
        public string valueunituri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public PartMetaExtProperty() { Xname = "partMetaExtProperty"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:party (without child elements)
    /// <summary>
    public class Party
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string typeuri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Party() { Xname = "party"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "d"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:personDetails (without child elements)
    /// <summary>
    public class PersonDetails
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public PersonDetails() { Xname = "personDetails"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "s"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:phone (without child elements)
    /// <summary>
    public class Phone
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string role;
        public string roleuri;
        public string tech;
        public string techuri;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Phone() { Xname = "phone"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "d"; Xcard = "u"; }
        public Phone(string propValue) { Xname = "phone"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "d"; Xcard = "u"; thisValue = propValue; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:planning (without child elements)
    /// <summary>
    public class Planning
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Planning() { Xname = "planning"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "s"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:planningExtProperty (without child elements)
    /// <summary>
    public class PlanningExtProperty
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string typeuri;
        public string rel;
        public string reluri;
        public string validfrom;
        public string validto;
        public string value;
        public string valuedatatype;
        public string valueunit;
        public string valueunituri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public PlanningExtProperty() { Xname = "planningExtProperty"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:planningItem (without child elements)
    /// <summary>
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:POIDetails (without child elements)
    /// <summary>
    public class POIDetails
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public POIDetails() { Xname = "POIDetails"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "s"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:polygon (without child elements)
    /// <summary>
    public class Polygon
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Polygon() { Xname = "polygon"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:position (without child elements)
    /// <summary>
    public class Position
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:postalCode (without child elements)
    /// <summary>
    public class PostalCode
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:priority (without child elements)
    /// <summary>
    public class Priority
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Priority() { Xname = "priority"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
        public Priority(string propValue) { Xname = "priority"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; thisValue = propValue; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:profile (without child elements)
    /// <summary>
    public class Profile
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string versioninfo;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Profile() { Xname = "profile"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
        public Profile(string propValue) { Xname = "profile"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; thisValue = propValue; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:provider (without child elements)
    /// <summary>
    public class Provider
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string typeuri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Provider() { Xname = "provider"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:pubStatus (without child elements)
    /// <summary>
    public class PubStatus
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:rating (without child elements)
    /// <summary>
    public class Rating
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string raters;
        public string ratertype;
        public string ratertypeuri;
        public string ratingtype;
        public string ratingtypeuri;
        public string scalemax;
        public string scalemin;
        public string scaleunit;
        public string scaleunituri;
        public string valcalctype;
        public string valcalctypeuri;
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:rb (without child elements)
    /// <summary>
    public class Rb
    {
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Rb() { Xname = "rb"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "m"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:rDate (without child elements)
    /// <summary>
    public class RDate
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public RDate() { Xname = "rDate"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public RDate(string propValue) { Xname = "rDate"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:regionDelim (without child elements)
    /// <summary>
    public class RegionDelim
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:registration (without child elements)
    /// <summary>
    public class Registration
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string media;
        public string role;
        public string roleuri;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Registration() { Xname = "registration"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public Registration(string propValue) { Xname = "registration"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:related (without child elements)
    /// <summary>
    public class Related
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string typeuri;
        public string rank;
        public string rel;
        public string reluri;
        public string validfrom;
        public string validto;
        public string value;
        public string valuedatatype;
        public string valueunit;
        public string valueunituri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Related() { Xname = "related"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:remoteContent (without child elements)
    /// <summary>
    public class RemoteContent
    {
        public string version;
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string audiobitrate;
        public string audiochannels;
        public string audiochannelsuri;
        public string audiocodec;
        public string audiocodecuri;
        public string audiosamplerate;
        public string audiosamplesize;
        public string audiovbr;
        public string colourdepth;
        public string colourindicator;
        public string colourindicatoruri;
        public string colourspace;
        public string colourspaceuri;
        public string contenttype;
        public string duration;
        public string durationunit;
        public string durationunituri;
        public string format;
        public string formaturi;
        public string generated;
        public string generator;
        public string hascontent;
        public string height;
        public string heightunit;
        public string heightunituri;
        public string href;
        public string language;
        public string layoutorientation;
        public string layoutorientationuri;
        public string orientation;
        public string persistidref;
        public string rendition;
        public string renditionuri;
        public string residref;
        public string resolution;
        public string size;
        public string title;
        public string validfrom;
        public string validto;
        public string videoaspectratio;
        public string videoavgbitrate;
        public string videocodec;
        public string videocodecuri;
        public string videodefinition;
        public string videodefinitionuri;
        public string videoframerate;
        public string videosampling;
        public string videoscaling;
        public string videoscalinguri;
        public string videoscan;
        public string videovbr;
        public string width;
        public string widthunit;
        public string widthunituri;
        public string wordcount;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public RemoteContent() { Xname = "remoteContent"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:remoteContentExtProperty (without child elements)
    /// <summary>
    public class RemoteContentExtProperty
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string typeuri;
        public string rel;
        public string reluri;
        public string validfrom;
        public string validto;
        public string value;
        public string valuedatatype;
        public string valueunit;
        public string valueunituri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public RemoteContentExtProperty() { Xname = "remoteContentExtProperty"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:remoteInfo (without child elements)
    /// <summary>
    public class RemoteInfo
    {
        public string version;
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string contenttype;
        public string format;
        public string formaturi;
        public string guidref;
        public string href;
        public string hreftype;
        public string persistidref;
        public string rank;
        public string rel;
        public string reluri;
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:rightsInfo (without child elements)
    /// <summary>
    public class RightsInfo
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string aspect;
        public string aspecturi;
        public string idrefs;
        public string scope;
        public string scopeuri;
        public string validfrom;
        public string validto;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public RightsInfo() { Xname = "rightsInfo"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "w"; Xcard = "s"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:rightsInfoExtProperty (without child elements)
    /// <summary>
    public class RightsInfoExtProperty
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string typeuri;
        public string rel;
        public string reluri;
        public string validfrom;
        public string validto;
        public string value;
        public string valuedatatype;
        public string valueunit;
        public string valueunituri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public RightsInfoExtProperty() { Xname = "rightsInfoExtProperty"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:role (without child elements)
    /// <summary>
    public class Role
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:rp (without child elements)
    /// <summary>
    public class Rp
    {
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Rp() { Xname = "rp"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "m"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:rRule (without child elements)
    /// <summary>
    public class RRule
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:rt (without child elements)
    /// <summary>
    public class Rt
    {
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Rt() { Xname = "rt"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "m"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:ruby (without child elements)
    /// <summary>
    public class Ruby
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Ruby() { Xname = "ruby"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "m"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:sameAs (without child elements)
    /// <summary>
    public class SameAs
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string typeuri;
        public string validfrom;
        public string validto;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public SameAs() { Xname = "sameAs"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:sameAsScheme (without child elements)
    /// <summary>
    public class SameAsScheme
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public SameAsScheme() { Xname = "sameAsScheme"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "d"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:scheduled (without child elements)
    /// <summary>
    public class Scheduled
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:scheme (without child elements)
    /// <summary>
    public class Scheme
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string uri;
        public string alias;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Scheme() { Xname = "scheme"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:schemeMeta (without child elements)
    /// <summary>
    public class SchemeMeta
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:schemeMetaExtProperty (without child elements)
    /// <summary>
    public class SchemeMetaExtProperty
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string typeuri;
        public string rel;
        public string reluri;
        public string validfrom;
        public string validto;
        public string value;
        public string valuedatatype;
        public string valueunit;
        public string valueunituri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public SchemeMetaExtProperty() { Xname = "schemeMetaExtProperty"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:sender (without child elements)
    /// <summary>
    public class Sender
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string typeuri;
        public string role;
        public string roleuri;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Sender() { Xname = "sender"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
        public Sender(string propValue) { Xname = "sender"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; thisValue = propValue; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:sent (without child elements)
    /// <summary>
    public class Sent
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Sent() { Xname = "sent"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
        public Sent(string propValue) { Xname = "sent"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; thisValue = propValue; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:service (without child elements)
    /// <summary>
    public class Service
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:signal (without child elements)
    /// <summary>
    public class Signal
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string severity;
        public string severityuri;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Signal() { Xname = "signal"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:slugline (without child elements)
    /// <summary>
    public class Slugline
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string rank;
        public string role;
        public string roleuri;
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:span (without child elements)
    /// <summary>
    public class Span
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:start (without child elements)
    /// <summary>
    public class Start
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:subject (without child elements)
    /// <summary>
    public class Subject
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string typeuri;
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:timeDelim (without child elements)
    /// <summary>
    public class TimeDelim
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string end;
        public string renditionref;
        public string renditionrefuri;
        public string start;
        public string timeunit;
        public string timeunituri;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public TimeDelim() { Xname = "timeDelim"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
        public TimeDelim(string propValue) { Xname = "timeDelim"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; thisValue = propValue; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:timestamp (without child elements)
    /// <summary>
    public class Timestamp
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string role;
        public string roleuri;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Timestamp() { Xname = "timestamp"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public Timestamp(string propValue) { Xname = "timestamp"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:title (without child elements)
    /// <summary>
    public class Title
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string media;
        public string role;
        public string roleuri;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Title() { Xname = "title"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public Title(string propValue) { Xname = "title"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:transmitId (without child elements)
    /// <summary>
    public class TransmitId
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public TransmitId() { Xname = "transmitId"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
        public TransmitId(string propValue) { Xname = "transmitId"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; thisValue = propValue; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:type (without child elements)
    /// <summary>
    public class Type
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
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

    /// <summary>
    /// Class for the NewsML-G2 element nar:urgency (without child elements)
    /// <summary>
    public class Urgency
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Urgency() { Xname = "urgency"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
        public Urgency(string propValue) { Xname = "urgency"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; thisValue = propValue; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:usageTerms (without child elements)
    /// <summary>
    public class UsageTerms
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string href;
        public string media;
        public string role;
        public string roleuri;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public UsageTerms() { Xname = "usageTerms"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public UsageTerms(string propValue) { Xname = "usageTerms"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:userInteraction (without child elements)
    /// <summary>
    public class UserInteraction
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string interactions;
        public string interactiontype;
        public string interactiontypeuri;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public UserInteraction() { Xname = "userInteraction"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; }
        public UserInteraction(string propValue) { Xname = "userInteraction"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "u"; thisValue = propValue; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:versionCreated (without child elements)
    /// <summary>
    public class VersionCreated
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public VersionCreated() { Xname = "versionCreated"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; }
        public VersionCreated(string propValue) { Xname = "versionCreated"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "p"; Xcard = "s"; thisValue = propValue; }
    }

    /// <summary>
    /// Class for the NewsML-G2 element nar:web (without child elements)
    /// <summary>
    public class Web
    {
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string role;
        public string roleuri;
        public string thisValue;
        public readonly string Xname;
        public readonly string XnsURI;
        public readonly string XnsPrefix;
        public readonly string Xusagecode;
        public readonly string Xcard;
        public Web() { Xname = "web"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "d"; Xcard = "u"; }
        public Web(string propValue) { Xname = "web"; XnsURI = "http://iptc.org/std/nar/2006-10-01/"; XnsPrefix = "nar"; Xusagecode = "d"; Xcard = "u"; thisValue = propValue; }
    }

    /// <summary>
    /// Class for a virtual element including all attributes defined in the NewsML-G2 context (without child elements)
    /// <summary>
    public class GenericProperty
    {
        public string standard;
        public string standardversion;
        public string conformance;
        public string guid;
        public string version;
        public string id;
        public string creator;
        public string creatoruri;
        public string modified;
        public string custom;
        public string how;
        public string howuri;
        public string why;
        public string whyuri;
        public string pubconstraint;
        public string pubconstrainturi;
        public string xmllang;
        public string dir;
        public string qcode;
        public string uri;
        public string literal;
        public string type;
        public string typeuri;
        public string additionalInfo;
        public string alias;
        public string altitude;
        public string approxend;
        public string approxstart;
        public string aspect;
        public string aspecturi;
        public string audiobitrate;
        public string audiochannels;
        public string audiochannelsuri;
        public string audiocodec;
        public string audiocodecuri;
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
        public string colourindicatoruri;
        public string colourspace;
        public string colourspaceuri;
        public string confidence;
        public string contentrefs;
        public string contenttype;
        public string count;
        public string created;
        public string derivedfrom;
        public string duration;
        public string durationunit;
        public string durationunituri;
        public string encoding;
        public string encodinguri;
        public string end;
        public string environment;
        public string environmenturi;
        public string format;
        public string formaturi;
        public string freq;
        public string generated;
        public string generator;
        public string gpsdatum;
        public string guidref;
        public string hascontent;
        public string hashtype;
        public string hashtypeuri;
        public string height;
        public string heightunit;
        public string heightunituri;
        public string href;
        public string hreflang;
        public string hreftype;
        public string idformat;
        public string idformaturi;
        public string idref;
        public string idrefs;
        public string interactions;
        public string interactiontype;
        public string interactiontypeuri;
        public string interval;
        public string jobtitle;
        public string jobtitleuri;
        public string language;
        public string layoutorientation;
        public string layoutorientationuri;
        public string latitude;
        public string longitude;
        public string market;
        public string marketuri;
        public string marketlabel;
        public string marketlabelsrc;
        public string marketlabelsrcuri;
        public string media;
        public string mode;
        public string modeuri;
        public string orientation;
        public string original;
        public string part;
        public string parturi;
        public string partid;
        public string persistidref;
        public string preferredalias;
        public string radunit;
        public string radunituri;
        public string rangefrom;
        public string rangeto;
        public string rank;
        public string raters;
        public string ratertype;
        public string ratertypeuri;
        public string ratingtype;
        public string ratingtypeuri;
        public string rel;
        public string reluri;
        public string relevance;
        public string rendition;
        public string renditionuri;
        public string renditionref;
        public string renditionrefuri;
        public string representation;
        public string representationuri;
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
        public string scaleunituri;
        public string scope;
        public string scopeuri;
        public string separator;
        public string seq;
        public string severity;
        public string severityuri;
        public string significance;
        public string size;
        public string start;
        public string symbol;
        public string symbolsrc;
        public string symbolsrcuri;
        public string tag;
        public string target;
        public string targeturi;
        public string tech;
        public string techuri;
        public string timestamp;
        public string timeunit;
        public string timeunituri;
        public string title;
        public string until;
        public string url;
        public string valcalctype;
        public string valcalctypeuri;
        public string validfrom;
        public string validto;
        public string value;
        public string valuedatatype;
        public string valueunit;
        public string valueunituri;
        public string versioninfo;
        public string videoaspectratio;
        public string videoavgbitrate;
        public string videocodec;
        public string videocodecuri;
        public string videodefinition;
        public string videodefinitionuri;
        public string videoframerate;
        public string videosampling;
        public string videoscaling;
        public string videoscalinguri;
        public string videoscan;
        public string videovbr;
        public string width;
        public string widthunit;
        public string widthunituri;
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
