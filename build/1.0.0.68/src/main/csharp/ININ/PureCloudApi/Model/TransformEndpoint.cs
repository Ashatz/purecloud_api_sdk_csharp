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
    public class TransformEndpoint :  IEquatable<TransformEndpoint>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransformEndpoint" /> class.
        /// </summary>
        public TransformEndpoint()
        {
            this.Ready = false;
            this.Active = false;
            
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
        /// The Url to the swagger documentation of the endpoint where parsed entities will be posted
        /// </summary>
        /// <value>The Url to the swagger documentation of the endpoint where parsed entities will be posted</value>
        [DataMember(Name="swaggerUrl", EmitDefaultValue=false)]
        public string SwaggerUrl { get; set; }
  
        
        /// <summary>
        /// The swagger route to use
        /// </summary>
        /// <value>The swagger route to use</value>
        [DataMember(Name="route", EmitDefaultValue=false)]
        public string Route { get; set; }
  
        
        /// <summary>
        /// The entity type being posted
        /// </summary>
        /// <value>The entity type being posted</value>
        [DataMember(Name="entity", EmitDefaultValue=false)]
        public string Entity { get; set; }
  
        
        /// <summary>
        /// The swagger function being called
        /// </summary>
        /// <value>The swagger function being called</value>
        [DataMember(Name="apiFunction", EmitDefaultValue=false)]
        public string ApiFunction { get; set; }
  
        
        /// <summary>
        /// Whether this TransformEndpoint has been configured to work (security groups, permissions, etc)
        /// </summary>
        /// <value>Whether this TransformEndpoint has been configured to work (security groups, permissions, etc)</value>
        [DataMember(Name="ready", EmitDefaultValue=false)]
        public bool? Ready { get; set; }
  
        
        /// <summary>
        /// Whether this TransformEndpoint is currently active and accepting transformation operations
        /// </summary>
        /// <value>Whether this TransformEndpoint is currently active and accepting transformation operations</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }
  
        
        /// <summary>
        /// The number of entities to send in an array for batch POSTs, or 0 for unbatched POSTs
        /// </summary>
        /// <value>The number of entities to send in an array for batch POSTs, or 0 for unbatched POSTs</value>
        [DataMember(Name="batchSize", EmitDefaultValue=false)]
        public int? BatchSize { get; set; }
  
        
        /// <summary>
        /// The number of parallel POSTs to allow at once
        /// </summary>
        /// <value>The number of parallel POSTs to allow at once</value>
        [DataMember(Name="parallelism", EmitDefaultValue=false)]
        public int? Parallelism { get; set; }
  
        
        /// <summary>
        /// The swagger route to use
        /// </summary>
        /// <value>The swagger route to use</value>
        [DataMember(Name="updateProgressEvery", EmitDefaultValue=false)]
        public int? UpdateProgressEvery { get; set; }
  
        
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
            sb.Append("class TransformEndpoint {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SwaggerUrl: ").Append(SwaggerUrl).Append("\n");
            sb.Append("  Route: ").Append(Route).Append("\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
            sb.Append("  ApiFunction: ").Append(ApiFunction).Append("\n");
            sb.Append("  Ready: ").Append(Ready).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  BatchSize: ").Append(BatchSize).Append("\n");
            sb.Append("  Parallelism: ").Append(Parallelism).Append("\n");
            sb.Append("  UpdateProgressEvery: ").Append(UpdateProgressEvery).Append("\n");
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
            return this.Equals(obj as TransformEndpoint);
        }

        /// <summary>
        /// Returns true if TransformEndpoint instances are equal
        /// </summary>
        /// <param name="obj">Instance of TransformEndpoint to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransformEndpoint other)
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
                    this.SwaggerUrl == other.SwaggerUrl ||
                    this.SwaggerUrl != null &&
                    this.SwaggerUrl.Equals(other.SwaggerUrl)
                ) && 
                (
                    this.Route == other.Route ||
                    this.Route != null &&
                    this.Route.Equals(other.Route)
                ) && 
                (
                    this.Entity == other.Entity ||
                    this.Entity != null &&
                    this.Entity.Equals(other.Entity)
                ) && 
                (
                    this.ApiFunction == other.ApiFunction ||
                    this.ApiFunction != null &&
                    this.ApiFunction.Equals(other.ApiFunction)
                ) && 
                (
                    this.Ready == other.Ready ||
                    this.Ready != null &&
                    this.Ready.Equals(other.Ready)
                ) && 
                (
                    this.Active == other.Active ||
                    this.Active != null &&
                    this.Active.Equals(other.Active)
                ) && 
                (
                    this.BatchSize == other.BatchSize ||
                    this.BatchSize != null &&
                    this.BatchSize.Equals(other.BatchSize)
                ) && 
                (
                    this.Parallelism == other.Parallelism ||
                    this.Parallelism != null &&
                    this.Parallelism.Equals(other.Parallelism)
                ) && 
                (
                    this.UpdateProgressEvery == other.UpdateProgressEvery ||
                    this.UpdateProgressEvery != null &&
                    this.UpdateProgressEvery.Equals(other.UpdateProgressEvery)
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
                
                if (this.SwaggerUrl != null)
                    hash = hash * 57 + this.SwaggerUrl.GetHashCode();
                
                if (this.Route != null)
                    hash = hash * 57 + this.Route.GetHashCode();
                
                if (this.Entity != null)
                    hash = hash * 57 + this.Entity.GetHashCode();
                
                if (this.ApiFunction != null)
                    hash = hash * 57 + this.ApiFunction.GetHashCode();
                
                if (this.Ready != null)
                    hash = hash * 57 + this.Ready.GetHashCode();
                
                if (this.Active != null)
                    hash = hash * 57 + this.Active.GetHashCode();
                
                if (this.BatchSize != null)
                    hash = hash * 57 + this.BatchSize.GetHashCode();
                
                if (this.Parallelism != null)
                    hash = hash * 57 + this.Parallelism.GetHashCode();
                
                if (this.UpdateProgressEvery != null)
                    hash = hash * 57 + this.UpdateProgressEvery.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 57 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }

    }


}
