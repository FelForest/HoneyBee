using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnObjects : MonoBehaviour
{
    public Slider gague;

    public GameObject[] objects;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gague.value == gague.maxValue)
        {
            SP(objects);
        }
    }

    void SP(GameObject[] objects)
    {
        if (objects != null)
        {
            foreach (GameObject obj in objects)
            {
                obj.SetActive(true);
            }
        }
    }
}
