using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillGauge : ObjectDrag
{
    public float fillSpeed = 0.1f;
    public float currentGauge = 0.0f;
    public float movementThreshold = 1.0f;
    public float maxGauge = 1.0f;
    public Slider gauge;
    internal bool isFull = false;

    protected override void Update()
    {
        base.Update();

        // ������ �Ÿ��� ���� �̻��̸� ����� ���
        if (isDragging && Vector3.Distance(transform.position, startPosition) > movementThreshold)
        {
            if (!isFull )
            {
                if (currentGauge < maxGauge)
                {
                    currentGauge += fillSpeed;
                    gauge.value = currentGauge / maxGauge;
                    startPosition = transform.position;
                }
                else
                {
                    Debug.Log("Gague Full");
                    isFull = true;
                }
            }
            
            
        }
    }
}