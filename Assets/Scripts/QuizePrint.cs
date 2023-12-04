using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizePrint : MonoBehaviour
{
    public string[] Contents;
    public Text content;
    public bool[] answers;
    private int num = 0;
    public GameObject result;
    public float waitTime = 2.0f;
    public GameObject gagueUI;
    public Slider gague;
    public GameObject Honey;
    // Start is called before the first frame update
    void Start()
    {
        gagueUI.SetActive(true); gague.value = 0 ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonClicked(bool value)
    {
        if(num + 1 < Contents.Length)
        {
            StartCoroutine(WaitSecond(waitTime,value));
            
        }
    }

    IEnumerator WaitSecond(float second, bool value)
    {
        if (num < Contents.Length)
        {
            result.SetActive(true);
            if (value == answers[num])
            {
                result.GetComponent<Text>().text = "O";
            }
            else
            {
                result.GetComponent<Text>().text = "X";
            }
            yield return new WaitForSeconds(second);
            result.SetActive(false);

            num++;
            gague.value = num * (gague.maxValue / answers.Length);
            if (num < Contents.Length)
            {
                content.text = Contents[num];
            }


        }
        if (num == 3)
        {
            Honey.SetActive(true);
            gagueUI.SetActive(false);
            gameObject.SetActive(false);
        }
        Debug.Log(num);
        
    }
}
