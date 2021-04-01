#pragma warning disable 0649 //disable unnusign warnings
using UnityEngine;

namespace TEDinc.Utils.Components.Events
{ 
    public sealed class BoolEventInverter : MonoBehaviour
    {
        [SerializeField]
        private UnityEventBool inverted;

        public void Invoke(bool value) =>
            inverted?.Invoke(!value);
    }
}