//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SwiftyNames.V1._0
{
    using System;
    using System.Collections.Generic;
    
    public partial class Form
    {
        public long Id { get; set; }
        public string CurrentAddress { get; set; }
        public bool IsMarried { get; set; }
        public bool IsDivorced { get; set; }
        public bool IsCourtAvoid { get; set; }
        public bool IsConvicted { get; set; }
        public string CurrentName { get; set; }
        public string Street { get; set; }
        public int StateId { get; set; }
        public string PhoneNumbers { get; set; }
        public string ProposedName { get; set; }
        public string DeliveryphoneAddress { get; set; }
        public string DeliveryAddress { get; set; }
        public string DateOrdered { get; set; }
        public string IsDeliveredOutside { get; set; }
        public string EmbassyDelivery { get; set; }
        public int DeliveryCountry { get; set; }
        public string FullAddress { get; set; }
        public string EmbassyAdrress { get; set; }
        public string HowUHear { get; set; }
        public string ServiceComment { get; set; }
        public int Nationality_NationalityId { get; set; }
        public int State_Id { get; set; }
        public int Reason_Id { get; set; }
        public int NewsPapersPrice_Id { get; set; }
        public int Delivery_Id { get; set; }
        public string TheNoticeOf { get; set; }
    
        public virtual Delivery Delivery { get; set; }
        public virtual Nationality Nationality { get; set; }
        public virtual NewsPapersPrice NewsPapersPrice { get; set; }
        public virtual Reason Reason { get; set; }
        public virtual State State { get; set; }
    }
}