using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    int LevelNumber = 1;
    public GameObject introCanvas, inGameCanvas, gameOverCanvas;
    public static Game Singleton;
    public GameObject player;

    private void Awake()
    {
        Singleton = this;       
    }
    public enum GameState
    {
        intro,
        inGame,
        gameOver
    }
    GameState state = GameState.intro;

    // Start is called before the first frame update
    void Start()
    {
        // int a = SpawnEnemies.NombreEnemy;
    }

    // Update is called once per frame
    void Update()
    {
        if (state == GameState.intro)
        {

        }
        if (state == GameState.inGame)
        {
            InGame();
        }
        if (state == GameState.gameOver)
        {
            foreach (var a in GameObject.FindGameObjectsWithTag("Enemy"))
            {
                Destroy(a);
            }
        }
    }

    #region InGame 
    void InGame()
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
    #endregion
    public void SetGameState(GameState newState)
    {
        state = newState;
        AdaptCanvasToGameState(newState);
        if (state == GameState.intro)
        {
            //
        }
        if (state == GameState.inGame)
        {
            GameObject newPlayer = Instantiate(player);
        }
        if (state == GameState.gameOver)
        {
            //
        }
    }
    void AdaptCanvasToGameState(GameState newState)
    {
        if (state == GameState.intro)
        {
            introCanvas.SetActive(true);
            inGameCanvas.SetActive(false);
            gameOverCanvas.SetActive(false);

        }
        if (state == GameState.inGame)
        {
            introCanvas.SetActive(false);
            inGameCanvas.SetActive(true);
            gameOverCanvas.SetActive(false);
        }
        if (state == GameState.gameOver)
        {
            introCanvas.SetActive(false);
            inGameCanvas.SetActive(false);
            gameOverCanvas.SetActive(true);
        }
    }
    public void SetIntroState() 
    {
        SetGameState(GameState.intro);
    }
    public void SetInGameState()
    {
        SetGameState(GameState.inGame);
    }
    public void SetGameOverState()
    {
        SetGameState(GameState.gameOver);
    }
}
