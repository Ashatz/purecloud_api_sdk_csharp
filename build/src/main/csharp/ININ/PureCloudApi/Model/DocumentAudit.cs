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
    public partial class DocumentAudit :  IEquatable<DocumentAudit>
    { 
    
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LevelEnum {
            
            [EnumMember(Value = "USER")]
            User,
            
            [EnumMember(Value = "SYSTEM")]
            System
        }
    
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum {
            
            [EnumMember(Value = "SUCCESS")]
            Success,
            
            [EnumMember(Value = "FAILURE")]
            Failure
        }
    
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionContextEnum {
            
            [EnumMember(Value = "CREATE")]
            Create,
            
            [EnumMember(Value = "READ")]
            Read,
            
            [EnumMember(Value = "UPDATE")]
            Update,
            
            [EnumMember(Value = "DELETE")]
            Delete,
            
            [EnumMember(Value = "DOWNLOAD")]
            Download,
            
            [EnumMember(Value = "VIEW")]
            View,
            
            [EnumMember(Value = "UPLOAD")]
            Upload,
            
            [EnumMember(Value = "SAVE")]
            Save,
            
            [EnumMember(Value = "MOVE")]
            Move,
            
            [EnumMember(Value = "COPY")]
            Copy,
            
            [EnumMember(Value = "ADD")]
            Add,
            
            [EnumMember(Value = "REMOVE")]
            Remove,
            
            [EnumMember(Value = "RECEIVE")]
            Receive,
            
            [EnumMember(Value = "CONVERT")]
            Convert,
            
            [EnumMember(Value = "FAX")]
            Fax,
            
            [EnumMember(Value = "CREATE_COVERPAGE")]
            CreateCoverpage,
            
            [EnumMember(Value = "USER_ADD")]
            UserAdd,
            
            [EnumMember(Value = "USER_REMOVE")]
            UserRemove,
            
            [EnumMember(Value = "MEMBER_ADD")]
            MemberAdd,
            
            [EnumMember(Value = "MEMBER_REMOVE")]
            MemberRemove,
            
            [EnumMember(Value = "MEMBER_UPDATE")]
            MemberUpdate,
            
            [EnumMember(Value = "TAG_ADD")]
            TagAdd,
            
            [EnumMember(Value = "TAG_REMOVE")]
            TagRemove,
            
            [EnumMember(Value = "TAG_UPDATE")]
            TagUpdate,
            
            [EnumMember(Value = "ATTRIBUTE_ADD")]
            AttributeAdd,
            
            [EnumMember(Value = "ATTRIBUTE_REMOVE")]
            AttributeRemove,
            
            [EnumMember(Value = "ATTRIBUTE_UPDATE")]
            AttributeUpdate,
            
            [EnumMember(Value = "ATTRIBUTE_GROUP_INSTANCE_ADD")]
            AttributeGroupInstanceAdd,
            
            [EnumMember(Value = "ATTRIBUTE_GROUP_INSTANCE_REMOVE")]
            AttributeGroupInstanceRemove,
            
            [EnumMember(Value = "ATTRIBUTE_GROUP_INSTANCE_UPDATE")]
            AttributeGroupInstanceUpdate,
            
            [EnumMember(Value = "INDEX_SAVE")]
            IndexSave,
            
            [EnumMember(Value = "INDEX_DELETE")]
            IndexDelete,
            
            [EnumMember(Value = "INDEX_CREATE")]
            IndexCreate,
            
            [EnumMember(Value = "FILE_SAVE")]
            FileSave,
            
            [EnumMember(Value = "FILE_DELETE")]
            FileDelete,
            
            [EnumMember(Value = "FILE_READ")]
            FileRead,
            
            [EnumMember(Value = "THUMBNAIL_CREATE")]
            ThumbnailCreate,
            
            [EnumMember(Value = "TEXT_EXTRACT")]
            TextExtract,
            
            [EnumMember(Value = "SHARE_ADD")]
            ShareAdd,
            
            [EnumMember(Value = "SHARE_REMOVE")]
            ShareRemove,
            
            [EnumMember(Value = "VERSION_CREATE")]
            VersionCreate
        }
    
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum {
            
            [EnumMember(Value = "CREATE")]
            Create,
            
            [EnumMember(Value = "READ")]
            Read,
            
            [EnumMember(Value = "UPDATE")]
            Update,
            
            [EnumMember(Value = "DELETE")]
            Delete,
            
            [EnumMember(Value = "DOWNLOAD")]
            Download,
            
            [EnumMember(Value = "VIEW")]
            View,
            
            [EnumMember(Value = "UPLOAD")]
            Upload,
            
            [EnumMember(Value = "SAVE")]
            Save,
            
            [EnumMember(Value = "MOVE")]
            Move,
            
            [EnumMember(Value = "COPY")]
            Copy,
            
            [EnumMember(Value = "ADD")]
            Add,
            
            [EnumMember(Value = "REMOVE")]
            Remove,
            
            [EnumMember(Value = "RECEIVE")]
            Receive,
            
            [EnumMember(Value = "CONVERT")]
            Convert,
            
            [EnumMember(Value = "FAX")]
            Fax,
            
            [EnumMember(Value = "CREATE_COVERPAGE")]
            CreateCoverpage,
            
            [EnumMember(Value = "USER_ADD")]
            UserAdd,
            
            [EnumMember(Value = "USER_REMOVE")]
            UserRemove,
            
            [EnumMember(Value = "MEMBER_ADD")]
            MemberAdd,
            
            [EnumMember(Value = "MEMBER_REMOVE")]
            MemberRemove,
            
            [EnumMember(Value = "MEMBER_UPDATE")]
            MemberUpdate,
            
            [EnumMember(Value = "TAG_ADD")]
            TagAdd,
            
            [EnumMember(Value = "TAG_REMOVE")]
            TagRemove,
            
            [EnumMember(Value = "TAG_UPDATE")]
            TagUpdate,
            
            [EnumMember(Value = "ATTRIBUTE_ADD")]
            AttributeAdd,
            
            [EnumMember(Value = "ATTRIBUTE_REMOVE")]
            AttributeRemove,
            
            [EnumMember(Value = "ATTRIBUTE_UPDATE")]
            AttributeUpdate,
            
            [EnumMember(Value = "ATTRIBUTE_GROUP_INSTANCE_ADD")]
            AttributeGroupInstanceAdd,
            
            [EnumMember(Value = "ATTRIBUTE_GROUP_INSTANCE_REMOVE")]
            AttributeGroupInstanceRemove,
            
            [EnumMember(Value = "ATTRIBUTE_GROUP_INSTANCE_UPDATE")]
            AttributeGroupInstanceUpdate,
            
            [EnumMember(Value = "INDEX_SAVE")]
            IndexSave,
            
            [EnumMember(Value = "INDEX_DELETE")]
            IndexDelete,
            
            [EnumMember(Value = "INDEX_CREATE")]
            IndexCreate,
            
            [EnumMember(Value = "FILE_SAVE")]
            FileSave,
            
            [EnumMember(Value = "FILE_DELETE")]
            FileDelete,
            
            [EnumMember(Value = "FILE_READ")]
            FileRead,
            
            [EnumMember(Value = "THUMBNAIL_CREATE")]
            ThumbnailCreate,
            
            [EnumMember(Value = "TEXT_EXTRACT")]
            TextExtract,
            
            [EnumMember(Value = "SHARE_ADD")]
            ShareAdd,
            
            [EnumMember(Value = "SHARE_REMOVE")]
            ShareRemove,
            
            [EnumMember(Value = "VERSION_CREATE")]
            VersionCreate
        }
        
        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [DataMember(Name="level", EmitDefaultValue=false)]
        public LevelEnum? Level { get; set; }
    
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
    
        /// <summary>
        /// Gets or Sets ActionContext
        /// </summary>
        [DataMember(Name="actionContext", EmitDefaultValue=false)]
        public ActionContextEnum? ActionContext { get; set; }
    
        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionEnum? Action { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentAudit" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="User">User.</param>
        /// <param name="Workspace">Workspace.</param>
        /// <param name="TransactionId">TransactionId.</param>
        /// <param name="TransactionInitiator">TransactionInitiator (default to false).</param>
        /// <param name="Application">Application.</param>
        /// <param name="ServiceName">ServiceName.</param>
        /// <param name="Level">Level.</param>
        /// <param name="Timestamp">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="Status">Status.</param>
        /// <param name="ActionContext">ActionContext.</param>
        /// <param name="Action">Action.</param>
        /// <param name="Entity">Entity.</param>
        /// <param name="Changes">Changes.</param>

        public DocumentAudit(string Name = null, UriReference User = null, UriReference Workspace = null, string TransactionId = null, bool? TransactionInitiator = null, string Application = null, string ServiceName = null, LevelEnum? Level = null, DateTime? Timestamp = null, StatusEnum? Status = null, ActionContextEnum? ActionContext = null, ActionEnum? Action = null, AuditEntityReference Entity = null, List<AuditChange> Changes = null, )
        {
            this.Name = Name;
            this.User = User;
            this.Workspace = Workspace;
            this.TransactionId = TransactionId;
            // use default value if no "TransactionInitiator" provided
            if (TransactionInitiator == null)
            {
                this.TransactionInitiator = false;
            }
            else
            {
                this.TransactionInitiator = TransactionInitiator;
            }
            this.Application = Application;
            this.ServiceName = ServiceName;
            this.Level = Level;
            this.Timestamp = Timestamp;
            this.Status = Status;
            this.ActionContext = ActionContext;
            this.Action = Action;
            this.Entity = Entity;
            this.Changes = Changes;
            
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
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UriReference User { get; set; }
    
        /// <summary>
        /// Gets or Sets Workspace
        /// </summary>
        [DataMember(Name="workspace", EmitDefaultValue=false)]
        public UriReference Workspace { get; set; }
    
        /// <summary>
        /// Gets or Sets TransactionId
        /// </summary>
        [DataMember(Name="transactionId", EmitDefaultValue=false)]
        public string TransactionId { get; set; }
    
        /// <summary>
        /// Gets or Sets TransactionInitiator
        /// </summary>
        [DataMember(Name="transactionInitiator", EmitDefaultValue=false)]
        public bool? TransactionInitiator { get; set; }
    
        /// <summary>
        /// Gets or Sets Application
        /// </summary>
        [DataMember(Name="application", EmitDefaultValue=false)]
        public string Application { get; set; }
    
        /// <summary>
        /// Gets or Sets ServiceName
        /// </summary>
        [DataMember(Name="serviceName", EmitDefaultValue=false)]
        public string ServiceName { get; set; }
    
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }
    
        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        [DataMember(Name="entity", EmitDefaultValue=false)]
        public AuditEntityReference Entity { get; set; }
    
        /// <summary>
        /// Gets or Sets Changes
        /// </summary>
        [DataMember(Name="changes", EmitDefaultValue=false)]
        public List<AuditChange> Changes { get; set; }
    
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
            sb.Append("class DocumentAudit {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Workspace: ").Append(Workspace).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  TransactionInitiator: ").Append(TransactionInitiator).Append("\n");
            sb.Append("  Application: ").Append(Application).Append("\n");
            sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ActionContext: ").Append(ActionContext).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
            sb.Append("  Changes: ").Append(Changes).Append("\n");
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
            return this.Equals(obj as DocumentAudit);
        }

        /// <summary>
        /// Returns true if DocumentAudit instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentAudit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentAudit other)
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
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.Workspace == other.Workspace ||
                    this.Workspace != null &&
                    this.Workspace.Equals(other.Workspace)
                ) &&
                (
                    this.TransactionId == other.TransactionId ||
                    this.TransactionId != null &&
                    this.TransactionId.Equals(other.TransactionId)
                ) &&
                (
                    this.TransactionInitiator == other.TransactionInitiator ||
                    this.TransactionInitiator != null &&
                    this.TransactionInitiator.Equals(other.TransactionInitiator)
                ) &&
                (
                    this.Application == other.Application ||
                    this.Application != null &&
                    this.Application.Equals(other.Application)
                ) &&
                (
                    this.ServiceName == other.ServiceName ||
                    this.ServiceName != null &&
                    this.ServiceName.Equals(other.ServiceName)
                ) &&
                (
                    this.Level == other.Level ||
                    this.Level != null &&
                    this.Level.Equals(other.Level)
                ) &&
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.ActionContext == other.ActionContext ||
                    this.ActionContext != null &&
                    this.ActionContext.Equals(other.ActionContext)
                ) &&
                (
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
                ) &&
                (
                    this.Entity == other.Entity ||
                    this.Entity != null &&
                    this.Entity.Equals(other.Entity)
                ) &&
                (
                    this.Changes == other.Changes ||
                    this.Changes != null &&
                    this.Changes.SequenceEqual(other.Changes)
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
                
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                
                if (this.Workspace != null)
                    hash = hash * 59 + this.Workspace.GetHashCode();
                
                if (this.TransactionId != null)
                    hash = hash * 59 + this.TransactionId.GetHashCode();
                
                if (this.TransactionInitiator != null)
                    hash = hash * 59 + this.TransactionInitiator.GetHashCode();
                
                if (this.Application != null)
                    hash = hash * 59 + this.Application.GetHashCode();
                
                if (this.ServiceName != null)
                    hash = hash * 59 + this.ServiceName.GetHashCode();
                
                if (this.Level != null)
                    hash = hash * 59 + this.Level.GetHashCode();
                
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.ActionContext != null)
                    hash = hash * 59 + this.ActionContext.GetHashCode();
                
                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();
                
                if (this.Entity != null)
                    hash = hash * 59 + this.Entity.GetHashCode();
                
                if (this.Changes != null)
                    hash = hash * 59 + this.Changes.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }

    }
}
