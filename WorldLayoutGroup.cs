#if UNITY_EDITOR

using UnityEditor;
using UnityEngine;

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


    private void OnEnable()
    {
        RequestLayoutRebuild();
    }

    private void OnValidate()
    {
        RequestLayoutRebuild();
    }

    private void OnTransformChildrenChanged()
    {
        RequestLayoutRebuild();
    }

    private void RequestLayoutRebuild()
    {
        if (layoutQueued) return;

        if (this == null) return;

        layoutQueued = true;

        EditorApplication.delayCall += ApplyLayout;
    }

    private void OnDisable()
    {
        layoutQueued = false;

        EditorApplication.delayCall -= ApplyLayout;
    }

    private void OnDestroy()
    {
        layoutQueued = false;

        EditorApplication.delayCall -= ApplyLayout;
    }

    public void ApplyLayout()
    {
        EditorApplication.delayCall -= ApplyLayout;
        layoutQueued = false;

        Vector3 step = GetStepVector(direction);

        int index = 0;

        for (int i = 0; i < transform.childCount; i++)
        {
            Transform child = transform.GetChild(i);

            child.localPosition = step * (spacing * index);

            index++;
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
        }

        return Vector3.right;
    }
}

#endif