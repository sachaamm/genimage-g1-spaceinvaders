using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndofLevel : MonoBehaviour
{
   public int EnnemyNumber = 10;
    public string nextLevel = "toto";
    // Start is called before the first frame update
    void Start()
    {
        EnnemyNumber--;
    }

    // Update is called once per frame
    void Update()
    {
        int a = 0; 
        if (EnnemyNumber < 0)
        {
            LevelEnd();
        }
       

    }
    void LevelEnd()
    {
        Debug.Log("levelend");
        SceneManager.LoadScene(nextLevel);
    }
}
