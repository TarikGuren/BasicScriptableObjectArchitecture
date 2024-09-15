using UnityEngine;

namespace BasicScriptableObjectArchitecture.Events
{
    [CreateAssetMenu(menuName = Constants.EVENT_BASE + "Vector2Event", fileName = "Vector2Event")]
    public class Vector2Event : GameEvent<Vector2>
    {
    }
}