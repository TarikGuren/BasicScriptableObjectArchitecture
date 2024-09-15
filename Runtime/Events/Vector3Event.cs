using UnityEngine;

namespace BasicScriptableObjectArchitecture.Runtime.Events
{
    [CreateAssetMenu(menuName = Constants.EVENT_BASE + "Vector3Event", fileName = "Vector3Event")]
    public class Vector3Event : GameEvent<Vector3>
    {
    }
}