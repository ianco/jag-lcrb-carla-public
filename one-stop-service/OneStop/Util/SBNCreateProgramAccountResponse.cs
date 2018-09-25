﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute("SBNCreateProgramAccountResponse", Namespace="", IsNullable=false)]
public partial class SBNCreateProgramAccountResponse1 {
    
    private SBNCreateProgramAccountResponseHeader headerField;
    
    private SBNCreateProgramAccountResponseBody bodyField;
    
    private string versionField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public SBNCreateProgramAccountResponseHeader header {
        get {
            return this.headerField;
        }
        set {
            this.headerField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public SBNCreateProgramAccountResponseBody body {
        get {
            return this.bodyField;
        }
        set {
            this.bodyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Version {
        get {
            return this.versionField;
        }
        set {
            this.versionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class SBNCreateProgramAccountResponseHeader {
    
    private string requestModeField;
    
    private string documentSubTypeField;
    
    private string senderIDField;
    
    private string receiverIDField;
    
    private string transactionIDField;
    
    private string transactionDateTimeField;
    
    private string partnerNoteField;
    
    private SBNCreateProgramAccountResponseHeaderCCRAHeader cCRAHeaderField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string requestMode {
        get {
            return this.requestModeField;
        }
        set {
            this.requestModeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string documentSubType {
        get {
            return this.documentSubTypeField;
        }
        set {
            this.documentSubTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string senderID {
        get {
            return this.senderIDField;
        }
        set {
            this.senderIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string receiverID {
        get {
            return this.receiverIDField;
        }
        set {
            this.receiverIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string transactionID {
        get {
            return this.transactionIDField;
        }
        set {
            this.transactionIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string transactionDateTime {
        get {
            return this.transactionDateTimeField;
        }
        set {
            this.transactionDateTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string partnerNote {
        get {
            return this.partnerNoteField;
        }
        set {
            this.partnerNoteField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public SBNCreateProgramAccountResponseHeaderCCRAHeader CCRAHeader {
        get {
            return this.cCRAHeaderField;
        }
        set {
            this.cCRAHeaderField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class SBNCreateProgramAccountResponseHeaderCCRAHeader {
    
    private string userApplicationField;
    
    private string userRoleField;
    
    private SBNCreateProgramAccountResponseHeaderCCRAHeaderUserCredentials userCredentialsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string userApplication {
        get {
            return this.userApplicationField;
        }
        set {
            this.userApplicationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string userRole {
        get {
            return this.userRoleField;
        }
        set {
            this.userRoleField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public SBNCreateProgramAccountResponseHeaderCCRAHeaderUserCredentials userCredentials {
        get {
            return this.userCredentialsField;
        }
        set {
            this.userCredentialsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class SBNCreateProgramAccountResponseHeaderCCRAHeaderUserCredentials {
    
    private string businessRegistrationNumberField;
    
    private string legalNameField;
    
    private string postalCodeField;
    
    private string lastNameField;
    
    private SBNCreateProgramAccountResponseHeaderCCRAHeaderUserCredentialsCorporationInformation corporationInformationField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
    public string businessRegistrationNumber {
        get {
            return this.businessRegistrationNumberField;
        }
        set {
            this.businessRegistrationNumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string legalName {
        get {
            return this.legalNameField;
        }
        set {
            this.legalNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string postalCode {
        get {
            return this.postalCodeField;
        }
        set {
            this.postalCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string lastName {
        get {
            return this.lastNameField;
        }
        set {
            this.lastNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public SBNCreateProgramAccountResponseHeaderCCRAHeaderUserCredentialsCorporationInformation corporationInformation {
        get {
            return this.corporationInformationField;
        }
        set {
            this.corporationInformationField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class SBNCreateProgramAccountResponseHeaderCCRAHeaderUserCredentialsCorporationInformation {
    
    private string incorporationCertificateIdentifierField;
    
    private string jurisdictionCodeField;
    
    private string jurisdictionProvinceCodeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string incorporationCertificateIdentifier {
        get {
            return this.incorporationCertificateIdentifierField;
        }
        set {
            this.incorporationCertificateIdentifierField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string jurisdictionCode {
        get {
            return this.jurisdictionCodeField;
        }
        set {
            this.jurisdictionCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string jurisdictionProvinceCode {
        get {
            return this.jurisdictionProvinceCodeField;
        }
        set {
            this.jurisdictionProvinceCodeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class SBNCreateProgramAccountResponseBody {
    
    private SBNCreateProgramAccountResponseBodyBusinessProgramAccountNumber businessProgramAccountNumberField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public SBNCreateProgramAccountResponseBodyBusinessProgramAccountNumber businessProgramAccountNumber {
        get {
            return this.businessProgramAccountNumberField;
        }
        set {
            this.businessProgramAccountNumberField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class SBNCreateProgramAccountResponseBodyBusinessProgramAccountNumber {
    
    private string businessRegistrationNumberField;
    
    private string businessProgramIdentifierField;
    
    private string businessProgramAccountReferenceNumberField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
    public string businessRegistrationNumber {
        get {
            return this.businessRegistrationNumberField;
        }
        set {
            this.businessRegistrationNumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string businessProgramIdentifier {
        get {
            return this.businessProgramIdentifierField;
        }
        set {
            this.businessProgramIdentifierField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
    public string businessProgramAccountReferenceNumber {
        get {
            return this.businessProgramAccountReferenceNumberField;
        }
        set {
            this.businessProgramAccountReferenceNumberField = value;
        }
    }
}