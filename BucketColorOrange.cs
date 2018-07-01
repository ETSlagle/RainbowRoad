using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketColorOrange : MonoBehaviour {

    public void OnTriggerEnter2D(Collider2D collision)
    {
        SpriteRenderer m_SpriteRenderer;
        m_SpriteRenderer = collision.GetComponent<SpriteRenderer>();
        m_SpriteRenderer.color = Color.white;
        Assets.Scripts.Global.current_color = "orange";


    }
}
