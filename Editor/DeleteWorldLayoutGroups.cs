using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Alihan4108.WorldLayoutTools
{
    public class DeleteWorldLayoutGroups : IProcessSceneWithReport
    {
        public int callbackOrder => 0;

        public void OnProcessScene(Scene scene, BuildReport report)
        {
            if (Application.isPlaying)
                return;

            int removedCount = 0;

            foreach (var root in scene.GetRootGameObjects())
            {
                var groups = root.GetComponentsInChildren<WorldLayoutGroup>(true);

                foreach (var group in groups)
                {
                    Object.DestroyImmediate(group, true);
                    removedCount++;
                }
            }

            if (removedCount > 0)
            {
                Debug.Log($"Scene '{scene.name}': Removed {removedCount} WorldLayoutGroup component(s).");
            }
        }
    }
}