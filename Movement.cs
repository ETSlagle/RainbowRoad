using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour

{//use this for initialization
    void Start()
    {
    }
    public float moveSpeed;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = new Vector3(transform.position.x + moveSpeed, transform.position.y, transform.position.z); //+ moveSpeed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = new Vector3(transform.position.x - moveSpeed, transform.position.y, transform.position.z); //+ moveSpeed);
        }
    }
}





//public class Movement : MonoBehaviour

//{//use this for initialization
//    void Start()
//    {
//    }
//    public float moveSpeed;
//    // Update is called once per frame
//    void Update()
//    {
//        if (Input.GetKey(KeyCode.RightArrow))
//        {
//            transform.position = new Vector3(transform.position.x + moveSpeed, transform.position.y, transform.position.z); //+ moveSpeed);
//        }
//        if (Input.GetKey(KeyCode.LeftArrow))
//        {
//            transform.position = new Vector3(transform.position.x - moveSpeed, transform.position.y, transform.position.z); //+ moveSpeed);
//        }
//    }

//}






//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;


//public class Movement : MonoBehaviour
//{

//    public float movespeed;             //Floating point variable to store the player's movement speed.

//    public Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.

//    // Use this for initialization
//    void Start()
//    {
//        //Get and store a reference to the Rigidbody2D component so that we can access it.
//        Rigidbody2D rb2d = GetComponent<Rigidbody2D>();

//    }

//    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
//    void FixedUpdate()
//    {
//        if (Input.GetKeyDown(KeyCode.RightArrow))
//            {
//            float moveHorizontal = Input.GetAxis("Horizontal");

//            //Use the two store floats to create a new Vector2 variable movement.
//            Vector2 movement = new Vector2(moveHorizontal, 0);

//            //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
//            rb2d.AddForce(movement * movespeed);
//        }
//            if (Input.GetKeyDown(KeyCode.LeftArrow))
//            {
//            float moveHorizontal = Input.GetAxis("Horizontal");

//            //Use the two store floats to create a new Vector2 variable movement.
//            Vector2 movement = new Vector2(moveHorizontal, 0);

//            //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
//            rb2d.AddForce(movement * movespeed);
//        }
//    }
//}