using UnityEngine;
using UnityEngine.SceneManagement;
using System;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace TEDinc.Utils.Components.SceneManagment
{
    public class SceneLoader : MonoBehaviour, IInitable
    {
#if UNITY_EDITOR
        [SerializeField]
        private string sceneName;
#endif
        [SerializeField, Min(0)]
        private int sceneIndex;
        [SerializeField]
        private LoadSceneMode loadSceneMode;

        public void Init() =>
            SceneManager.LoadSceneAsync(sceneIndex, loadSceneMode);

#if UNITY_EDITOR
        private void OnValidate()
        {
            sceneIndex = Mathf.Clamp(sceneIndex, 0, SceneManager.sceneCountInBuildSettings - 1);
            sceneName = SceneManager.GetSceneByBuildIndex(sceneIndex).name;
        }
#endif
    }
}
