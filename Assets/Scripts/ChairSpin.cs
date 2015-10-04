﻿using UnityEngine;
using System.Collections;
using System;

public class ChairSpin : MonoBehaviour {
    private bool isRotating = false;
    private float spinTime = 2.0f;

    void OnMouseDown()
    {
        Debug.Log(transform.rotation.y.ToString());
        isRotating = true;
    }

    void Update()
    {
        if (isRotating)
        {
            spinChair();
            spinTime -= Time.deltaTime;
        }
    }

    void spinChair()
    {
            transform.Rotate(Vector3.down, Time.deltaTime * 180, Space.World);
        //Debug.Log(transform.rotation.y.ToString());
        if (spinTime <= 0)
        {
            isRotating = false;
            spinTime = 2.0f;
        }
    }
}
