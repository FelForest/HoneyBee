using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DespanObjects : MonoBehaviour
{

    public Slider gague;

    public GameObject[] objects;
    
    // Update is called once per frame
    void Update()
    {
        if(gague.value == gague.maxValue)
        {
            DSP(objects);
        }
    }

    void DSP(GameObject[] objects)
    {
        if (objects != null)
        {
            foreach (GameObject obj in objects)
            {
                obj.SetActive(false);
            }
        }
    }
}
