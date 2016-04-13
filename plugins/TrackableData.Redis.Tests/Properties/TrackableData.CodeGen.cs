﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by TrackableData.CodeGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;
using TrackableData;
using System.Threading.Tasks;
using StackExchange.Redis;
using TrackableData.TestKits;
using Xunit;

#region ITestPocoForContainer

namespace TrackableData.Redis.Tests
{
    public partial class TrackableTestPocoForContainer : ITestPocoForContainer
    {
        [IgnoreDataMember]
        public IPocoTracker<ITestPocoForContainer> Tracker { get; set; }

        [IgnoreDataMember]
        public bool Changed { get { return Tracker != null && Tracker.HasChange; } }

        ITracker ITrackable.Tracker
        {
            get
            {
                return Tracker;
            }
            set
            {
                var t = (IPocoTracker<ITestPocoForContainer>)value;
                Tracker = t;
            }
        }

        ITracker<ITestPocoForContainer> ITrackable<ITestPocoForContainer>.Tracker
        {
            get
            {
                return Tracker;
            }
            set
            {
                var t = (IPocoTracker<ITestPocoForContainer>)value;
                Tracker = t;
            }
        }

        public ITrackable GetChildTrackable(object name)
        {
            switch ((string)name)
            {
                default:
                    return null;
            }
        }

        public IEnumerable<KeyValuePair<object, ITrackable>> GetChildTrackables(bool changedOnly = false)
        {
            yield break;
        }

        public static class PropertyTable
        {
            public static readonly PropertyInfo Name = typeof(ITestPocoForContainer).GetProperty("Name");
            public static readonly PropertyInfo Age = typeof(ITestPocoForContainer).GetProperty("Age");
            public static readonly PropertyInfo Extra = typeof(ITestPocoForContainer).GetProperty("Extra");
        }

        private string _Name;

        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (Tracker != null && Name != value)
                    Tracker.TrackSet(PropertyTable.Name, _Name, value);
                _Name = value;
            }
        }

        private int _Age;

        public int Age
        {
            get
            {
                return _Age;
            }
            set
            {
                if (Tracker != null && Age != value)
                    Tracker.TrackSet(PropertyTable.Age, _Age, value);
                _Age = value;
            }
        }

        private int _Extra;

        public int Extra
        {
            get
            {
                return _Extra;
            }
            set
            {
                if (Tracker != null && Extra != value)
                    Tracker.TrackSet(PropertyTable.Extra, _Extra, value);
                _Extra = value;
            }
        }
    }
}

#endregion
#region ITestPoco

namespace TrackableData.Redis.Tests
{
    public partial class TrackableTestPoco : ITestPoco
    {
        [IgnoreDataMember]
        public IPocoTracker<ITestPoco> Tracker { get; set; }

        [IgnoreDataMember]
        public bool Changed { get { return Tracker != null && Tracker.HasChange; } }

        ITracker ITrackable.Tracker
        {
            get
            {
                return Tracker;
            }
            set
            {
                var t = (IPocoTracker<ITestPoco>)value;
                Tracker = t;
            }
        }

        ITracker<ITestPoco> ITrackable<ITestPoco>.Tracker
        {
            get
            {
                return Tracker;
            }
            set
            {
                var t = (IPocoTracker<ITestPoco>)value;
                Tracker = t;
            }
        }

        public ITrackable GetChildTrackable(object name)
        {
            switch ((string)name)
            {
                default:
                    return null;
            }
        }

        public IEnumerable<KeyValuePair<object, ITrackable>> GetChildTrackables(bool changedOnly = false)
        {
            yield break;
        }

        public static class PropertyTable
        {
            public static readonly PropertyInfo Id = typeof(ITestPoco).GetProperty("Id");
            public static readonly PropertyInfo Name = typeof(ITestPoco).GetProperty("Name");
            public static readonly PropertyInfo Age = typeof(ITestPoco).GetProperty("Age");
            public static readonly PropertyInfo Extra = typeof(ITestPoco).GetProperty("Extra");
        }

        private int _Id;

