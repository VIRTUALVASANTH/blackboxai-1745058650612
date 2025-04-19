using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using System.Collections.Generic;

public class ARNavigationManager : MonoBehaviour
{
    public ARSession arSession;
    public ARSessionOrigin arSessionOrigin;
    public NavigationPathRenderer pathRenderer;
    public MapboxLocationProvider locationProvider;

    private bool isSessionReady = false;

    void Start()
    {
        if (arSession == null || arSessionOrigin == null || pathRenderer == null || locationProvider == null)
        {
            Debug.LogError("ARNavigationManager: Missing references.");
            return;
        }

        arSession.stateChanged += OnARSessionStateChanged;
        locationProvider.OnLocationUpdated += OnLocationUpdated;
    }

    private void OnARSessionStateChanged(ARSessionStateChangedEventArgs args)
    {
        if (args.state == ARSessionState.SessionTracking)
        {
            isSessionReady = true;
            Debug.Log("AR Session is tracking.");
            // Start navigation or localization logic here
            locationProvider.StartLocationUpdates();
        }
        else
        {
            isSessionReady = false;
        }
    }

    private void OnLocationUpdated(Vector3 userPosition)
    {
        if (!isSessionReady) return;

        // Update navigation path based on user position
        pathRenderer.UpdatePath(userPosition);
    }

    void OnDestroy()
    {
        arSession.stateChanged -= OnARSessionStateChanged;
        locationProvider.OnLocationUpdated -= OnLocationUpdated;
    }
}
