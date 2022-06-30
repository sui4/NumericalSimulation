using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simulator : MonoBehaviour
{
    Vector3 E = new Vector3(1, 2, 1);
    Vector3 B = new Vector3(5, 7, 8);
    Vector3 pos = new Vector3(10, 12, 1);
    Vector3 vel = new Vector3(2, 3, 4);
    float k = 10f; // q/m
    float deltaT = 0.001f;

    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        // deltaT = Time.deltaTime;
        Vector3 t = (k * deltaT / 2f) * B;
        Vector3 s = (2f * t) / (1f + Vector3.Dot(t, t));

        Vector3 vMinus = vel + E * (k * deltaT / 2f);
        Vector3 vCenter = vMinus + Vector3.Cross(vMinus, t);
        Vector3 vPlus = vMinus + Vector3.Cross(vCenter, s);

        vel = vPlus + E * (k * deltaT / 2f);
        
        // update pos
        pos += vel * deltaT;
        this.transform.position = pos;
    }


}
