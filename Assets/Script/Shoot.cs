using System.Collections;
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
        if (Input.GetKey(KeyCode.Space)) 
        {
            GameObject laser2 = Instantiate(laserPrefab);
            laser2.transform.position = gameObject.transform.position;
     }
    }
}
