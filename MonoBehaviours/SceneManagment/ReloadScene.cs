using UnityEngine;
using UnityEngine.SceneManagement;

namespace TEDinc.Utils.Components.SceneManagment
{
    public sealed class ReloadScene : MonoBehaviour
    {
        public void Reload() =>
            SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
    }
}
