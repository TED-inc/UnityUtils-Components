using System;
using TEDinc.Utils.Components.SceneManagment;
using UnityEngine;

namespace TEDinc.Utils.Components.Events
{
    public class NonMonobehEvents : MonoBehaviour, IInitable
    {
        public static Action OnStart;
        public static Action OnUpdate;
        public static Action OnLateUpdate;
        public static Action OnFixedUpdate;
        public static Action OnMonoDestroy;

        public static NonMonobehEvents instance { get => _instance ?? CreateInstance(); private set => _instance = value; }
        private static NonMonobehEvents _instance;

        public void Init()
        {
            if (instance == null)
                instance = this;
            else if (instance != this)
                Destroy(gameObject);
        }

        private static NonMonobehEvents CreateInstance()
        {
            GameObject go = new GameObject($"[{nameof(NonMonobehEvents)}]");
            go.AddComponent<ToDontDestoyOnLoad>();
            instance = go.AddComponent<NonMonobehEvents>();
            return instance;
        }

        private void Start() =>
           OnStart?.Invoke();
        private void Update() =>
            OnUpdate?.Invoke();
        private void LateUpdate() =>
            OnLateUpdate?.Invoke();
        private void FixedUpdate() =>
            OnFixedUpdate?.Invoke();
        private void OnDestroy() =>
            OnMonoDestroy?.Invoke();
    }
}
