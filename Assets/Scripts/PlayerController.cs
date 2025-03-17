using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   
   private Rigidbody2D rBody;

   private float speed = 5;   

   private float horizontalInput;
   


   void Awake()
   {

    rBody = GetComponent<Rigidbody2D>();
   }
    void Start()



    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {

        rBody.velocity = new Vector2(horizontalInput * speed, rBody.velocity.y); 
    }
}
