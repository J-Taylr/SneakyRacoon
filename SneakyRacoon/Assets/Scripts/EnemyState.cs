using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyState : MonoBehaviour
{
    public int state;
    public Transform player;
    public AIDestinationSetter destination;
    public AIPath speedControl;

    public Transform[] patrolNodes;
    public Transform node;
    private int selection;
    public float pursuitTime;

    void Start() {
        NewDestination();
    }


    void Update() 
    {
        print(state);
        //RaycastHit2D hit =
        if (state == 0)//patroling
        {
            speedControl.maxSpeed = 6;
            destination.target = node;
            if (Vector3.Distance(node.position, transform.position) <= 1f)
            {
                NewDestination();
            }
        }
        else if (state == 1)//chaseing
        {
            speedControl.maxSpeed = 10;
            destination.target = player;
        }
    }

    void NewDestination() {
        selection = UnityEngine.Random.Range(0, patrolNodes.Length);
        print(selection);
        node = patrolNodes[selection];
        state = 0;
    }

    void OnTriggerEnter2D(Collider2D detect) {
        if (detect.tag == "Player" && GameManager.Instance.PlayerisHidden == false)
        {
            state = 1;
        }
    }
    void OnTriggerExit2D(Collider2D lose) {
        if (lose.tag == "Player")
        {
            Invoke("NewDestination", pursuitTime);
        }
    }
}
