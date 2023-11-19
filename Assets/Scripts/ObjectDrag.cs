using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDrag : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 offset;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // 마우스 왼쪽 버튼이 처음 클릭되었을 때
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == gameObject)
                {
                    // 클릭한 오브젝트가 현재 스크립트가 부착된 오브젝트인 경우
                    isDragging = true;
                    offset = transform.position - hit.point;
                }
            }
        }
        else if (Input.GetMouseButtonUp(0))
        {
            // 마우스 왼쪽 버튼이 놓여졌을 때
            isDragging = false;
        }

        if (isDragging)
        {
            // 마우스를 클릭하고 있는 동안 오브젝트를 마우스 위치로 이동
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                transform.position = hit.point + offset;
            }
        }
    }
}
