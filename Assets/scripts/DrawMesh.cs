using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using System.Linq;

public class DrawMesh : MonoBehaviour
{
    public LineRenderer lineRenderer;
    List<Vector2> points = new List<Vector2>();

    public void UpdateLine(Vector2 position)
    {
        if (points.Count == 0 || Vector2.Distance(points.Last(), position) > 0.1f)
        {
            SetPoint(position);
        }
    }

    void SetPoint(Vector2 point)
    {
        points.Add(point);
        lineRenderer.positionCount = points.Count;
        lineRenderer.SetPosition(points.Count - 1, point);
    }
}

