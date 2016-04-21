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
    /// 
    /// </summary>
    [DataContract]
    public partial class Campaign :  IEquatable<Campaign>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Campaign" />class.
        /// </summary>
<<<<<<< HEAD
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="SelfUri">SelfUri.</param>
        /// <param name="PhoneNumberColumns">PhoneNumberColumns.</param>
        /// <param name="SkipPreviewDisabled">SkipPreviewDisabled (default to false).</param>
        /// <param name="PreviewTimeOutSeconds">PreviewTimeOutSeconds.</param>

        public Campaign(string Id = null, string Name = null, string SelfUri = null, List<PhoneNumberColumn> PhoneNumberColumns = null, bool? SkipPreviewDisabled = null, int? PreviewTimeOutSeconds = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.SelfUri = SelfUri;
            this.PhoneNumberColumns = PhoneNumberColumns;
=======
        /// <param name="Name">Name.</param>
        /// <param name="DateCreated">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="DateModified">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="Version">Version.</param>
        /// <param name="ContactList">ContactList.</param>
        /// <param name="Queue">Queue.</param>
        /// <param name="DialingMode">DialingMode.</param>
        /// <param name="Script">Script.</param>
        /// <param name="EdgeGroup">EdgeGroup.</param>
        /// <param name="CampaignStatus">CampaignStatus.</param>
        /// <param name="PhoneColumns">PhoneColumns.</param>
        /// <param name="AbandonRate">AbandonRate.</param>
        /// <param name="DncLists">DncLists.</param>
        /// <param name="CallableTimeSet">CallableTimeSet.</param>
        /// <param name="CallAnalysisResponseSet">CallAnalysisResponseSet.</param>
        /// <param name="Errors">Errors.</param>
        /// <param name="CallerName">CallerName.</param>
        /// <param name="CallerAddress">CallerAddress.</param>
        /// <param name="OutboundLineCount">OutboundLineCount.</param>
        /// <param name="RuleSets">RuleSets.</param>
        /// <param name="SkipPreviewDisabled">SkipPreviewDisabled (default to false).</param>
        /// <param name="PreviewTimeOutSeconds">PreviewTimeOutSeconds.</param>
        /// <param name="SingleNumberPreview">SingleNumberPreview (default to false).</param>
        /// <param name="ContactSort">ContactSort.</param>

        public Campaign(string Name = null, DateTime? DateCreated = null, DateTime? DateModified = null, int? Version = null, UriReference ContactList = null, UriReference Queue = null, string DialingMode = null, UriReference Script = null, UriReference EdgeGroup = null, string CampaignStatus = null, List<PhoneColumn> PhoneColumns = null, double? AbandonRate = null, List<UriReference> DncLists = null, UriReference CallableTimeSet = null, UriReference CallAnalysisResponseSet = null, List<RestErrorDetail> Errors = null, string CallerName = null, string CallerAddress = null, int? OutboundLineCount = null, List<UriReference> RuleSets = null, bool? SkipPreviewDisabled = null, long? PreviewTimeOutSeconds = null, bool? SingleNumberPreview = null, ContactSort ContactSort = null)
        {
            this.Name = Name;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.Version = Version;
            this.ContactList = ContactList;
            this.Queue = Queue;
            this.DialingMode = DialingMode;
            this.Script = Script;
            this.EdgeGroup = EdgeGroup;
            this.CampaignStatus = CampaignStatus;
            this.PhoneColumns = PhoneColumns;
            this.AbandonRate = AbandonRate;
            this.DncLists = DncLists;
            this.CallableTimeSet = CallableTimeSet;
            this.CallAnalysisResponseSet = CallAnalysisResponseSet;
            this.Errors = Errors;
            this.CallerName = CallerName;
            this.CallerAddress = CallerAddress;
            this.OutboundLineCount = OutboundLineCount;
            this.RuleSets = RuleSets;
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
=======
            // use default value if no "SingleNumberPreview" provided
            if (SingleNumberPreview == null)
            {
                this.SingleNumberPreview = false;
            }
            else
            {
                this.SingleNumberPreview = SingleNumberPreview;
            }
            this.ContactSort = ContactSort;
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

    
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
<<<<<<< HEAD
        public string Id { get; set; }
=======
        public string Id { get; private set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
<<<<<<< HEAD
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; set; }
=======
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
    
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
<<<<<<< HEAD
        [DataMember(Name="phoneNumberColumns", EmitDefaultValue=false)]
        public List<PhoneNumberColumn> PhoneNumberColumns { get; set; }
=======
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }
    
        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
    
        /// <summary>
        /// Gets or Sets ContactList
        /// </summary>
        [DataMember(Name="contactList", EmitDefaultValue=false)]
        public UriReference ContactList { get; set; }
    
        /// <summary>
        /// Gets or Sets Queue
        /// </summary>
        [DataMember(Name="queue", EmitDefaultValue=false)]
        public UriReference Queue { get; set; }
    
        /// <summary>
        /// Gets or Sets DialingMode
        /// </summary>
        [DataMember(Name="dialingMode", EmitDefaultValue=false)]
        public string DialingMode { get; set; }
    
        /// <summary>
        /// Gets or Sets Script
        /// </summary>
        [DataMember(Name="script", EmitDefaultValue=false)]
        public UriReference Script { get; set; }
    
        /// <summary>
        /// Gets or Sets EdgeGroup
        /// </summary>
        [DataMember(Name="edgeGroup", EmitDefaultValue=false)]
        public UriReference EdgeGroup { get; set; }
    
        /// <summary>
        /// Gets or Sets CampaignStatus
        /// </summary>
        [DataMember(Name="campaignStatus", EmitDefaultValue=false)]
        public string CampaignStatus { get; set; }
    
        /// <summary>
        /// Gets or Sets PhoneColumns
        /// </summary>
        [DataMember(Name="phoneColumns", EmitDefaultValue=false)]
        public List<PhoneColumn> PhoneColumns { get; set; }
    
        /// <summary>
        /// Gets or Sets AbandonRate
        /// </summary>
        [DataMember(Name="abandonRate", EmitDefaultValue=false)]
        public double? AbandonRate { get; set; }
    
        /// <summary>
        /// Gets or Sets DncLists
        /// </summary>
        [DataMember(Name="dncLists", EmitDefaultValue=false)]
        public List<UriReference> DncLists { get; set; }
    
        /// <summary>
        /// Gets or Sets CallableTimeSet
        /// </summary>
        [DataMember(Name="callableTimeSet", EmitDefaultValue=false)]
        public UriReference CallableTimeSet { get; set; }
    
        /// <summary>
        /// Gets or Sets CallAnalysisResponseSet
        /// </summary>
        [DataMember(Name="callAnalysisResponseSet", EmitDefaultValue=false)]
        public UriReference CallAnalysisResponseSet { get; set; }
    
        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<RestErrorDetail> Errors { get; set; }
    
        /// <summary>
        /// Gets or Sets CallerName
        /// </summary>
        [DataMember(Name="callerName", EmitDefaultValue=false)]
        public string CallerName { get; set; }
    
        /// <summary>
        /// Gets or Sets CallerAddress
        /// </summary>
        [DataMember(Name="callerAddress", EmitDefaultValue=false)]
        public string CallerAddress { get; set; }
    
        /// <summary>
        /// Gets or Sets OutboundLineCount
        /// </summary>
        [DataMember(Name="outboundLineCount", EmitDefaultValue=false)]
        public int? OutboundLineCount { get; set; }
    
        /// <summary>
        /// Gets or Sets RuleSets
        /// </summary>
        [DataMember(Name="ruleSets", EmitDefaultValue=false)]
        public List<UriReference> RuleSets { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
    
        /// <summary>
        /// Gets or Sets SkipPreviewDisabled
        /// </summary>
        [DataMember(Name="skipPreviewDisabled", EmitDefaultValue=false)]
        public bool? SkipPreviewDisabled { get; set; }
    
        /// <summary>
        /// Gets or Sets PreviewTimeOutSeconds
        /// </summary>
        [DataMember(Name="previewTimeOutSeconds", EmitDefaultValue=false)]
<<<<<<< HEAD
        public int? PreviewTimeOutSeconds { get; set; }
=======
        public long? PreviewTimeOutSeconds { get; set; }
    
        /// <summary>
        /// Gets or Sets SingleNumberPreview
        /// </summary>
        [DataMember(Name="singleNumberPreview", EmitDefaultValue=false)]
        public bool? SingleNumberPreview { get; set; }
    
        /// <summary>
        /// Gets or Sets ContactSort
        /// </summary>
        [DataMember(Name="contactSort", EmitDefaultValue=false)]
        public ContactSort ContactSort { get; set; }
    
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
    
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
<<<<<<< HEAD
=======
            sb.Append("  SingleNumberPreview: ").Append(SingleNumberPreview).Append("\n");
            sb.Append("  ContactSort: ").Append(ContactSort).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
                ) &&
                (
                    this.PhoneNumberColumns == other.PhoneNumberColumns ||
                    this.PhoneNumberColumns != null &&
                    this.PhoneNumberColumns.SequenceEqual(other.PhoneNumberColumns)
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
                    this.SingleNumberPreview == other.SingleNumberPreview ||
                    this.SingleNumberPreview != null &&
                    this.SingleNumberPreview.Equals(other.SingleNumberPreview)
                ) &&
                (
                    this.ContactSort == other.ContactSort ||
                    this.ContactSort != null &&
                    this.ContactSort.Equals(other.ContactSort)
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
<<<<<<< HEAD
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                if (this.PhoneNumberColumns != null)
                    hash = hash * 59 + this.PhoneNumberColumns.GetHashCode();
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                if (this.SkipPreviewDisabled != null)
                    hash = hash * 59 + this.SkipPreviewDisabled.GetHashCode();
                if (this.PreviewTimeOutSeconds != null)
                    hash = hash * 59 + this.PreviewTimeOutSeconds.GetHashCode();
<<<<<<< HEAD
=======
                if (this.SingleNumberPreview != null)
                    hash = hash * 59 + this.SingleNumberPreview.GetHashCode();
                if (this.ContactSort != null)
                    hash = hash * 59 + this.ContactSort.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                return hash;
            }
        }

    }
}
