using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Explosion : MonoBehaviour
{
    private float cDown = 0.75f;

    
    private void Update()
    {
        
        cDown -= Time.deltaTime;
        if (cDown <= 0f)
        {
            Destroy(gameObject);
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        Destroy(this.gameObject);

        if (collision.gameObject.GetComponent<Bomb>() != null)
        {
            collision.gameObject.GetComponent<Bomb>().Explode();
        }
    }
}
