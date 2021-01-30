using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    GameObject player;

    public float CamZOffset;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        FollowPlayer();
    }

    public void FollowPlayer()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, (player.transform.position.z + CamZOffset));
    }

}
