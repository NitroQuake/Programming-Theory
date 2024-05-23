using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidpointAlterFormula : MonoBehaviour
{
    public Transform targetPos;
    // Start is called before the first frame update
    void Start()
    {
        float distance = Vector2.Distance(transform.position, targetPos.position) - 2;
        float scale = distance / Vector2.Distance(transform.position, targetPos.position);
        Debug.Log((transform.position.x + targetPos.position.x) * scale + " , " + (transform.position.y + targetPos.position.y) * scale);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
