using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDrag : MonoBehaviour
{
    protected bool isDragging = false;
    protected Vector3 offset;
    protected Vector3 startPosition;

    
    protected virtual void Update()
    {
        objDrag();
    }

    protected void objDrag()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // ���콺 ���� ��ư�� ó�� Ŭ���Ǿ��� ��
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == gameObject)
                {
                    // Ŭ���� ������Ʈ�� ���� ��ũ��Ʈ�� ������ ������Ʈ�� ���
                    isDragging = true;
                    offset = transform.position - hit.point;
                    startPosition = transform.position;
                }
            }
        }
        else if (Input.GetMouseButtonUp(0))
        {
            // ���콺 ���� ��ư�� �������� ��
            isDragging = false;
        }

        if (isDragging)
        {
            // ���콺�� Ŭ���ϰ� �ִ� ���� ������Ʈ�� ���콺 ��ġ�� �̵�
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                transform.position = hit.point + offset;
            }
        }
    }
}
