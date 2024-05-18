using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{

    public float upperBound = 14.4f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= upperBound)
        {
            transform.position = new Vector3(transform.position.x, upperBound, transform.position.z);
        }
    }

}