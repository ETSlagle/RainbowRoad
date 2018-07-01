using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CurrentColorGreen : MonoBehaviour {

    public void Colorgreen()
    {
        Assets.Scripts.Global.current_color = "green";
        SceneManager.LoadScene("RainbowRoad");
    }

}
