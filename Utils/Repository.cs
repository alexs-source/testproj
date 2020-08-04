using Azure.Cosmos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using testproj.Models;

namespace testproj.Utils
{
    public class Repository : ISingleton
    {
        private const string EndpointUrl = "https://testproj-cosmosdb.documents.azure.com:443/";
        private const string AuthorizationKey = "vmBH10D3MTJ43J0xhGrDXI4j3M40by6wupxxorf9pEFJ8s2G9z5RcrUzMOuqmd6I7QDB5gsnhRFgQfJiecF7hg==";
        private const string DatabaseId = "TestProjDatabase";
        private const string UserContainerId = "UserContainer";
        private const string StorageContainerId = "StorageContainer";
        private const string LastVisitedAndModifiedContainerId = "LastVisitedAndModifiedContainer";

        private CosmosClient CosmosClient;
        private CosmosDatabase TestProjDatabase;
        private CosmosContainer UserContainer;
        private CosmosContainer StorageContainer;
        private CosmosContainer LastVisitedAndModifiedContainer;

        public Repository()
        {
            CosmosClient = new CosmosClient(EndpointUrl, AuthorizationKey);
            TestProjDatabase = CosmosClient.CreateDatabaseIfNotExistsAsync(DatabaseId).Result;

            CreateUserContainer();
            CreateStorageContainer();
            CreateLastVisitedAndModifiedContainer();
        }

        private void CreateUserContainer()
        {
            var ContainerResponse = TestProjDatabase.CreateContainerIfNotExistsAsync(UserContainerId, "/UserId").Result;
            UserContainer = ContainerResponse.Container;
        }
        private void CreateStorageContainer()
        {
            var ContainerResponse = TestProjDatabase.CreateContainerIfNotExistsAsync(StorageContainerId, "/StorageId").Result;
            StorageContainer = ContainerResponse.Container;
        }
        private void CreateLastVisitedAndModifiedContainer()
        {
            var ContainerResponse = TestProjDatabase.CreateContainerIfNotExistsAsync(LastVisitedAndModifiedContainerId, "/Type").Result;
            LastVisitedAndModifiedContainer = ContainerResponse.Container;
        }

        public async Task<ShoppingList[]> GetShoppingListsByUserIdAsync(int UserId)
        {
            return null;
        }

        public async Task<Storage[]> GetStoragesByUserIdAsync(int UserId)
        {
            var sqlQueryText = $"SELECT * FROM c WHERE c.UserId = '{UserId}' and c.Type='storage'";
            QueryDefinition queryDefinition = new QueryDefinition(sqlQueryText);
            var Storages = new List<Storage>();

            await foreach(var storage in UserContainer.GetItemQueryIterator<Storage>(queryDefinition))
            {
                Storages.Add(storage);
            }

            return Storages.ToArray();
        }

        public async Task<Recipe[]> GetRecipesByUserIdAsync(int UserId)
        {
            return null;
        }


        public async Task<bool> AddStorageAsync(Storage storage)
        {
            var userId = GetUserId();
            
            var CreateStorageUserContainer = await UserContainer.CreateItemAsync<Storage>(storage, new PartitionKey(storage.UserId));
            var CreateStorageStorageContainer = await StorageContainer.CreateItemAsync<Storage>(storage, new PartitionKey(storage.StorageId));
            var CreateStorageLastVisitedAndModifiedContainer = await LastVisitedAndModifiedContainer.CreateItemAsync<Storage>(storage, new PartitionKey(storage.Type));

            return true;
        }

        private int GetUserId()
        {
            return 1;
        }
    }
}
