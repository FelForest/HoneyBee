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
    public bool isBlink;
    public bool WantedSpawn = true;
    public GameObject nextObj;
    void Start()
    {
        rend = GetComponent<Renderer>();
        spawn = GetComponent<SpawnObj>();

        if (isBlink)
        {
            StartBlick();
        }
        
    }

    void StartBlick()
    {
        isClicked = false;
        StartCoroutine(Blink());
    }

    public void Clicked()
    {
        isClicked = true;
        gague.SetActive(true);
        kit.SetActive(true);
    }

    private void Update()
    {
        if (kit.GetComponent<FillGauge>().isFull && !isSpawn)
        {
            isSpawn = true;
            if (WantedSpawn)
            {
                spawn.spawnObj();
            }
            else
            {
                nextObj.SetActive(true);
            }
            
        }
        
    }



    IEnumerator Blink()
    {
        while (!isClicked)
        {
            if (rend.material != null)
            {
                rend.material.color = color1; // ��¦�̴� �������� ����
                yield return new WaitForSeconds(timeStep);
                rend.material.color = color2; // ��¦���� �ʴ� ���� �������� ����
                yield return new WaitForSeconds(timeStep);
            }
        }
        if(rend.material != null)
        {
            rend.material.color = color1;
        }
        
        yield return null;
    }
}
