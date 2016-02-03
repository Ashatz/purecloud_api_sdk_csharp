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
    public class OAuthClient :  IEquatable<OAuthClient>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthClient" /> class.
        /// </summary>
        public OAuthClient()
        {
            
        }

        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
  
        
        /// <summary>
        /// The name of the OAuth client.
        /// </summary>
        /// <value>The name of the OAuth client.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// The number of seconds, between 5mins and 48hrs, until tokens created with this client expire. If this field is omitted, a default of 24 hours will be applied.
        /// </summary>
        /// <value>The number of seconds, between 5mins and 48hrs, until tokens created with this client expire. If this field is omitted, a default of 24 hours will be applied.</value>
        [DataMember(Name="accessTokenValiditySeconds", EmitDefaultValue=false)]
        public long? AccessTokenValiditySeconds { get; set; }
  
        
        /// <summary>
        /// One or more OAuth Grant/Client types supported by this client.
        /// </summary>
        /// <value>One or more OAuth Grant/Client types supported by this client.</value>
        [DataMember(Name="authorizedGrantTypes", EmitDefaultValue=false)]
        public List<string> AuthorizedGrantTypes { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
  
        
        /// <summary>
        /// List of allowed callbacks for this client. For example: https://myap.example.com/auth/callback
        /// </summary>
        /// <value>List of allowed callbacks for this client. For example: https://myap.example.com/auth/callback</value>
        [DataMember(Name="registeredRedirectUri", EmitDefaultValue=false)]
        public List<string> RegisteredRedirectUri { get; set; }
  
        
        /// <summary>
        /// System created secret assigned to this client. Secrets are required for code authorization grants.
        /// </summary>
        /// <value>System created secret assigned to this client. Secrets are required for code authorization grants.</value>
        [DataMember(Name="secret", EmitDefaultValue=false)]
        public string Secret { get; set; }
  
        
        /// <summary>
        /// Roles assigned to this client. Roles only apply to clients using the client_credential grant
        /// </summary>
        /// <value>Roles assigned to this client. Roles only apply to clients using the client_credential grant</value>
        [DataMember(Name="roleIds", EmitDefaultValue=false)]
        public List<string> RoleIds { get; set; }
  
        
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
            sb.Append("class OAuthClient {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AccessTokenValiditySeconds: ").Append(AccessTokenValiditySeconds).Append("\n");
            sb.Append("  AuthorizedGrantTypes: ").Append(AuthorizedGrantTypes).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  RegisteredRedirectUri: ").Append(RegisteredRedirectUri).Append("\n");
            sb.Append("  Secret: ").Append(Secret).Append("\n");
            sb.Append("  RoleIds: ").Append(RoleIds).Append("\n");
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
            return this.Equals(obj as OAuthClient);
        }

        /// <summary>
        /// Returns true if OAuthClient instances are equal
        /// </summary>
        /// <param name="obj">Instance of OAuthClient to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OAuthClient other)
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
                    this.AccessTokenValiditySeconds == other.AccessTokenValiditySeconds ||
                    this.AccessTokenValiditySeconds != null &&
                    this.AccessTokenValiditySeconds.Equals(other.AccessTokenValiditySeconds)
                ) && 
                (
                    this.AuthorizedGrantTypes == other.AuthorizedGrantTypes ||
                    this.AuthorizedGrantTypes != null &&
                    this.AuthorizedGrantTypes.SequenceEqual(other.AuthorizedGrantTypes)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.RegisteredRedirectUri == other.RegisteredRedirectUri ||
                    this.RegisteredRedirectUri != null &&
                    this.RegisteredRedirectUri.SequenceEqual(other.RegisteredRedirectUri)
                ) && 
                (
                    this.Secret == other.Secret ||
                    this.Secret != null &&
                    this.Secret.Equals(other.Secret)
                ) && 
                (
                    this.RoleIds == other.RoleIds ||
                    this.RoleIds != null &&
                    this.RoleIds.SequenceEqual(other.RoleIds)
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
                
                if (this.AccessTokenValiditySeconds != null)
                    hash = hash * 57 + this.AccessTokenValiditySeconds.GetHashCode();
                
                if (this.AuthorizedGrantTypes != null)
                    hash = hash * 57 + this.AuthorizedGrantTypes.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 57 + this.Description.GetHashCode();
                
                if (this.RegisteredRedirectUri != null)
                    hash = hash * 57 + this.RegisteredRedirectUri.GetHashCode();
                
                if (this.Secret != null)
                    hash = hash * 57 + this.Secret.GetHashCode();
                
                if (this.RoleIds != null)
                    hash = hash * 57 + this.RoleIds.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 57 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }

    }


}
