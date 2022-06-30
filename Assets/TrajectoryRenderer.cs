using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrajectoryRenderer : MonoBehaviour
{
    LineRenderer lineRenderer;

    [SerializeField]
    Transform target;

    [SerializeField]
    Transform prefab;

    int step;
    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = gameObject.AddComponent<LineRenderer>();
        lineRenderer.material = new Material(Shader.Find("Sprites/Default"));

        lineRenderer.SetPosition(0, target.position);
        lineRenderer.SetPosition(1, target.position);
        lineRenderer.startWidth = 0.001f;
        lineRenderer.endWidth = 0.001f;
        lineRenderer.startColor = Color.red;
        lineRenderer.endColor = Color.red;

        step = 0;
    }

    // Update is called once per frame
    void Update()
    {
        step += 1;
        DrawLine(target.position);
        if(step % 10 == 0) {
            Instantiate(prefab, target.position, Quaternion.identity);
        }
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
