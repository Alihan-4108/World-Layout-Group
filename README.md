
WorldLayoutGroup is a lightweight, editor-only layout component for Unity
that automatically arranges child GameObjects in the scene, similar to
Unity's UI LayoutGroup but designed for world (non-UI) objects.


### Basic Setup

1. Create or select a GameObject that will act as the **parent**.
2. Add the `WorldLayoutGroup` component to the parent GameObject.
3. Place the objects you want to arrange as **children** of this parent.

### Layout Configuration

You can control how the child objects are arranged using the Inspector:

- **Direction**  
  Select the direction in which the children will be laid out:
  - Right
  - Left
  - Up
  - Down

- **Spacing**  
  Defines the distance between each child object.
