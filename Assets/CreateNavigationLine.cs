using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNavigationLine : MonoBehaviour
{
    float distance;
    public GameObject Line;
    public float distanceThreshold = 2.0f;
    Vector3 lastPosition;
    Vector3 currentPosition;

    // Start is called before the first frame update
    void Start()
    {
        lastPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        currentPosition = transform.position;
        distance = Vector3.Distance(lastPosition, currentPosition);
        if (distance > distanceThreshold)
        {
            lastPosition = currentPosition;
            Vector3 linePosition = new Vector3(transform.position.x, 0, transform.position.z);
            Instantiate(Line, linePosition, Quaternion.identity);
        }
    }
}
