using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GaguePosition : MonoBehaviour
{
    public Slider Gague;
    // Start is called before the first frame update
    void Start()
    {
        Gague = Instantiate(Gague);
    }

    // Update is called once per frame
    void Update()
    {
        Gague.transform.position = Camera.main.WorldToScreenPoint(transform.position + new Vector3(0, 0.8f, 0));

    }
}