        public int Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (Tracker != null && Id != value)
                    Tracker.TrackSet(PropertyTable.Id, _Id, value);
                _Id = value;
            }
        }

        private string _Name;

        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (Tracker != null && Name != value)
                    Tracker.TrackSet(PropertyTable.Name, _Name, value);
                _Name = value;
            }
        }

        private int _Age;

        public int Age
        {
            get
            {
                return _Age;
            }
            set
            {
                if (Tracker != null && Age != value)
                    Tracker.TrackSet(PropertyTable.Age, _Age, value);
                _Age = value;
            }
        }

        private int _Extra;

        public int Extra
        {
            get
            {
                return _Extra;
            }
            set
            {
                if (Tracker != null && Extra != value)
                    Tracker.TrackSet(PropertyTable.Extra, _Extra, value);
                _Extra = value;
            }
        }
    }
}

#endregion
#region ITestTypeNullablePoco

namespace TrackableData.Redis.Tests
{
    public partial class TrackableTestTypeNullablePoco : ITestTypeNullablePoco
    {
        [IgnoreDataMember]
        public IPocoTracker<ITestTypeNullablePoco> Tracker { get; set; }

        [IgnoreDataMember]
        public bool Changed { get { return Tracker != null && Tracker.HasChange; } }

        ITracker ITrackable.Tracker
        {
            get
            {
                return Tracker;
            }
            set
            {
                var t = (IPocoTracker<ITestTypeNullablePoco>)value;
                Tracker = t;
            }
        }

        ITracker<ITestTypeNullablePoco> ITrackable<ITestTypeNullablePoco>.Tracker
        {
            get
            {
                return Tracker;
            }
            set
            {
                var t = (IPocoTracker<ITestTypeNullablePoco>)value;
                Tracker = t;
            }
        }

        public ITrackable GetChildTrackable(object name)
        {
            switch ((string)name)
            {
                default:
                    return null;
            }
        }

        public IEnumerable<KeyValuePair<object, ITrackable>> GetChildTrackables(bool changedOnly = false)
        {
            yield break;
        }

        public static class PropertyTable
        {
            public static readonly PropertyInfo Id = typeof(ITestTypeNullablePoco).GetProperty("Id");
            public static readonly PropertyInfo ValBool = typeof(ITestTypeNullablePoco).GetProperty("ValBool");
            public static readonly PropertyInfo ValByte = typeof(ITestTypeNullablePoco).GetProperty("ValByte");
            public static readonly PropertyInfo ValShort = typeof(ITestTypeNullablePoco).GetProperty("ValShort");
            public static readonly PropertyInfo ValChar = typeof(ITestTypeNullablePoco).GetProperty("ValChar");
            public static readonly PropertyInfo ValInt = typeof(ITestTypeNullablePoco).GetProperty("ValInt");
            public static readonly PropertyInfo ValLong = typeof(ITestTypeNullablePoco).GetProperty("ValLong");
            public static readonly PropertyInfo ValFloat = typeof(ITestTypeNullablePoco).GetProperty("ValFloat");
            public static readonly PropertyInfo ValDouble = typeof(ITestTypeNullablePoco).GetProperty("ValDouble");
            public static readonly PropertyInfo ValDecimal = typeof(ITestTypeNullablePoco).GetProperty("ValDecimal");
            public static readonly PropertyInfo ValDateTime = typeof(ITestTypeNullablePoco).GetProperty("ValDateTime");
            public static readonly PropertyInfo ValDateTimeOffset = typeof(ITestTypeNullablePoco).GetProperty("ValDateTimeOffset");
            public static readonly PropertyInfo ValTimeSpan = typeof(ITestTypeNullablePoco).GetProperty("ValTimeSpan");
            public static readonly PropertyInfo ValGuid = typeof(ITestTypeNullablePoco).GetProperty("ValGuid");
            public static readonly PropertyInfo ValSuit = typeof(ITestTypeNullablePoco).GetProperty("ValSuit");
        }

        private int _Id;

