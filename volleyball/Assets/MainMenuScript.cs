using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{
    public Text playerName;
    private void Start()
    {
        playerName.text = PlayerPrefs.GetString("Name", "User").ToString();
        
        //LoadPlayer();
    }
    void Update()
    {
        playerName.text = PlayerPrefs.GetString("Name", "User");
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1 );
    }

    public void OpenOptionsMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +2);
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Exited game");
    }

    
}
