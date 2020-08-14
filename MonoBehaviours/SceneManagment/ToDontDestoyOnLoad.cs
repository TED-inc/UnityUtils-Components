using UnityEngine;
using UnityEngine.Events;

namespace TEDinc.Utils.Components.SceneManagment
{
    public sealed class ToDontDestoyOnLoad : MonoBehaviour
    {
        [SerializeField]
        private UnityEvent callOnMove;
        private void Awake()
        {
            transform.parent = null;
            DontDestroyOnLoad(gameObject);
            callOnMove?.Invoke();
        }
    }
}