        public int Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (Tracker != null && Id != value)
                    Tracker.TrackSet(PropertyTable.Id, _Id, value);
                _Id = value;
            }
        }

        private bool? _ValBool;

        public bool? ValBool
        {
            get
            {
                return _ValBool;
            }
            set
            {
                if (Tracker != null && ValBool != value)
                    Tracker.TrackSet(PropertyTable.ValBool, _ValBool, value);
                _ValBool = value;
            }
        }

        private byte? _ValByte;

        public byte? ValByte
        {
            get
            {
                return _ValByte;
            }
            set
            {
                if (Tracker != null && ValByte != value)
                    Tracker.TrackSet(PropertyTable.ValByte, _ValByte, value);
                _ValByte = value;
            }
        }

        private short? _ValShort;

        public short? ValShort
        {
            get
            {
                return _ValShort;
            }
            set
            {
                if (Tracker != null && ValShort != value)
                    Tracker.TrackSet(PropertyTable.ValShort, _ValShort, value);
                _ValShort = value;
            }
        }

        private char? _ValChar;

        public char? ValChar
        {
            get
            {
                return _ValChar;
            }
            set
            {
                if (Tracker != null && ValChar != value)
                    Tracker.TrackSet(PropertyTable.ValChar, _ValChar, value);
                _ValChar = value;
            }
        }

        private int? _ValInt;

        public int? ValInt
        {
            get
            {
                return _ValInt;
            }
            set
            {
                if (Tracker != null && ValInt != value)
                    Tracker.TrackSet(PropertyTable.ValInt, _ValInt, value);
                _ValInt = value;
            }
        }

        private long? _ValLong;

        public long? ValLong
        {
            get
            {
                return _ValLong;
            }
            set
            {
                if (Tracker != null && ValLong != value)
                    Tracker.TrackSet(PropertyTable.ValLong, _ValLong, value);
                _ValLong = value;
            }
        }

        private float? _ValFloat;

        public float? ValFloat
        {
            get
            {
                return _ValFloat;
            }
            set
            {
                if (Tracker != null && ValFloat != value)
                    Tracker.TrackSet(PropertyTable.ValFloat, _ValFloat, value);
                _ValFloat = value;
            }
        }

        private double? _ValDouble;

        public double? ValDouble
        {
            get
            {
                return _ValDouble;
            }
            set
            {
                if (Tracker != null && ValDouble != value)
                    Tracker.TrackSet(PropertyTable.ValDouble, _ValDouble, value);
                _ValDouble = value;
            }
        }

        private decimal? _ValDecimal;

        public decimal? ValDecimal
        {
            get
            {
                return _ValDecimal;
            }
            set
            {
                if (Tracker != null && ValDecimal != value)
                    Tracker.TrackSet(PropertyTable.ValDecimal, _ValDecimal, value);
                _ValDecimal = value;
            }
        }

        private DateTime? _ValDateTime;

        public DateTime? ValDateTime
        {
            get
            {
                return _ValDateTime;
            }
            set
            {
                if (Tracker != null && ValDateTime != value)
                    Tracker.TrackSet(PropertyTable.ValDateTime, _ValDateTime, value);
                _ValDateTime = value;
            }
        }

        private DateTimeOffset? _ValDateTimeOffset;

        public DateTimeOffset? ValDateTimeOffset
        {
            get
            {
                return _ValDateTimeOffset;
            }
            set
            {
                if (Tracker != null && ValDateTimeOffset != value)
                    Tracker.TrackSet(PropertyTable.ValDateTimeOffset, _ValDateTimeOffset, value);
                _ValDateTimeOffset = value;
            }
        }

        private TimeSpan? _ValTimeSpan;

        public TimeSpan? ValTimeSpan
        {
            get
            {
                return _ValTimeSpan;
            }
            set
            {
                if (Tracker != null && ValTimeSpan != value)
                    Tracker.TrackSet(PropertyTable.ValTimeSpan, _ValTimeSpan, value);
                _ValTimeSpan = value;
            }
        }

        private Guid? _ValGuid;

        public Guid? ValGuid
        {
            get
            {
                return _ValGuid;
            }
            set
            {
                if (Tracker != null && ValGuid != value)
                    Tracker.TrackSet(PropertyTable.ValGuid, _ValGuid, value);
                _ValGuid = value;
            }
        }

        private Suit? _ValSuit;

        public Suit? ValSuit
        {
            get
            {
                return _ValSuit;
            }
            set
            {
                if (Tracker != null && ValSuit != value)
                    Tracker.TrackSet(PropertyTable.ValSuit, _ValSuit, value);
                _ValSuit = value;
            }
        }
    }
}

