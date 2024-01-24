using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
    public float riseSpeed = 5f;

    void Update()
    {
        Rise();
    }

    void Rise()
    {
        // Move the water plane upward
        transform.Translate(Vector3.up * riseSpeed * Time.deltaTime);
    }
}