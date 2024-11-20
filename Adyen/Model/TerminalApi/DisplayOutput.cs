﻿namespace Adyen.Model.TerminalApi
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class DisplayOutput
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public OutputContent OutputContent;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MenuEntry", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public MenuEntry[] MenuEntry;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "base64Binary")]
        public byte[] OutputSignature;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool? ResponseRequiredFlag;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        [System.ComponentModel.DefaultValueAttribute(0)]
        public int? MinimumDisplayTime;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public DeviceType Device;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public InfoQualifyType InfoQualify;
    }
}