using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Apple.ReplayKit;
using UnityEngine.UI;

public class FillGauge : ObjectDrag
{
    public float fillSpeed = 0.1f;
    public float currentGauge = 0.0f;
    public float movementThreshold = 1.0f;
    public float maxGauge = 1.0f;
    public Slider gauge;
    internal bool isFull = false;
    public GameObject kit;
    protected override void Update()
    {
        base.Update();

        // 움직인 거리가 일정 이상이면 디버그 출력
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
                    
                    gameObject.SetActive(false);
                    kit.SetActive(false);
                }
            }
            
            
        }
    }
}
