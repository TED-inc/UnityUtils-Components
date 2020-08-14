using UnityEngine;

namespace TEDinc.Utils.Components.Etc
{
    public class ChainOfEnable : MonoBehaviour
    {
        [SerializeField]
        private GameObject[] order;

        private void Awake()
        {
            if (order != null)
                foreach (var item in order)
                    item.SetActive(true);
        }
    }
}
