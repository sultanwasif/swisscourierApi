//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SwissCourierApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_orders
    {
        public string ORDER_NO { get; set; }
        public System.DateTime ORDER_DATE { get; set; }
        public string VOUCHER_NO { get; set; }
        public string DRIVER_NAME { get; set; }
        public string DRIVER_MOBILE { get; set; }
        public Nullable<System.DateTime> DELIVERY_DATE { get; set; }
        public Nullable<decimal> PRODUCT_CHARGE { get; set; }
        public Nullable<decimal> DELIVERY_CHARGE { get; set; }
        public string ORDER_REMARKS { get; set; }
        public string CLIENT_NAME { get; set; }
        public string CLIENT_MOBILE { get; set; }
        public string CLIENT_ADDRESS { get; set; }
        public string CLIENT_LOCATION { get; set; }
        public string CLIENT_EMIRATE { get; set; }
        public string CUSTOMER_NAME { get; set; }
        public string CUSTOMER_MOBILE { get; set; }
        public string CUSTOMER_ADDRESS { get; set; }
        public string CUSTOMER_LOCATION { get; set; }
        public string CUSTOMER_EMIRATE { get; set; }
        public string VOUCHER_STATUS { get; set; }
        public string PAID_STATUS { get; set; }
        public byte[] UPDATE_DATE { get; set; }
    }
}