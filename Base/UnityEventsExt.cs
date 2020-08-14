using System;
using UnityEngine.Events;

namespace TEDinc.Utils.Components
{
    [Serializable]
    public class UnityEventBool : UnityEvent<bool> { }
    [Serializable]
    public class UnityEventInt : UnityEvent<int> { }
}
