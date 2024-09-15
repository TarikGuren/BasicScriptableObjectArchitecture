using UnityEngine;

namespace BasicScriptableObjectArchitecture.Events
{
    [CreateAssetMenu(menuName = Constants.EVENT_BASE + "IntEvent", fileName = "IntEvent")]
    public class IntEvent : GameEvent<int>
    {
    }
}