using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NameSaver : MonoBehaviour
{

    public string playerName;

    public GameObject inputField;

    public GameObject textDisplay;

    public GameObject mainMenu;

    public Text savedName;

    public saved jsonlogic;
    public playerListClass jsonlist;

    public void SaveName()
    {
        playerName = inputField.GetComponent<Text>().text;
        textDisplay.GetComponent<Text>().text = playerName;
        PlayerPrefs.SetString("Name", playerName);
        List<PlayerInfo> list = new List<PlayerInfo>();
        if (jsonlist.PlayerExists(playerName, jsonlist.list) == false)
        {
            jsonlist.AddPlayer(playerName, jsonlist.list);
            Debug.Log("ADDED new player to json list");
        }
        //jsonlist.SaveToJson(jsonlist.list);
        //Debug.Log("saved to j");

    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void Start()
    {
        textDisplay.GetComponent<Text>().text = PlayerPrefs.GetString("Name","User");
        jsonlogic = GameObject.FindGameObjectWithTag("jsonsaver").GetComponent<saved>();
    }
}