using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost : MonoBehaviour
{


   
//    public float incrementRate = 0.1f;  //The rate you want the speed to change
//    public string powerUpName = "Boost";   //The tag of the powerup gameobject

//    private bool executePowerUp = false;  //Checks whether to execute the powerup 
//    private float currentSpeed; //The current speed of your powerup boost value
//    private float lerpTime;  //The lerp time 'T'

//    void Start()
//    {
//        currentSpeed = Assets.Scripts.Global.minspeed; //Set current speed to equal the minimum speed
//    }

//    void Update()
//    {
//        if (executePowerUp) //If the executePowerUp bool is true
//        {
//            if (lerpTime <= 1) //If the lerp time has not reached the maximum value ('To')
//            {
//                lerpTime += Time.deltaTime * incrementRate; //Increase the lerp time by deltaTime multiplied by the rate
//                currentSpeed = Mathf.Lerp(Assets.Scripts.Global.minspeed, Assets.Scripts.Global.maxspeed, lerpTime); //Set the current speed to the current lerped value
//                print(currentSpeed); //print the current speed for you to see the change in the value
//            }
//            else //If the lerp time has exceeded the 'To' value
//            {
//                executePowerUp = false; //Turn execute powerup to false
//                lerpTime = 0; //Reset the lerp time
//            }
//        }
//    }

//    void OnTriggerEnter2D(Collider2D other)
//    {
//        if (other.CompareTag(powerUpName)) //If the trigger object tag is equal to the powerup tag
//        {
//            executePowerUp = true; //Set execute power to true to initiate the lerp code
//        }
//    }
//}


public void OnTriggerEnter2D(Collider2D collision)
   {
            Assets.Scripts.Global.minspeed += 25f;   
    
        
    }
    public void OnTriggerExit2D(Collider2D collision)
    {

        Assets.Scripts.Global.minspeed -= 25f;
        
    }
}


