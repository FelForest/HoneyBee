using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GatherHoney : MonoBehaviour
{
    public string[] texts;
    public Text text;
    public GameObject bg;
    public bool st;
    
    public int scenenum;

    // Start is called before the first frame update
    void Start()
    {
        if(st)
        {
            StartCoroutine(StartText());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("√‚µπ");
        if (other.gameObject.CompareTag("Honey"))
        {
            if (bg != null)
            {
                bg.SetActive(true);
            }
            
            other.gameObject.SetActive(false);
            StartCoroutine(StartText());
        }
    }

    IEnumerator StartText()
    {
        foreach(string t in texts)
        {
            text.text = t;
            yield return new WaitForSeconds(2.0f);
        }

        if(scenenum == 1)
        {
            SceneManager.LoadScene(scenenum);
        }
        yield return null;
    }
}
