using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;


    // We use this to limit the user from spaming the space keyboard
    private bool canSpawnNewDog;

    private float spanwNewDogInterval = 1.0f;

    void Start() 
    {
        // By default, player can spawn new dog
        canSpawnNewDog = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (canSpawnNewDog)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                Debug.Log("User can spawn new dog");
                StartCoroutine(SpawnDogRestrictor());
            }
            else 
            {
                Debug.Log("User not allowed to spawn new dog yet");
            }
        }
    }

    /**
    * Kickstarts after the user spawns a dog.
    * Makes the user wait a specified sec before a new dog can be spawned
    */
    private IEnumerator SpawnDogRestrictor()
     {
        canSpawnNewDog = false;
        Debug.Log("Waiting for 3 Secs before allowing user to spawn new dog");
        yield return new WaitForSeconds(spanwNewDogInterval);
        canSpawnNewDog = true;
        Debug.Log("User is now allowed to spawn new dog after waiting " + spanwNewDogInterval + " sec");
     }
}
