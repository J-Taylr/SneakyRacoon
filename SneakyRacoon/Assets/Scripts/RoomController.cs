using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomController : MonoBehaviour
{
    public float Max;
    public List<GameObject> FoodinRoom = new List<GameObject>();
    [SerializeField] GameObject prefab;
    [SerializeField] BoxCollider2D bc;

    Vector2 cubeSize;
    Vector2 cubeCenter;

    public bool roomActive = false;

    

    void Awake()
    {
        Transform cubeTrans = bc.GetComponent<Transform>();
        cubeCenter = cubeTrans.position;

        // Multiply by scale because it does affect the size of the collider
        cubeSize.x = cubeTrans.localScale.x * bc.size.x;
        cubeSize.y = cubeTrans.localScale.y * bc.size.y;
    }

    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {


        
        //CheckActive();
    }

    public void SpawnFood(GameObject prefab)
    {
        
            GameObject go = Instantiate(prefab, RandomSpawnPos(), Quaternion.identity);
        GameManager.Instance.foodSpawned.Add(go);
    }


    private Vector2 RandomSpawnPos()
    {
        // You can also take off half the bounds of the thing you want in the box, so it doesn't extend outside.
        // Right now, the center of the prefab could be right on the extents of the box
        Vector2 randomPosition = new Vector2(Random.Range(-cubeSize.x / 2, cubeSize.x / 2), Random.Range(-cubeSize.y / 2, cubeSize.y / 2));

        return cubeCenter + randomPosition;
    }

    private void OnTriggerExit2D(Collider2D collision) 
    {
        if (collision.gameObject.CompareTag("Player")) //when the player exits the room, deactivate it
        {
            
            roomActive = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) // when the player enters the room, activate it
        {
            print(gameObject.name + "active");
            roomActive = true;
        }
    }

    public bool CheckActive()
    {
        return (roomActive);
    }


}
