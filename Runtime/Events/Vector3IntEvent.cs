using UnityEngine;

namespace BasicScriptableObjectArchitecture.Runtime.Events
{
    [CreateAssetMenu(menuName = Constants.EVENT_BASE + "Vector3IntEvent", fileName = "Vector3IntEvent")]
    public class Vector3IntEvent : GameEvent<Vector3Int>
    {
    }
}