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
        Debug.Log("�⵹");
        if (other.gameObject.CompareTag("FlowerPowder"))
        {
            other.gameObject.SetActive(false);
            count += 1;
            if(count != maxCount)
            {
                text.text = "�ɰ��� "+ (maxCount - count) + "�� �� �����!";
            }
            else
            {
                text.text = "�׷� ���� ���ư���!";
                //�� ��ȯ
                StartCoroutine(DelaySecond());
            }
            
        }
    }

    IEnumerator DelaySecond()
    {
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene(2);
    }
}
