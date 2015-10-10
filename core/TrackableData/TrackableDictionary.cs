﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace TrackableData
{
    public class TrackableDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ITrackable
        where TValue : new()
    {
        private readonly Dictionary<TKey, TValue> _dictionary = new Dictionary<TKey, TValue>();

        // Tracker

        public TrackableDictionaryTracker<TKey, TValue> Tracker { get; set; }

        // ITrackable

        public bool Changed
        {
            get
            {
                return Tracker != null && Tracker.HasChange;
            }
        }

        ITracker ITrackable.Tracker
        {
            get
            {
                return Tracker;
            }

            set
            {
                var tracker = (TrackableDictionaryTracker<TKey, TValue>)value;
                Tracker = tracker;
            }
        }

        public IEnumerable<ITrackable> ChildrenTrackables
        {
            get
            {
                // TODO: DO IT LATER
                yield break;
            }
        }

        // IDictionary<TKey, TValue>

        public bool ContainsKey(TKey key)
        {
            return _dictionary.ContainsKey(key);
        }

        public void Add(TKey key, TValue value)
        {
            _dictionary.Add(key, value);

            if (Tracker != null)
                Tracker.TrackAdd(key, value);
        }

        public bool Remove(TKey key)
        {
            TValue value;
            if (_dictionary.TryGetValue(key, out value))
            {
                _dictionary.Remove(key);
                if (Tracker != null)
                    Tracker.TrackRemove(key, value);
                return true;
            }
            return false;
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            return _dictionary.TryGetValue(key, out value);
        }

        public TValue this[TKey key]
        {
            get { return _dictionary[key]; }
            set
            {
                TValue oldValue;
                if (_dictionary.TryGetValue(key, out oldValue))
                {
                    _dictionary[key] = value;

                    if (Tracker != null)
                        Tracker.TrackModify(key, oldValue, value);
                }
                else
                {
                    _dictionary[key] = value;

                    if (Tracker != null)
                        Tracker.TrackAdd(key, value);
                }
            }
        }

        public ICollection<TKey> Keys
        {
            get { return _dictionary.Keys; }
        }

        public ICollection<TValue> Values
        {
            get { return _dictionary.Values; }
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return _dictionary.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_dictionary).GetEnumerator();
        }

        // ICollection<KeyValuePair<TKey, TValue>>

        public void Add(KeyValuePair<TKey, TValue> item)
        {
            ((ICollection<KeyValuePair<TKey, TValue>>)_dictionary).Add(item);

            if (Tracker != null)
            {
                if (Tracker != null)
                    Tracker.TrackAdd(item.Key, item.Value);
            }
        }

        public void Clear()
        {
            if (Tracker != null)
            {
                foreach (var i in _dictionary)
                {
                    if (Tracker != null)
                        Tracker.TrackRemove(i.Key, i.Value);
                }
            }
            _dictionary.Clear();
        }

        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            return ((ICollection<KeyValuePair<TKey, TValue>>)_dictionary).Contains(item);
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            ((ICollection<KeyValuePair<TKey, TValue>>)_dictionary).CopyTo(array, arrayIndex);
        }

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            if (((ICollection<KeyValuePair<TKey, TValue>>)_dictionary).Remove(item))
            {
                if (Tracker != null)
                    Tracker.TrackRemove(item.Key, item.Value);
                return true;
            }
            return false;
        }

        public int Count
        {
            get { return _dictionary.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }
    }
}
