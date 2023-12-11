using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class QuizePrint : MonoBehaviour
{
    public string[] Contents;
    public Text content;
    public bool[] answers;
    public GameObject result;
    public GameObject Gague;

    public GameObject[] honeys;
    public Material color1;
    public Material color2;

    private Material resultColor;
    public static int num = 0;
    private bool isLoaded = false;
    private Slider value;

    public GameObject honeyPot;

    public GameObject nextObj;
    // Start is called before the first frame update
    void Start()
    {
        Gague.SetActive(true);
        value = Gague.GetComponentInChildren<Slider>();
        value.value = 0.0f;

        


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonClicked(bool value)
    {
        
        if (!isLoaded)
        {
            isLoaded = true;
            

            StartCoroutine(WaitLoaded(value));
        }
    }

    IEnumerator WaitLoaded(bool answer)
    {
        Debug.Log(num);
        if(num < answers.Length)
        {
            
            string ans;
            if(answer == answers[num])
            {
                ans = "O";
            }
            else
            {
                ans = "X";
            }
            num++;
            result.SetActive(true);
            result.GetComponent<Text>().text = ans;
            value.value = num * (value.maxValue / Contents.Length);
            
            
            yield return new WaitForSeconds(2.0f);
            result.SetActive(false);
            
            if (num == 3)
            {
                foreach (GameObject honey in honeys)
                {
                    honey.GetComponent<Renderer>().material = color2;
                }
                honeyPot.GetComponent<XRSimpleInteractable>().enabled = false;
                honeyPot.GetComponent<XRGrabInteractable>().enabled = true;
                if(nextObj != null)
                {
                    nextObj.SetActive(true);
                }
                gameObject.SetActive(false);
            }
            else
            {
                content.text = Contents[num];
                isLoaded = false;
            }
            
            
            
        }
        
        yield return null;
    }
}
