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
        // 1. ȭ�� ������ �����Ѵ�.

       bool isDownLeft = Input.GetMouseButtonDown(0);
       bool isDownRight = Input.GetMouseButtonDown(1);
        //bool isdd = Input.GetMouseButton(0);
       //bool isUp = Input.GetMouseButtonUp(0);

        // 2. ȸ���� ��Ű��
        if(isDownLeft)
        {
            Debug.Log("�������ϴ�!");
            rotatonSpeed = 100;
        }
        else if (isDownRight)
        {
            Debug.Log("�������ϴ�!");
            rotatonSpeed = -100;
        }
            this.transform.Rotate(0, 0, rotatonSpeed);

        // �ӵ� ���̱�
        this.rotatonSpeed *= 0.96f;


    }
}
