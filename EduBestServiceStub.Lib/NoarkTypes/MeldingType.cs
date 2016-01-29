﻿namespace EduBestServiceStub.Lib.NoarkTypes
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.arkivverket.no/Noark4-1-WS-WD/types")]
    [System.Xml.Serialization.XmlRoot("Melding")]
    public partial class MeldingType {
    
        private JournpostType journpostField;
    
        private NoarksakType noarksakField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public JournpostType journpost {
            get {
                return this.journpostField;
            }
            set {
                this.journpostField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NoarksakType noarksak {
            get {
                return this.noarksakField;
            }
            set {
                this.noarksakField = value;
            }
        }
    }
}