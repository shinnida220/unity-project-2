using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    // Speed/Distance to move with a second
    public float speed = 40.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Ensures this object moves per/time and not in every ingle frame at the speed
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
