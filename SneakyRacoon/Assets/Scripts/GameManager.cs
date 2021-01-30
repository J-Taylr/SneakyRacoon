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
    public bool PlayerisHidden = false;
    public float timeRemaining = 60;
    public Slider hungerSlider;
    
    
    public enum Room {KITCHEN,LOUNGE,BEDROOM,TOILET}
     Room activeRoom;

    [Header("Rooms")]
    public RoomController kitchen;
    public RoomController lounge;

    public CameraController cam;


    public GameObject[] roomsinHouse;

    public List<GameObject> foodSpawned = new List<GameObject>();

    public List<GameObject> foodPrefabs = new List<GameObject>();

    void Start()
    {
        roomsinHouse = GameObject.FindGameObjectsWithTag("Room");
        cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraController>();
    }

    
    void Update()
    {
        //CheckRooms();
        HungerTimer();
        FoodSpawner();
        hungerSlider.value = timeRemaining;
    }

   /* public void CheckRooms()
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

    }*/

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


    public void FoodSpawner()
    {
        if (foodSpawned.Count < 10)
        {
            GameObject roomToSpawn = roomsinHouse[Random.Range(0, roomsinHouse.Length)];
            GameObject foodToSpawn = foodPrefabs[Random.Range(0, foodPrefabs.Count)];

            roomToSpawn.GetComponent<RoomController>().SpawnFood(foodToSpawn);

        
        }
    }



}