#endregion
#region ITestTypePoco

namespace TrackableData.Redis.Tests
{
    public partial class TrackableTestTypePoco : ITestTypePoco
    {
        [IgnoreDataMember]
        public IPocoTracker<ITestTypePoco> Tracker { get; set; }

        [IgnoreDataMember]
        public bool Changed { get { return Tracker != null && Tracker.HasChange; } }

        ITracker ITrackable.Tracker
        {
            get
            {
                return Tracker;
            }
            set
            {
                var t = (IPocoTracker<ITestTypePoco>)value;
                Tracker = t;
            }
        }

        ITracker<ITestTypePoco> ITrackable<ITestTypePoco>.Tracker
        {
            get
            {
                return Tracker;
            }
            set
            {
                var t = (IPocoTracker<ITestTypePoco>)value;
                Tracker = t;
            }
        }

        public ITrackable GetChildTrackable(object name)
        {
            switch ((string)name)
            {
                default:
                    return null;
            }
        }

        public IEnumerable<KeyValuePair<object, ITrackable>> GetChildTrackables(bool changedOnly = false)
        {
            yield break;
        }

        public static class PropertyTable
        {
            public static readonly PropertyInfo ValBool = typeof(ITestTypePoco).GetProperty("ValBool");
            public static readonly PropertyInfo ValByte = typeof(ITestTypePoco).GetProperty("ValByte");
            public static readonly PropertyInfo ValShort = typeof(ITestTypePoco).GetProperty("ValShort");
            public static readonly PropertyInfo ValChar = typeof(ITestTypePoco).GetProperty("ValChar");
            public static readonly PropertyInfo ValInt = typeof(ITestTypePoco).GetProperty("ValInt");
            public static readonly PropertyInfo ValLong = typeof(ITestTypePoco).GetProperty("ValLong");
            public static readonly PropertyInfo ValFloat = typeof(ITestTypePoco).GetProperty("ValFloat");
            public static readonly PropertyInfo ValDouble = typeof(ITestTypePoco).GetProperty("ValDouble");
            public static readonly PropertyInfo ValDecimal = typeof(ITestTypePoco).GetProperty("ValDecimal");
            public static readonly PropertyInfo ValDateTime = typeof(ITestTypePoco).GetProperty("ValDateTime");
            public static readonly PropertyInfo ValDateTimeOffset = typeof(ITestTypePoco).GetProperty("ValDateTimeOffset");
            public static readonly PropertyInfo ValTimeSpan = typeof(ITestTypePoco).GetProperty("ValTimeSpan");
            public static readonly PropertyInfo ValString = typeof(ITestTypePoco).GetProperty("ValString");
            public static readonly PropertyInfo ValBytes = typeof(ITestTypePoco).GetProperty("ValBytes");
            public static readonly PropertyInfo ValGuid = typeof(ITestTypePoco).GetProperty("ValGuid");
            public static readonly PropertyInfo ValSuit = typeof(ITestTypePoco).GetProperty("ValSuit");
        }

        private bool _ValBool;

        public bool ValBool
        {
            get
            {
                return _ValBool;
            }
            set
            {
                if (Tracker != null && ValBool != value)
                    Tracker.TrackSet(PropertyTable.ValBool, _ValBool, value);
                _ValBool = value;
            }
        }

        private byte _ValByte;

        public byte ValByte
        {
            get
            {
                return _ValByte;
            }
            set
            {
                if (Tracker != null && ValByte != value)
                    Tracker.TrackSet(PropertyTable.ValByte, _ValByte, value);
                _ValByte = value;
            }
        }

        private short _ValShort;

        public short ValShort
        {
            get
            {
                return _ValShort;
            }
            set
            {
                if (Tracker != null && ValShort != value)
                    Tracker.TrackSet(PropertyTable.ValShort, _ValShort, value);
                _ValShort = value;
            }
        }

        private char _ValChar;

