using UnityEngine;
using System;
using System.Collections;
using Mapbox.Unity.Location;

public class MapboxLocationProvider : MonoBehaviour
{
    public event Action<Vector3> OnLocationUpdated;

    private AbstractLocationProvider locationProvider;

    void Start()
    {
        locationProvider = LocationProviderFactory.Instance.DefaultLocationProvider as AbstractLocationProvider;
        if (locationProvider == null)
        {
            Debug.LogError("MapboxLocationProvider: No location provider found.");
            return;
        }
        StartLocationUpdates();
    }

    public void StartLocationUpdates()
    {
        StartCoroutine(LocationUpdateRoutine());
    }

    private IEnumerator LocationUpdateRoutine()
    {
        while (true)
        {
            var location = locationProvider.CurrentLocation;
            if (location.IsLocationUpdated)
            {
                Vector3 unityPosition = ConvertLatLonToUnityPosition(location.LatitudeLongitude);
                OnLocationUpdated?.Invoke(unityPosition);
            }
            yield return new WaitForSeconds(1f);
        }
    }

    private Vector3 ConvertLatLonToUnityPosition(Vector2d latLon)
    {
        // Convert GPS coordinates to Unity world position
        // This is a placeholder; actual conversion depends on Mapbox map setup
        return new Vector3((float)latLon.x, 0, (float)latLon.y);
    }
}
