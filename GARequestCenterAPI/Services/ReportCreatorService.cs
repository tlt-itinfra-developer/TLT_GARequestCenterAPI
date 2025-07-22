using GARequestCenterAPI.Models;
using iText.Html2pdf;
using iText.Html2pdf.Resolver.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout.Font;
using System;
using System.IO;
using System.Threading.Tasks;
 
namespace GARequestCenterAPI.Services
{
    public class ReportCreatorService
    {
        public async Task<byte[]> PDFCreator(PdfModel model)
        {
            byte[] buffer;
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    using (PdfWriter pw = new PdfWriter(ms))
                    {
                        pw.SetCloseStream(true);
                        using (PdfDocument pdfDoc = new PdfDocument(pw))
                        {
                            ConverterProperties cProps = new ConverterProperties();
                            if (!model.isCustomFont)
                            {
                                FontProvider fp = new DefaultFontProvider(true, false, false);
                                //fp.AddFont("./Fonts/Sarabun/THSarabunNew.ttf");
                                fp.AddFont("./Fonts/SarabunSun/THSarabun.ttf");
                                fp.AddFont("./Fonts/SarabunSun/THSarabunBold.ttf");
                                fp.AddFont("./Fonts/SarabunSun/THSarabunNew.ttf");
                                cProps.SetFontProvider(fp);
                            }
                            pdfDoc.SetDefaultPageSize((model.landscape) ? PageSize.A4.Rotate() : PageSize.A4);
                            pdfDoc.SetCloseWriter(true);
                            pdfDoc.SetCloseReader(true);
                            pdfDoc.SetFlushUnusedObjects(true);
                            HtmlConverter.ConvertToPdf(model.html, pdfDoc, cProps);
                        }
                    }
                    buffer = ms.ToArray();
                }
            }
            catch (InvalidOperationException ioe)
            {
                buffer = null;
            }
            catch (Exception ex)
            {
                buffer = null;
            }

            return buffer;
        }
    }
}
