    using System;
using System.Collections.Generic;
using System.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace DAISYSharp
{
    public class OPFFile
    {
        public string _FileName { get; set; }
        private XmlDocument _opfDom;
        public List<string> _FileList { get; set; }
        public bool IsValid()
        {
            XmlNode packageNode = _opfDom.DocumentElement;
            Debug.WriteLine("Document element: " + packageNode.Name);
            string uid = packageNode.Attributes["unique-identifier"].Value;
            Debug.WriteLine("unique-identifier: " + uid);
            String uidExpression = String.Format("//*[@id=\'{0}\']", uid);
            Debug.WriteLine("uidExpression = " + uidExpression);
            XmlNode uniqueIdentifier = _opfDom.SelectSingleNode(uidExpression);
            if (uniqueIdentifier != null)
            {
                Debug.WriteLine("uniqueIdentifier = " + uniqueIdentifier.InnerXml);
            } //if
            else
            {
                Debug.WriteLine("Invalid book! " + _FileName);
            }

            return true;
        }

        private void BuildManifest()
        {

        }

        public OPFFile()
        {
            _opfDom = new XmlDocument();
        } //default constructor

        public OPFFile(string Filename)
        {
            _FileName = Filename;
            try
            {
                _opfDom = new XmlDocument();
                _opfDom.Load(_FileName);
            
            } //try
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            } //catch
            IsValid();

        } //OPFFile, explicit constructor
    }
}
