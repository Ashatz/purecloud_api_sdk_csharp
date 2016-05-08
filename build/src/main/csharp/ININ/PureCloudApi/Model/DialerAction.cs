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
    public partial class DialerAction :  IEquatable<DialerAction>
    { 

        /// <summary>
        /// Type of the action
        /// </summary>
        /// <value>Type of the action</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum {
            
            [EnumMember(Value = "Action")]
            Action,
            
            [EnumMember(Value = "modifyContactAttribute")]
            Modifycontactattribute
        }


        /// <summary>
        /// Identifier of the action
        /// </summary>
        /// <value>Identifier of the action</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ActionTypeNameEnum {
            
            [EnumMember(Value = "DO_NOT_DIAL")]
            DoNotDial,
            
            [EnumMember(Value = "MODIFY_CONTACT_ATTRIBUTE")]
            ModifyContactAttribute,
            
            [EnumMember(Value = "SWITCH_TO_PREVIEW")]
            SwitchToPreview,
            
            [EnumMember(Value = "APPEND_NUMBER_TO_DNC_LIST")]
            AppendNumberToDncList,
            
            [EnumMember(Value = "SCHEDULE_CALLBACK")]
            ScheduleCallback
        }


        /// <summary>
        /// Indicator of the type of update action (applicable only to certain types of actions)
        /// </summary>
        /// <value>Indicator of the type of update action (applicable only to certain types of actions)</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum UpdateOptionEnum {
            
            [EnumMember(Value = "SET")]
            Set,
            
            [EnumMember(Value = "INCREMENT")]
            Increment,
            
            [EnumMember(Value = "DECREMENT")]
            Decrement,
            
            [EnumMember(Value = "CURRENT_TIME")]
            CurrentTime
        }

        

        /// <summary>
        /// Type of the action
        /// </summary>
        /// <value>Type of the action</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
    

        /// <summary>
        /// Identifier of the action
        /// </summary>
        /// <value>Identifier of the action</value>
        [DataMember(Name="actionTypeName", EmitDefaultValue=false)]
        public ActionTypeNameEnum? ActionTypeName { get; set; }
    

        /// <summary>
        /// Indicator of the type of update action (applicable only to certain types of actions)
        /// </summary>
        /// <value>Indicator of the type of update action (applicable only to certain types of actions)</value>
        [DataMember(Name="updateOption", EmitDefaultValue=false)]
        public UpdateOptionEnum? UpdateOption { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DialerAction" />class.
        /// </summary>
        /// <param name="Type">Type of the action (required).</param>
        /// <param name="ActionTypeName">Identifier of the action (required).</param>
        /// <param name="UpdateOption">Indicator of the type of update action (applicable only to certain types of actions).</param>
        /// <param name="Properties">Map of key-value pairs pertinent to the action (different actions require different properties).</param>

        public DialerAction(TypeEnum? Type = null, ActionTypeNameEnum? ActionTypeName = null, UpdateOptionEnum? UpdateOption = null, Dictionary<string, string> Properties = null)
        {
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for DialerAction and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            // to ensure "ActionTypeName" is required (not null)
            if (ActionTypeName == null)
            {
                throw new InvalidDataException("ActionTypeName is a required property for DialerAction and cannot be null");
            }
            else
            {
                this.ActionTypeName = ActionTypeName;
            }
            this.UpdateOption = UpdateOption;
            this.Properties = Properties;
            
        }

    
        /// <summary>
        /// Map of key-value pairs pertinent to the action (different actions require different properties)
        /// </summary>
        /// <value>Map of key-value pairs pertinent to the action (different actions require different properties)</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public Dictionary<string, string> Properties { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DialerAction {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ActionTypeName: ").Append(ActionTypeName).Append("\n");
            sb.Append("  UpdateOption: ").Append(UpdateOption).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
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
            return this.Equals(obj as DialerAction);
        }

        /// <summary>
        /// Returns true if DialerAction instances are equal
        /// </summary>
        /// <param name="other">Instance of DialerAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DialerAction other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.ActionTypeName == other.ActionTypeName ||
                    this.ActionTypeName != null &&
                    this.ActionTypeName.Equals(other.ActionTypeName)
                ) &&
                (
                    this.UpdateOption == other.UpdateOption ||
                    this.UpdateOption != null &&
                    this.UpdateOption.Equals(other.UpdateOption)
                ) &&
                (
                    this.Properties == other.Properties ||
                    this.Properties != null &&
                    this.Properties.SequenceEqual(other.Properties)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.ActionTypeName != null)
                    hash = hash * 59 + this.ActionTypeName.GetHashCode();
                if (this.UpdateOption != null)
                    hash = hash * 59 + this.UpdateOption.GetHashCode();
                if (this.Properties != null)
                    hash = hash * 59 + this.Properties.GetHashCode();
                return hash;
            }
        }

    }
}
