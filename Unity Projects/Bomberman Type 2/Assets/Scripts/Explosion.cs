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
    public GameObject explosionPrefab;

    public bool GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData)
    {
        if (destructTile.GetTile<Tile>(position) == true)
        {
            Instantiate(tilePrefab, transform.position, Quaternion.identity);
            Destroy(destructTile);
            Destroy(explosionPrefab);
        }
        else
        {
           Destroy(gameObject);
        }
        return true;
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Explosion>() != null)
        {
            return;
        }
        else if (collision.gameObject.GetComponent<Bomb>() != null)
        {
            collision.gameObject.GetComponent<Bomb>().Explode();
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
