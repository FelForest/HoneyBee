using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GatherHoney : MonoBehaviour
{
    public string[] texts;
    public Text text;
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
        Debug.Log("√‚µπ");
        if (other.gameObject.CompareTag("Honey"))
        {
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
        yield return null;
    }
}
