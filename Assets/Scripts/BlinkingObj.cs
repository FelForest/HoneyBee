using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkingObj : MonoBehaviour
{
    private Renderer rend;
    private SpawnObj spawn;
    [SerializeField] private Color color1;
    [SerializeField] private Color color2;
    [SerializeField] private float timeStep = 0.5f;
    private bool isClicked = false;
    private bool isSpawn = false;
    public GameObject gague;
    public GameObject kit;
    void Start()
    {
        rend = GetComponent<Renderer>();
        spawn = GetComponent<SpawnObj>();
        
        
        StartBlick();
    }

    void StartBlick()
    {
        isClicked = false;
        StartCoroutine(Blink());
    }

    public void Clicked()
    {
        isClicked = true;
    }

    private void Update()
    {
        if (kit.GetComponent<FillGauge>().isFull && !isSpawn)
        {
            isSpawn = true;
            spawn.spawnObj();
        }
        
    }



    IEnumerator Blink()
    {
        while (!isClicked)
        {
            if (rend.material != null)
            {
                rend.material.color = color1; // 반짝이는 색상으로 변경
                yield return new WaitForSeconds(timeStep);
                rend.material.color = color2; // 반짝이지 않는 원래 색상으로 변경
                yield return new WaitForSeconds(timeStep);
            }
        }
        if(rend.material != null)
        {
            rend.material.color = color1;
        }
        gague.SetActive(true);
        kit.SetActive(true);
        yield return null;
    }
}
