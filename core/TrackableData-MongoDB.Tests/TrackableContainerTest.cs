﻿using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Threading.Tasks;
using TrackableData.TestKits;
using Xunit;

namespace TrackableData.MongoDB.Tests
{
    public interface ITestPocoForContainer : ITrackablePoco<ITestPocoForContainer>
    {
        string Name { get; set; }
        int Age { get; set; }
        int Extra { get; set; }
    }

    public interface ITestContainer : ITrackableContainer<ITestContainer>
    {
        TrackableTestPocoForContainer Person { get; set; }
        TrackableDictionary<int, MissionData> Missions { get; set; }
        TrackableList<TagData> Tags { get; set; }
    }

    public class TrackableContainerTest
        : StorageContainerTestKit<TrackableTestContainer, TrackableTestPocoForContainer>,
          IClassFixture<Database>
    {
        private static TrackableContainerMongoDbMapper<ITestContainer> _mapper =
            new TrackableContainerMongoDbMapper<ITestContainer>();

        private Database _db;
        private IMongoCollection<BsonDocument> _collection;
        private ObjectId _testId = ObjectId.GenerateNewId();

        public TrackableContainerTest(Database db)
        {
            _db = db;
            _db.Test.DropCollectionAsync(nameof(TrackablePocoTest)).Wait();
            _collection = _db.Test.GetCollection<BsonDocument>(nameof(TrackableContainerTest));
        }

        protected override Task CreateAsync(TrackableTestContainer container)
        {
            return _mapper.CreateAsync(_collection, container, _testId);
        }

        protected override Task<int> DeleteAsync()
        {
            return _mapper.DeleteAsync(_collection, _testId);
        }

        protected override async Task<TrackableTestContainer> LoadAsync()
        {
            return (TrackableTestContainer)await _mapper.LoadAsync(_collection, _testId);
        }

        protected override Task SaveAsync(IContainerTracker tracker)
        {
            return _mapper.SaveAsync(_collection, (TrackableTestContainerTracker)tracker, _testId);
        }
    }
}