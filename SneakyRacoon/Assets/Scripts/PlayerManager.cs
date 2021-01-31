using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject sprite;
    MouseMovement playerMover;

    

    private void Start()
    {
        
        playerMover = GetComponent<MouseMovement>();
    }

    public void EatFood()
    {
        transform.localScale += new Vector3(0.1f, 0, 0);
        playerMover.LowerSpeed();

    }




   
   

  
}
