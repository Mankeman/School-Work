using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Bomb : MonoBehaviour
{
    public LayerMask levelMask;
    private float countdown = 2f;
    public int firePower;
    public float fuse = 2;

    void Update()
    {
        countdown -= Time.deltaTime;

        if (countdown <= 0f)
        {
            FindObjectOfType<MapDesctruction>().Explode(transform.position);
            Destroy(gameObject);
        }
    }
    public void Explode()
    {
        for (int i = 0; i < firePower; i++)
        {

        }
        Destroy(gameObject);
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        GetComponent<CircleCollider2D>().isTrigger = false;
    }
}
