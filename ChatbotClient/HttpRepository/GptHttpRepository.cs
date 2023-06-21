using ClientModels;
using Microsoft.Extensions.Options;
using MudBlazor;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using static ClientModels.ChatBotResponse;

namespace ChatbotClient.HttpRepository
{
    public class GptHttpRepository
    {
        private readonly HttpClient _httpClient;
        private readonly IOptions<ChatOptions> _options;

        public GptHttpRepository(HttpClient httpClient, IOptions<ChatOptions> options)
        {
            _httpClient = httpClient;
            _options = options;
        }

        public async Task<ClientModels.ChatBotResponse.Message> CreateChatCompletion(List<ClientModels.ChatBotResponse.Message> messages)
        {
            var request = new { model = _options.Value.GtpModel, messages = messages.ToArray() };

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _options.Value.ApiKey);

            var response = await _httpClient.PostAsJsonAsync(_options.Value.ApiUrl, request);
            response.EnsureSuccessStatusCode();

            var chatCompletionResponse = await response.Content.ReadFromJsonAsync<ChatbotResponse>();
            return chatCompletionResponse?.choices.First().message;
        }
    }
}
