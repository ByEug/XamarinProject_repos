using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace App2
{
    //[Serializable]
    public class SettingsXML
    {
        public string ShortLang { get; set; }

        public string Animation { get; set; }

        public SettingsXML()
        {

        }

        public SettingsXML(string buffer, string AnimBuffer)
        {
            ShortLang = buffer;
            Animation = AnimBuffer;
        }
         
    }

    [XmlRoot("ArrayOfSettings")]
    public class SettingsRoot
    {
        public SettingsRoot() { Settings = new List<SettingsXML>(); }

        [XmlElement("SettingsXML")]
        public List<SettingsXML> Settings { get; set; }
    }
}
