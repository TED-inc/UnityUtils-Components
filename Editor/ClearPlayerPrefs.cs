using UnityEngine;
using UnityEditor;

namespace TEDinc.Tools
{
    public sealed class ClearPlayerPrefs
    {
        [MenuItem(nameof(Tools) + "/" + nameof(ClearPlayerPrefs))]
        public static void Clear() =>
            PlayerPrefs.DeleteAll();
    }
}
