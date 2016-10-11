using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ININ.PureCloudApi.Model
{
    /// <summary>
    /// Campaign
    /// </summary>
    [DataContract]
    public partial class Campaign :  IEquatable<Campaign>
    {
        /// <summary>
        /// dialing mode of the campaign
        /// </summary>
        /// <value>dialing mode of the campaign</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DialingModeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Agentless for "agentless"
            /// </summary>
            [EnumMember(Value = "agentless")]
            Agentless,
            
            /// <summary>
            /// Enum Preview for "preview"
            /// </summary>
            [EnumMember(Value = "preview")]
            Preview,
            
            /// <summary>
            /// Enum Power for "power"
            /// </summary>
            [EnumMember(Value = "power")]
            Power,
            
            /// <summary>
            /// Enum Predictive for "predictive"
            /// </summary>
            [EnumMember(Value = "predictive")]
            Predictive,
            
            /// <summary>
            /// Enum Progressive for "progressive"
            /// </summary>
            [EnumMember(Value = "progressive")]
            Progressive
        }
        /// <summary>
        /// dialing mode of the campaign
        /// </summary>
        /// <value>dialing mode of the campaign</value>
        [DataMember(Name="dialingMode", EmitDefaultValue=false)]
        public DialingModeEnum? DialingMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Campaign" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Campaign() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Campaign" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
        /// <param name="ContactList">identifier of the contact list for the campaign (required).</param>
        /// <param name="Queue">identifier of the agent assignment queue, required for all dialing modes other than agentless (required).</param>
        /// <param name="DialingMode">dialing mode of the campaign (required).</param>
        /// <param name="Script">identifier of the campaign script, required for all dialing modes other than agentless (required).</param>
        /// <param name="EdgeGroup">identifier of the edge group, required for all dialing modes other than preview (required).</param>
        /// <param name="CampaignStatus">status of the campaign; can be set to &#39;on&#39; or &#39;off&#39; (required).</param>
        /// <param name="PhoneColumns">the contact list phone columns to be called for the campaign (required).</param>
        /// <param name="AbandonRate">the targeted abandon rate percentage.</param>
        /// <param name="DncLists">identifiers of the do not call lists.</param>
        /// <param name="CallableTimeSet">the identifier of the callable time set.</param>
        /// <param name="CallAnalysisResponseSet">the identifier of the call analysis response set, required for all dialing modes other than preview (required).</param>
        /// <param name="Errors">a list of current error conditions associated with the campaign.</param>
        /// <param name="CallerName">caller id name to be displayed on the outbound call.</param>
        /// <param name="CallerAddress">caller id phone number to be displayed on the outbound call.</param>
        /// <param name="OutboundLineCount">for agentless campaigns, the number of outbound lines to be concurrently dialed.</param>
        /// <param name="RuleSets">identifiers of the rule sets.</param>
        /// <param name="SkipPreviewDisabled">for preview campaigns, indicator of whether the agent can skip a preview without placing a call (default to false).</param>
        /// <param name="PreviewTimeOutSeconds">for preview campaigns, number of seconds before a call will be automatically placed. A value of 0 indicates no automatic placement of calls.</param>
        /// <param name="ContactSort">information determining the order in which the contacts will be dialed.</param>
        /// <param name="NoAnswerTimeout">for non-preview campaigns, how long to wait before dispositioning as &#39;no-answer&#39;, default 30 seconds.</param>
        /// <param name="CallAnalysisLanguage">The language the edge will use to analyse the call.</param>
        /// <param name="Priority">The priority of this campaign relative to other campaigns.</param>
        public Campaign(string Name = null, int? Version = null, UriReference ContactList = null, UriReference Queue = null, DialingModeEnum? DialingMode = null, UriReference Script = null, UriReference EdgeGroup = null, string CampaignStatus = null, List<PhoneColumn> PhoneColumns = null, double? AbandonRate = null, List<UriReference> DncLists = null, UriReference CallableTimeSet = null, UriReference CallAnalysisResponseSet = null, List<RestErrorDetail> Errors = null, string CallerName = null, string CallerAddress = null, int? OutboundLineCount = null, List<UriReference> RuleSets = null, bool? SkipPreviewDisabled = null, long? PreviewTimeOutSeconds = null, ContactSort ContactSort = null, int? NoAnswerTimeout = null, string CallAnalysisLanguage = null, int? Priority = null)
        {
            // to ensure "ContactList" is required (not null)
            if (ContactList == null)
            {
                throw new InvalidDataException("ContactList is a required property for Campaign and cannot be null");
            }
            else
            {
                this.ContactList = ContactList;
            }
            // to ensure "Queue" is required (not null)
            if (Queue == null)
            {
                throw new InvalidDataException("Queue is a required property for Campaign and cannot be null");
            }
            else
            {
                this.Queue = Queue;
            }
            // to ensure "DialingMode" is required (not null)
            if (DialingMode == null)
            {
                throw new InvalidDataException("DialingMode is a required property for Campaign and cannot be null");
            }
            else
            {
                this.DialingMode = DialingMode;
            }
            // to ensure "Script" is required (not null)
            if (Script == null)
            {
                throw new InvalidDataException("Script is a required property for Campaign and cannot be null");
            }
            else
            {
                this.Script = Script;
            }
            // to ensure "EdgeGroup" is required (not null)
            if (EdgeGroup == null)
            {
                throw new InvalidDataException("EdgeGroup is a required property for Campaign and cannot be null");
            }
            else
            {
                this.EdgeGroup = EdgeGroup;
            }
            // to ensure "CampaignStatus" is required (not null)
            if (CampaignStatus == null)
            {
                throw new InvalidDataException("CampaignStatus is a required property for Campaign and cannot be null");
            }
            else
            {
                this.CampaignStatus = CampaignStatus;
            }
            // to ensure "PhoneColumns" is required (not null)
            if (PhoneColumns == null)
            {
                throw new InvalidDataException("PhoneColumns is a required property for Campaign and cannot be null");
            }
            else
            {
                this.PhoneColumns = PhoneColumns;
            }
            // to ensure "CallAnalysisResponseSet" is required (not null)
            if (CallAnalysisResponseSet == null)
            {
                throw new InvalidDataException("CallAnalysisResponseSet is a required property for Campaign and cannot be null");
            }
            else
            {
                this.CallAnalysisResponseSet = CallAnalysisResponseSet;
            }
            this.Name = Name;
            this.Version = Version;
            this.AbandonRate = AbandonRate;
            this.DncLists = DncLists;
            this.CallableTimeSet = CallableTimeSet;
            this.Errors = Errors;
            this.CallerName = CallerName;
            this.CallerAddress = CallerAddress;
            this.OutboundLineCount = OutboundLineCount;
            this.RuleSets = RuleSets;
            // use default value if no "SkipPreviewDisabled" provided
            if (SkipPreviewDisabled == null)
            {
                this.SkipPreviewDisabled = false;
            }
            else
            {
                this.SkipPreviewDisabled = SkipPreviewDisabled;
            }
            this.PreviewTimeOutSeconds = PreviewTimeOutSeconds;
            this.ContactSort = ContactSort;
            this.NoAnswerTimeout = NoAnswerTimeout;
            this.CallAnalysisLanguage = CallAnalysisLanguage;
            this.Priority = Priority;
        }
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; private set; }
        /// <summary>
        /// Required for updates, must match the version number of the most recent update
        /// </summary>
        /// <value>Required for updates, must match the version number of the most recent update</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
        /// <summary>
        /// identifier of the contact list for the campaign
        /// </summary>
        /// <value>identifier of the contact list for the campaign</value>
        [DataMember(Name="contactList", EmitDefaultValue=false)]
        public UriReference ContactList { get; set; }
        /// <summary>
        /// identifier of the agent assignment queue, required for all dialing modes other than agentless
        /// </summary>
        /// <value>identifier of the agent assignment queue, required for all dialing modes other than agentless</value>
        [DataMember(Name="queue", EmitDefaultValue=false)]
        public UriReference Queue { get; set; }
        /// <summary>
        /// identifier of the campaign script, required for all dialing modes other than agentless
        /// </summary>
        /// <value>identifier of the campaign script, required for all dialing modes other than agentless</value>
        [DataMember(Name="script", EmitDefaultValue=false)]
        public UriReference Script { get; set; }
        /// <summary>
        /// identifier of the edge group, required for all dialing modes other than preview
        /// </summary>
        /// <value>identifier of the edge group, required for all dialing modes other than preview</value>
        [DataMember(Name="edgeGroup", EmitDefaultValue=false)]
        public UriReference EdgeGroup { get; set; }
        /// <summary>
        /// status of the campaign; can be set to &#39;on&#39; or &#39;off&#39;
        /// </summary>
        /// <value>status of the campaign; can be set to &#39;on&#39; or &#39;off&#39;</value>
        [DataMember(Name="campaignStatus", EmitDefaultValue=false)]
        public string CampaignStatus { get; set; }
        /// <summary>
        /// the contact list phone columns to be called for the campaign
        /// </summary>
        /// <value>the contact list phone columns to be called for the campaign</value>
        [DataMember(Name="phoneColumns", EmitDefaultValue=false)]
        public List<PhoneColumn> PhoneColumns { get; set; }
        /// <summary>
        /// the targeted abandon rate percentage
        /// </summary>
        /// <value>the targeted abandon rate percentage</value>
        [DataMember(Name="abandonRate", EmitDefaultValue=false)]
        public double? AbandonRate { get; set; }
        /// <summary>
        /// identifiers of the do not call lists
        /// </summary>
        /// <value>identifiers of the do not call lists</value>
        [DataMember(Name="dncLists", EmitDefaultValue=false)]
        public List<UriReference> DncLists { get; set; }
        /// <summary>
        /// the identifier of the callable time set
        /// </summary>
        /// <value>the identifier of the callable time set</value>
        [DataMember(Name="callableTimeSet", EmitDefaultValue=false)]
        public UriReference CallableTimeSet { get; set; }
        /// <summary>
        /// the identifier of the call analysis response set, required for all dialing modes other than preview
        /// </summary>
        /// <value>the identifier of the call analysis response set, required for all dialing modes other than preview</value>
        [DataMember(Name="callAnalysisResponseSet", EmitDefaultValue=false)]
        public UriReference CallAnalysisResponseSet { get; set; }
        /// <summary>
        /// a list of current error conditions associated with the campaign
        /// </summary>
        /// <value>a list of current error conditions associated with the campaign</value>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<RestErrorDetail> Errors { get; set; }
        /// <summary>
        /// caller id name to be displayed on the outbound call
        /// </summary>
        /// <value>caller id name to be displayed on the outbound call</value>
        [DataMember(Name="callerName", EmitDefaultValue=false)]
        public string CallerName { get; set; }
        /// <summary>
        /// caller id phone number to be displayed on the outbound call
        /// </summary>
        /// <value>caller id phone number to be displayed on the outbound call</value>
        [DataMember(Name="callerAddress", EmitDefaultValue=false)]
        public string CallerAddress { get; set; }
        /// <summary>
        /// for agentless campaigns, the number of outbound lines to be concurrently dialed
        /// </summary>
        /// <value>for agentless campaigns, the number of outbound lines to be concurrently dialed</value>
        [DataMember(Name="outboundLineCount", EmitDefaultValue=false)]
        public int? OutboundLineCount { get; set; }
        /// <summary>
        /// identifiers of the rule sets
        /// </summary>
        /// <value>identifiers of the rule sets</value>
        [DataMember(Name="ruleSets", EmitDefaultValue=false)]
        public List<UriReference> RuleSets { get; set; }
        /// <summary>
        /// for preview campaigns, indicator of whether the agent can skip a preview without placing a call
        /// </summary>
        /// <value>for preview campaigns, indicator of whether the agent can skip a preview without placing a call</value>
        [DataMember(Name="skipPreviewDisabled", EmitDefaultValue=false)]
        public bool? SkipPreviewDisabled { get; set; }
        /// <summary>
        /// for preview campaigns, number of seconds before a call will be automatically placed. A value of 0 indicates no automatic placement of calls
        /// </summary>
        /// <value>for preview campaigns, number of seconds before a call will be automatically placed. A value of 0 indicates no automatic placement of calls</value>
        [DataMember(Name="previewTimeOutSeconds", EmitDefaultValue=false)]
        public long? PreviewTimeOutSeconds { get; set; }
        /// <summary>
        /// information determining the order in which the contacts will be dialed
        /// </summary>
        /// <value>information determining the order in which the contacts will be dialed</value>
        [DataMember(Name="contactSort", EmitDefaultValue=false)]
        public ContactSort ContactSort { get; set; }
        /// <summary>
        /// for non-preview campaigns, how long to wait before dispositioning as &#39;no-answer&#39;, default 30 seconds
        /// </summary>
        /// <value>for non-preview campaigns, how long to wait before dispositioning as &#39;no-answer&#39;, default 30 seconds</value>
        [DataMember(Name="noAnswerTimeout", EmitDefaultValue=false)]
        public int? NoAnswerTimeout { get; set; }
        /// <summary>
        /// The language the edge will use to analyse the call
        /// </summary>
        /// <value>The language the edge will use to analyse the call</value>
        [DataMember(Name="callAnalysisLanguage", EmitDefaultValue=false)]
        public string CallAnalysisLanguage { get; set; }
        /// <summary>
        /// The priority of this campaign relative to other campaigns
        /// </summary>
        /// <value>The priority of this campaign relative to other campaigns</value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int? Priority { get; set; }
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Campaign {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  ContactList: ").Append(ContactList).Append("\n");
            sb.Append("  Queue: ").Append(Queue).Append("\n");
            sb.Append("  DialingMode: ").Append(DialingMode).Append("\n");
            sb.Append("  Script: ").Append(Script).Append("\n");
            sb.Append("  EdgeGroup: ").Append(EdgeGroup).Append("\n");
            sb.Append("  CampaignStatus: ").Append(CampaignStatus).Append("\n");
            sb.Append("  PhoneColumns: ").Append(PhoneColumns).Append("\n");
            sb.Append("  AbandonRate: ").Append(AbandonRate).Append("\n");
            sb.Append("  DncLists: ").Append(DncLists).Append("\n");
            sb.Append("  CallableTimeSet: ").Append(CallableTimeSet).Append("\n");
            sb.Append("  CallAnalysisResponseSet: ").Append(CallAnalysisResponseSet).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  CallerName: ").Append(CallerName).Append("\n");
            sb.Append("  CallerAddress: ").Append(CallerAddress).Append("\n");
            sb.Append("  OutboundLineCount: ").Append(OutboundLineCount).Append("\n");
            sb.Append("  RuleSets: ").Append(RuleSets).Append("\n");
            sb.Append("  SkipPreviewDisabled: ").Append(SkipPreviewDisabled).Append("\n");
            sb.Append("  PreviewTimeOutSeconds: ").Append(PreviewTimeOutSeconds).Append("\n");
            sb.Append("  ContactSort: ").Append(ContactSort).Append("\n");
            sb.Append("  NoAnswerTimeout: ").Append(NoAnswerTimeout).Append("\n");
            sb.Append("  CallAnalysisLanguage: ").Append(CallAnalysisLanguage).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Campaign);
        }

        /// <summary>
        /// Returns true if Campaign instances are equal
        /// </summary>
        /// <param name="other">Instance of Campaign to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Campaign other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.ContactList == other.ContactList ||
                    this.ContactList != null &&
                    this.ContactList.Equals(other.ContactList)
                ) &&
                (
                    this.Queue == other.Queue ||
                    this.Queue != null &&
                    this.Queue.Equals(other.Queue)
                ) &&
                (
                    this.DialingMode == other.DialingMode ||
                    this.DialingMode != null &&
                    this.DialingMode.Equals(other.DialingMode)
                ) &&
                (
                    this.Script == other.Script ||
                    this.Script != null &&
                    this.Script.Equals(other.Script)
                ) &&
                (
                    this.EdgeGroup == other.EdgeGroup ||
                    this.EdgeGroup != null &&
                    this.EdgeGroup.Equals(other.EdgeGroup)
                ) &&
                (
                    this.CampaignStatus == other.CampaignStatus ||
                    this.CampaignStatus != null &&
                    this.CampaignStatus.Equals(other.CampaignStatus)
                ) &&
                (
                    this.PhoneColumns == other.PhoneColumns ||
                    this.PhoneColumns != null &&
                    this.PhoneColumns.SequenceEqual(other.PhoneColumns)
                ) &&
                (
                    this.AbandonRate == other.AbandonRate ||
                    this.AbandonRate != null &&
                    this.AbandonRate.Equals(other.AbandonRate)
                ) &&
                (
                    this.DncLists == other.DncLists ||
                    this.DncLists != null &&
                    this.DncLists.SequenceEqual(other.DncLists)
                ) &&
                (
                    this.CallableTimeSet == other.CallableTimeSet ||
                    this.CallableTimeSet != null &&
                    this.CallableTimeSet.Equals(other.CallableTimeSet)
                ) &&
                (
                    this.CallAnalysisResponseSet == other.CallAnalysisResponseSet ||
                    this.CallAnalysisResponseSet != null &&
                    this.CallAnalysisResponseSet.Equals(other.CallAnalysisResponseSet)
                ) &&
                (
                    this.Errors == other.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(other.Errors)
                ) &&
                (
                    this.CallerName == other.CallerName ||
                    this.CallerName != null &&
                    this.CallerName.Equals(other.CallerName)
                ) &&
                (
                    this.CallerAddress == other.CallerAddress ||
                    this.CallerAddress != null &&
                    this.CallerAddress.Equals(other.CallerAddress)
                ) &&
                (
                    this.OutboundLineCount == other.OutboundLineCount ||
                    this.OutboundLineCount != null &&
                    this.OutboundLineCount.Equals(other.OutboundLineCount)
                ) &&
                (
                    this.RuleSets == other.RuleSets ||
                    this.RuleSets != null &&
                    this.RuleSets.SequenceEqual(other.RuleSets)
                ) &&
                (
                    this.SkipPreviewDisabled == other.SkipPreviewDisabled ||
                    this.SkipPreviewDisabled != null &&
                    this.SkipPreviewDisabled.Equals(other.SkipPreviewDisabled)
                ) &&
                (
                    this.PreviewTimeOutSeconds == other.PreviewTimeOutSeconds ||
                    this.PreviewTimeOutSeconds != null &&
                    this.PreviewTimeOutSeconds.Equals(other.PreviewTimeOutSeconds)
                ) &&
                (
                    this.ContactSort == other.ContactSort ||
                    this.ContactSort != null &&
                    this.ContactSort.Equals(other.ContactSort)
                ) &&
                (
                    this.NoAnswerTimeout == other.NoAnswerTimeout ||
                    this.NoAnswerTimeout != null &&
                    this.NoAnswerTimeout.Equals(other.NoAnswerTimeout)
                ) &&
                (
                    this.CallAnalysisLanguage == other.CallAnalysisLanguage ||
                    this.CallAnalysisLanguage != null &&
                    this.CallAnalysisLanguage.Equals(other.CallAnalysisLanguage)
                ) &&
                (
                    this.Priority == other.Priority ||
                    this.Priority != null &&
                    this.Priority.Equals(other.Priority)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();
                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                if (this.ContactList != null)
                    hash = hash * 59 + this.ContactList.GetHashCode();
                if (this.Queue != null)
                    hash = hash * 59 + this.Queue.GetHashCode();
                if (this.DialingMode != null)
                    hash = hash * 59 + this.DialingMode.GetHashCode();
                if (this.Script != null)
                    hash = hash * 59 + this.Script.GetHashCode();
                if (this.EdgeGroup != null)
                    hash = hash * 59 + this.EdgeGroup.GetHashCode();
                if (this.CampaignStatus != null)
                    hash = hash * 59 + this.CampaignStatus.GetHashCode();
                if (this.PhoneColumns != null)
                    hash = hash * 59 + this.PhoneColumns.GetHashCode();
                if (this.AbandonRate != null)
                    hash = hash * 59 + this.AbandonRate.GetHashCode();
                if (this.DncLists != null)
                    hash = hash * 59 + this.DncLists.GetHashCode();
                if (this.CallableTimeSet != null)
                    hash = hash * 59 + this.CallableTimeSet.GetHashCode();
                if (this.CallAnalysisResponseSet != null)
                    hash = hash * 59 + this.CallAnalysisResponseSet.GetHashCode();
                if (this.Errors != null)
                    hash = hash * 59 + this.Errors.GetHashCode();
                if (this.CallerName != null)
                    hash = hash * 59 + this.CallerName.GetHashCode();
                if (this.CallerAddress != null)
                    hash = hash * 59 + this.CallerAddress.GetHashCode();
                if (this.OutboundLineCount != null)
                    hash = hash * 59 + this.OutboundLineCount.GetHashCode();
                if (this.RuleSets != null)
                    hash = hash * 59 + this.RuleSets.GetHashCode();
                if (this.SkipPreviewDisabled != null)
                    hash = hash * 59 + this.SkipPreviewDisabled.GetHashCode();
                if (this.PreviewTimeOutSeconds != null)
                    hash = hash * 59 + this.PreviewTimeOutSeconds.GetHashCode();
                if (this.ContactSort != null)
                    hash = hash * 59 + this.ContactSort.GetHashCode();
                if (this.NoAnswerTimeout != null)
                    hash = hash * 59 + this.NoAnswerTimeout.GetHashCode();
                if (this.CallAnalysisLanguage != null)
                    hash = hash * 59 + this.CallAnalysisLanguage.GetHashCode();
                if (this.Priority != null)
                    hash = hash * 59 + this.Priority.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }
    }

}
