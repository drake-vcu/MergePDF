using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace MergePDF
{
    public class PdfMerger
    {
        public List<string> Documents { get; set; }
        public string OutputFile { get; set; }

        public PdfMerger()
        {
            Init();
        }

        private void Init()
        {
            Documents = new List<string>();
            OutputFile = string.Empty;
        }

        public void Clear()
        {
            Init();
        }

        /// <summary>
        /// Adds a pdf filepath/filename
        /// </summary>
        /// <param name="filename"></param>
        public void AddFile(string filename)
        {
            Documents.Add(filename);
        }

        /// <summary>
        /// Merges pdf files
        /// </summary>
        /// <param name="outputFile">optionally set outputfile here</param>
        public void MergeFiles(string outputFile = null)
        {
            if (outputFile != null)
                OutputFile = outputFile;
            if (Documents?.Count < 2)
                throw new ArgumentException("Two or more files are required to merge!");
            if (OutputFile == null)
                throw new ArgumentNullException("Output file not set!");
            if ((OutputFile ?? string.Empty) == string.Empty)
                throw new ArgumentException("Output file not set!");

            var outDocument = new PdfDocument();

            using (PdfDocument outPdf = new PdfDocument())
            {
                foreach (var document in Documents)
                {
                    PdfDocument importPdf = PdfReader.Open(document.Replace(@"\", "/"), PdfDocumentOpenMode.Import);
                    CopyPages(importPdf, outPdf);
                }
                var outputLocation = OutputFile.Replace(@"\", "/");
                outPdf.Save(outputLocation);
            }
        }

        private void CopyPages(PdfDocument from, PdfDocument to)
        {
            for (int i = 0; i < from.PageCount; i++)
            {
                to.AddPage(from.Pages[i]);
            }
        }
    }
}
