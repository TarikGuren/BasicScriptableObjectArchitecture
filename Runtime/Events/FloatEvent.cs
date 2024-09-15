using UnityEngine;

namespace BasicScriptableObjectArchitecture.Runtime.Events
{    
    [CreateAssetMenu(menuName = Constants.EVENT_BASE + "FloatEvent", fileName = "FloatEvent")]
    public class FloatEvent : GameEvent<float>
    {
    }
}