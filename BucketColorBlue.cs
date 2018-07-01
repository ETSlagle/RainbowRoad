using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketColorBlue : MonoBehaviour {

    public void OnTriggerEnter2D(Collider2D collision)
    {
        SpriteRenderer m_SpriteRenderer;
        m_SpriteRenderer = collision.GetComponent<SpriteRenderer>();
        m_SpriteRenderer.color = Color.blue;
        Assets.Scripts.Global.current_color = "blue";


    }
}
