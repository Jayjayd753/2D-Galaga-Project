using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //~* === Use the comments in the code to complete this game === ~*//

    // === Create a float variable for the speed of the player === //
    public float speed;

    // === Create a Rigidbody2D variable for the player === //
    Rigidbody2D playerRB; 

    // === Create a float variable for the player's Left and Right input === //
    public float horizontal;

    // === Create a public GameObject variable for the projectile prefab === //
    public GameObject projectilePrefab;
    
    
    
    void Start()
    {
        // === Write the code below to set your Rigidbody2D variable EQUAL to the Rigidbody2D component === //
        playerRB = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        // === Write the code below to set your input float variable EQUAL to the player's horizontal inputs (HINT: use ' Input.GetAxis() ') === //
        horizontal = Input.GetAxis("Horizontal");

      
       // === Create a private Vector2 Variable and set it EQUAL to transform.position
       Vector2 position = transform.position;
      
      
       // === Get the x value of your Vector2 variable and set it EQUAl to itself
       position.x = position.x + speed * horizontal * Time.deltaTime;

       transform.position = position;
      
      
      
      
        // === Create an if-statement below to get the player's key down and then call the method to launch your projectile/bullet === //
        // ~ HINT: use ' Input.GetKeyDown() ' ~ //
        if(Input.GetKeyDown(KeyCode.Space))
        {
           Launch();
        }


    }

    void Launch()
    {
        // === Add the code below to launch your projectile UP towards the enemy === //

        GameObject projectile = Instantiate(projectilePrefab, transform.position + Vector3.up * 1.2f, projectilePrefab.transform.rotation);
        Projectile projectileObject = projectile.GetComponent<Projectile>();


        projectileObject.Launch(Vector2.up, 500);








    }
    
}