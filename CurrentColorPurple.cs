using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CurrentColorPurple : MonoBehaviour {

    public void colorPurple()
    {
        Assets.Scripts.Global.current_color = "purple";
        SceneManager.LoadScene("RainbowRoad");
    }

}
