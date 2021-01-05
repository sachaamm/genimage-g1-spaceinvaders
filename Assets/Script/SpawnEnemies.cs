using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public static SpawnEnemies Singleton;
    public GameObject SpawnPoint;

    public static int NombreEnemy = 5;
    private void Awake()
    {
        Singleton = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnEnemiesForLevel(int Level)
    {
        for (int i = 0; i < NombreEnemy; i++)
        {
            GameObject NewEnemy = Instantiate(EnemyPrefab);

            NewEnemy.transform.position = new Vector3(i, 0, 0) + SpawnPoint.transform.position;
           // float ennemySpeed = gameObject.GetComponent<Enemy>();
            Enemy componentEnemy = NewEnemy.GetComponent<Enemy>();
            float enemySpeed = componentEnemy.speed;
            componentEnemy.speed = Level /(float)100;
            //HingeJoint hinge = gameObject.GetComponent<HingeJoint>();
        }
    }
}
