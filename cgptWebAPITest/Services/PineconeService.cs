using cgptWebAPITest.Configurations;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Pinecone;
using Pinecone.Rest;
using System;
using System.Numerics;
using System.Reflection;
using Vector = Pinecone.Vector;
using Microsoft.Extensions.Configuration;
using System.Runtime.Intrinsics;

namespace cgptWebAPITest.Services
{
    public class PineconeService : IPineconeService
    {
       
        private readonly PineconeClient _pineconeClient;
        private readonly Index<RestTransport>? _index;
        private readonly IConfiguration _configuration;
        public PineconeService(IConfiguration configuration)
        {
            _configuration = configuration;
            var apiKey = configuration["Pinecone:apiKey"];
            var enviroment = configuration["Pinecone:enviroment"];
            if (string.IsNullOrWhiteSpace(apiKey))
            {
                throw new ArgumentException("API key must not be null or whitespace.", nameof(apiKey));
            }

            if (string.IsNullOrWhiteSpace(enviroment))
            {
                throw new ArgumentException("Environment must not be null or whitespace.", nameof(enviroment));
            }
            _pineconeClient =  new PineconeClient(apiKey, enviroment);
           
        }



        public async Task<string> GetAllIndex()
        {
            
            //List all indexes
            var indexes = await _pineconeClient.ListIndexes();
            //Return all indexes name with Null handling
            return indexes != null ? string.Join(',', indexes) : string.Empty;
        }

        public async Task<string> CreateIndex(string name)
        {
            

            //List all indexes
            var indexes = await _pineconeClient.ListIndexes();

            //Create a new index if it doesn't exist
            if (!indexes.Contains(name))
            {
                await _pineconeClient.CreateIndex(name, 1536, Metric.Cosine);
            }
            //Return the index name
            return name;

        }

        public async Task<IActionResult> DeleteIndex(string name)
        {
            

            await _pineconeClient.DeleteIndex(name);

            //Return the index name
            return new OkResult();

        }

        public async Task<uint> UpsertVectorsAsync(string indexName, IEnumerable<(string Id, float[] Values)> vectorData)
        {

            
            var vectors = new List<Vector>();

            foreach (var data in vectorData)
            {
                vectors.Add(new Vector
                {
                    Id = data.Id,
                    Values = data.Values
                });
            }

            var index = await _pineconeClient.GetIndex<RestTransport>(indexName);
            return await index.Upsert(vectors);
        }

        public async Task<ScoredVector[]> GetEmbedding(string indexName,uint top, float[] values)
        {

            var vector = new[] { 0.1f, 0.2f, 0.3f};
            //Get Embedding by Query
            var index = await _pineconeClient.GetIndex<RestTransport>(indexName);
            var result = await index.Query(values, top, null, null, null, true, false);
            return result;


        }
    }
};
