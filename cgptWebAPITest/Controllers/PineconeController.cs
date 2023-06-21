using cgptWebAPITest.Models;
using cgptWebAPITest.Services;
using Microsoft.AspNetCore.Mvc;

namespace cgptWebAPITest.Controllers
{
    public class PineconeController : ControllerBase
    {
        private readonly ILogger<PineconeController> _logger;
        private readonly IPineconeService _pineconeService;

        public PineconeController(ILogger<PineconeController> logger, IPineconeService pineconeService)
        {
            _logger = logger;
            _pineconeService = pineconeService;
        }

        [HttpGet()]
        [Route("GetAllIndex")]
        public async Task<IActionResult> GetAllIndex()
        {
            var result = await _pineconeService.GetAllIndex();
            return Ok(result);
        }

        [HttpPost()]
        [Route("CreateIndex")]
        public async Task<IActionResult> CreateIndex(string name)
        {
            var result = await _pineconeService.CreateIndex(name);
            return Ok(result);
        }

        [HttpPost()]
        [Route("DeleteIndex")]
        public async Task<IActionResult> DeleteIndex(string name)
        {
            var result = await _pineconeService.DeleteIndex(name);
            return Ok(result);
        }

        [HttpPost()]
        [Route("UpsertVectorAsync")]
        public async Task<IActionResult> UpsertVectorAsync(string indexName, [FromBody] List<VactorData> vectorData)
        {
            try
            {
                var data = vectorData.Select(x => (x.id, x.Values));
                var result = await _pineconeService.UpsertVectorsAsync(indexName, data);
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return BadRequest(e.Message);
            }
           
        }   
    }
}
