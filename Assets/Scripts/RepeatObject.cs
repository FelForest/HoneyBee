using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatObject : MonoBehaviour
{
    public Transform centerTransoform;
    float radius = 0.4f;
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
        

        transform.position = new Vector3(x, transform.position.y, centerTransoform.position.z);

        angle += angularSpeed * Time.deltaTime;
    }
}
