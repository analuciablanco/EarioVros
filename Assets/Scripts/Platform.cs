﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : Enemy2D
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.tag =="horizontal")
        {
            HorizontalMovement();
        }
        else if(gameObject.tag=="vertical")
        {
            VerticalMovement();
        }
    }

}