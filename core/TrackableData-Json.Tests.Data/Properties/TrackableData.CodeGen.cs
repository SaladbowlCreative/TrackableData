// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Akka.Interfaced CodeGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;
using TrackableData;

#region TrackableData.Json.Tests.Data.IHand

namespace TrackableData.Json.Tests.Data
{
    public class TrackableHand : IHand, ITrackable<IHand>
    {
        [IgnoreDataMember]
        public TrackablePocoTracker<IHand> Tracker { get; set; }

        public bool Changed { get { return Tracker != null && Tracker.HasChange; } }

        ITracker ITrackable.Tracker
        {
            get
            {
                return Tracker;
            }
            set
            {
                var t = (TrackablePocoTracker<IHand>)value;
                Tracker = t;
            }
        }

        ITracker<IHand> ITrackable<IHand>.Tracker
        {
            get
            {
                return Tracker;
            }
            set
            {
                var t = (TrackablePocoTracker<IHand>)value;
                Tracker = t;
            }
        }

        public ITrackable GetChildTrackable(object name)
        {
            switch ((string)name)
            {
                case "MainRing":
                    return MainRing as ITrackable;
                case "SubRing":
                    return SubRing as ITrackable;
                default:
                    return null;
            }
        }

        public IEnumerable<KeyValuePair<object, ITrackable>> GetChildTrackables(bool changedOnly = false)
        {
            var trackableMainRing = MainRing as ITrackable;
            if (trackableMainRing != null && (changedOnly == false || trackableMainRing.Changed))
                yield return new KeyValuePair<object, ITrackable>("MainRing", trackableMainRing);
            var trackableSubRing = SubRing as ITrackable;
            if (trackableSubRing != null && (changedOnly == false || trackableSubRing.Changed))
                yield return new KeyValuePair<object, ITrackable>("SubRing", trackableSubRing);
        }

        public static readonly PropertyInfo MainRingProperty = typeof(IHand).GetProperty("MainRing");
        public static readonly PropertyInfo SubRingProperty = typeof(IHand).GetProperty("SubRing");

        private TrackableData.Json.Tests.Data.IRing _MainRing;

        public TrackableData.Json.Tests.Data.IRing MainRing
        {
            get
            {
                return _MainRing;
            }
            set
            {
                if (Tracker != null && MainRing != value)
                    Tracker.TrackSet(MainRingProperty, _MainRing, value);
                _MainRing = value;
            }
        }

        private TrackableData.Json.Tests.Data.IRing _SubRing;

        public TrackableData.Json.Tests.Data.IRing SubRing
        {
            get
            {
                return _SubRing;
            }
            set
            {
                if (Tracker != null && SubRing != value)
                    Tracker.TrackSet(SubRingProperty, _SubRing, value);
                _SubRing = value;
            }
        }
    }
}

#endregion

#region TrackableData.Json.Tests.Data.IPerson

namespace TrackableData.Json.Tests.Data
{
    public class TrackablePerson : IPerson, ITrackable<IPerson>
    {
        [IgnoreDataMember]
        public TrackablePocoTracker<IPerson> Tracker { get; set; }

        public bool Changed { get { return Tracker != null && Tracker.HasChange; } }

        ITracker ITrackable.Tracker
        {
            get
            {
                return Tracker;
            }
            set
            {
                var t = (TrackablePocoTracker<IPerson>)value;
                Tracker = t;
            }
        }

        ITracker<IPerson> ITrackable<IPerson>.Tracker
        {
            get
            {
                return Tracker;
            }
            set
            {
                var t = (TrackablePocoTracker<IPerson>)value;
                Tracker = t;
            }
        }

        public ITrackable GetChildTrackable(object name)
        {
            switch ((string)name)
            {
                case "LeftHand":
                    return LeftHand as ITrackable;
                case "RightHand":
                    return RightHand as ITrackable;
                default:
                    return null;
            }
        }

        public IEnumerable<KeyValuePair<object, ITrackable>> GetChildTrackables(bool changedOnly = false)
        {
            var trackableLeftHand = LeftHand as ITrackable;
            if (trackableLeftHand != null && (changedOnly == false || trackableLeftHand.Changed))
                yield return new KeyValuePair<object, ITrackable>("LeftHand", trackableLeftHand);
            var trackableRightHand = RightHand as ITrackable;
            if (trackableRightHand != null && (changedOnly == false || trackableRightHand.Changed))
                yield return new KeyValuePair<object, ITrackable>("RightHand", trackableRightHand);
        }

