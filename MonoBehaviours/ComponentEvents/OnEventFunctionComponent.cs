#pragma warning disable 0649 //disable unnusign warnings
using System;
using UnityEngine;
using UnityEngine.Events;

namespace TEDinc.Utils.Components.Events
{
    public sealed class OnEventFunctionComponent : MonoBehaviour
    { 
        public Action onEvent;
        public EventFunctions callAt = EventFunctions.Start;
        public EventFunctionsUpdates callIn = EventFunctionsUpdates.None;
        [SerializeField]
        private UnityEvent call;

        #region calls
        private void Awake()
        {
            if (callAt.HasFlag(EventFunctions.Awake))
            {
                call?.Invoke();
                onEvent?.Invoke();
            }
        }

        private void OnEnable()
        {
            if (callAt.HasFlag(EventFunctions.OnEnable))
            {
                call?.Invoke();
                onEvent?.Invoke();
            }
        }

        private void Start()
        {
            if (callAt.HasFlag(EventFunctions.Start))
            {
                call?.Invoke();
                onEvent?.Invoke();
            }
        }

        private void OnDisable()
        {
            if (callAt.HasFlag(EventFunctions.OnDisable))
            {
                call?.Invoke();
                onEvent?.Invoke();
            }
        }

        private void OnDestroy()
        {
            if (callAt.HasFlag(EventFunctions.OnDestroy))
            {
                call?.Invoke();
                onEvent?.Invoke();
            }
        }



        private void FixedUpdate()
        {
            if (callIn.HasFlag(EventFunctionsUpdates.FixedUpdate))
            {
                call?.Invoke();
                onEvent?.Invoke();
            }
        }

        private void Update()
        {
            if (callIn.HasFlag(EventFunctionsUpdates.Update))
            {
                call?.Invoke();
                onEvent?.Invoke();
            }
        }

        private void LateUpdate()
        {
            if (callIn.HasFlag(EventFunctionsUpdates.LateUpdate))
            {
                call?.Invoke();
                onEvent?.Invoke();
            }
        }
        #endregion
    }

    [Flags]
    public enum EventFunctions : int
    {
        None = 0,
        Awake = 1,
        OnEnable = 2,
        Start = 4,
        OnDisable = 8,
        OnDestroy = 16
    }

    [Flags]
    public enum EventFunctionsUpdates : int
    {
        None = 0,
        FixedUpdate = 1,
        Update = 2,
        LateUpdate = 4
    }
}
