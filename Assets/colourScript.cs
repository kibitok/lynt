﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.C))
        {
            Renderer rend = gameObject.GetComponent<Renderer>();
            rend.material.color = Color.green;

            Debug.Log(Color.green);

        }

    }
}
