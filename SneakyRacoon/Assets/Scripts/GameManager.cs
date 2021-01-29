using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private static GameManager _instance;
    public static GameManager Instance { get { return _instance; } }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }

       
    }

    //start script here//start script here//start script here//start script here//
    

    public int playerScore = 0;
     public enum Room {KITCHEN,LOUNGE,BEDROOM,TOILET}
     Room activeRoom;

    [Header("Rooms")]
    public RoomController kitchen;
    public RoomController lounge;




    void Start()
    {
        
    }

    
    void Update()
    {
        CheckRooms();
    }

    public void CheckRooms()
    {
        if (kitchen.CheckActive() == true)
        {
            print("kitchenactive");
            activeRoom = Room.KITCHEN;

        }
        if (lounge.CheckActive() == true) 
        {
            print("lounge is active");
            activeRoom = Room.LOUNGE;
        }



    }

  

}
