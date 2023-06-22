using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LogicScript : MonoBehaviour
{

    public int playerScore;
    public TMP_Text scoreText;
    public GameObject gameOverScreen;
    public TMP_Text highscore;
    public int highScoreInt;
   
   


    private void Start()
    {
        highscore.text = PlayerPrefs.GetInt("Highscore",0).ToString();
        //LoadPlayer();
    }


    [ContextMenu("Increase score")]
    public void addScore()
    {
        playerScore++;
        scoreText.text = playerScore.ToString();

        if (playerScore > PlayerPrefs.GetInt("Highscore",0))
        {
            PlayerPrefs.SetInt("Highscore", playerScore);
            highscore.text = playerScore.ToString();
            highScoreInt = playerScore;
        }
        
    }


    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        //SavePlayer();
        gameOverScreen.SetActive(true);
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void SavePlayer()
    {
        Player player = new Player();
        player.playerHighScore = highScoreInt; 
        SaveSystem.SavePlayer(player);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        highScoreInt = data.highScore;
        highscore.SetText(highScoreInt.ToString());
    }
}


