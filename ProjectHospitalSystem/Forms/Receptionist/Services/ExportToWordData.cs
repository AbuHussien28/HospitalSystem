﻿using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using ProjectHospitalSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHospitalSystem.Forms.Receptionist.Services
{
    public class ExportToWordData
    {
        private  HospitalSystemContext _context;
        public ExportToWordData(HospitalSystemContext context)
        {
            _context = context;
        }

        public void ExportBillToWord(Bill bill, string filePath)
        {
            using (var wordDoc = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
            {
                var mainPart = wordDoc.AddMainDocumentPart();
                mainPart.Document = new Document();
                var body = mainPart.Document.AppendChild(new Body());
                AddCenteredText(body, "Hospital Name: ITI Hospital");
                AddCenteredText(body, "Address: ITI Menofia Branch");
                AddCenteredText(body, "Phone: 0235355628");
                body.AppendChild(new Paragraph(new Run(new DocumentFormat.OpenXml.Wordprocessing.Text($"Patient ID: {bill.PatientId}"))));
                body.AppendChild(new Paragraph(new Run(new DocumentFormat.OpenXml.Wordprocessing.Text($"Patient Name: {bill.Patient.FullName}"))));
                body.AppendChild(new Paragraph(new Run(new DocumentFormat.OpenXml.Wordprocessing.Text($"Bill ID: {bill.BillId}"))));
                body.AppendChild(new Paragraph(new Run(new DocumentFormat.OpenXml.Wordprocessing.Text($"Generated Date: {bill.GenertedDate.ToShortDateString()}"))));
                body.AppendChild(new Paragraph(new Run(new DocumentFormat.OpenXml.Wordprocessing.Text($"Due Date: {bill.DueDate.ToShortDateString()}"))));
                body.AppendChild(new Paragraph(new Run(new DocumentFormat.OpenXml.Wordprocessing.Text($"Original Bill Amount: EGP {bill.OriginalAmount}"))));
                body.AppendChild(new Paragraph(new Run(new DocumentFormat.OpenXml.Wordprocessing.Text($"Late Fee: ${bill.LateFee ?? 0}"))));
                body.AppendChild(new Paragraph(new Run(new DocumentFormat.OpenXml.Wordprocessing.Text($"Total Bill Amount with LateFee:  EGP {bill.TotalAmount}"))));
                decimal totalPaid = bill.Payments?.Sum(p => p.AmountPaid) ?? 0;
                decimal remainingBalance = bill.TotalAmount - totalPaid;
                body.AppendChild(new Paragraph(new Run(new DocumentFormat.OpenXml.Wordprocessing.Text($"Remaining Balance: EGP {remainingBalance:F2}"))));


                var totalPaymentsInDept = _context.Bills
                    .Where(b => b.PatientId == bill.PatientId && b.DepartmentId == bill.DepartmentId && b.Status != BillStatus.Expired)
                    .Sum(b => b.OriginalAmount + (b.LateFee ?? 0));
                body.AppendChild(new Paragraph(new Run(new Text($"Total Payments in Department: EGP {totalPaymentsInDept:F2}"))));
                body.AppendChild(new Paragraph(new Run(new DocumentFormat.OpenXml.Wordprocessing.Text($"Department: {bill.Department.DeptName}"))));
                body.AppendChild(new Paragraph(new Run(new DocumentFormat.OpenXml.Wordprocessing.Text($"Status: {bill.Status}"))));
                body.AppendChild(new Paragraph(new Run(new DocumentFormat.OpenXml.Wordprocessing.Text("Thank you for choosing our hospital!"))));
            }
        }
        private static void AddCenteredText(Body body, string text)
        {
            var paragraph = new Paragraph();
            var run = new Run(new Text(text));
            var paragraphProperties = new ParagraphProperties
            {
                Justification = new Justification { Val = JustificationValues.Center }
            };
            paragraph.Append(paragraphProperties);
            paragraph.Append(run);
            body.Append(paragraph);
        }
    }
}
