//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AgriFarmProj.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class tblFarmLand
    {
        [DataMember]
        public int FarmerLandId { get; set; }
        [DataMember]
        public Nullable<int> Farmerid { get; set; }
        [DataMember]
        public string FarmerLandArea { get; set; }
        [DataMember]
        public string FarmerLandAddress { get; set; }
        [DataMember]
        public string FarmerLandPincode { get; set; }
    
        public virtual tblFarmer tblFarmer { get; set; }
    }
}