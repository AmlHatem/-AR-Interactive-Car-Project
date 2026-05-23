# 🚘 AR Interactive Car Project

An Augmented Reality (AR) project developed using Unity that allows users to interact with a virtual 3D car in real time.

The project combines:
- Augmented Reality (AR)
- 3D Interaction
- Unity Game Development
- C# Scripting

to create an immersive and interactive user experience.

---

# 🚀 Project Overview

The main idea of the project is to display a virtual car in the real environment using AR technology.

Users can interact with the car through multiple features such as:
- Opening and closing doors
- Opening the hood
- Changing the car color
- Rotating the car automatically

The project demonstrates how AR can be used to create realistic and interactive 3D experiences.

---

# 🧠 Project Features

## 🚪 Door Interaction

The car door can open and close when clicked.

### Features
- Interactive door movement
- Smooth rotation behavior
- User-controlled interaction

### Script Used
```csharp
DoorOpen.cs
```

### Functionality
When the user clicks on the door:
- If the door is closed → it opens
- If the door is open → it closes

---

# 🎨 Car Color Changing

Users can change the car color dynamically by clicking on the car body.

### Features
- Random color generation
- Real-time material update
- Interactive visual customization

### Script Used
```csharp
ChangeCarColor.cs
```

### Functionality
Every click generates a new random RGB color for the car material.

---

# 🔧 Hood Opening System

The car hood can be opened and closed using keyboard interaction.

### Features
- Smooth hood animation
- Rotation interpolation using Quaternion
- Keyboard-controlled interaction

### Script Used
```csharp
OpenHood.cs
```

### Functionality
Pressing the `H` key:
- Opens the hood
- Closes the hood

The hood movement is animated smoothly using:
```csharp
Quaternion.Lerp()
```

---

# 🔄 Car Rotation

The car rotates continuously to provide a complete 360° view.

### Features
- Automatic rotation
- Smooth animation
- Better object visualization

### Script Used
```csharp
RotateCar.cs
```

### Functionality
The car rotates around the Y-axis continuously using:
```csharp
transform.Rotate()
```

---

# 🛠️ Technologies Used

- Unity
- C#
- Augmented Reality (AR)
- 3D Modeling
- Unity Engine Components

---

# ⚙️ System Workflow

## 🔹 Step 1: AR Scene Initialization
The AR environment is initialized inside Unity.

---

## 🔹 Step 2: Car Visualization
The 3D car model appears in the user's environment.

---

## 🔹 Step 3: User Interaction
Users interact with the car using:
- Mouse clicks
- Keyboard inputs

---

## 🔹 Step 4: Real-Time Object Response
The car responds instantly to user actions such as:
- Door opening
- Hood movement
- Color changing
- Rotation

---

# 📊 Main Concepts Used

- Object Interaction
- Transform Rotation
- Material Manipulation
- Animation Logic
- Real-Time Rendering
- User Input Handling

---

# ▶️ How to Run

```bash
# Open the project in Unity

# Add AR camera and scene objects

# Attach scripts to the car objects

# Run the scene inside Unity
```

---

# 📈 Future Improvements

- Add realistic car sounds
- Add engine start/stop interaction
- Implement touch controls for mobile devices
- Add wheel movement animation
- Add interior car interaction
- Support ARCore / ARKit integration

---

# 📌 Project Goals

- Learn Augmented Reality development
- Build interactive 3D experiences
- Practice Unity scripting using C#
- Create immersive AR applications

---

# 👩‍💻 Author

Developed as an Augmented Reality and Unity project for educational and research purposes.
