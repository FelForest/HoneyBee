using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GatherPowder : MonoBehaviour
{
    public Text text;
    public int count = 0;
    private int maxCount = 3;
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
        Debug.Log("출돌");
        if (other.gameObject.CompareTag("FlowerPowder"))
        {
            other.gameObject.SetActive(false);
            count += 1;
            if(count != maxCount)
            {
                text.text = count + " / " + maxCount;
            }
            else
            {
                text.text = "그럼 이제 돌아가자!";
                //신 전환
                
            }
            
        }
    }
}
