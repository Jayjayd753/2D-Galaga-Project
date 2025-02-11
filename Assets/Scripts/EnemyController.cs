using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    //~* === Use the comments in the code to complete this game === ~*//

    // === Create a float variable for the speed of the enemy === //
    public float speed =0;
    
    // === Create a float variable for the change time of the enemy === //
    public float timer = 3;
       
    // === Create a Rigidbody2D variable for the enemy === //
    public int direction = 1;

    // === Create a float varaible for the timer of the enemy === //
    float changeTime;

    // === Create an int varaible for the direction of the enemy and set it EQUAL to 1 === //
    float xRange = 9.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        changeTime = timer;
    }

    void Update()
    {
        changeTime -= Time.deltaTime;
        Vector2 position = transform.position;
        if (changeTime < 0 || transform.position.x > xRange || transform.
        position.x < -xRange) {
            direction = -direction;
            changeTime = timer;


        }

        position.x = position.x + Time.deltaTime * speed * direction;
        transform.position = position;
    }


    
    
   
    
     



    
}
