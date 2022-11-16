using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Boundary on top of the screen.
    private float topBound = 30;
    // Boundary on the bottom of the screen.
    private float lowerBound = -10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() 
    {   
        // This lines of code will destroy the game object once it's pass the boundary set for the gameplay.
        if (transform.position.z > topBound) {
            Destroy(gameObject);

        } else if (transform.position.z < lowerBound) 
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        } }
}
