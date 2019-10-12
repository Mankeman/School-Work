﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MapDes : MonoBehaviour
{
    public Tilemap tMap;
    public Tile wallTile;
    public Tile destructTile;
    public GameObject explosPrefab;

    public void Explode(Vector2 worldPos)
    {
        Vector3Int originCell = tMap.WorldToCell(worldPos);

        ExplodeCell(originCell);
        ExplodeCell(originCell + new Vector3Int(1, 0, 0));
        ExplodeCell(originCell + new Vector3Int(-1, 0, 0));
        ExplodeCell(originCell + new Vector3Int(0, -1, 0));
        ExplodeCell(originCell + new Vector3Int(0, 1, 0));
    }

    void ExplodeCell(Vector3Int cell)
    {

        Tile tile = tMap.GetTile<Tile>(cell);
        if (tile == wallTile)
        {
            return;
        }
        if (tile == destructTile)
        {
            tMap.SetTile(cell, null);
        }
        Vector3 pos = tMap.GetCellCenterWorld(cell);
        Instantiate(explosPrefab, pos, Quaternion.identity);
        Destroy(gameObject);
    }
}