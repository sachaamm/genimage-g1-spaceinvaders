using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject laserPrefab2;
    float count;
    public float countMax = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 laserOffset = new Vector3(0, 0.5f, 0);
        count += Time.deltaTime;
       
        if (count > countMax)
        {
            GameObject laser2 = Instantiate(laserPrefab2, ParentReference.Singleton.projectilesParent.transform);
            laser2.transform.position = gameObject.transform.position + laserOffset;
            count = 0;
            Destroy(laser2, 2);
           
        }
        

    }
}
