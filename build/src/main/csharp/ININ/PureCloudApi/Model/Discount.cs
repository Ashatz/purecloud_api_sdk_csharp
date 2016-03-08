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
    public partial class Discount :  IEquatable<Discount>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Discount" /> class.
        /// Initializes a new instance of the <see cref="Discount" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="AnnualPrePay">AnnualPrePay (default to false).</param>
        /// <param name="Discount">Discount.</param>
        /// <param name="Maximum">Maximum.</param>
        /// <param name="Minimum">Minimum.</param>
        /// <param name="ProductCategory">ProductCategory.</param>

        public Discount(string Name = null, bool? AnnualPrePay = null, string Discount = null, string Maximum = null, string Minimum = null, string ProductCategory = null, )
        {
            this.Name = Name;
            // use default value if no "AnnualPrePay" provided
            if (AnnualPrePay == null)
            {
                this.AnnualPrePay = false;
            }
            else
            {
                this.AnnualPrePay = AnnualPrePay;
            }
            this.Discount = Discount;
            this.Maximum = Maximum;
            this.Minimum = Minimum;
            this.ProductCategory = ProductCategory;
            
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
        /// Gets or Sets AnnualPrePay
        /// </summary>
        [DataMember(Name="annualPrePay", EmitDefaultValue=false)]
        public bool? AnnualPrePay { get; set; }
    
        /// <summary>
        /// Gets or Sets Discount
        /// </summary>
        [DataMember(Name="discount", EmitDefaultValue=false)]
        public string Discount { get; set; }
    
        /// <summary>
        /// Gets or Sets Maximum
        /// </summary>
        [DataMember(Name="maximum", EmitDefaultValue=false)]
        public string Maximum { get; set; }
    
        /// <summary>
        /// Gets or Sets Minimum
        /// </summary>
        [DataMember(Name="minimum", EmitDefaultValue=false)]
        public string Minimum { get; set; }
    
        /// <summary>
        /// Gets or Sets ProductCategory
        /// </summary>
        [DataMember(Name="productCategory", EmitDefaultValue=false)]
        public string ProductCategory { get; set; }
    
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
            sb.Append("class Discount {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AnnualPrePay: ").Append(AnnualPrePay).Append("\n");
            sb.Append("  Discount: ").Append(Discount).Append("\n");
            sb.Append("  Maximum: ").Append(Maximum).Append("\n");
            sb.Append("  Minimum: ").Append(Minimum).Append("\n");
            sb.Append("  ProductCategory: ").Append(ProductCategory).Append("\n");
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
            return this.Equals(obj as Discount);
        }

        /// <summary>
        /// Returns true if Discount instances are equal
        /// </summary>
        /// <param name="other">Instance of Discount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Discount other)
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
                    this.AnnualPrePay == other.AnnualPrePay ||
                    this.AnnualPrePay != null &&
                    this.AnnualPrePay.Equals(other.AnnualPrePay)
                ) && 
                (
                    this.Discount == other.Discount ||
                    this.Discount != null &&
                    this.Discount.Equals(other.Discount)
                ) && 
                (
                    this.Maximum == other.Maximum ||
                    this.Maximum != null &&
                    this.Maximum.Equals(other.Maximum)
                ) && 
                (
                    this.Minimum == other.Minimum ||
                    this.Minimum != null &&
                    this.Minimum.Equals(other.Minimum)
                ) && 
                (
                    this.ProductCategory == other.ProductCategory ||
                    this.ProductCategory != null &&
                    this.ProductCategory.Equals(other.ProductCategory)
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
                
                if (this.AnnualPrePay != null)
                    hash = hash * 59 + this.AnnualPrePay.GetHashCode();
                
                if (this.Discount != null)
                    hash = hash * 59 + this.Discount.GetHashCode();
                
                if (this.Maximum != null)
                    hash = hash * 59 + this.Maximum.GetHashCode();
                
                if (this.Minimum != null)
                    hash = hash * 59 + this.Minimum.GetHashCode();
                
                if (this.ProductCategory != null)
                    hash = hash * 59 + this.ProductCategory.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }

    }
}
