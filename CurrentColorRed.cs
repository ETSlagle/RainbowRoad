using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CurrentColorRed : MonoBehaviour {
    public void colorRed() {
        Assets.Scripts.Global.current_color = "red";
        SceneManager.LoadScene("RainbowRoad");

    }

}
