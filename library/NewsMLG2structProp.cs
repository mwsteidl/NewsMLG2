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
Class: NewsIT.IPTC.NewsMLG2.StructuredProperty
  

Current date / persID / change log (most current at top)
StartDate: 2014-03-19
******************************************************************************/
using System;
using System.Collections.Generic;

namespace NewsIT.IPTC.NewsMLG2
{
    public class StructuredProperty
    {
        public string ParentXPath;
        public string ParentChildNameSeq;
        public string ChildNameSeq;
        public object CoreProp;
        public List<object> ChildProps;

        public StructuredProperty()
        {
            ParentChildNameSeq = string.Empty;
            ChildNameSeq = string.Empty;
            ChildProps = new List<object>();
        }
    }
}
