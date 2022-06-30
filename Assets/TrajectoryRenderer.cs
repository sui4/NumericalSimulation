using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrajectoryRenderer : MonoBehaviour
{
    LineRenderer lineRenderer;

    [SerializeField]
    Transform target;

    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = gameObject.AddComponent<LineRenderer>();
        lineRenderer.material = new Material(Shader.Find("Sprites/Default"));

        lineRenderer.SetPosition(0, target.position);
        lineRenderer.SetPosition(1, target.position);
        lineRenderer.startWidth = 0.1f;
        lineRenderer.endWidth = 0.1f;
        lineRenderer.startColor = Color.red;
        lineRenderer.endColor = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        DrawLine(target.position);
    }

        
    void DrawLine(Vector3 pos) {
        int posCount = lineRenderer.positionCount + 1;
        Vector3[] positions = new Vector3[posCount];
        lineRenderer.GetPositions(positions);
        positions[posCount - 1] = pos;
        lineRenderer.positionCount = posCount;
        lineRenderer.SetPositions(positions);
    }
}
