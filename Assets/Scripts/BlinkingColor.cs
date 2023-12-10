using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkingColor : MonoBehaviour
{
    public bool isBlink = true;
    public Material material1;
    public Material material2;

    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        StartCoroutine("Blink");
    }

    IEnumerator Blink()
    {
        while (isBlink)
        {
            rend.material = material1;
            yield return new WaitForSeconds(1.0f);
            rend.material = material2;
            yield return new WaitForSeconds(1.0f);
        }
    }

    public void StopBlink()
    {
        isBlink = false;
    }
}
