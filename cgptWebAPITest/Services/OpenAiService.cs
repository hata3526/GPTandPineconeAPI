using cgptWebAPITest.Configurations;
using Microsoft.Extensions.Options;
using OpenAI_API.Completions;
using OpenAI_API.Embedding;
using OpenAI_API.Images;
using OpenAI_API.Models;

namespace cgptWebAPITest.Services
{
    public class OpenAiService : IOpenAiService
    {

        private readonly OpenAiConfig _openAiConfig;

        public OpenAiService(IOptionsMonitor<OpenAiConfig> optionsMonitor)
        {
            _openAiConfig = optionsMonitor.CurrentValue;
        }

        public Task<string> CheckProgramingLanguage(string language)
        {
            var api = new OpenAI_API.OpenAIAPI(_openAiConfig.Key);

            var chat = api.Chat.CreateConversation();

            chat.AppendSystemMessage("You are a teacher who help new programmers understand things are programming langage or not. If the user tells you a programming language respond with yes,if a user tells you something which is not a programing langage respond with no. you will only respond with yes or no.you do not say enything else.");

            chat.AppendUserInput(language);

            var response = chat.GetResponseFromChatbotAsync();
            return response;

        }

        public async Task<string> CompleteSentence(string text)
        {
            // api instance
            var api = new OpenAI_API.OpenAIAPI(_openAiConfig.Key);
            var result = await api.Completions.GetCompletion(text);
            return result;
        }

        public async Task<string> CompleteSentenceAdvance(string text)
        {
            //api instance
            var api = new OpenAI_API.OpenAIAPI(_openAiConfig.Key);
            var result = await api.Completions.CreateCompletionAsync(
                new CompletionRequest(text, model: Model.CurieText, temperature: 0 / 1));
            return result.Completions[0].Text;
        }

       

        public async Task<string> CreateImageAsync(string request)
        {
            var api = new OpenAI_API.OpenAIAPI(_openAiConfig.Key);
            var result = await api.ImageGenerations.CreateImageAsync(new ImageGenerationRequest(request, 1, ImageSize._512));
            return result.Data[0].Url;
        }

        public async Task<float[]> CreateEmbeddingAsync(string request)
        {
            var api = new OpenAI_API.OpenAIAPI(_openAiConfig.Key);
            var result = await api.Embeddings.CreateEmbeddingAsync(new EmbeddingRequest(model: Model.AdaTextEmbedding, request));
            return result.Data[0].Embedding;
        }
    }
}
