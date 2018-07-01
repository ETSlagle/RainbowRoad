using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorOnObject : MonoBehaviour {


    SpriteRenderer m_SpriteRenderer;
    //The Color to be assigned to the Renderer’s Material
    Color m_NewColor;

    //These are the values that the Color Sliders return
    float m_Red, m_Blue, m_Green;

    void Start()
    {
        //Fetch the SpriteRenderer from the GameObject
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        //Set the GameObject's Color quickly to a set Color (blue)
        if (Assets.Scripts.Global.current_color == "blue")
        {
            m_SpriteRenderer.color = Color.blue;
        }
        if(Assets.Scripts.Global.current_color == "red")
        {
            m_SpriteRenderer.color = Color.red;
        }
        if(Assets.Scripts.Global.current_color == "orange")
        {
            m_SpriteRenderer.color = Color.white;
        }
        if(Assets.Scripts.Global.current_color == "yellow")
        {
            m_SpriteRenderer.color = Color.yellow;
        }
        if(Assets.Scripts.Global.current_color == "green")
        {
            m_SpriteRenderer.color = Color.green;
        }
        if(Assets.Scripts.Global.current_color == "purple")
        {
            m_SpriteRenderer.color = Color.magenta;
        }
    }

    void Update()
    {

    }

    }















    //if (Assets.Scripts.Global.current_color == "red")
    //    altColor = Color.red;
    //matt.color = altColor;

    //if (Assets.Scripts.Global.current_color == "orange")
    //    altColor = Color.cyan;
    //matt.color = altColor;


    //if (Assets.Scripts.Global.current_color == "yellow")
    //    altColor = Color.yellow;
    //matt.color = altColor;


    //if (Assets.Scripts.Global.current_color == "green")
    //    altColor = Color.green;
    //matt.color = altColor;


    //if (Assets.Scripts.Global.current_color == "blue")
    //    altColor = Color.blue;
    //matt.color = altColor;


    //if (Assets.Scripts.Global.current_color == "purple")
    //    altColor = Color.magenta;
    //matt.color = altColor;
