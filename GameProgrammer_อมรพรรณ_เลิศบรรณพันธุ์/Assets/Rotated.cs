﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotated : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(Vector3.right * Time.deltaTime * 25f);
        transform.Rotate(new Vector3(15, 30, 45)* Time.deltaTime);
    }
}
