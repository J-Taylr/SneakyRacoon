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

    //start script here//start script here//start script here//start script here//start script here//start script here//start script here//start script here//start script here//start script here//start script here//st


    public int playerScore = 0;
     public enum Room {KITCHEN,LOUNGE,BEDROOM,TOILET}
     Room activeRoom;

    [Header("Rooms")]
    public RoomController kitchen;
    public RoomController lounge;

    public CameraController cam;

    void Start()
    {
        cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraController>();
    }

    
    void Update()
    {
        CheckRooms();
    }

    public void CheckRooms()
    {
        if (kitchen.CheckActive() == true)
        {
            print("kitchen is active");
            activeRoom = Room.KITCHEN;
            cam.CamToKitchen();
        }

        if (lounge.CheckActive() == true) 
        {
            print("lounge is active");
            activeRoom = Room.LOUNGE;
            cam.CamToLounge();
        }



    }

  

}
