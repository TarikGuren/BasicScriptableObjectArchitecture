using UnityEngine;
using UnityEngine.Events;

namespace BasicScriptableObjectArchitecture.Runtime.Events
{
    public class GameEventListener : MonoBehaviour
    {
        [Tooltip("Event to register with.")] 
        public GameEvent Event;

        [Tooltip("Response to invoke when Event is raised.")]
        public UnityEvent Response;

        private void OnEnable()
        {
            Event.AddListener(OnEventRaised);
        }

        private void OnDisable()
        {
            Event.RemoveListener(OnEventRaised);
        }

        public void OnEventRaised()
        {
            Response.Invoke();
        }
    }
    
    public abstract class GameEventListener<T, TEvent> : MonoBehaviour where TEvent : GameEvent<T>
    {
        [Tooltip("Event to register with.")] 
        public TEvent Event;

        [Tooltip("Response to invoke when Event is raised.")]
        public UnityEvent<T> Response;

        private void OnEnable()
        {
            Event.AddListener(OnEventRaised);
        }

        private void OnDisable()
        {
            Event.RemoveListener(OnEventRaised);
        }

        public void OnEventRaised(T arg)
        {
            Response.Invoke(arg);
        }
    }
}