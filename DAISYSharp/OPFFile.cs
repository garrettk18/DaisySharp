    using System;
using System.Collections.Generic;
using System.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DAISYSharp
{
    public class OPFFile
    {
        public string _FileName { get; set; }
        private XmlDocument _opfDom;
        public List<string> _FileList { get; set; }
    }
}
