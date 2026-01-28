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

## 💡 Editor Usage Recommendation!!

`WorldLayoutGroup` is designed to be used as an **editor tool**.

For a clean and efficient runtime setup, it is recommended to place all  
WorldLayoutGroup-related scripts inside an **`Editor`** folder  
(for example: `Assets/Editor/WorldLayoutGroup`).

Unity automatically excludes scripts inside the `Editor` folder from game builds.  
This allows you to freely use `WorldLayoutGroup` in the scene during level design,  
while keeping your final build free of editor-only logic.

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
