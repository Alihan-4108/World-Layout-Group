using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace Alihan4108.WorldLayoutTools
{
    [ExecuteInEditMode]
    public class WorldLayoutGroup : MonoBehaviour
    {
        public enum LayoutDirection
        {
            Right = 0,
            Left = 1,
            Up = 2,
            Down = 3,
        }

        [Header("Settings")]
        [SerializeField] private LayoutDirection direction = LayoutDirection.Right;
        [SerializeField] private float spacing = 1f;

        private bool layoutQueued;

        private void OnEnable() => RequestLayoutRebuild();
        private void OnValidate() => RequestLayoutRebuild();
        private void OnTransformChildrenChanged() => RequestLayoutRebuild();

        private void RequestLayoutRebuild()
        {
#if UNITY_EDITOR
            if (layoutQueued) return;
            if (this == null) return;

            layoutQueued = true;
            EditorApplication.delayCall += ApplyLayout;
#endif
        }

        private void OnDisable()
        {
#if UNITY_EDITOR
            layoutQueued = false;
            EditorApplication.delayCall -= ApplyLayout;
#endif
        }

        private void OnDestroy()
        {
#if UNITY_EDITOR
            layoutQueued = false;
            EditorApplication.delayCall -= ApplyLayout;
#endif
        }

        public void ApplyLayout()
        {
#if UNITY_EDITOR
            EditorApplication.delayCall -= ApplyLayout;
            layoutQueued = false;
#endif
            Vector3 step = GetStepVector(direction);

            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).localPosition = step * (spacing * i);
            }
        }

        private Vector3 GetStepVector(LayoutDirection dir)
        {
            switch (dir)
            {
                case LayoutDirection.Right: return Vector3.right;
                case LayoutDirection.Left: return Vector3.left;
                case LayoutDirection.Up: return Vector3.up;
                case LayoutDirection.Down: return Vector3.down;
                default: return Vector3.right;
            }
        }
    }
}