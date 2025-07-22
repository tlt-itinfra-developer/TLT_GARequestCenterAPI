using GARequestCenterAPI.Models;
using GARequestCenterAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GARequestCenterAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        [Route("PDFCreator")]
        [HttpPost]
        public async Task<FileContentResult> PDFCreator(PdfModel model)
        {
            Response.Headers.Add("Strict-Transport-Security", "max-age=31536000; includeSubDomains");
            ReportCreatorService service = new ReportCreatorService();
            return new FileContentResult(await service.PDFCreator(model), "application/pdf");
        }
    }
}
