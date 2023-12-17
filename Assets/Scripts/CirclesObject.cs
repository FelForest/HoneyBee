using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CirclesObject : MonoBehaviour
{
    public Transform centerTransoform;
    float radius = 0.2f;
    float angularSpeed = 72f;

    float angle = 0f;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float angleInRadians = angle * Mathf.Deg2Rad;

        float x = radius * Mathf.Cos(angleInRadians) + centerTransoform.position.x;
        float y = radius * Mathf.Sin(angleInRadians) + centerTransoform.position.y;

        transform.position  = new Vector3(x, y + 2.0f, centerTransoform.position.z);

        angle += angularSpeed * Time.deltaTime;
        
    }
}
