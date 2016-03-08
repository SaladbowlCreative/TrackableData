﻿using Xunit;

namespace TrackableData.MySql.Tests
{
    public class TrackablePocoTest : SqlTestKits.TrackablePocoTest, IClassFixture<Database>
    {
        public TrackablePocoTest(Database db)
            : base(db, Database.SqlProvider)
        {
        }
    }

    public class TrackablePocoWithAutoIdTest : SqlTestKits.TrackablePocoWithAutoIdTest, IClassFixture<Database>
    {
        public TrackablePocoWithAutoIdTest(Database db)
            : base(db, Database.SqlProvider)
        {
        }
    }

    public class TrackablePocoWithHeadKeysTest : SqlTestKits.TrackablePocoWithHeadKeysTest, IClassFixture<Database>
    {
        public TrackablePocoWithHeadKeysTest(Database db)
            : base(db, Database.SqlProvider)
        {
        }
    }

    public class TrackableDictionaryDataTest : SqlTestKits.TrackableDictionaryDataTest, IClassFixture<Database>
    {
        public TrackableDictionaryDataTest(Database db)
            : base(db, Database.SqlProvider)
        {
        }
    }

    public class TrackableDictionaryDataWithHeadKeysTest : SqlTestKits.TrackableDictionaryDataWithHeadKeysTest, IClassFixture<Database>
    {
        public TrackableDictionaryDataWithHeadKeysTest(Database db)
            : base(db, Database.SqlProvider)
        {
        }
    }

    public class TrackableDictionaryStringTest : SqlTestKits.TrackableDictionaryStringTest, IClassFixture<Database>
    {
        public TrackableDictionaryStringTest(Database db)
            : base(db, Database.SqlProvider)
        {
        }
    }

    public class TrackableContainerTest : SqlTestKits.TrackableContainerTest, IClassFixture<Database>
    {
        public TrackableContainerTest(Database db)
            : base(db, Database.SqlProvider)
        {
        }
    }
}

