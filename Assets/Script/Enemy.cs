using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 1;
    bool reachLimit = false;
    float count;
    public float tempsDescente = 0.4f;
    Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        direction = new Vector3(1, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        tempsDescente = 0.005f / speed * 0.4f;
        if (NextPosIsInLimit(direction * speed))
        {
            transform.Translate(direction * speed);
        }
        else { reachLimit = true; }
        if (reachLimit)
        {
            count += Time.deltaTime;
            transform.Translate(Vector3.down * speed);
            if(count > tempsDescente)
            {
                reachLimit = false;
                count = 0;
                direction = -direction;
            }
        }
        
    }
    
       
    void OnTriggerEnter2D(Collider2D collision)
    {      
        if (collision.gameObject.tag == "Shoot")
        {  
            Destroy(gameObject);
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
