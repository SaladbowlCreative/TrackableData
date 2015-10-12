﻿using System;
using System.Linq;
using TrackableData.Tests.Data;
using Xunit;

namespace TrackableData.Tests
{
    public class PocoTest
    {
        private TrackablePerson CreateTestPerson()
        {
            return new TrackablePerson
            {
                Name = "Alice",
                Age = 20,
                LeftHand = new TrackableHand
                {
                    MainRing = new TrackableRing { Name = "NormalRing", Power = 10 },
                    SubRing = new TrackableRing { Name = "TutorialRing", Power = 5 }
                },
                RightHand = new TrackableHand
                {
                    MainRing = new TrackableRing { Name = "NormalRing", Power = 9 },
                    SubRing = new TrackableRing { Name = "DummyRing", Power = 1 }
                }
            };
        }

        private TrackablePerson CreateTestPersonWithTracker()
        {
            var person = CreateTestPerson();
            person.SetDefaultTrackerDeep();
            return person;
        }

        [Fact]
        public void TestPoco_Tracking_Work()
        {
            var person = CreateTestPersonWithTracker();
            person.Name = "Bob";

            Assert.Equal(true, person.Tracker.HasChange);
            Assert.Equal(1, person.Tracker.ChangeMap.Count);
            Assert.Equal("Name", person.Tracker.ChangeMap.Keys.First().Name);
            Assert.Equal("Bob", person.Tracker.ChangeMap.Values.First().NewValue);
            Assert.Equal("Alice", person.Tracker.ChangeMap.Values.First().OldValue);
        }

        [Fact]
        public void TestPoco_OverlappedTracking_Work()
        {
            var person = CreateTestPersonWithTracker();
            person.Name = "Bob";
            person.Name = "Cindy";

            Assert.Equal(true, person.Tracker.HasChange);
            Assert.Equal(1, person.Tracker.ChangeMap.Count);
            Assert.Equal("Name", person.Tracker.ChangeMap.Keys.First().Name);
            Assert.Equal("Cindy", person.Tracker.ChangeMap.Values.First().NewValue);
            Assert.Equal("Alice", person.Tracker.ChangeMap.Values.First().OldValue);
        }

        [Fact]
        public void TestPoco_ApplyToTrackable_Work()
        {
            var person = CreateTestPersonWithTracker();
            person.Name = "Bob";
            person.Age = 30;

            var person2 = CreateTestPerson();
            person.Tracker.ApplyTo(person2);

            Assert.Equal(person.Name, person2.Name);
            Assert.Equal(person.Age, person2.Age);
        }

        [Fact]
        public void TestPoco_ApplyToTracker_Work()
        {
            var person = CreateTestPersonWithTracker();
            person.Name = "Bob";
            person.Age = 30;

            var tracker2 = new TrackablePocoTracker<Person>();
            person.Tracker.ApplyTo(tracker2);

            var person2 = CreateTestPerson();
            tracker2.ApplyTo(person2);

            Assert.Equal(person.Name, person2.Name);
            Assert.Equal(person.Age, person2.Age);
        }

        [Fact]
        public void TestPoco_RollbackToTrackable_Work()
        {
            var person = CreateTestPersonWithTracker();
            person.Name = "Bob";
            person.Age = 30;

            var person2 = CreateTestPerson();
            person.Tracker.ApplyTo(person2);
            person.Tracker.RollbackTo(person2);

            Assert.Equal("Alice", person2.Name);
            Assert.Equal(20, person2.Age);
        }

        [Fact]
        public void TestPoco_RollbackToTracker_Work()
        {
            var person = CreateTestPersonWithTracker();
            person.Name = "Bob";
            person.Age = 30;

            var tracker2 = new TrackablePocoTracker<Person>();
            person.Tracker.ApplyTo(tracker2);
            person.Tracker.RollbackTo(tracker2);

            var person2 = CreateTestPerson();
            tracker2.ApplyTo(person2);

            Assert.Equal("Alice", person2.Name);
            Assert.Equal(20, person2.Age);
        }
    }
}
