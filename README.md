# 🪐 Augmented Reality Solar System Explorer

An advanced **Augmented Reality (AR)** educational application developed using **Unity** and **Vuforia**. This project provides an immersive experience where users can visualize and interact with 3D planetary models by scanning physical image targets.

---

## 🌟 Project Features
* **AR-based Visualization:** High-quality 3D rendering of planets upon marker detection.
* **Interactive UI:** Dynamic start menu, sound controls, and info panels.
* **Clickable Planets:** Users can interact with planets to trigger detailed information.
* **Smooth Planet Rotation:** Realistic celestial movement using Quaternion interpolation for visual stability.
* **Intelligent Tracking:** Auto-hiding UI elements when the camera loses the image target.
* **Android Optimized:** Built for mobile deployment (Targeting API Level 29+).

---

## 🛠 Technologies & Tools
* **Game Engine:** Unity Engine.
* **AR Platform:** Vuforia Engine.
* **Programming Language:** C#.
* **UI System:** Unity UI System (Screen Space - Overlay).
* **Assets:** 3D models from Unity Asset Store and UI icons from Flaticon.

---

## 📂 Project Structure (Unity Hierarchy)
The project is organized for scalability and clean management:
* **AR Camera:** The primary viewport for AR rendering.
* **ImageTargets (Planets):** Individual markers for each planet in the solar system .
* **Main Canvas:** Contains the `MainUI` (Start/Sound buttons) and `InfoPanel` for infographics .
* **Managers:** `GameManager` and `AudioManager` to handle global app states and sound .

---

## 💻 Key Scripts Implementation

### 1. Interactivity (`PlanetClick.cs`)
Uses **Physics Raycasting** to detect user touches on 3D planets and display their corresponding 2D infographic panels.

### 2. Smooth Rotation (`SmoothRotate.cs`)
Applies `Quaternion.Slerp` for smooth, consistent rotation of planets, ensuring a professional look in the AR environment.

### 3. UI Control (`PlanetInfoController.cs`)
Manages the dynamic display of information, enabling the semi-transparent info panel when a planet is selected.

---

## 🚀 Getting Started & Build
1.  **Environment Setup:** Enable Vuforia in Unity Player Settings and add the AR Camera .
2.  **Markers:** Print the image targets (Rated 4-5 stars by Vuforia for high tracking stability).
3.  **Full Project Link:** 🔗 **[Download Full Version from Google Drive](https://drive.google.com/file/d/1sYOrxn_T1B3xrwDxuDCUremLlSunGgNk/view)** (Includes large assets like NDK, SDK, and models).

---

## ⚠️ Challenges & Solutions
* **Tracking Instability:** Solved by using advanced smoothing techniques for 3D object rotation.
* **Build Conflicts:** Resolved Android SDK/NDK setting issues and switched Input Handling to "Both" for better compatibility.

---

## 🎯 Future Roadmap
* Add voice narration for each planet.
* Implement planet comparison features.
* Enhance UI with advanced visual effects and animations (Fade/Zoom).

