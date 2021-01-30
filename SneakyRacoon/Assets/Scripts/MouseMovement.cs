using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{

    public float speed;
    public float rotationOffset;

    private Vector3 target; //mouse position

    private Rigidbody2D rb2D;
  
    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }

  
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            MovePlayer();
        }
     
        //MovePlayer();
        RotatePlayer();
    }


    public void MovePlayer()
    {
        rb2D.AddForce(transform.up * speed);
        target = Input.mousePosition;
        target.z = 20;
        //transform.position = Vector2.Lerp(transform.position, Camera.main.ScreenToWorldPoint(target), speed * Time.deltaTime);
    }

    public void RotatePlayer()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 0;

        Vector3 objectPos = Camera.main.WorldToScreenPoint(transform.position);
        mousePos.x = mousePos.x - objectPos.x;
        mousePos.y = mousePos.y - objectPos.y;

        float angle = (Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg) - 90;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

    }


}
