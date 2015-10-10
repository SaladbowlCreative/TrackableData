﻿using Basic.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackableData;

namespace Basic.Program
{
    class BasicExample
    {
        public static void Run()
        {
            var ud = new TrackableUserData();
            ud.Tracker = new TrackablePocoTracker<UserData>();
            ud.Name = "Bob";
            ud.Level = 1;
            ud.Gold = 10;
            Console.WriteLine(ud.Tracker);
        }
    }
}
