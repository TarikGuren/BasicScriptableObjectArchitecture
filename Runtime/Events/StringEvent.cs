using UnityEngine;

namespace BasicScriptableObjectArchitecture.Runtime.Events
{
    [CreateAssetMenu(menuName = Constants.EVENT_BASE + "StringEvent", fileName = "StringEvent")]
    public class StringEvent : GameEvent<string>
    {
    }
}