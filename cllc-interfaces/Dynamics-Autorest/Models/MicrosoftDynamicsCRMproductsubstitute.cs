// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.productsubstitute
    /// </summary>
    public partial class MicrosoftDynamicsCRMproductsubstitute
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMproductsubstitute class.
        /// </summary>
        public MicrosoftDynamicsCRMproductsubstitute()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMproductsubstitute class.
        /// </summary>
        /// <param name="salesrelationshiptype">Select the type of the product
        /// relationship.</param>
        /// <param name="_transactioncurrencyidValue">Shows the currency
        /// associated with the record.</param>
        /// <param name="exchangerate">Shows the conversion rate of the
        /// record's currency. The exchange rate is used to convert all money
        /// fields in the record from the local currency to the system's
        /// default currency.</param>
        /// <param name="_createdonbehalfbyValue">Shows who created the record
        /// on behalf of another user.</param>
        /// <param name="_organizationidValue">Shows the organization
        /// associated with the record.</param>
        /// <param name="statecode">Select the product relationship's
        /// status.</param>
        /// <param name="_productidValue">Shows the product that the
        /// relationship is defined for.</param>
        /// <param name="versionnumber">Shows the version number of the product
        /// relationship.</param>
        /// <param name="statuscode">Shows whether the product relationship is
        /// active or inactive.</param>
        /// <param name="_modifiedonbehalfbyValue">Shows who created the record
        /// on behalf of another user.</param>
        /// <param name="_createdbyValue">Shows who created the record.</param>
        /// <param name="importsequencenumber">Shows the data import or data
        /// migration that created this record.</param>
        /// <param name="direction">Select whether the relationship is
        /// unidirectional or bidirectional.</param>
        /// <param name="createdon">Shows the date and time when the record was
        /// created.</param>
        /// <param name="modifiedon">Shows the date and time when the record
        /// was last updated.</param>
        /// <param name="productsubstituteid">Shows the unique identifier of
        /// the product relationship.</param>
        /// <param name="_modifiedbyValue">Shows who last updated the
        /// record.</param>
        /// <param name="_substitutedproductidValue">Select the related product
        /// that the relationship needs to be defined for.</param>
        /// <param name="overriddencreatedon">Shows the date and time that the
        /// record was migrated.</param>
        /// <param name="utcconversiontimezonecode">Shows the time zone code
        /// that was in use when the record was created.</param>
        /// <param name="timezoneruleversionnumber">For internal use
        /// only.</param>
        public MicrosoftDynamicsCRMproductsubstitute(int? salesrelationshiptype = default(int?), string _transactioncurrencyidValue = default(string), decimal? exchangerate = default(decimal?), string _createdonbehalfbyValue = default(string), string _organizationidValue = default(string), int? statecode = default(int?), string _productidValue = default(string), string versionnumber = default(string), int? statuscode = default(int?), string _modifiedonbehalfbyValue = default(string), string _createdbyValue = default(string), int? importsequencenumber = default(int?), int? direction = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string productsubstituteid = default(string), string _modifiedbyValue = default(string), string _substitutedproductidValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? utcconversiontimezonecode = default(int?), int? timezoneruleversionnumber = default(int?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMasyncoperation> productSubstituteAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> productSubstituteBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMproduct productid = default(MicrosoftDynamicsCRMproduct), MicrosoftDynamicsCRMproduct substitutedproductid = default(MicrosoftDynamicsCRMproduct), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMsyncerror> productSubstituteSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>))
        {
            Salesrelationshiptype = salesrelationshiptype;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Exchangerate = exchangerate;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._organizationidValue = _organizationidValue;
            Statecode = statecode;
            this._productidValue = _productidValue;
            Versionnumber = versionnumber;
            Statuscode = statuscode;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._createdbyValue = _createdbyValue;
            Importsequencenumber = importsequencenumber;
            Direction = direction;
            Createdon = createdon;
            Modifiedon = modifiedon;
            Productsubstituteid = productsubstituteid;
            this._modifiedbyValue = _modifiedbyValue;
            this._substitutedproductidValue = _substitutedproductidValue;
            Overriddencreatedon = overriddencreatedon;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            ProductSubstituteAsyncOperations = productSubstituteAsyncOperations;
            ProductSubstituteBulkDeleteFailures = productSubstituteBulkDeleteFailures;
            Productid = productid;
            Substitutedproductid = substitutedproductid;
            Organizationid = organizationid;
            Transactioncurrencyid = transactioncurrencyid;
            ProductSubstituteSyncErrors = productSubstituteSyncErrors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets select the type of the product relationship.
        /// </summary>
        [JsonProperty(PropertyName = "salesrelationshiptype")]
        public int? Salesrelationshiptype { get; set; }

        /// <summary>
        /// Gets or sets shows the currency associated with the record.
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// Gets or sets shows the conversion rate of the record's currency.
        /// The exchange rate is used to convert all money fields in the record
        /// from the local currency to the system's default currency.
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// Gets or sets shows who created the record on behalf of another
        /// user.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets shows the organization associated with the record.
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// Gets or sets select the product relationship's status.
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// Gets or sets shows the product that the relationship is defined
        /// for.
        /// </summary>
        [JsonProperty(PropertyName = "_productid_value")]
        public string _productidValue { get; set; }

        /// <summary>
        /// Gets or sets shows the version number of the product relationship.
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets shows whether the product relationship is active or
        /// inactive.
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// Gets or sets shows who created the record on behalf of another
        /// user.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets shows who created the record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets shows the data import or data migration that created
        /// this record.
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// Gets or sets select whether the relationship is unidirectional or
        /// bidirectional.
        /// </summary>
        [JsonProperty(PropertyName = "direction")]
        public int? Direction { get; set; }

        /// <summary>
        /// Gets or sets shows the date and time when the record was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets shows the date and time when the record was last
        /// updated.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets shows the unique identifier of the product
        /// relationship.
        /// </summary>
        [JsonProperty(PropertyName = "productsubstituteid")]
        public string Productsubstituteid { get; set; }

        /// <summary>
        /// Gets or sets shows who last updated the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets select the related product that the relationship needs
        /// to be defined for.
        /// </summary>
        [JsonProperty(PropertyName = "_substitutedproductid_value")]
        public string _substitutedproductidValue { get; set; }

        /// <summary>
        /// Gets or sets shows the date and time that the record was migrated.
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// Gets or sets shows the time zone code that was in use when the
        /// record was created.
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProductSubstitute_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> ProductSubstituteAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProductSubstitute_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> ProductSubstituteBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productid")]
        public MicrosoftDynamicsCRMproduct Productid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "substitutedproductid")]
        public MicrosoftDynamicsCRMproduct Substitutedproductid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProductSubstitute_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> ProductSubstituteSyncErrors { get; set; }

    }
}
