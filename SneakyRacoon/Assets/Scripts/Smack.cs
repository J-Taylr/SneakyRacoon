using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smack : MonoBehaviour
{

    public GameObject prefab;
    public bool HasHit = false;
    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (HasHit == false)
        {
            Instantiate(prefab, transform.position, Quaternion.identity);
            StartCoroutine("HitTimer");
        }
        HasHit = true;
    }
    public IEnumerator HitTimer()
    {
        yield return new WaitForSeconds(2);
        HasHit = false;
    }
}

