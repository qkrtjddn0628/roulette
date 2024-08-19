using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    private float rotatonSpeed = 0;

    void Start()
    {
        
    }

    void Update()
    {
        // 1. 화면 누르면 감지한다.

       bool isDownLeft = Input.GetMouseButtonDown(0);
       bool isDownRight = Input.GetMouseButtonDown(1);
        //bool isdd = Input.GetMouseButton(0);
       //bool isUp = Input.GetMouseButtonUp(0);

        // 2. 회전을 시키기
        if(isDownLeft)
        {
            Debug.Log("눌렀습니다!");
            rotatonSpeed = 100;
        }
        else if (isDownRight)
        {
            Debug.Log("눌렀습니다!");
            rotatonSpeed = -100;
        }
            this.transform.Rotate(0, 0, rotatonSpeed);

        // 속도 줄이기
        this.rotatonSpeed *= 0.96f;


    }
}
