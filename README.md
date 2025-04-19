# Outdoor AR Navigation Unity Project

This Unity project implements an outdoor AR navigation app for Android using AR Foundation and Mapbox SDK, replicating the functionality shown in the video "Outdoor AR Navigation Demo (day&night)".

## Features
- AR session with ARCore support
- Outdoor localization and mapping using Mapbox SDK
- Navigation path rendering in AR space
- Day and night mode lighting
- UI for navigation status

## Setup Instructions

1. **Unity Version**: Use Unity 2021.3 LTS or later.
2. **Install AR Foundation**:
   - Open Unity Package Manager.
   - Install `AR Foundation` and `ARCore XR Plugin`.
3. **Install Mapbox SDK for Unity**:
   - Download Mapbox Unity SDK from https://github.com/mapbox/mapbox-unity-sdk
   - Import the SDK into your project.
4. **Configure Mapbox**:
   - In Unity, open the Mapbox configuration and enter your API key:
     ```
     pk.eyJ1IjoicjBsZXgiLCJhIjoiY204MWg0dXZwMDJscTJrczc3MTQwdzJzbyJ9.sEvz7ZEI4yvYxQR6o5X3Bg
     ```
5. **Scene Setup**:
   - Create a new scene `MainScene`.
   - Add AR Session and AR Session Origin.
   - Add Mapbox components for map and navigation.
   - Add the provided C# scripts to manage AR navigation.

6. **Build Settings**:
   - Switch platform to Android.
   - Set minimum API level to 24 or higher.
   - Enable ARCore support in XR settings.
   - Configure Android manifest permissions for camera and location.

7. **Deploy**:
   - Connect your Android device.
   - Build and run the project.

## Provided Files

- `Assets/Scripts/ARNavigationManager.cs` - Manages AR session and navigation logic.
- `Assets/Scripts/MapboxLocationProvider.cs` - Integrates Mapbox location services.
- `Assets/Scripts/NavigationPathRenderer.cs` - Renders navigation path in AR.
- `Assets/Scenes/MainScene.unity` - Main scene setup (to be created in Unity).

## Notes

- This project requires a physical Android device with ARCore support.
- Ensure location services and camera permissions are granted.
- The app supports day and night mode lighting adjustments.

---

For any questions or issues, please contact the developer.
