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
    public class LocalDateTime :  IEquatable<LocalDateTime>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocalDateTime" /> class.
        /// </summary>
        public LocalDateTime()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [DataMember(Name="year", EmitDefaultValue=false)]
        public int? Year { get; set; }
  
        
        /// <summary>
        /// Gets or Sets DayOfMonth
        /// </summary>
        [DataMember(Name="dayOfMonth", EmitDefaultValue=false)]
        public int? DayOfMonth { get; set; }
  
        
        /// <summary>
        /// Gets or Sets DayOfWeek
        /// </summary>
        [DataMember(Name="dayOfWeek", EmitDefaultValue=false)]
        public int? DayOfWeek { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Era
        /// </summary>
        [DataMember(Name="era", EmitDefaultValue=false)]
        public int? Era { get; set; }
  
        
        /// <summary>
        /// Gets or Sets DayOfYear
        /// </summary>
        [DataMember(Name="dayOfYear", EmitDefaultValue=false)]
        public int? DayOfYear { get; set; }
  
        
        /// <summary>
        /// Gets or Sets HourOfDay
        /// </summary>
        [DataMember(Name="hourOfDay", EmitDefaultValue=false)]
        public int? HourOfDay { get; set; }
  
        
        /// <summary>
        /// Gets or Sets MinuteOfHour
        /// </summary>
        [DataMember(Name="minuteOfHour", EmitDefaultValue=false)]
        public int? MinuteOfHour { get; set; }
  
        
        /// <summary>
        /// Gets or Sets SecondOfMinute
        /// </summary>
        [DataMember(Name="secondOfMinute", EmitDefaultValue=false)]
        public int? SecondOfMinute { get; set; }
  
        
        /// <summary>
        /// Gets or Sets MillisOfSecond
        /// </summary>
        [DataMember(Name="millisOfSecond", EmitDefaultValue=false)]
        public int? MillisOfSecond { get; set; }
  
        
        /// <summary>
        /// Gets or Sets YearOfEra
        /// </summary>
        [DataMember(Name="yearOfEra", EmitDefaultValue=false)]
        public int? YearOfEra { get; set; }
  
        
        /// <summary>
        /// Gets or Sets YearOfCentury
        /// </summary>
        [DataMember(Name="yearOfCentury", EmitDefaultValue=false)]
        public int? YearOfCentury { get; set; }
  
        
        /// <summary>
        /// Gets or Sets CenturyOfEra
        /// </summary>
        [DataMember(Name="centuryOfEra", EmitDefaultValue=false)]
        public int? CenturyOfEra { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Chronology
        /// </summary>
        [DataMember(Name="chronology", EmitDefaultValue=false)]
        public Chronology Chronology { get; set; }
  
        
        /// <summary>
        /// Gets or Sets MonthOfYear
        /// </summary>
        [DataMember(Name="monthOfYear", EmitDefaultValue=false)]
        public int? MonthOfYear { get; set; }
  
        
        /// <summary>
        /// Gets or Sets MillisOfDay
        /// </summary>
        [DataMember(Name="millisOfDay", EmitDefaultValue=false)]
        public int? MillisOfDay { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Weekyear
        /// </summary>
        [DataMember(Name="weekyear", EmitDefaultValue=false)]
        public int? Weekyear { get; set; }
  
        
        /// <summary>
        /// Gets or Sets WeekOfWeekyear
        /// </summary>
        [DataMember(Name="weekOfWeekyear", EmitDefaultValue=false)]
        public int? WeekOfWeekyear { get; set; }
  
        
        /// <summary>
        /// Gets or Sets FieldTypes
        /// </summary>
        [DataMember(Name="fieldTypes", EmitDefaultValue=false)]
        public List<DateTimeFieldType> FieldTypes { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Values
        /// </summary>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<int?> Values { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public List<DateTimeField> Fields { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LocalDateTime {\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  DayOfMonth: ").Append(DayOfMonth).Append("\n");
            sb.Append("  DayOfWeek: ").Append(DayOfWeek).Append("\n");
            sb.Append("  Era: ").Append(Era).Append("\n");
            sb.Append("  DayOfYear: ").Append(DayOfYear).Append("\n");
            sb.Append("  HourOfDay: ").Append(HourOfDay).Append("\n");
            sb.Append("  MinuteOfHour: ").Append(MinuteOfHour).Append("\n");
            sb.Append("  SecondOfMinute: ").Append(SecondOfMinute).Append("\n");
            sb.Append("  MillisOfSecond: ").Append(MillisOfSecond).Append("\n");
            sb.Append("  YearOfEra: ").Append(YearOfEra).Append("\n");
            sb.Append("  YearOfCentury: ").Append(YearOfCentury).Append("\n");
            sb.Append("  CenturyOfEra: ").Append(CenturyOfEra).Append("\n");
            sb.Append("  Chronology: ").Append(Chronology).Append("\n");
            sb.Append("  MonthOfYear: ").Append(MonthOfYear).Append("\n");
            sb.Append("  MillisOfDay: ").Append(MillisOfDay).Append("\n");
            sb.Append("  Weekyear: ").Append(Weekyear).Append("\n");
            sb.Append("  WeekOfWeekyear: ").Append(WeekOfWeekyear).Append("\n");
            sb.Append("  FieldTypes: ").Append(FieldTypes).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            
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
            return this.Equals(obj as LocalDateTime);
        }

        /// <summary>
        /// Returns true if LocalDateTime instances are equal
        /// </summary>
        /// <param name="obj">Instance of LocalDateTime to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LocalDateTime other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Year == other.Year ||
                    this.Year != null &&
                    this.Year.Equals(other.Year)
                ) && 
                (
                    this.DayOfMonth == other.DayOfMonth ||
                    this.DayOfMonth != null &&
                    this.DayOfMonth.Equals(other.DayOfMonth)
                ) && 
                (
                    this.DayOfWeek == other.DayOfWeek ||
                    this.DayOfWeek != null &&
                    this.DayOfWeek.Equals(other.DayOfWeek)
                ) && 
                (
                    this.Era == other.Era ||
                    this.Era != null &&
                    this.Era.Equals(other.Era)
                ) && 
                (
                    this.DayOfYear == other.DayOfYear ||
                    this.DayOfYear != null &&
                    this.DayOfYear.Equals(other.DayOfYear)
                ) && 
                (
                    this.HourOfDay == other.HourOfDay ||
                    this.HourOfDay != null &&
                    this.HourOfDay.Equals(other.HourOfDay)
                ) && 
                (
                    this.MinuteOfHour == other.MinuteOfHour ||
                    this.MinuteOfHour != null &&
                    this.MinuteOfHour.Equals(other.MinuteOfHour)
                ) && 
                (
                    this.SecondOfMinute == other.SecondOfMinute ||
                    this.SecondOfMinute != null &&
                    this.SecondOfMinute.Equals(other.SecondOfMinute)
                ) && 
                (
                    this.MillisOfSecond == other.MillisOfSecond ||
                    this.MillisOfSecond != null &&
                    this.MillisOfSecond.Equals(other.MillisOfSecond)
                ) && 
                (
                    this.YearOfEra == other.YearOfEra ||
                    this.YearOfEra != null &&
                    this.YearOfEra.Equals(other.YearOfEra)
                ) && 
                (
                    this.YearOfCentury == other.YearOfCentury ||
                    this.YearOfCentury != null &&
                    this.YearOfCentury.Equals(other.YearOfCentury)
                ) && 
                (
                    this.CenturyOfEra == other.CenturyOfEra ||
                    this.CenturyOfEra != null &&
                    this.CenturyOfEra.Equals(other.CenturyOfEra)
                ) && 
                (
                    this.Chronology == other.Chronology ||
                    this.Chronology != null &&
                    this.Chronology.Equals(other.Chronology)
                ) && 
                (
                    this.MonthOfYear == other.MonthOfYear ||
                    this.MonthOfYear != null &&
                    this.MonthOfYear.Equals(other.MonthOfYear)
                ) && 
                (
                    this.MillisOfDay == other.MillisOfDay ||
                    this.MillisOfDay != null &&
                    this.MillisOfDay.Equals(other.MillisOfDay)
                ) && 
                (
                    this.Weekyear == other.Weekyear ||
                    this.Weekyear != null &&
                    this.Weekyear.Equals(other.Weekyear)
                ) && 
                (
                    this.WeekOfWeekyear == other.WeekOfWeekyear ||
                    this.WeekOfWeekyear != null &&
                    this.WeekOfWeekyear.Equals(other.WeekOfWeekyear)
                ) && 
                (
                    this.FieldTypes == other.FieldTypes ||
                    this.FieldTypes != null &&
                    this.FieldTypes.SequenceEqual(other.FieldTypes)
                ) && 
                (
                    this.Values == other.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(other.Values)
                ) && 
                (
                    this.Fields == other.Fields ||
                    this.Fields != null &&
                    this.Fields.SequenceEqual(other.Fields)
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
                
                if (this.Year != null)
                    hash = hash * 57 + this.Year.GetHashCode();
                
                if (this.DayOfMonth != null)
                    hash = hash * 57 + this.DayOfMonth.GetHashCode();
                
                if (this.DayOfWeek != null)
                    hash = hash * 57 + this.DayOfWeek.GetHashCode();
                
                if (this.Era != null)
                    hash = hash * 57 + this.Era.GetHashCode();
                
                if (this.DayOfYear != null)
                    hash = hash * 57 + this.DayOfYear.GetHashCode();
                
                if (this.HourOfDay != null)
                    hash = hash * 57 + this.HourOfDay.GetHashCode();
                
                if (this.MinuteOfHour != null)
                    hash = hash * 57 + this.MinuteOfHour.GetHashCode();
                
                if (this.SecondOfMinute != null)
                    hash = hash * 57 + this.SecondOfMinute.GetHashCode();
                
                if (this.MillisOfSecond != null)
                    hash = hash * 57 + this.MillisOfSecond.GetHashCode();
                
                if (this.YearOfEra != null)
                    hash = hash * 57 + this.YearOfEra.GetHashCode();
                
                if (this.YearOfCentury != null)
                    hash = hash * 57 + this.YearOfCentury.GetHashCode();
                
                if (this.CenturyOfEra != null)
                    hash = hash * 57 + this.CenturyOfEra.GetHashCode();
                
                if (this.Chronology != null)
                    hash = hash * 57 + this.Chronology.GetHashCode();
                
                if (this.MonthOfYear != null)
                    hash = hash * 57 + this.MonthOfYear.GetHashCode();
                
                if (this.MillisOfDay != null)
                    hash = hash * 57 + this.MillisOfDay.GetHashCode();
                
                if (this.Weekyear != null)
                    hash = hash * 57 + this.Weekyear.GetHashCode();
                
                if (this.WeekOfWeekyear != null)
                    hash = hash * 57 + this.WeekOfWeekyear.GetHashCode();
                
                if (this.FieldTypes != null)
                    hash = hash * 57 + this.FieldTypes.GetHashCode();
                
                if (this.Values != null)
                    hash = hash * 57 + this.Values.GetHashCode();
                
                if (this.Fields != null)
                    hash = hash * 57 + this.Fields.GetHashCode();
                
                return hash;
            }
        }

    }


}
