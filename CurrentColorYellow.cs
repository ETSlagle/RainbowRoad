using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CurrentColorYellow : MonoBehaviour {

    public void colorYellow()
    {
        Assets.Scripts.Global.current_color = "yellow";
        SceneManager.LoadScene("RainbowRoad");
    }

}