        public char ValChar
        {
            get
            {
                return _ValChar;
            }
            set
            {
                if (Tracker != null && ValChar != value)
                    Tracker.TrackSet(PropertyTable.ValChar, _ValChar, value);
                _ValChar = value;
            }
        }

        private int _ValInt;

        public int ValInt
        {
            get
            {
                return _ValInt;
            }
            set
            {
                if (Tracker != null && ValInt != value)
                    Tracker.TrackSet(PropertyTable.ValInt, _ValInt, value);
                _ValInt = value;
            }
        }

        private long _ValLong;

        public long ValLong
        {
            get
            {
                return _ValLong;
            }
            set
            {
                if (Tracker != null && ValLong != value)
                    Tracker.TrackSet(PropertyTable.ValLong, _ValLong, value);
                _ValLong = value;
            }
        }

        private float _ValFloat;

        public float ValFloat
        {
            get
            {
                return _ValFloat;
            }
            set
            {
                if (Tracker != null && ValFloat != value)
                    Tracker.TrackSet(PropertyTable.ValFloat, _ValFloat, value);
                _ValFloat = value;
            }
        }

        private double _ValDouble;

        public double ValDouble
        {
            get
            {
                return _ValDouble;
            }
            set
            {
                if (Tracker != null && ValDouble != value)
                    Tracker.TrackSet(PropertyTable.ValDouble, _ValDouble, value);
                _ValDouble = value;
            }
        }

        private decimal _ValDecimal;

        public decimal ValDecimal
        {
            get
            {
                return _ValDecimal;
            }
            set
            {
                if (Tracker != null && ValDecimal != value)
                    Tracker.TrackSet(PropertyTable.ValDecimal, _ValDecimal, value);
                _ValDecimal = value;
            }
        }

        private DateTime _ValDateTime;

        public DateTime ValDateTime
        {
            get
            {
                return _ValDateTime;
            }
            set
            {
                if (Tracker != null && ValDateTime != value)
                    Tracker.TrackSet(PropertyTable.ValDateTime, _ValDateTime, value);
                _ValDateTime = value;
            }
        }

        private DateTimeOffset _ValDateTimeOffset;

        public DateTimeOffset ValDateTimeOffset
        {
            get
            {
                return _ValDateTimeOffset;
            }
            set
            {
                if (Tracker != null && ValDateTimeOffset != value)
                    Tracker.TrackSet(PropertyTable.ValDateTimeOffset, _ValDateTimeOffset, value);
                _ValDateTimeOffset = value;
            }
        }

        private TimeSpan _ValTimeSpan;

        public TimeSpan ValTimeSpan
        {
            get
            {
                return _ValTimeSpan;
            }
            set
            {
                if (Tracker != null && ValTimeSpan != value)
                    Tracker.TrackSet(PropertyTable.ValTimeSpan, _ValTimeSpan, value);
                _ValTimeSpan = value;
            }
        }

        private string _ValString;

        public string ValString
        {
            get
            {
                return _ValString;
            }
            set
            {
                if (Tracker != null && ValString != value)
                    Tracker.TrackSet(PropertyTable.ValString, _ValString, value);
                _ValString = value;
            }
        }

        private byte[] _ValBytes;

        public byte[] ValBytes
        {
            get
            {
                return _ValBytes;
            }
            set
            {
                if (Tracker != null && ValBytes != value)
                    Tracker.TrackSet(PropertyTable.ValBytes, _ValBytes, value);
                _ValBytes = value;
            }
        }

        private Guid _ValGuid;

        public Guid ValGuid
        {
            get
            {
                return _ValGuid;
            }
            set
            {
                if (Tracker != null && ValGuid != value)
                    Tracker.TrackSet(PropertyTable.ValGuid, _ValGuid, value);
                _ValGuid = value;
            }
        }

        private Suit _ValSuit;

        public Suit ValSuit
        {
            get
            {
                return _ValSuit;
            }
            set
            {
                if (Tracker != null && ValSuit != value)
                    Tracker.TrackSet(PropertyTable.ValSuit, _ValSuit, value);
                _ValSuit = value;
            }
        }
    }
}

