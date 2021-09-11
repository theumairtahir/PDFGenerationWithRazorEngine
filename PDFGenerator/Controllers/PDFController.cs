using PDFGenerator.Models;
using Rotativa.MVC;
using System;
using System.Web.Mvc;

namespace PDFGenerator.Controllers
{
    public class PDFController : Controller
    {
        // GET: PDF
        //[Route("/GetPDF")]
        public ActionResult GetInvoice()
        {
            InvoiceModel model = new InvoiceModel
            {
                Address = "JEEDAH",
                AmountInWords = "Twanty Five Saudi Riyal Only",
                Balance = 0,
                CashRecevied = 0,
                ContactNumber = "12345",
                CustomerNumber = "DANA SUPER MARKET NUZAL",
                Discount = 0,
                InvoiceTime = DateTime.Now,
                NetTotal = 25,
                OldBalance = 0,
                SalesMan = "Ali",
                TotalBeforeTax = 25,
                VAT = "",
                VATAmount = 0,
                VoucherNumber = "302"
            };
            InvoiceDetailModel detail1 = new InvoiceDetailModel
            {
                ItemName = "Best Royal Date",
                NetTotal = 25,
                VATAmount = 0,
                Quantity = 5,
                Rate = 5,
                Total = 25
            };
            InvoiceDetailModel detail2 = new InvoiceDetailModel
            {
                ItemName = "Best Royal Date",
                NetTotal = 25,
                VATAmount = 0,
                Quantity = 5,
                Rate = 5,
                Total = 25
            };
            InvoiceDetailModel detail3 = new InvoiceDetailModel
            {
                ItemName = "Best Royal Date",
                NetTotal = 25,
                VATAmount = 0,
                Quantity = 5,
                Rate = 5,
                Total = 25
            };
            InvoiceDetailModel detail4 = new InvoiceDetailModel
            {
                ItemName = "Best Royal Date",
                NetTotal = 25,
                VATAmount = 0,
                Quantity = 5,
                Rate = 5,
                Total = 25
            };
            InvoiceDetailModel detail5 = new InvoiceDetailModel
            {
                ItemName = "Best Royal Date",
                NetTotal = 25,
                VATAmount = 0,
                Quantity = 5,
                Rate = 5,
                Total = 25
            };
            model.Details.Add(detail1);
            model.Details.Add(detail2);
            model.Details.Add(detail3);
            model.Details.Add(detail4);
            model.Details.Add(detail5);
            return View(model);
        }
        public ActionResult GetInvoicePrint()
        {
            Rotativa.Core.DriverOptions options = new Rotativa.Core.DriverOptions
            {
                PageMargins = new Rotativa.Core.Options.Margins(0, 0, 0, 0),
                PageSize = Rotativa.Core.Options.Size.A4,
                PageOrientation = Rotativa.Core.Options.Orientation.Portrait
            };
            return new ActionAsPdf("GetInvoice")
            { FileName = $"Invoice_{DateTime.Now:ddMMyyyyHmmss}.pdf", RotativaOptions = options };
        }
    }
}