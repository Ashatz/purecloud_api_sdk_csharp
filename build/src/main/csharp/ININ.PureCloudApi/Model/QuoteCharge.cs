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
    /// QuoteCharge
    /// </summary>
    [DataContract]
    public partial class QuoteCharge :  IEquatable<QuoteCharge>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteCharge" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QuoteCharge() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteCharge" /> class.
        /// </summary>
        /// <param name="Id">The quote charge Id. (required).</param>
        /// <param name="Sku">The quote charge SKU. (required).</param>
        /// <param name="Name">The quote charge name. (required).</param>
        /// <param name="ChargeType">The quote charge type. (required).</param>
        /// <param name="Quantity">The quote charge quantity. (required).</param>
        /// <param name="ListTotal">The quote charge total price before discounts. (required).</param>
        /// <param name="Total">The quote charge total price after discounts. (required).</param>
        /// <param name="ListPriceDisplay">The quote charge list price before discounts. (required).</param>
        /// <param name="Discount">The quote charge discount percent. (required).</param>
        /// <param name="EffectivePrice">The quote charge list price after discounts. (required).</param>
        /// <param name="ProductShippable">Indicates whether the product can be shipped. (required) (default to false).</param>
        /// <param name="ShippingAddress">The quote shipping address. (required).</param>
        /// <param name="ForRelatedPart">The part number of a part related to the quote charge..</param>
        public QuoteCharge(string Id = null, string Sku = null, string Name = null, string ChargeType = null, int? Quantity = null, string ListTotal = null, string Total = null, string ListPriceDisplay = null, string Discount = null, string EffectivePrice = null, bool? ProductShippable = null, BillingAddress ShippingAddress = null, string ForRelatedPart = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for QuoteCharge and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Sku" is required (not null)
            if (Sku == null)
            {
                throw new InvalidDataException("Sku is a required property for QuoteCharge and cannot be null");
            }
            else
            {
                this.Sku = Sku;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for QuoteCharge and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "ChargeType" is required (not null)
            if (ChargeType == null)
            {
                throw new InvalidDataException("ChargeType is a required property for QuoteCharge and cannot be null");
            }
            else
            {
                this.ChargeType = ChargeType;
            }
            // to ensure "Quantity" is required (not null)
            if (Quantity == null)
            {
                throw new InvalidDataException("Quantity is a required property for QuoteCharge and cannot be null");
            }
            else
            {
                this.Quantity = Quantity;
            }
            // to ensure "ListTotal" is required (not null)
            if (ListTotal == null)
            {
                throw new InvalidDataException("ListTotal is a required property for QuoteCharge and cannot be null");
            }
            else
            {
                this.ListTotal = ListTotal;
            }
            // to ensure "Total" is required (not null)
            if (Total == null)
            {
                throw new InvalidDataException("Total is a required property for QuoteCharge and cannot be null");
            }
            else
            {
                this.Total = Total;
            }
            // to ensure "ListPriceDisplay" is required (not null)
            if (ListPriceDisplay == null)
            {
                throw new InvalidDataException("ListPriceDisplay is a required property for QuoteCharge and cannot be null");
            }
            else
            {
                this.ListPriceDisplay = ListPriceDisplay;
            }
            // to ensure "Discount" is required (not null)
            if (Discount == null)
            {
                throw new InvalidDataException("Discount is a required property for QuoteCharge and cannot be null");
            }
            else
            {
                this.Discount = Discount;
            }
            // to ensure "EffectivePrice" is required (not null)
            if (EffectivePrice == null)
            {
                throw new InvalidDataException("EffectivePrice is a required property for QuoteCharge and cannot be null");
            }
            else
            {
                this.EffectivePrice = EffectivePrice;
            }
            // to ensure "ProductShippable" is required (not null)
            if (ProductShippable == null)
            {
                throw new InvalidDataException("ProductShippable is a required property for QuoteCharge and cannot be null");
            }
            else
            {
                this.ProductShippable = ProductShippable;
            }
            // to ensure "ShippingAddress" is required (not null)
            if (ShippingAddress == null)
            {
                throw new InvalidDataException("ShippingAddress is a required property for QuoteCharge and cannot be null");
            }
            else
            {
                this.ShippingAddress = ShippingAddress;
            }
            this.ForRelatedPart = ForRelatedPart;
        }
        
        /// <summary>
        /// The quote charge Id.
        /// </summary>
        /// <value>The quote charge Id.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// The quote charge SKU.
        /// </summary>
        /// <value>The quote charge SKU.</value>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; set; }
        /// <summary>
        /// The quote charge name.
        /// </summary>
        /// <value>The quote charge name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The quote charge type.
        /// </summary>
        /// <value>The quote charge type.</value>
        [DataMember(Name="chargeType", EmitDefaultValue=false)]
        public string ChargeType { get; set; }
        /// <summary>
        /// The quote charge quantity.
        /// </summary>
        /// <value>The quote charge quantity.</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }
        /// <summary>
        /// The quote charge total price before discounts.
        /// </summary>
        /// <value>The quote charge total price before discounts.</value>
        [DataMember(Name="listTotal", EmitDefaultValue=false)]
        public string ListTotal { get; set; }
        /// <summary>
        /// The quote charge total price after discounts.
        /// </summary>
        /// <value>The quote charge total price after discounts.</value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public string Total { get; set; }
        /// <summary>
        /// The quote charge list price before discounts.
        /// </summary>
        /// <value>The quote charge list price before discounts.</value>
        [DataMember(Name="listPriceDisplay", EmitDefaultValue=false)]
        public string ListPriceDisplay { get; set; }
        /// <summary>
        /// The quote charge discount percent.
        /// </summary>
        /// <value>The quote charge discount percent.</value>
        [DataMember(Name="discount", EmitDefaultValue=false)]
        public string Discount { get; set; }
        /// <summary>
        /// The quote charge list price after discounts.
        /// </summary>
        /// <value>The quote charge list price after discounts.</value>
        [DataMember(Name="effectivePrice", EmitDefaultValue=false)]
        public string EffectivePrice { get; set; }
        /// <summary>
        /// Indicates whether the product can be shipped.
        /// </summary>
        /// <value>Indicates whether the product can be shipped.</value>
        [DataMember(Name="productShippable", EmitDefaultValue=false)]
        public bool? ProductShippable { get; set; }
        /// <summary>
        /// The quote shipping address.
        /// </summary>
        /// <value>The quote shipping address.</value>
        [DataMember(Name="shippingAddress", EmitDefaultValue=false)]
        public BillingAddress ShippingAddress { get; set; }
        /// <summary>
        /// The part number of a part related to the quote charge.
        /// </summary>
        /// <value>The part number of a part related to the quote charge.</value>
        [DataMember(Name="forRelatedPart", EmitDefaultValue=false)]
        public string ForRelatedPart { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuoteCharge {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ChargeType: ").Append(ChargeType).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  ListTotal: ").Append(ListTotal).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  ListPriceDisplay: ").Append(ListPriceDisplay).Append("\n");
            sb.Append("  Discount: ").Append(Discount).Append("\n");
            sb.Append("  EffectivePrice: ").Append(EffectivePrice).Append("\n");
            sb.Append("  ProductShippable: ").Append(ProductShippable).Append("\n");
            sb.Append("  ShippingAddress: ").Append(ShippingAddress).Append("\n");
            sb.Append("  ForRelatedPart: ").Append(ForRelatedPart).Append("\n");
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
            return this.Equals(obj as QuoteCharge);
        }

        /// <summary>
        /// Returns true if QuoteCharge instances are equal
        /// </summary>
        /// <param name="other">Instance of QuoteCharge to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuoteCharge other)
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
                    this.Sku == other.Sku ||
                    this.Sku != null &&
                    this.Sku.Equals(other.Sku)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.ChargeType == other.ChargeType ||
                    this.ChargeType != null &&
                    this.ChargeType.Equals(other.ChargeType)
                ) && 
                (
                    this.Quantity == other.Quantity ||
                    this.Quantity != null &&
                    this.Quantity.Equals(other.Quantity)
                ) && 
                (
                    this.ListTotal == other.ListTotal ||
                    this.ListTotal != null &&
                    this.ListTotal.Equals(other.ListTotal)
                ) && 
                (
                    this.Total == other.Total ||
                    this.Total != null &&
                    this.Total.Equals(other.Total)
                ) && 
                (
                    this.ListPriceDisplay == other.ListPriceDisplay ||
                    this.ListPriceDisplay != null &&
                    this.ListPriceDisplay.Equals(other.ListPriceDisplay)
                ) && 
                (
                    this.Discount == other.Discount ||
                    this.Discount != null &&
                    this.Discount.Equals(other.Discount)
                ) && 
                (
                    this.EffectivePrice == other.EffectivePrice ||
                    this.EffectivePrice != null &&
                    this.EffectivePrice.Equals(other.EffectivePrice)
                ) && 
                (
                    this.ProductShippable == other.ProductShippable ||
                    this.ProductShippable != null &&
                    this.ProductShippable.Equals(other.ProductShippable)
                ) && 
                (
                    this.ShippingAddress == other.ShippingAddress ||
                    this.ShippingAddress != null &&
                    this.ShippingAddress.Equals(other.ShippingAddress)
                ) && 
                (
                    this.ForRelatedPart == other.ForRelatedPart ||
                    this.ForRelatedPart != null &&
                    this.ForRelatedPart.Equals(other.ForRelatedPart)
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
                if (this.Sku != null)
                    hash = hash * 59 + this.Sku.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.ChargeType != null)
                    hash = hash * 59 + this.ChargeType.GetHashCode();
                if (this.Quantity != null)
                    hash = hash * 59 + this.Quantity.GetHashCode();
                if (this.ListTotal != null)
                    hash = hash * 59 + this.ListTotal.GetHashCode();
                if (this.Total != null)
                    hash = hash * 59 + this.Total.GetHashCode();
                if (this.ListPriceDisplay != null)
                    hash = hash * 59 + this.ListPriceDisplay.GetHashCode();
                if (this.Discount != null)
                    hash = hash * 59 + this.Discount.GetHashCode();
                if (this.EffectivePrice != null)
                    hash = hash * 59 + this.EffectivePrice.GetHashCode();
                if (this.ProductShippable != null)
                    hash = hash * 59 + this.ProductShippable.GetHashCode();
                if (this.ShippingAddress != null)
                    hash = hash * 59 + this.ShippingAddress.GetHashCode();
                if (this.ForRelatedPart != null)
                    hash = hash * 59 + this.ForRelatedPart.GetHashCode();
                return hash;
            }
        }
    }

}
