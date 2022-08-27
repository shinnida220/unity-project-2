using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Holds the user horizontal input
    public float horizontalInput;
    // Velcocity of the movement
    public float speed = 11.0f;
    // X boundary for player
    public float xRange = 10.0f;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Do a check to ensure player stays on the view area
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // Get the user input -ve Left, +ve Right
        horizontalInput = Input.GetAxis("Horizontal");

        // Move the user base on the input
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        // Monitor spacebar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile (food prefabs)
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
