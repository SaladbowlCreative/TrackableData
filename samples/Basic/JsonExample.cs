﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using TrackableData;
using TrackableData.Json;

namespace Basic
{
    internal class JsonExample
    {
        private static JsonSerializerSettings s_jsonSerializerSettings =
            new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.None,
                DefaultValueHandling = DefaultValueHandling.Ignore,
                Converters = new JsonConverter[]
                {
                    new TrackablePocoTrackerJsonConverter<IUserData>(),
                    new TrackableDictionaryTrackerJsonConverter<int, string>(),
                    new TrackableSetTrackerJsonConverter<int>(),
                    new TrackableListTrackerJsonConverter<string>(),
                }
            };

        private static void RunTrackablePoco()
        {
            Console.WriteLine("***** TrackablePoco (Json) *****");

            var u = new TrackableUserData();
            u.SetDefaultTracker();

            u.Name = "Bob";
            u.Level = 1;
            u.Gold = 10;

            var json = JsonConvert.SerializeObject(u.Tracker, s_jsonSerializerSettings);
            Console.WriteLine(json);
            u.Tracker.Clear();

            u.Level += 10;
            u.Gold += 100;

            var json2 = JsonConvert.SerializeObject(u.Tracker, s_jsonSerializerSettings);
            Console.WriteLine(json2);
            u.Tracker.Clear();

            Console.WriteLine();
        }

        private static void RunTrackableDictionary()
        {
            Console.WriteLine("***** TrackableDictionary (Json) *****");

            var dict = new TrackableDictionary<int, string>();
            dict.SetDefaultTracker();

            dict.Add(1, "One");
            dict.Add(2, "Two");
            dict.Add(3, "Three");

            var json = JsonConvert.SerializeObject(dict.Tracker, s_jsonSerializerSettings);
            Console.WriteLine(json);
            dict.Tracker.Clear();

            dict.Remove(1);
            dict[2] = "TwoTwo";
            dict.Add(4, "Four");

            var json2 = JsonConvert.SerializeObject(dict.Tracker, s_jsonSerializerSettings);
            Console.WriteLine(json2);
            dict.Tracker.Clear();

            Console.WriteLine();
        }

        private static void RunTrackableSet()
        {
            Console.WriteLine("***** TrackableSet (Json) *****");

            var set = new TrackableSet<int>();
            set.SetDefaultTracker();

            set.Add(1);
            set.Add(2);
            set.Add(3);

            var json = JsonConvert.SerializeObject(set.Tracker, s_jsonSerializerSettings);
            Console.WriteLine(json);
            set.Tracker.Clear();

            set.Remove(1);
            set.Add(4);

            var json2 = JsonConvert.SerializeObject(set.Tracker, s_jsonSerializerSettings);
            Console.WriteLine(json2);
            set.Tracker.Clear();

            Console.WriteLine();
        }

        private static void RunTrackableList()
        {
            Console.WriteLine("***** TrackableList (Json) *****");

            var list = new TrackableList<string>();
            list.SetDefaultTracker();

            list.Add("One");
            list.Add("Two");
            list.Add("Three");

            var json = JsonConvert.SerializeObject(list.Tracker, s_jsonSerializerSettings);
            Console.WriteLine(json);
            list.Tracker.Clear();

            list.RemoveAt(0);
            list[1] = "TwoTwo";
            list.Add("Four");

            var json2 = JsonConvert.SerializeObject(list.Tracker, s_jsonSerializerSettings);
            Console.WriteLine(json2);
            list.Tracker.Clear();

            Console.WriteLine();
        }

        public static void Run()
        {
            RunTrackablePoco();
            RunTrackableDictionary();
            RunTrackableSet();
            RunTrackableList();
        }
    }
}
