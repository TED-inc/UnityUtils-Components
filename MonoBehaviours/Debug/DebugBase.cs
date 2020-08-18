using UnityEngine;

namespace TEDinc.Utils.Components.Debug
{
    public abstract class DebugBase : MonoBehaviour
    {
#if !UNITY_EDITOR && !DEVELOPMENT_BUILD
        private void Awake() =>
            Destroy(gameObject);
#endif
    }
}
