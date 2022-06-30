using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateLinePos : MonoBehaviour
{
    LineRenderer lineRenderer;

    [SerializeField]
    Transform target;
    [SerializeField]
    Vector3 vector;

    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = gameObject.GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        lineRenderer.SetPosition(0, target.position);
        lineRenderer.SetPosition(1, target.position + vector);
    }
}