#endregion
#region ITestContainer

namespace TrackableData.Redis.Tests
{
    public partial class TrackableTestContainer : ITestContainer
    {
        [IgnoreDataMember]
        private TrackableTestContainerTracker _tracker;

        [IgnoreDataMember]
        public TrackableTestContainerTracker Tracker
        {
            get
            {
                return _tracker;
            }
            set
            {
                _tracker = value;
                Person.Tracker = value?.PersonTracker;
                Missions.Tracker = value?.MissionsTracker;
                Tags.Tracker = value?.TagsTracker;
            }
        }

        public bool Changed { get { return Tracker != null && Tracker.HasChange; } }

        ITracker ITrackable.Tracker
        {
            get
            {
                return Tracker;
            }
            set
            {
                var t = (TrackableTestContainerTracker)value;
                Tracker = t;
            }
        }

        ITracker<ITestContainer> ITrackable<ITestContainer>.Tracker
        {
            get
            {
                return Tracker;
            }
            set
            {
                var t = (TrackableTestContainerTracker)value;
                Tracker = t;
            }
        }

        IContainerTracker<ITestContainer> ITrackableContainer<ITestContainer>.Tracker
        {
            get
            {
                return Tracker;
            }
            set
            {
                var t = (TrackableTestContainerTracker)value;
                Tracker = t;
            }
        }

        public ITrackable GetChildTrackable(object name)
        {
            switch ((string)name)
            {
                case "Person":
                    return Person as ITrackable;
                case "Missions":
                    return Missions as ITrackable;
                case "Tags":
                    return Tags as ITrackable;
                default:
                    return null;
            }
        }

        public IEnumerable<KeyValuePair<object, ITrackable>> GetChildTrackables(bool changedOnly = false)
        {
            var trackablePerson = Person as ITrackable;
            if (trackablePerson != null && (changedOnly == false || trackablePerson.Changed))
                yield return new KeyValuePair<object, ITrackable>("Person", trackablePerson);
            var trackableMissions = Missions as ITrackable;
            if (trackableMissions != null && (changedOnly == false || trackableMissions.Changed))
                yield return new KeyValuePair<object, ITrackable>("Missions", trackableMissions);
            var trackableTags = Tags as ITrackable;
            if (trackableTags != null && (changedOnly == false || trackableTags.Changed))
                yield return new KeyValuePair<object, ITrackable>("Tags", trackableTags);
        }

        private TrackableTestPocoForContainer _Person = new TrackableTestPocoForContainer();

        public TrackableTestPocoForContainer Person
        {
            get
            {
                return _Person;
            }
            set
            {
                if (_Person != null)
                    _Person.Tracker = null;
                if (value != null)
                    value.Tracker = Tracker?.PersonTracker;
                _Person = value;
            }
        }

        TrackableTestPocoForContainer ITestContainer.Person
        {
            get { return _Person; }
            set { _Person = (TrackableTestPocoForContainer)value; }
        }

        private TrackableDictionary<int, MissionData> _Missions = new TrackableDictionary<int, MissionData>();

        public TrackableDictionary<int, MissionData> Missions
        {
            get
            {
                return _Missions;
            }
            set
            {
                if (_Missions != null)
                    _Missions.Tracker = null;
                if (value != null)
                    value.Tracker = Tracker?.MissionsTracker;
                _Missions = value;
            }
        }

        TrackableDictionary<int, MissionData> ITestContainer.Missions
        {
            get { return _Missions; }
            set { _Missions = (TrackableDictionary<int, MissionData>)value; }
        }

        private TrackableList<TagData> _Tags = new TrackableList<TagData>();

        public TrackableList<TagData> Tags
        {
            get
            {
                return _Tags;
            }
            set
            {
                if (_Tags != null)
                    _Tags.Tracker = null;
                if (value != null)
                    value.Tracker = Tracker?.TagsTracker;
                _Tags = value;
            }
        }

        TrackableList<TagData> ITestContainer.Tags
        {
            get { return _Tags; }
            set { _Tags = (TrackableList<TagData>)value; }
        }
    }

