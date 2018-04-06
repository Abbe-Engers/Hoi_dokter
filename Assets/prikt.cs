using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prikt : MonoBehaviour
{

    float y = 0;

    Rigidbody rigid;

    // Use this for initialization
    void Start()    {


    }

    // Update is called once per frame
    void Update()   {

    }

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "pain")
        {
            y = Random.Range(0.0f, -3.0f);
            transform.position = new Vector3(transform.position.x, y, transform.position.z);
        }
    }
}
