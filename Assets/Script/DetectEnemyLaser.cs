﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectEnemyLaser : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "EnemyLaser")
        {
           PlayerLife.Singleton.RecevoirDegat();
           Destroy(collision.gameObject);
        }
    }
}
