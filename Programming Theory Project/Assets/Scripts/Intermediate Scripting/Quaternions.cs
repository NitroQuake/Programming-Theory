using UnityEngine;
using System.Collections;

public class Quaternions : MonoBehaviour
{
    public Transform target;

    void Update()
    {
        Vector3 relativePos = target.position - transform.position;
        transform.rotation = Quaternion.LookRotation(relativePos);
        //looks at that direction, use Quaternuion than Euler's angles
    }
}