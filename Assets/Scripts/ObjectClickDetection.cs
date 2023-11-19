using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClickDetection : MonoBehaviour
{
    void Update()
    {
        // 마우스 왼쪽 버튼이 클릭되었을 때
        if (Input.GetMouseButtonDown(0))
        {
            // Ray를 생성하여 마우스 위치에서 화면으로 쏘기
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Ray가 어떤 오브젝트와 충돌했는지 확인
            if (Physics.Raycast(ray, out hit))
            {
                // 충돌한 오브젝트의 처리
                GameObject clickedObject = hit.transform.gameObject;
                Debug.Log("Clicked on: " + clickedObject.name);
                // 유나타 스위치 왜 안됨?
                string tag = clickedObject.tag;
                if (tag == "Flower")
                {
                    clickedObject.GetComponent<BlinkingObj>().Clicked();
                }
                else if (tag == "Honey")
                {

                }
                else if (tag == "HoneyBee")
                {

                }

                // 여기에 클릭된 오브젝트에 대한 추가 로직을 추가할 수 있습니다.
            }
        }
    }
}
