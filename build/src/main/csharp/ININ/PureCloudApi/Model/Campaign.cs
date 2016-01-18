using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;



namespace ININ.PureCloudApi.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class Campaign :  IEquatable<Campaign>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Campaign" /> class.
        /// </summary>
        public Campaign()
        {
            this.SkipPreviewDisabled = false;
            this.SingleNumberPreview = false;
            
        }

        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }
  
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
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
  
        
        /// <summary>
        /// Gets or Sets SkipPreviewDisabled
        /// </summary>
        [DataMember(Name="skipPreviewDisabled", EmitDefaultValue=false)]
        public bool? SkipPreviewDisabled { get; set; }
  
        
        /// <summary>
        /// Gets or Sets PreviewTimeOutSeconds
        /// </summary>
        [DataMember(Name="previewTimeOutSeconds", EmitDefaultValue=false)]
        public long? PreviewTimeOutSeconds { get; set; }
  
        
        /// <summary>
        /// Gets or Sets SingleNumberPreview
        /// </summary>
        [DataMember(Name="singleNumberPreview", EmitDefaultValue=false)]
        public bool? SingleNumberPreview { get; set; }
  
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; set; }
  
        
  
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
            sb.Append("  SingleNumberPreview: ").Append(SingleNumberPreview).Append("\n");
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
        /// <param name="obj">Instance of Campaign to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Campaign other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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
                    this.SingleNumberPreview == other.SingleNumberPreview ||
                    this.SingleNumberPreview != null &&
                    this.SingleNumberPreview.Equals(other.SingleNumberPreview)
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
                    hash = hash * 57 + this.Id.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 57 + this.Name.GetHashCode();
                
                if (this.DateCreated != null)
                    hash = hash * 57 + this.DateCreated.GetHashCode();
                
                if (this.DateModified != null)
                    hash = hash * 57 + this.DateModified.GetHashCode();
                
                if (this.Version != null)
                    hash = hash * 57 + this.Version.GetHashCode();
                
                if (this.ContactList != null)
                    hash = hash * 57 + this.ContactList.GetHashCode();
                
                if (this.Queue != null)
                    hash = hash * 57 + this.Queue.GetHashCode();
                
                if (this.DialingMode != null)
                    hash = hash * 57 + this.DialingMode.GetHashCode();
                
                if (this.Script != null)
                    hash = hash * 57 + this.Script.GetHashCode();
                
                if (this.EdgeGroup != null)
                    hash = hash * 57 + this.EdgeGroup.GetHashCode();
                
                if (this.CampaignStatus != null)
                    hash = hash * 57 + this.CampaignStatus.GetHashCode();
                
                if (this.PhoneColumns != null)
                    hash = hash * 57 + this.PhoneColumns.GetHashCode();
                
                if (this.AbandonRate != null)
                    hash = hash * 57 + this.AbandonRate.GetHashCode();
                
                if (this.DncLists != null)
                    hash = hash * 57 + this.DncLists.GetHashCode();
                
                if (this.CallableTimeSet != null)
                    hash = hash * 57 + this.CallableTimeSet.GetHashCode();
                
                if (this.CallAnalysisResponseSet != null)
                    hash = hash * 57 + this.CallAnalysisResponseSet.GetHashCode();
                
                if (this.Errors != null)
                    hash = hash * 57 + this.Errors.GetHashCode();
                
                if (this.CallerName != null)
                    hash = hash * 57 + this.CallerName.GetHashCode();
                
                if (this.CallerAddress != null)
                    hash = hash * 57 + this.CallerAddress.GetHashCode();
                
                if (this.OutboundLineCount != null)
                    hash = hash * 57 + this.OutboundLineCount.GetHashCode();
                
                if (this.RuleSets != null)
                    hash = hash * 57 + this.RuleSets.GetHashCode();
                
                if (this.SkipPreviewDisabled != null)
                    hash = hash * 57 + this.SkipPreviewDisabled.GetHashCode();
                
                if (this.PreviewTimeOutSeconds != null)
                    hash = hash * 57 + this.PreviewTimeOutSeconds.GetHashCode();
                
                if (this.SingleNumberPreview != null)
                    hash = hash * 57 + this.SingleNumberPreview.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 57 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }

    }


}
