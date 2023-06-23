using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;


[System.Serializable]
public class PlayerInfo
{
    public string playerName;
    public int playerHighScore;
}

[System.Serializable]
public class playerListClass
{
    public List<PlayerInfo> list = new List<PlayerInfo>();

    public void AddPlayer(string playerName, List<PlayerInfo> list)
    {
        PlayerInfo newPlayer = new PlayerInfo();
        newPlayer.playerName = playerName;
        newPlayer.playerHighScore = 0;
        list.Add(newPlayer);
    }

    public bool PlayerExists(string playerName, List<PlayerInfo> list)
    {
        foreach (PlayerInfo player in list)
        {
            if (player.playerName == playerName) return true;
        }
        return false;
    }

    
}

public class saved : MonoBehaviour
{
    public playerListClass players = new playerListClass();

    public void SaveToJson()
    {
        string playersData = JsonUtility.ToJson(players);
        string filePath = Application.persistentDataPath + "/PlayersData.json" ;
        Debug.Log(filePath);
        System.IO.File.WriteAllText(filePath, playersData);
        Debug.Log("saved players data");
    }

 

}


