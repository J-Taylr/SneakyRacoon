using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
   

    [Header("Camera Positions")]
    public GameObject KitchenCam;
    public GameObject LoungeCam;

    GameManager.Room activeRoom;
    private void Start()
    {
        transform.position = KitchenCam.transform.position;
    }

    private void Update()
    {
        MoveCamera();
    }

    public void MoveCamera()
    {
        switch (activeRoom) // when room is active, move camera to active rooms 'cam' game object
        {
            case GameManager.Room.KITCHEN:
                Camera.main.transform.position = KitchenCam.transform.position;
                break;
            case GameManager.Room.LOUNGE:
                print("cam to lounge");
                Camera.main.transform.position = LoungeCam.transform.position;
                break;
        }
    }




}
