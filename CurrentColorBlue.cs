using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CurrentColorBlue : MonoBehaviour {

    public void colorBlue()
    {
        Assets.Scripts.Global.current_color = "blue";
        SceneManager.LoadScene("RainbowRoad");
    }
  
}
