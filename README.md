## WorldLayoutGroup

WorldLayoutGroup is a lightweight, **editor-only** layout component for Unity.  
It automatically arranges child GameObjects in the scene, similar to Unity’s  
UI `LayoutGroup`, but designed for **world (non-UI) objects**.

---

## Basic Setup

1. Select one or more GameObjects in the **Hierarchy**.
2. Right-click and choose:  
   ** → Create World Layout Group**
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
