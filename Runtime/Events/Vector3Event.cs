using UnityEngine;

namespace BasicScriptableObjectArchitecture.Events
{
    [CreateAssetMenu(menuName = Constants.EVENT_BASE + "Vector3Event", fileName = "Vector3Event")]
    public class Vector3Event : GameEvent<Vector3>
    {
    }
}