using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GatteringFlowerPowder : MonoBehaviour
{
    public Text text;
    [SerializeField]
    int count = 0;
    public GameObject HoneyPot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.CompareTag("FlowerPowder"))
        {
            Destroy(other.gameObject);
            if(count < 2)
            {
                count++;
                text.text = count + "/3";
            }
            else
            {
                text.text = "²ÜÀ» ¸¸µéÀÚ!";
                HoneyPot.SetActive(true);
            }
        }
    }
}
