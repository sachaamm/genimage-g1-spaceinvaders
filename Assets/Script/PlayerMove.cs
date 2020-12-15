using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Vector3 direction;
    public float speed = 0.10f; 
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        direction = new Vector3(1, 0,0);
       // transform.position = direction + transform.position;
        transform.position = direction*speed + transform.position;

    }
}
