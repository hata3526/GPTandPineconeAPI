using OpenAI_API.Images;

namespace cgptWebAPITest.Services
{
    public interface IOpenAiService
    {
        Task<string> CompleteSentence(string text);
        Task<string> CompleteSentenceAdvance(string text);
        Task<string> CheckProgramingLanguage(string language);
        Task<string> CreateImageAsync(string request);
        Task<float[]> CreateEmbeddingAsync(string request);


    }
}
