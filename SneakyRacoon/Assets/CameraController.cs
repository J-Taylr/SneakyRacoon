using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float camSpeed;

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
        
    }

   

    public void CamToKitchen()
    {
        print("camtokitchen");
        Camera.main.transform.position = Vector3.MoveTowards(Camera.main.transform.position, KitchenCam.transform.position, camSpeed * Time.deltaTime);
    }

    public void CamToLounge()
    {
        print("camtolounge");
        Camera.main.transform.position = Vector3.MoveTowards(Camera.main.transform.position, LoungeCam.transform.position, camSpeed * Time.deltaTime);
    }




}
