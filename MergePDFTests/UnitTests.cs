using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MergePDF;
using PdfSharp.Pdf.IO;

namespace MergePDFTests
{
    [TestClass]
    public class UnitTests
    {
        private const string PDF_TEST_FILE_1 = @"..\..\TestFiles\test_1.pdf";
        private const string PDF_TEST_FILE_2 = @"..\..\TestFiles\test_2.pdf";
        private const string PDF_OUT = "out.pdf";

        [TestMethod]
        public void Merge_with_no_files_Fail()
        {
            PdfMerger pdfMerger = new PdfMerger();
            Assert.ThrowsException<Exception>(() => pdfMerger.MergeFiles());
        }

        [TestMethod]
        public void Merge_with_not_enough_files_Fail()
        {
            PdfMerger pdfMerger = new PdfMerger();
            pdfMerger.AddFile(PDF_TEST_FILE_1);

            if (System.IO.File.Exists(PDF_OUT))
                System.IO.File.Delete(PDF_OUT);

            Assert.ThrowsException<Exception>(() => pdfMerger.MergeFiles(PDF_OUT));
        }

        [TestMethod]
        public void Merge_with_no_out_file_Fail()
        {
            PdfMerger pdfMerger = new PdfMerger();
            pdfMerger.AddFile(PDF_TEST_FILE_1);
            pdfMerger.AddFile(PDF_TEST_FILE_2);

            if (System.IO.File.Exists(PDF_OUT))
                System.IO.File.Delete(PDF_OUT);

            Assert.ThrowsException<Exception>(() => pdfMerger.MergeFiles());
        }

        [TestMethod]
        public void Merge_files_Pass()
        {
            PdfMerger pdfMerger = new PdfMerger();
            pdfMerger.AddFile(PDF_TEST_FILE_1);
            pdfMerger.AddFile(PDF_TEST_FILE_2);

            if (System.IO.File.Exists(PDF_OUT))
                System.IO.File.Delete(PDF_OUT);

            pdfMerger.MergeFiles(PDF_OUT);

            Assert.IsTrue(System.IO.File.Exists(PDF_OUT));
        }

        [TestMethod]
        public void Merge_files_pageCount_verify_Pass()
        {
            PdfMerger pdfMerger = new PdfMerger();
            pdfMerger.AddFile(PDF_TEST_FILE_1);
            pdfMerger.AddFile(PDF_TEST_FILE_2);
            pdfMerger.AddFile(PDF_TEST_FILE_1);
            pdfMerger.AddFile(PDF_TEST_FILE_2);

            if (System.IO.File.Exists(PDF_OUT))
                System.IO.File.Delete(PDF_OUT);

            pdfMerger.MergeFiles(PDF_OUT);

            var count = PdfReader.Open(PDF_OUT.Replace(@"\", "/"), PdfDocumentOpenMode.Import).PageCount;
            Assert.AreEqual(pdfMerger.Documents.Count, count);
        }
    }
}
