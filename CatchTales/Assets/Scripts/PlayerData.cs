using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    // Start is called before the first frame update
    private Player player; 
    public Player Player
    {
        get
        {
            return player;
        }
        set
        {
            player = value;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
