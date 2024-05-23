using UnityEngine;
using System.Collections;

public class Coroutine : MonoBehaviour
{
    public float smoothing = 1f;
    public Transform target;


    void Start()
    {
        StartCoroutine(MyCoroutine(target));

        //StopCoroutine("Movement");
        //StartCoroutine("Movement", target);
    }


    IEnumerator MyCoroutine(Transform target)
    {
        while (Vector3.Distance(transform.position, target.position) > 0.05f)
        {
            transform.position = Vector3.Lerp(transform.position, target.position, smoothing * Time.deltaTime);

            yield return null;
        }

        print("Reached the target.");

        yield return new WaitForSeconds(3f);

        print("MyCoroutine is now finished.");
    }

    IEnumerator Movement(Vector3 target)
    {
        while (Vector3.Distance(transform.position, target) > 0.05f)
        {
            transform.position = Vector3.Lerp(transform.position, target, smoothing * Time.deltaTime);

            yield return null;
        }
    }
}