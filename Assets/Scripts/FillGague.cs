using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillGague : MonoBehaviour
{
    public Transform tool;
    public Slider gague;
    public float threshold;

    private Vector3 perPos;
    private Vector3 curPos;
    private float dist;


    // Start is called before the first frame update
    void Start()
    {
        perPos = tool.position;
    }

    // Update is called once per frame
    void Update()
    {
        curPos = tool.position;
        dist = Vector3.Distance(curPos, perPos);
        perPos = curPos;

        if(gague.value < gague.maxValue)
        {
            if (dist < threshold)
            gague.value += dist;
        }
    }
}
