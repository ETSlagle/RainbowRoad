using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points_By_Color : MonoBehaviour {

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.tag == Assets.Scripts.Global.current_color)
        {
            Assets.Scripts.Global.PointsperSec += 19;

        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (gameObject.tag == Assets.Scripts.Global.current_color)
            Assets.Scripts.Global.PointsperSec -= 19;
    }
}
	

