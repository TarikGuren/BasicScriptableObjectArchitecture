using System;
using System.Collections.Generic;
using UnityEngine;

namespace BasicScriptableObjectArchitecture.Events
{
    [CreateAssetMenu(menuName = Constants.EVENT_BASE + "GameEvent", fileName = "GameEvent", order = -1)]
    public class GameEvent : ScriptableObject
    {
        private readonly List<Action> _eventListeners = new();

        public void Invoke()
        {
            for (int i = _eventListeners.Count - 1; i >= 0; i--)
                _eventListeners[i].Invoke();
        }

        public void AddListener(Action listener)
        {
            if (!_eventListeners.Contains(listener))
                _eventListeners.Add(listener);
        }

        public void RemoveListener(Action listener)
        {
            if (_eventListeners.Contains(listener))
                _eventListeners.Remove(listener);
        }
    }
    
    public abstract class GameEvent<T> : ScriptableObject
    {
        private readonly List<Action<T>> _eventListeners = new();

        public void Invoke(T arg)
        {
            for (int i = _eventListeners.Count - 1; i >= 0; i--)
                _eventListeners[i].Invoke(arg);
        }

        public void AddListener(Action<T> listener)
        {
            if (!_eventListeners.Contains(listener))
                _eventListeners.Add(listener);
        }

        public void RemoveListener(Action<T> listener)
        {
            if (_eventListeners.Contains(listener))
                _eventListeners.Remove(listener);
        }
    }
}