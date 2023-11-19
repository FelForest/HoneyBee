using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClickDetection : MonoBehaviour
{
    void Update()
    {
        // ���콺 ���� ��ư�� Ŭ���Ǿ��� ��
        if (Input.GetMouseButtonDown(0))
        {
            // Ray�� �����Ͽ� ���콺 ��ġ���� ȭ������ ���
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Ray�� � ������Ʈ�� �浹�ߴ��� Ȯ��
            if (Physics.Raycast(ray, out hit))
            {
                // �浹�� ������Ʈ�� ó��
                GameObject clickedObject = hit.transform.gameObject;
                Debug.Log("Clicked on: " + clickedObject.name);
                // ����Ÿ ����ġ �� �ȵ�?
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

                // ���⿡ Ŭ���� ������Ʈ�� ���� �߰� ������ �߰��� �� �ֽ��ϴ�.
            }
        }
    }
}
