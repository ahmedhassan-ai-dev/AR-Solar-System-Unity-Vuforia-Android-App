# 🪐 Augmented Reality Solar System Explorer

[cite_start]An advanced **Augmented Reality (AR)** educational application developed using **Unity** and **Vuforia**[cite: 1, 3]. [cite_start]This project provides an immersive experience where users can visualize and interact with 3D planetary models by scanning physical image targets[cite: 4, 8].

---

## 🌟 Project Features
* [cite_start]**AR-based Visualization:** High-quality 3D rendering of planets upon marker detection[cite: 8].
* [cite_start]**Interactive UI:** Dynamic start menu, sound controls, and info panels[cite: 8].
* [cite_start]**Clickable Planets:** Users can interact with planets to trigger detailed information[cite: 9, 52].
* [cite_start]**Smooth Planet Rotation:** Realistic celestial movement using Quaternion interpolation for visual stability[cite: 11, 57].
* [cite_start]**Intelligent Tracking:** Auto-hiding UI elements when the camera loses the image target[cite: 12, 59].
* [cite_start]**Android Optimized:** Built for mobile deployment (Targeting API Level 29+)[cite: 63].

---

## 🛠 Technologies & Tools
* [cite_start]**Game Engine:** Unity Engine[cite: 6].
* [cite_start]**AR Platform:** Vuforia Engine[cite: 6].
* [cite_start]**Programming Language:** C#[cite: 6].
* [cite_start]**UI System:** Unity UI System (Screen Space - Overlay)[cite: 6, 38].
* [cite_start]**Assets:** 3D models from Unity Asset Store and UI icons from Flaticon[cite: 116].

---

## 📂 Project Structure (Unity Hierarchy)
The project is organized for scalability and clean management:
* [cite_start]**AR Camera:** The primary viewport for AR rendering[cite: 24].
* [cite_start]**ImageTargets (Planets):** Individual markers for each planet in the solar system[cite: 25].
* [cite_start]**Main Canvas:** Contains the `MainUI` (Start/Sound buttons) and `InfoPanel` for infographics [cite: 15-21].
* [cite_start]**Managers:** `GameManager` and `AudioManager` to handle global app states and sound [cite: 22-23].

---

## 💻 Key Scripts Implementation

### 1. Interactivity (`PlanetClick.cs`)
[cite_start]Uses **Physics Raycasting** to detect user touches on 3D planets and display their corresponding 2D infographic panels[cite: 51, 72, 74].

### 2. Smooth Rotation (`SmoothRotate.cs`)
[cite_start]Applies `Quaternion.Slerp` for smooth, consistent rotation of planets, ensuring a professional look in the AR environment[cite: 85, 88].

### 3. UI Control (`PlanetInfoController.cs`)
[cite_start]Manages the dynamic display of information, enabling the semi-transparent info panel when a planet is selected[cite: 45, 79, 83].

---

## 🚀 Getting Started & Build
1.  [cite_start]**Environment Setup:** Enable Vuforia in Unity Player Settings and add the AR Camera [cite: 31-32].
2.  [cite_start]**Markers:** Print the image targets (Rated 4-5 stars by Vuforia for high tracking stability) [cite: 119-131].
3.  [cite_start]**Full Project Link:** 🔗 **[Download Full Version from Google Drive](https://drive.google.com/file/d/1sYOrxn_T1B3xrwDxuDCUremLlSunGgNk/view)** (Includes large assets like NDK, SDK, and models)[cite: 97, 103].

---

## ⚠️ Challenges & Solutions
* [cite_start]**Tracking Instability:** Solved by using advanced smoothing techniques for 3D object rotation[cite: 100, 105].
* [cite_start]**Build Conflicts:** Resolved Android SDK/NDK setting issues and switched Input Handling to "Both" for better compatibility[cite: 102, 103].

---

## 🎯 Future Roadmap
* [cite_start]Add voice narration for each planet[cite: 112].
* [cite_start]Implement planet comparison features[cite: 112].
* [cite_start]Enhance UI with advanced visual effects and animations (Fade/Zoom)[cite: 112].

---

## 👤 Developer
**Course:** Image Processing (AI 306)  
[cite_start]Developed as a demonstration of how AR can transform educational experiences[cite: 172].
