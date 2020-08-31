#pragma warning disable 0649 //dissable unnusign warnings
using UnityEngine;

namespace TEDinc.Utils.Components.Debug
{
    public sealed class DebugManager : DebugBase, IInitable
    {
        [SerializeField]
        private new bool enabled;
        [SerializeField]
        private UnityEventBool enebleEvent;
        private bool readyToSwitchEnable = true;

        public void Init() =>
            enebleEvent?.Invoke(enabled);

        private void OnValidate() =>
            enebleEvent?.Invoke(enabled);


        private void FixedUpdate()
        {
            if ((Input.touchCount == 5 || Input.GetKeyDown(KeyCode.BackQuote)))
            {
                if (!readyToSwitchEnable)
                    return;
                enabled ^= true;
                enebleEvent.Invoke(enabled);
                readyToSwitchEnable = false;
            }
            else if (Input.touchCount < 5 || !Input.GetKeyDown(KeyCode.BackQuote))
                readyToSwitchEnable = true;
        }
    }
}
