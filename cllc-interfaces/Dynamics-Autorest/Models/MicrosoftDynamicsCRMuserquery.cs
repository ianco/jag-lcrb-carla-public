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
    /// Microsoft.Dynamics.CRM.userquery
    /// </summary>
    public partial class MicrosoftDynamicsCRMuserquery
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMuserquery
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMuserquery()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMuserquery
        /// class.
        /// </summary>
        /// <param name="modifiedon">Shows the date and time when the record
        /// was last updated. The date and time are displayed in the time zone
        /// selected in Microsoft Dynamics 365 options.</param>
        /// <param name="statecode">Shows whether the saved view is active or
        /// inactive.</param>
        /// <param name="fetchxml">Contains the Fetch XML query that defines
        /// the entities and attributes included in the saved view.</param>
        /// <param name="_modifiedbyValue">Shows who last updated the
        /// record.</param>
        /// <param name="advancedgroupby">Type the column name that will be
        /// used to group the results from the data collected across multiple
        /// records from a user view.</param>
        /// <param name="columnsetxml">Shows the columns and sorting criteria
        /// for the saved view, stored in XML format.</param>
        /// <param name="_owningteamValue">Unique identifier of the team who
        /// owns this saved view.</param>
        /// <param name="layoutxml">For internal use only.</param>
        /// <param name="_createdonbehalfbyValue">Shows who created the record
        /// on behalf of another user.</param>
        /// <param name="conditionalformatting">Type information about how the
        /// items in the user view are formatted.</param>
        /// <param name="userqueryid">Unique identifier of the saved
        /// view.</param>
        /// <param name="querytype">Shows the code for the query type to
        /// indicate whether the saved view is an address book filter, advanced
        /// search, or other view.</param>
        /// <param name="returnedtypecode">Type of entity that the saved view
        /// displays.</param>
        /// <param name="createdon">Shows the date and time when the record was
        /// created. The date and time are displayed in the time zone selected
        /// in Microsoft Dynamics 365 options.</param>
        /// <param name="_owningbusinessunitValue">Shows the business unit that
        /// the record owner belongs to.</param>
        /// <param name="_modifiedonbehalfbyValue">Shows who last updated the
        /// record on behalf of another user.</param>
        /// <param name="description">Type additional information to describe
        /// the saved view, such as the filter criteria or intended results
        /// set.</param>
        /// <param name="versionnumber">Version number of the saved
        /// view.</param>
        /// <param name="_owninguserValue">Unique identifier of the user who
        /// owns this saved view.</param>
        /// <param name="_parentqueryidValue">Choose the ID of the saved query
        /// that the record was created from.</param>
        /// <param name="name">Type a descriptive name for the saved
        /// view.</param>
        /// <param name="_createdbyValue">Shows who created the record.</param>
        /// <param name="statuscode">Select the item's status.</param>
        /// <param name="_owneridValue">Enter the user or team who is assigned
        /// to manage the record. This field is updated every time the record
        /// is assigned to a different user.</param>
        public MicrosoftDynamicsCRMuserquery(System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? statecode = default(int?), string fetchxml = default(string), string _modifiedbyValue = default(string), string advancedgroupby = default(string), string columnsetxml = default(string), string _owningteamValue = default(string), string layoutxml = default(string), string _createdonbehalfbyValue = default(string), string conditionalformatting = default(string), string userqueryid = default(string), int? querytype = default(int?), string returnedtypecode = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _owningbusinessunitValue = default(string), string _modifiedonbehalfbyValue = default(string), string description = default(string), string versionnumber = default(string), string _owninguserValue = default(string), string _parentqueryidValue = default(string), string name = default(string), string _createdbyValue = default(string), int? statuscode = default(int?), string _owneridValue = default(string), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMsyncerror> userQuerySyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMbulkdeletefailure> userQueryBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMasyncoperation> userQueryAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser))
        {
            Modifiedon = modifiedon;
            Statecode = statecode;
            Fetchxml = fetchxml;
            this._modifiedbyValue = _modifiedbyValue;
            Advancedgroupby = advancedgroupby;
            Columnsetxml = columnsetxml;
            this._owningteamValue = _owningteamValue;
            Layoutxml = layoutxml;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Conditionalformatting = conditionalformatting;
            Userqueryid = userqueryid;
            Querytype = querytype;
            Returnedtypecode = returnedtypecode;
            Createdon = createdon;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Description = description;
            Versionnumber = versionnumber;
            this._owninguserValue = _owninguserValue;
            this._parentqueryidValue = _parentqueryidValue;
            Name = name;
            this._createdbyValue = _createdbyValue;
            Statuscode = statuscode;
            this._owneridValue = _owneridValue;
            Ownerid = ownerid;
            Modifiedby = modifiedby;
            Owningteam = owningteam;
            Createdonbehalfby = createdonbehalfby;
            UserQuerySyncErrors = userQuerySyncErrors;
            UserQueryBulkDeleteFailures = userQueryBulkDeleteFailures;
            UserQueryAsyncOperations = userQueryAsyncOperations;
            Modifiedonbehalfby = modifiedonbehalfby;
            Createdby = createdby;
            Owningbusinessunit = owningbusinessunit;
            Owninguser = owninguser;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets shows the date and time when the record was last
        /// updated. The date and time are displayed in the time zone selected
        /// in Microsoft Dynamics 365 options.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets shows whether the saved view is active or inactive.
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// Gets or sets contains the Fetch XML query that defines the entities
        /// and attributes included in the saved view.
        /// </summary>
        [JsonProperty(PropertyName = "fetchxml")]
        public string Fetchxml { get; set; }

        /// <summary>
        /// Gets or sets shows who last updated the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets type the column name that will be used to group the
        /// results from the data collected across multiple records from a user
        /// view.
        /// </summary>
        [JsonProperty(PropertyName = "advancedgroupby")]
        public string Advancedgroupby { get; set; }

        /// <summary>
        /// Gets or sets shows the columns and sorting criteria for the saved
        /// view, stored in XML format.
        /// </summary>
        [JsonProperty(PropertyName = "columnsetxml")]
        public string Columnsetxml { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the team who owns this saved
        /// view.
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "layoutxml")]
        public string Layoutxml { get; set; }

        /// <summary>
        /// Gets or sets shows who created the record on behalf of another
        /// user.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets type information about how the items in the user view
        /// are formatted.
        /// </summary>
        [JsonProperty(PropertyName = "conditionalformatting")]
        public string Conditionalformatting { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the saved view.
        /// </summary>
        [JsonProperty(PropertyName = "userqueryid")]
        public string Userqueryid { get; set; }

        /// <summary>
        /// Gets or sets shows the code for the query type to indicate whether
        /// the saved view is an address book filter, advanced search, or other
        /// view.
        /// </summary>
        [JsonProperty(PropertyName = "querytype")]
        public int? Querytype { get; set; }

        /// <summary>
        /// Gets or sets type of entity that the saved view displays.
        /// </summary>
        [JsonProperty(PropertyName = "returnedtypecode")]
        public string Returnedtypecode { get; set; }

        /// <summary>
        /// Gets or sets shows the date and time when the record was created.
        /// The date and time are displayed in the time zone selected in
        /// Microsoft Dynamics 365 options.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets shows the business unit that the record owner belongs
        /// to.
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// Gets or sets shows who last updated the record on behalf of another
        /// user.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets type additional information to describe the saved
        /// view, such as the filter criteria or intended results set.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets version number of the saved view.
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who owns this saved
        /// view.
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// Gets or sets choose the ID of the saved query that the record was
        /// created from.
        /// </summary>
        [JsonProperty(PropertyName = "_parentqueryid_value")]
        public string _parentqueryidValue { get; set; }

        /// <summary>
        /// Gets or sets type a descriptive name for the saved view.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets shows who created the record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets select the item's status.
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// Gets or sets enter the user or team who is assigned to manage the
        /// record. This field is updated every time the record is assigned to
        /// a different user.
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserQuery_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> UserQuerySyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserQuery_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> UserQueryBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserQuery_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> UserQueryAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

    }
}
