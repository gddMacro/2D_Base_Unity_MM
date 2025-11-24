# Unity 2D Game Development - Base Project

A foundational Unity project designed to introduce students to game development with Unity and C#. This project serves as the starting point for learning 2D game development concepts and best practices.

## About This Project

This repository provides a clean, pre-configured Unity 2D project template using the Universal Render Pipeline (URP). It is intended for educational purposes, allowing students to focus on learning game development concepts without dealing with initial project setup.

## Prerequisites

- Basic programming knowledge (variables, functions, loops, conditionals)
- Understanding of object-oriented programming concepts (classes, objects, inheritance)
- Unity Hub installed
- Unity Editor version **6000.0.58f2** (Unity 6) or compatible

## Learning Objectives

This project supports learning the following Unity 2D development topics:

### Core Concepts
- **Sprites & Sprite Rendering** - Working with 2D graphics, sprite sheets, and sorting layers
- **GameObjects & Components** - Understanding Unity's component-based architecture
- **Transforms & Movement** - Positioning, rotating, and moving objects in 2D space

### Level Design
- **Tilemaps** - Creating tile-based levels and environments
- **Tile Palettes** - Organizing and painting tiles efficiently
- **Collider Shapes** - Defining collision boundaries for tiles

### Physics & Interaction
- **2D Physics** - Rigidbody2D, forces, and gravity
- **Collisions & Triggers** - Detecting and responding to object interactions
- **Raycasting** - Line-of-sight and ground detection

### Animation
- **Animator Controller** - State machines for character animation
- **Animation Clips** - Creating and editing sprite animations
- **Animation Events** - Triggering code from animation timelines

### User Interface
- **Canvas System** - Building responsive game UI
- **UI Components** - Buttons, text, images, and sliders
- **Event System** - Handling user input on UI elements

### Audio
- **Audio Sources & Listeners** - Playing sounds in the game world
- **Audio Clips** - Managing sound effects and music
- **Audio Mixer** - Controlling volume and audio effects

### C# Scripting
- **MonoBehaviour Lifecycle** - Start, Update, FixedUpdate, and other callbacks
- **Input Handling** - Reading player input for controls
- **Coroutines** - Managing time-based operations
- **ScriptableObjects** - Creating reusable data containers
- **Events & Delegates** - Decoupled communication between scripts

## Getting Started

1. **Clone the repository**
   ```bash
   git clone https://github.com/gddMacro/2D_Base_Unity_MM.git
   ```

2. **Open in Unity Hub**
   - Launch Unity Hub
   - Click "Add" and select the cloned project folder
   - Ensure you have Unity 6000.0.58f2 installed (or install it via Unity Hub)

3. **Open the project**
   - Click on the project in Unity Hub to open it
   - Wait for Unity to import all assets

4. **Explore the base scene**
   - Navigate to `Assets/Scenes/`
   - Open `URP2DSceneTemplate.unity`

## Project Structure

```
Assets/
├── Scenes/          # Game scenes
│   └── URP2DSceneTemplate.unity
Packages/            # Package dependencies
ProjectSettings/     # Unity project configuration
```

## Version Control

This project is configured with:
- `.gitignore` - Properly configured for Unity projects
- `.gitattributes` - Git LFS tracking for large assets (audio, video, 3D models)

### Important Notes for Students
- Always commit your `.meta` files - they link assets to their GUIDs
- Never commit the `Library/` folder - it's regenerated automatically
- Pull changes before starting work to avoid merge conflicts

## License

This project is provided for educational purposes.
