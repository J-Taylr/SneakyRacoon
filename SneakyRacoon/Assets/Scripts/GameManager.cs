using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    public float timeRemaining = 60;
    public Slider hungerSlider;
    
    
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
        HungerTimer();

        hungerSlider.value = timeRemaining;
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

    public void ResetHunger()
    {
        timeRemaining = 60;
    }
  
    public void HungerTimer()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            
        }
        else
        {
            timeRemaining = 0;
        }


    }






}
