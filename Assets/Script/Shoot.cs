﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject laserPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 laserOffset = new Vector3(0, 0.5f, 0);
        
        if (Input.GetKey(KeyCode.Space)) 
        {
            GameObject laser2 = Instantiate(laserPrefab, ParentReference.Singleton.projectilesParent.transform);
            laser2.transform.position = gameObject.transform.position + laserOffset;
            Destroy(laser2, 2);
        }
    }
}
