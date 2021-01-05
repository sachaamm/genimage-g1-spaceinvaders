using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float IntervalleShoot = 0.1f;
    float compteur = 0f;
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
             compteur += Time.deltaTime;
        }
        if (compteur >= IntervalleShoot)
        {
            compteur = 0;
            Shooting();
        }
    }
    void Shooting()
    {
        Vector3 laserOffset = new Vector3(0, 0.5f, 0);
        
        GameObject laser2 = Instantiate(laserPrefab, ParentReference.Singleton.projectilesParent.transform);
        laser2.transform.position = gameObject.transform.position + laserOffset;
        Destroy(laser2, 2);
    }
}
