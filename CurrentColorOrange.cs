using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CurrentColorOrange : MonoBehaviour {

    public void colorOrange()
    {
        Assets.Scripts.Global.current_color = "orange";
        SceneManager.LoadScene("RainbowRoad");
    }

}
