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
       
        
        if (Input.GetKey(KeyCode.LeftArrow) && isInLimit())
        {
            transform.Translate(Vector3.left * speed);
        }
        if (Input.GetKey(KeyCode.RightArrow) && isInLimit())
        {
            transform.Translate(Vector3.right * speed);
        }

        

    }

     bool isInLimit()
    {
        //Screen.width;
        int width = Screen.width;
        int minX = -Screen.width/ 2;
        int maxX = Screen.width/ 2;

        if (minX < transform.position.x && transform.position.x < maxX)
        {
            return true;
        }
        return false;
    }

}
