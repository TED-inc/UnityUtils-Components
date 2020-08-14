using UnityEngine;
using UnityEngine.Events;

namespace TEDinc.Utils.Components.Events
{
    public sealed class AwakeComponentEvents : MonoBehaviour
    {
        [SerializeField]
        private UnityEvent onAwake;

        private void Awake() =>
            onAwake?.Invoke();
    }
}
