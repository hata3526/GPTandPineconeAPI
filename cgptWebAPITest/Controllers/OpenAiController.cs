using cgptWebAPITest.Services;
using Microsoft.AspNetCore.Mvc;

namespace cgptWebAPITest.Controllers
{
    public class OpenAiController : ControllerBase
    {
        private readonly ILogger<OpenAiController> _logger;
        private readonly IOpenAiService _openAiService;

        public OpenAiController(ILogger<OpenAiController> logger,IOpenAiService openAiService)
        {
            _logger = logger;
            _openAiService = openAiService;
        }

        [HttpPost()]
        [Route("CompleteSentence")]
        public async Task<IActionResult> CompleteSentence(string text)
        {
           var result = await _openAiService.CompleteSentence(text);
            return Ok(result);
        }

        [HttpPost()]
        [Route("CreateSentence")]
        public async Task<IActionResult> CreateSentence(string text)
        {
            var result = await _openAiService.CompleteSentenceAdvance(text);
            return Ok(result);
        }

        [HttpPost()]
        [Route("checkProgramingLanguage")]
        public async Task<IActionResult> CheckProgramingLanguage(string text)
        {
            var result = await _openAiService.CheckProgramingLanguage(text);
            return Ok(result);
        }

        [HttpPost()]
        [Route("CreateImage")]
        public async Task<IActionResult> CreateImage(string request)
        {
            var result = await _openAiService.CreateImageAsync(request);
            return Ok(result);
        }

        [HttpPost()]
        [Route("CreateEmbedding")]
        public async Task<IActionResult> CreateEmbedding(string request)
        {
            var result = await _openAiService.CreateEmbeddingAsync(request);
            return Ok(result);
        }

    }
}
