using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour
{
    public static PlayerLife Singleton;
    int life = 3;
    int maxLife = 3;
    public Slider lifeSlider;

    private void Awake()
    {
        Singleton = this;
        life = maxLife;
        lifeSlider.maxValue = life;
        UpdateLifeBar();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void RecevoirDegat()
   {
        life--;
        UpdateLifeBar();
        if (life <= 0)
        {
            Destroy(gameObject);
            Game.Singleton.SetGameOverState();
        }
   }
   
    void UpdateLifeBar()
    {
        lifeSlider.value = life;
    }

}
