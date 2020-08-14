using UnityEngine;

namespace TEDinc.Utils.Components.Aniamtion
{
    public sealed class SetAnimatorParam : MonoBehaviour
    {
        [SerializeField]
        private string paramName;
        [SerializeField]
        private Animator animator;

        public void SetParam(int i) =>
            animator.SetInteger(paramName, i);

        public void SetParam(bool b) =>
            animator.SetBool(paramName, b);
    }
}
