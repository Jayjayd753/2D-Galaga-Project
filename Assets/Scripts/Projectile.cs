using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    //~* === Use the comments in the code to complete this game === ~*//
    Rigidbody2D rb2D;


    // === Create a Rigidbody2D variable for the projectile/bullet === //
    


    void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }
    



    
    public void Launch (Vector2 direction, float force)
    {
        rb2D.AddForce(direction * force);
    }
    void OnCollisionEnter2D(Collision2D other)
    {
       Destroy(gameObject);
       Destroy(other.gameObject);
    }
  
  
  
  
    void Update()
    {
        if(transform.position.magnitude > 1000.0f)
        {
            Destroy(gameObject);
        }
    }
    
    // === Create a method below to detect the collision between the bullet and other GameObjects ( HINT: use  ' OnCollisionEnter2D() ' )  === //
    // === In the method, Destroy the gameObject and Destroy the other gameObject === //





}