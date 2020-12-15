using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{    
    public float speed = 0.10f; 
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {                     
        if (Input.GetKey(KeyCode.LeftArrow) && NextPosIsInLimit(Vector3.left * speed))
        {
            transform.Translate(Vector3.left * speed);
        }
        if (Input.GetKey(KeyCode.RightArrow) && NextPosIsInLimit(Vector3.right * speed))
        {
            transform.Translate(Vector3.right * speed);
        }

        

    }

     bool NextPosIsInLimit(Vector3 direction)
    {             
        int minX = 0;
        int maxX = Screen.width;
        Vector3 nextPos = Camera.main.WorldToScreenPoint(transform.position + direction);

        if (minX < nextPos.x && nextPos.x < maxX)
        {
            return true;
        }
        return false;
    }
}
