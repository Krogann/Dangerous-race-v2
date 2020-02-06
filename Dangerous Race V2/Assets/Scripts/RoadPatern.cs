using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadPatern : MonoBehaviour
{
    public float sizeMap = 70.0f;
    public float quantityMap = 3.0f;
    public float speedMap = 5.0f;

    void Update()
    {
        transform.position += Vector3.back * speedMap * Time.deltaTime;

        if (transform.position.z < -sizeMap)
        {
            transform.position += Vector3.forward * sizeMap * quantityMap;
        }
    }
}
