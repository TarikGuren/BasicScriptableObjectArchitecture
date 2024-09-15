using UnityEngine;

namespace BasicScriptableObjectArchitecture.Runtime.Events
{
    [CreateAssetMenu(menuName = Constants.EVENT_BASE + "IntEvent", fileName = "IntEvent")]
    public class IntEvent : GameEvent<int>
    {
    }
}