    public class TrackableTestContainerTracker : IContainerTracker<ITestContainer>
    {
        public TrackablePocoTracker<ITestPocoForContainer> PersonTracker { get; set; } = new TrackablePocoTracker<ITestPocoForContainer>();
        public TrackableDictionaryTracker<int, MissionData> MissionsTracker { get; set; } = new TrackableDictionaryTracker<int, MissionData>();
        public TrackableListTracker<TagData> TagsTracker { get; set; } = new TrackableListTracker<TagData>();

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("{ ");
            var first = true;
            if (PersonTracker != null && PersonTracker.HasChange)
            {
                if (first)
                    first = false;
                else
                    sb.Append(", ");
                sb.Append("Person:");
                sb.Append(PersonTracker);
            }

            if (MissionsTracker != null && MissionsTracker.HasChange)
            {
                if (first)
                    first = false;
                else
                    sb.Append(", ");
                sb.Append("Missions:");
                sb.Append(MissionsTracker);
            }

            if (TagsTracker != null && TagsTracker.HasChange)
            {
                if (first)
                    first = false;
                else
                    sb.Append(", ");
                sb.Append("Tags:");
                sb.Append(TagsTracker);
            }

            sb.Append(" }");
            return sb.ToString();
        }

        public bool HasChange
        {
            get
            {
                return
                    (PersonTracker != null && PersonTracker.HasChange) ||
                    (MissionsTracker != null && MissionsTracker.HasChange) ||
                    (TagsTracker != null && TagsTracker.HasChange) ||
                    false;
            }
        }

        public event TrackerHasChangeSet HasChangeSet
        {
            add { throw new NotImplementedException(); }
            remove { throw new NotImplementedException(); }
        }

        public void Clear()
        {
            if (PersonTracker != null)
                PersonTracker.Clear();
            if (MissionsTracker != null)
                MissionsTracker.Clear();
            if (TagsTracker != null)
                TagsTracker.Clear();
        }

        public void ApplyTo(object trackable)
        {
            ApplyTo((ITestContainer)trackable);
        }

        public void ApplyTo(ITestContainer trackable)
        {
            if (PersonTracker != null)
                PersonTracker.ApplyTo(trackable.Person);
            if (MissionsTracker != null)
                MissionsTracker.ApplyTo(trackable.Missions);
            if (TagsTracker != null)
                TagsTracker.ApplyTo(trackable.Tags);
        }

        public void ApplyTo(ITracker tracker)
        {
            ApplyTo((TrackableTestContainerTracker)tracker);
        }

        public void ApplyTo(ITracker<ITestContainer> tracker)
        {
            ApplyTo((TrackableTestContainerTracker)tracker);
        }

        public void ApplyTo(TrackableTestContainerTracker tracker)
        {
            if (PersonTracker != null)
                PersonTracker.ApplyTo(tracker.PersonTracker);
            if (MissionsTracker != null)
                MissionsTracker.ApplyTo(tracker.MissionsTracker);
            if (TagsTracker != null)
                TagsTracker.ApplyTo(tracker.TagsTracker);
        }

        public void RollbackTo(object trackable)
        {
            RollbackTo((ITestContainer)trackable);
        }

        public void RollbackTo(ITestContainer trackable)
        {
            if (PersonTracker != null)
                PersonTracker.RollbackTo(trackable.Person);
            if (MissionsTracker != null)
                MissionsTracker.RollbackTo(trackable.Missions);
            if (TagsTracker != null)
                TagsTracker.RollbackTo(trackable.Tags);
        }

        public void RollbackTo(ITracker tracker)
        {
            RollbackTo((TrackableTestContainerTracker)tracker);
        }

        public void RollbackTo(ITracker<ITestContainer> tracker)
        {
            RollbackTo((TrackableTestContainerTracker)tracker);
        }

        public void RollbackTo(TrackableTestContainerTracker tracker)
        {
            if (PersonTracker != null)
                PersonTracker.RollbackTo(tracker.PersonTracker);
            if (MissionsTracker != null)
                MissionsTracker.RollbackTo(tracker.MissionsTracker);
            if (TagsTracker != null)
                TagsTracker.RollbackTo(tracker.TagsTracker);
        }
    }
}

#endregion
