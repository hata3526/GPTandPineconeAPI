using Microsoft.AspNetCore.Mvc;
using Pinecone;

namespace cgptWebAPITest.Services
{
    public interface IPineconeService
    {

        Task<string> GetAllIndex();
        Task<string> CreateIndex(string name);
        Task<IActionResult> DeleteIndex(string name);
        Task<uint> UpsertVectorsAsync(string indexName, IEnumerable<(string Id, float[] Values)> vectorData);
        Task<ScoredVector[]> GetEmbedding(string indexName, uint top, float[] values);


    }
}
