# WorldLayoutGroup

WorldLayoutGroup is a lightweight, **editor-only** layout component for Unity.  
It automatically arranges child GameObjects in the scene, similar to Unity's  
UI `LayoutGroup`, but designed for **world (non-UI) objects**.

---

## Installation

### Via Unity Package Manager

1. Open **Package Manager** (`Window → Package Manager`)
2. Click the **+** button in the top-left corner
3. Select **"Add package from git URL..."**
4. Paste the following URL and click **Add**:

```
https://github.com/Alihan-4108/World-Layout-Group.git
```

### Via .unitypackage

You can also download the `.unitypackage` file directly from the [Releases](https://github.com/Alihan-4108/World-Layout-Group/releases) page and import it into your project via `Assets → Import Package → Custom Package...`.

---

## Basic Setup

1. Select one or more GameObjects in the **Hierarchy**.
2. Right-click and choose:  
   **→ Create World Layout Group**
3. A new parent GameObject is created:
   - Selected objects are moved under this parent
   - `WorldLayoutGroup` is automatically added

---

## Layout Configuration

You can control how child objects are arranged using the **Inspector**.

### Direction

Defines the direction in which child objects are laid out:

- **Right**
- **Left**
- **Up**
- **Down**

### Spacing

Controls the distance between each child object.

---

## ⚠️ Important Notes

### Build-Time Scene Component Stripping

During the build process, all WorldLayoutGroup components are automatically removed from every scene included in the build.

This means:

- WorldLayoutGroup does not exist in the final build  
- No layout logic runs at runtime  
- Object positions remain exactly as arranged in the editor  
- Editor scenes and prefab assets are **not modified**  

The removal is applied **only to the build output**.  
WorldLayoutGroup components remain fully intact in editor scenes and are never removed or altered during development.