        public static readonly PropertyInfo AgeProperty = typeof(IPerson).GetProperty("Age");
        public static readonly PropertyInfo LeftHandProperty = typeof(IPerson).GetProperty("LeftHand");
        public static readonly PropertyInfo NameProperty = typeof(IPerson).GetProperty("Name");
        public static readonly PropertyInfo RightHandProperty = typeof(IPerson).GetProperty("RightHand");

        private System.Int32 _Age;

        public System.Int32 Age
        {
            get
            {
                return _Age;
            }
            set
            {
                if (Tracker != null && Age != value)
                    Tracker.TrackSet(AgeProperty, _Age, value);
                _Age = value;
            }
        }

        private TrackableData.Json.Tests.Data.IHand _LeftHand;

        public TrackableData.Json.Tests.Data.IHand LeftHand
        {
            get
            {
                return _LeftHand;
            }
            set
            {
                if (Tracker != null && LeftHand != value)
                    Tracker.TrackSet(LeftHandProperty, _LeftHand, value);
                _LeftHand = value;
            }
        }

        private System.String _Name;

        public System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (Tracker != null && Name != value)
                    Tracker.TrackSet(NameProperty, _Name, value);
                _Name = value;
            }
        }

        private TrackableData.Json.Tests.Data.IHand _RightHand;

        public TrackableData.Json.Tests.Data.IHand RightHand
        {
            get
            {
                return _RightHand;
            }
            set
            {
                if (Tracker != null && RightHand != value)
                    Tracker.TrackSet(RightHandProperty, _RightHand, value);
                _RightHand = value;
            }
        }
    }
}

#endregion

#region TrackableData.Json.Tests.Data.IRing

namespace TrackableData.Json.Tests.Data
{
    public class TrackableRing : IRing, ITrackable<IRing>
    {
        [IgnoreDataMember]
        public TrackablePocoTracker<IRing> Tracker { get; set; }

        public bool Changed { get { return Tracker != null && Tracker.HasChange; } }

        ITracker ITrackable.Tracker
        {
            get
            {
                return Tracker;
            }
            set
            {
                var t = (TrackablePocoTracker<IRing>)value;
                Tracker = t;
            }
        }

        ITracker<IRing> ITrackable<IRing>.Tracker
        {
            get
            {
                return Tracker;
            }
            set
            {
                var t = (TrackablePocoTracker<IRing>)value;
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

        public static readonly PropertyInfo NameProperty = typeof(IRing).GetProperty("Name");
        public static readonly PropertyInfo PowerProperty = typeof(IRing).GetProperty("Power");

        private System.String _Name;

        public System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (Tracker != null && Name != value)
                    Tracker.TrackSet(NameProperty, _Name, value);
                _Name = value;
            }
        }

        private System.Int32 _Power;

        public System.Int32 Power
        {
            get
            {
                return _Power;
            }
            set
            {
                if (Tracker != null && Power != value)
                    Tracker.TrackSet(PowerProperty, _Power, value);
                _Power = value;
            }
        }
    }
}

#endregion

#region TrackableData.Json.Tests.Data.IDataContainer

namespace TrackableData.Json.Tests.Data
{
    public class TrackableDataContainer : IDataContainer, ITrackable<IDataContainer>
    {
        [IgnoreDataMember]
        private TrackableDataContainerTracker _tracker;

        [IgnoreDataMember]
        public TrackableDataContainerTracker Tracker
        {
            get
            {
                return _tracker;
            }
            set
            {
                _tracker = value;
                ((ITrackable)Dictionary).Tracker = value?.DictionaryTracker;
                ((ITrackable)List).Tracker = value?.ListTracker;
                ((ITrackable)Person).Tracker = value?.PersonTracker;
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
                var t = (TrackableDataContainerTracker)value;
                Tracker = t;
            }
        }

        ITracker<IDataContainer> ITrackable<IDataContainer>.Tracker
        {
            get
            {
                return Tracker;
            }
            set
            {
                var t = (TrackableDataContainerTracker)value;
                Tracker = t;
            }
        }

        public ITrackable GetChildTrackable(object name)
        {
            switch ((string)name)
            {
                case "Dictionary":
                    return Dictionary as ITrackable;
                case "List":
                    return List as ITrackable;
                case "Person":
                    return Person as ITrackable;
                default:
                    return null;
            }
        }

