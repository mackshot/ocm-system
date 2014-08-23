//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OCM.Core.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Operator
    {
        public Operator()
        {
            this.ChargePoints = new HashSet<ChargePoint>();
        }
    
        public int ID { get; set; }
        public string Title { get; set; }
        public string WebsiteURL { get; set; }
        public string Comments { get; set; }
        public string PhonePrimaryContact { get; set; }
        public string PhoneSecondaryContact { get; set; }
        public Nullable<bool> IsPrivateIndividual { get; set; }
        public Nullable<int> AddressInfoID { get; set; }
        public string BookingURL { get; set; }
        public string ContactEmail { get; set; }
        public string FaultReportEmail { get; set; }
        public Nullable<bool> IsRestrictedEdit { get; set; }
    
        public virtual AddressInfo AddressInfo { get; set; }
        public virtual ICollection<ChargePoint> ChargePoints { get; set; }
    }
}
