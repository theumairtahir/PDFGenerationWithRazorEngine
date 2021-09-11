using System;
using System.Collections.Generic;

namespace PDFGenerator.Models
{
    public class InvoiceModel
    {
        public InvoiceModel()
        {
            Details = new List<InvoiceDetailModel>();
        }
        public string VoucherNumber { get; set; }
        public DateTime InvoiceTime { get; set; }
        public string SalesMan { get; set; }
        public string CustomerNumber { get; set; }
        public string ContactNumber { get; set; }
        public string VAT { get; set; }
        public string Address { get; set; }
        public decimal TotalBeforeTax { get; set; }
        public decimal VATAmount { get; set; }
        public decimal Discount { get; set; }
        public decimal NetTotal { get; set; }
        public decimal OldBalance { get; set; }
        public decimal CashRecevied { get; set; }
        public decimal Balance { get; set; }
        public string AmountInWords { get; set; }
        public List<InvoiceDetailModel> Details { get; set; }
    }

    public class InvoiceDetailModel
    {
        public string ItemName { get; set; }
        public decimal Quantity { get; set; }
        public decimal Rate { get; set; }
        public decimal Total { get; set; }
        public decimal VATAmount { get; set; }
        public decimal NetTotal { get; set; }
    }
}