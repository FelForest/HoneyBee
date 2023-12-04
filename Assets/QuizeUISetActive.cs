using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizeUISetActive : MonoBehaviour
{
    private GameObject gagueUI;
    // Start is called before the first frame update
    void Start()
    {
        gagueUI = GameObject.Find("QuizeUI");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setUITrue()
    {
        gagueUI.SetActive(true);
    }
}
