using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.RestService;
using UnityEngine;


[System.Serializable]
public class PlayerData
{
    

    public string name;
    public int highScore;

    public PlayerData (Player player)
    {
        name = player.playerName;
        highScore = player.playerHighScore;


    }
}   
