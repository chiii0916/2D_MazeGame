﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider coin;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.gameObject.name== "Idle (32x32)_0")
        {
            coin.value += 1;
            Destroy(this.gameObject);
        }
    }
}
