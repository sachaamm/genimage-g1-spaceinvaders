using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    int LevelNumber = 1;

    // Start is called before the first frame update
    void Start()
    {
        // int a = SpawnEnemies.NombreEnemy;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] Enemies = GameObject.FindGameObjectsWithTag("Enemy");
        int NombreEnemies = Enemies.Length;

        if (NombreEnemies == 0)
        {
            NextLevel();
        }
    }

    public void NextLevel()
    {
        SpawnEnemies.Singleton.SpawnEnemiesForLevel(LevelNumber++);
    }
}
