using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Explosion : MonoBehaviour
{
    private float cDown = 1f;
    public Tilemap tMap;
    public Tilemap wallTile;
    public Tilemap destructTile;
    public GameObject tilePrefab;


    private void Start()
    {

        if (gameObject == destructTile)
        {
            Instantiate(tilePrefab, transform.position, Quaternion.identity);
            Destroy(destructTile);
            Destroy(gameObject);
        }
        else if (gameObject == wallTile)
        {
           Destroy(gameObject,0.01f);
        }
    }
    private void Update()
    {
        cDown -= Time.deltaTime;
        if (cDown <= 0f)
        {
            Destroy(gameObject);
        }
    }
}
