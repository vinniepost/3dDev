using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    void Start()
    {
        // Invoke the DestroyObject method after 3 seconds
        Invoke("DestroyObject", 4f);
    }

    void DestroyObject()
    {
        // Destroy the game object this script is attached to
        Destroy(gameObject);
    }
}
