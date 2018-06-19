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

    public partial class MicrosoftDynamicsCRMslakpiinstance
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMslakpiinstance class.
        /// </summary>
        public MicrosoftDynamicsCRMslakpiinstance()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMslakpiinstance class.
        /// </summary>
        public MicrosoftDynamicsCRMslakpiinstance(IList<MicrosoftDynamicsCRMsyncerror> sLAKPIInstanceSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), string _createdbyValue = default(string), string _createdonbehalfbyValue = default(string), string _modifiedbyValue = default(string), string _modifiedonbehalfbyValue = default(string), string _owneridValue = default(string), string _owningbusinessunitValue = default(string), string _owningteamValue = default(string), string _owninguserValue = default(string), string _regardingValue = default(string), string _transactioncurrencyidValue = default(string), IList<MicrosoftDynamicsCRMadoxioApplication> adoxioSlakpiinstanceAdoxioApplicationSLA = default(IList<MicrosoftDynamicsCRMadoxioApplication>), System.DateTimeOffset? computedfailuretime = default(System.DateTimeOffset?), System.DateTimeOffset? computedwarningtime = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), string description = default(string), double? exchangerate = default(double?), System.DateTimeOffset? failuretime = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), string name = default(string), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMincident regarding = default(MicrosoftDynamicsCRMincident), MicrosoftDynamicsCRMaccount regardingAccount = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMactivitypointer regardingActivitypointer = default(MicrosoftDynamicsCRMactivitypointer), MicrosoftDynamicsCRMadoxioApplication regardingAdoxioApplication = default(MicrosoftDynamicsCRMadoxioApplication), MicrosoftDynamicsCRMappointment regardingAppointment = default(MicrosoftDynamicsCRMappointment), MicrosoftDynamicsCRMcontact regardingContact = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMemail regardingEmail = default(MicrosoftDynamicsCRMemail), MicrosoftDynamicsCRMfax regardingFax = default(MicrosoftDynamicsCRMfax), MicrosoftDynamicsCRMinvoice regardingInvoice = default(MicrosoftDynamicsCRMinvoice), MicrosoftDynamicsCRMlead regardingLead = default(MicrosoftDynamicsCRMlead), MicrosoftDynamicsCRMletter regardingLetter = default(MicrosoftDynamicsCRMletter), MicrosoftDynamicsCRMopportunity regardingOpportunity = default(MicrosoftDynamicsCRMopportunity), MicrosoftDynamicsCRMphonecall regardingPhonecall = default(MicrosoftDynamicsCRMphonecall), MicrosoftDynamicsCRMquote regardingQuote = default(MicrosoftDynamicsCRMquote), MicrosoftDynamicsCRMsalesorder regardingSalesorder = default(MicrosoftDynamicsCRMsalesorder), MicrosoftDynamicsCRMserviceappointment regardingServiceappointment = default(MicrosoftDynamicsCRMserviceappointment), MicrosoftDynamicsCRMsocialactivity regardingSocialactivity = default(MicrosoftDynamicsCRMsocialactivity), MicrosoftDynamicsCRMtask regardingTask = default(MicrosoftDynamicsCRMtask), IList<MicrosoftDynamicsCRMincident> slakpiinstanceIncidentFirstresponsebykpi = default(IList<MicrosoftDynamicsCRMincident>), IList<MicrosoftDynamicsCRMincident> slakpiinstanceIncidentResolvebykpi = default(IList<MicrosoftDynamicsCRMincident>), string slakpiinstanceid = default(string), int? status = default(int?), System.DateTimeOffset? succeededon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), object versionnumber = default(object), System.DateTimeOffset? warningtime = default(System.DateTimeOffset?), int? warningtimereached = default(int?))
        {
            SLAKPIInstanceSyncErrors = sLAKPIInstanceSyncErrors;
            this._createdbyValue = _createdbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._owneridValue = _owneridValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._owningteamValue = _owningteamValue;
            this._owninguserValue = _owninguserValue;
            this._regardingValue = _regardingValue;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            AdoxioSlakpiinstanceAdoxioApplicationSLA = adoxioSlakpiinstanceAdoxioApplicationSLA;
            Computedfailuretime = computedfailuretime;
            Computedwarningtime = computedwarningtime;
            Createdby = createdby;
            Createdon = createdon;
            Createdonbehalfby = createdonbehalfby;
            Description = description;
            Exchangerate = exchangerate;
            Failuretime = failuretime;
            Modifiedby = modifiedby;
            Modifiedon = modifiedon;
            Modifiedonbehalfby = modifiedonbehalfby;
            Name = name;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            Regarding = regarding;
            RegardingAccount = regardingAccount;
            RegardingActivitypointer = regardingActivitypointer;
            RegardingAdoxioApplication = regardingAdoxioApplication;
            RegardingAppointment = regardingAppointment;
            RegardingContact = regardingContact;
            RegardingEmail = regardingEmail;
            RegardingFax = regardingFax;
            RegardingInvoice = regardingInvoice;
            RegardingLead = regardingLead;
            RegardingLetter = regardingLetter;
            RegardingOpportunity = regardingOpportunity;
            RegardingPhonecall = regardingPhonecall;
            RegardingQuote = regardingQuote;
            RegardingSalesorder = regardingSalesorder;
            RegardingServiceappointment = regardingServiceappointment;
            RegardingSocialactivity = regardingSocialactivity;
            RegardingTask = regardingTask;
            SlakpiinstanceIncidentFirstresponsebykpi = slakpiinstanceIncidentFirstresponsebykpi;
            SlakpiinstanceIncidentResolvebykpi = slakpiinstanceIncidentResolvebykpi;
            Slakpiinstanceid = slakpiinstanceid;
            Status = status;
            Succeededon = succeededon;
            Transactioncurrencyid = transactioncurrencyid;
            Versionnumber = versionnumber;
            Warningtime = warningtime;
            Warningtimereached = warningtimereached;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SLAKPIInstance_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> SLAKPIInstanceSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_regarding_value")]
        public string _regardingValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_slakpiinstance_adoxio_application_SLA")]
        public IList<MicrosoftDynamicsCRMadoxioApplication> AdoxioSlakpiinstanceAdoxioApplicationSLA { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "computedfailuretime")]
        public System.DateTimeOffset? Computedfailuretime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "computedwarningtime")]
        public System.DateTimeOffset? Computedwarningtime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public double? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "failuretime")]
        public System.DateTimeOffset? Failuretime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regarding")]
        public MicrosoftDynamicsCRMincident Regarding { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regarding_account")]
        public MicrosoftDynamicsCRMaccount RegardingAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regarding_activitypointer")]
        public MicrosoftDynamicsCRMactivitypointer RegardingActivitypointer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regarding_adoxio_application")]
        public MicrosoftDynamicsCRMadoxioApplication RegardingAdoxioApplication { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regarding_appointment")]
        public MicrosoftDynamicsCRMappointment RegardingAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regarding_contact")]
        public MicrosoftDynamicsCRMcontact RegardingContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regarding_email")]
        public MicrosoftDynamicsCRMemail RegardingEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regarding_fax")]
        public MicrosoftDynamicsCRMfax RegardingFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regarding_invoice")]
        public MicrosoftDynamicsCRMinvoice RegardingInvoice { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regarding_lead")]
        public MicrosoftDynamicsCRMlead RegardingLead { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regarding_letter")]
        public MicrosoftDynamicsCRMletter RegardingLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regarding_opportunity")]
        public MicrosoftDynamicsCRMopportunity RegardingOpportunity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regarding_phonecall")]
        public MicrosoftDynamicsCRMphonecall RegardingPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regarding_quote")]
        public MicrosoftDynamicsCRMquote RegardingQuote { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regarding_salesorder")]
        public MicrosoftDynamicsCRMsalesorder RegardingSalesorder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regarding_serviceappointment")]
        public MicrosoftDynamicsCRMserviceappointment RegardingServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regarding_socialactivity")]
        public MicrosoftDynamicsCRMsocialactivity RegardingSocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regarding_task")]
        public MicrosoftDynamicsCRMtask RegardingTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slakpiinstance_incident_firstresponsebykpi")]
        public IList<MicrosoftDynamicsCRMincident> SlakpiinstanceIncidentFirstresponsebykpi { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slakpiinstance_incident_resolvebykpi")]
        public IList<MicrosoftDynamicsCRMincident> SlakpiinstanceIncidentResolvebykpi { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slakpiinstanceid")]
        public string Slakpiinstanceid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public int? Status { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "succeededon")]
        public System.DateTimeOffset? Succeededon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public object Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "warningtime")]
        public System.DateTimeOffset? Warningtime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "warningtimereached")]
        public int? Warningtimereached { get; set; }

    }
}