        public IEnumerable<KeyValuePair<object, ITrackable>> GetChildTrackables(bool changedOnly = false)
        {
            var trackableDictionary = Dictionary as ITrackable;
            if (trackableDictionary != null && (changedOnly == false || trackableDictionary.Changed))
                yield return new KeyValuePair<object, ITrackable>("Dictionary", trackableDictionary);
            var trackableList = List as ITrackable;
            if (trackableList != null && (changedOnly == false || trackableList.Changed))
                yield return new KeyValuePair<object, ITrackable>("List", trackableList);
            var trackablePerson = Person as ITrackable;
            if (trackablePerson != null && (changedOnly == false || trackablePerson.Changed))
                yield return new KeyValuePair<object, ITrackable>("Person", trackablePerson);
        }

        private TrackableDictionary<System.Int32, System.String> _Dictionary;

        public TrackableDictionary<System.Int32, System.String> Dictionary
        {
            get
            {
                return _Dictionary;
            }
            set
            {
                if (_Dictionary != null)
                    _Dictionary.Tracker = null;
                if (value != null)
                    value.Tracker = Tracker?.DictionaryTracker;
                _Dictionary = value;
            }
        }

        System.Collections.Generic.IDictionary<System.Int32, System.String> IDataContainer.Dictionary
        {
            get { return _Dictionary; }
            set { _Dictionary = (TrackableDictionary<System.Int32, System.String>)value; }
        }

        private TrackableList<System.String> _List;

        public TrackableList<System.String> List
        {
            get
            {
                return _List;
            }
            set
            {
                if (_List != null)
                    _List.Tracker = null;
                if (value != null)
                    value.Tracker = Tracker?.ListTracker;
                _List = value;
            }
        }

        System.Collections.Generic.IList<System.String> IDataContainer.List
        {
            get { return _List; }
            set { _List = (TrackableList<System.String>)value; }
        }

        private TrackablePerson _Person;

        public TrackablePerson Person
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

        TrackableData.Json.Tests.Data.IPerson IDataContainer.Person
        {
            get { return _Person; }
            set { _Person = (TrackablePerson)value; }
        }
    }

    public class TrackableDataContainerTracker : ITracker<IDataContainer>, ITrackableContainerTracker
    {
        public TrackableDictionaryTracker<System.Int32, System.String> DictionaryTracker = new TrackableDictionaryTracker<System.Int32, System.String>();
        public TrackableListTracker<System.String> ListTracker = new TrackableListTracker<System.String>();
        public TrackablePocoTracker<TrackableData.Json.Tests.Data.IPerson> PersonTracker = new TrackablePocoTracker<TrackableData.Json.Tests.Data.IPerson>();

        public bool HasChange
        {
            get
            {
                return
                    DictionaryTracker.HasChange ||
                    ListTracker.HasChange ||
                    PersonTracker.HasChange ||
                    false;
            }
        }

        public void Clear()
        {
            DictionaryTracker.Clear();
            ListTracker.Clear();
            PersonTracker.Clear();
        }

        public void ApplyTo(object trackable)
        {
            ApplyTo((IDataContainer)trackable);
        }

        public void ApplyTo(IDataContainer trackable)
        {
            DictionaryTracker.ApplyTo(trackable.Dictionary);
            ListTracker.ApplyTo(trackable.List);
            PersonTracker.ApplyTo(trackable.Person);
        }

        public void ApplyTo(ITracker tracker)
        {
            ApplyTo((TrackableDataContainerTracker)tracker);
        }

        public void ApplyTo(ITracker<IDataContainer> tracker)
        {
            ApplyTo((TrackableDataContainerTracker)tracker);
        }

        public void ApplyTo(TrackableDataContainerTracker tracker)
        {
            DictionaryTracker.ApplyTo(tracker.DictionaryTracker);
            ListTracker.ApplyTo(tracker.ListTracker);
            PersonTracker.ApplyTo(tracker.PersonTracker);
        }

        public void RollbackTo(object trackable)
        {
            RollbackTo((IDataContainer)trackable);
        }

        public void RollbackTo(IDataContainer trackable)
        {
            DictionaryTracker.RollbackTo(trackable.Dictionary);
            ListTracker.RollbackTo(trackable.List);
            PersonTracker.RollbackTo(trackable.Person);
        }

        public void RollbackTo(ITracker tracker)
        {
            RollbackTo((TrackableDataContainerTracker)tracker);
        }

        public void RollbackTo(ITracker<IDataContainer> tracker)
        {
            RollbackTo((TrackableDataContainerTracker)tracker);
        }

        public void RollbackTo(TrackableDataContainerTracker tracker)
        {
            DictionaryTracker.RollbackTo(tracker.DictionaryTracker);
            ListTracker.RollbackTo(tracker.ListTracker);
            PersonTracker.RollbackTo(tracker.PersonTracker);
        }
    }
}

#endregion
