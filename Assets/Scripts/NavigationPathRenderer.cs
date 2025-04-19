using UnityEngine;
using System.Collections.Generic;

public class NavigationPathRenderer : MonoBehaviour
{
    public LineRenderer lineRenderer;
    private List<Vector3> pathPoints = new List<Vector3>();

    void Start()
    {
        if (lineRenderer == null)
        {
            Debug.LogError("NavigationPathRenderer: LineRenderer reference missing.");
        }
    }

    public void UpdatePath(Vector3 userPosition)
    {
        // For demo, create a simple path ahead of user
        pathPoints.Clear();
        pathPoints.Add(userPosition);
        pathPoints.Add(userPosition + new Vector3(0, 0, 10)); // 10 meters ahead
        pathPoints.Add(userPosition + new Vector3(5, 0, 20)); // turn right

        lineRenderer.positionCount = pathPoints.Count;
        lineRenderer.SetPositions(pathPoints.ToArray());
    }
}
