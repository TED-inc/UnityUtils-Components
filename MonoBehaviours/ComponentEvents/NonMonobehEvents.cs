using System;
using UnityEngine;
using TEDinc.Utils.Components;

namespace TEDinc.Utils.NonMonobehEvents
{
    public class NonMonobehEvents : MonoBehaviour, IInitable
    {
        public static Action OnInit;
        public static Action OnStart;
        public static Action OnUpdate;
        public static Action OnLateUpdate;
        public static Action OnFixedUpdate;
        public static Action OnMonoDestroy;

        private static NonMonobehEvents instance;

        public void Init()
        {
            if (instance == null)
            {
                instance = this;
                OnInit?.Invoke();
            }
            else
                Destroy(gameObject);
               
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
