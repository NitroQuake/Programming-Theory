using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public Transform point;
    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(point.position, Vector3.forward, Time.deltaTime * 20);
        transform.localRotation = Quaternion.identity;
    }
}
