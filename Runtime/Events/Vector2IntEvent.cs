using UnityEngine;

namespace BasicScriptableObjectArchitecture.Runtime.Events
{
    [CreateAssetMenu(menuName = Constants.EVENT_BASE + "Vector2IntEvent", fileName = "Vector2IntEvent")]
    public class Vector2IntEvent : GameEvent<Vector2Int>
    {
    }
}