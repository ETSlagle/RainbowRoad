using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketColorRed : MonoBehaviour {

    public void OnTriggerEnter2D(Collider2D collision)
    {
        SpriteRenderer m_SpriteRenderer;
        m_SpriteRenderer = collision.GetComponent<SpriteRenderer>();
        m_SpriteRenderer.color = Color.red;
        Assets.Scripts.Global.current_color = "red";


    }
}
