#if UNITY_EDITOR

using UnityEditor;
using UnityEngine;

public static class WorldLayoutGroupHierarchy
{
    [MenuItem("GameObject/Create World Layout Group", false, 0)]
    private static void GroupSelected(MenuCommand menuCommand)
    {
        GameObject active = Selection.activeGameObject;

        if (active == null) return;

        // menuCommand.context: Unity'nin o an için çağırdığı obje. Bu sayede her objeyi parente taşıdığında yeni parent oluşturmuyor.
        if (menuCommand.context != active)
            return;

        GameObject[] selectedObjects = Selection.gameObjects;

        if (selectedObjects == null || selectedObjects.Length == 0)
            return;

        GameObject parent = new GameObject("New Parent");

        Undo.RegisterCreatedObjectUndo(parent, "Create Parent");
        Undo.AddComponent<WorldLayoutGroup>(parent);

        //Eğer seçili objenin bir parenti varsa yeni oluşturduğum parent objesini seçili objenin parentinin altına atar. Eğer yoksa direkt root'a atar.
        Transform originalParent = selectedObjects[0].transform.parent;
        parent.transform.SetParent(originalParent, true);

        parent.transform.position = Tools.handlePosition;

        foreach (GameObject obj in selectedObjects)
        {
            Undo.SetTransformParent(obj.transform, parent.transform, "Group Objects");
        }

        Selection.activeGameObject = parent;
    }

    [MenuItem("GameObject/My Custom Tool/Group Selected", true)]
    private static bool GroupSelected_Validate()
    {
        return Selection.gameObjects != null && Selection.gameObjects.Length > 0;
    }
}

#endif