using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfReaderEXE
{
    public class PdfReaderClass
    {
        public static string toString(string sPath)
        {
            using (PdfReader oPDF = new PdfReader(sPath))
            {
                StringBuilder oText = new StringBuilder();
                for (int i = 1; i <= oPDF.NumberOfPages; i++)
                {
                    oText.Append(PdfTextExtractor.GetTextFromPage(oPDF, i));
                }
                return oText.ToString();
            }
        }

        public static List<string> toList(string sPath)
        {
            using (PdfReader oPDF = new PdfReader(sPath))
            {
                var oText = new StringBuilder();
                for (int i = 1; i <= oPDF.NumberOfPages; i++)
                {
                    oText.Append(PdfTextExtractor.GetTextFromPage(oPDF, i));
                }
                var oReturn = oText.ToString().Split(new char[] { '\n' }).ToList();
                return oReturn;
            }
        }
    }
}
