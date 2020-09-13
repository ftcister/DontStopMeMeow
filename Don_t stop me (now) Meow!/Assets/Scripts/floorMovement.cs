using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, 10f * Time.deltaTime, 0f);
        if (transform.position.z > 25)
        { 
            transform.position = new Vector3(0f, 0f, -125f);
        }
    }
}
