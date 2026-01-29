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
