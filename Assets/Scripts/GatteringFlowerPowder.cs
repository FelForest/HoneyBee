using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GatteringFlowerPowder : MonoBehaviour
{
    public Text text;
    [SerializeField]
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(count == 3)
        {
            text.text = "���� ������!";
        }
    }

    private void OnTriggerEnter(Collider other)
    {
       if (other.tag == "FlowerPowder")
        {
            text.text = count + "/3";
        }
    }
}
