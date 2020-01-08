using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MapDesctruction : MonoBehaviour
{
    public Tilemap tilemap;
    public Tile wallTile;
    public Tile destructTile;
    public GameObject bomb;
    public GameObject explosivePrefab;
    public GameObject tilePrefab;
    public GameObject acceleratorPowerup;
    public GameObject explosionPowerup;
    public GameObject extraBombPowerup;
    public GameObject kickPowerup;
    public GameObject maxExplosionPowerup;
    public GameObject powerGlovePowerup;
    public GameObject remoteControlPowerup;
    public GameObject skullPowerup;

    public void Explode(Vector2 worldPos)
    {
        Vector3Int originCell = tilemap.WorldToCell(worldPos);

        ExplodeCell(originCell);
        if (ExplodeCell(originCell + new Vector3Int(1, 0, 0)))
        {
        }

        if (ExplodeCell(originCell + new Vector3Int(0, 1, 0)))
        {
        }

        if (ExplodeCell(originCell + new Vector3Int(-1, 0, 0)))
        {
        }

        if (ExplodeCell(originCell + new Vector3Int(0, -1, 0)))
        {
        }

    }

    bool ExplodeCell(Vector3Int cell)
    {
        Tile tile = tilemap.GetTile<Tile>(cell);
        Vector3 pos = tilemap.GetCellCenterWorld(cell);

        if (tile == wallTile)
        {
            return false;
        }

        if (tile == destructTile)
        {
            Instantiate(tilePrefab, pos,Quaternion.identity);
            tilemap.SetTile(cell, null);
            Destroy(destructTile);
            SpawnPowerUp(cell);
            return true;
        }

        Instantiate(explosivePrefab, pos, Quaternion.identity);

        return true;
    }
    bool SpawnPowerUp(Vector3Int cell)
    {
        Tile tile = tilemap.GetTile<Tile>(cell);
        Vector3 pos = tilemap.GetCellCenterWorld(cell);

        System.Random spawnRate = new System.Random();
        int spawnChoice;
        spawnChoice = spawnRate.Next(1, 17);
        switch (spawnChoice)
        {
            case 1:
                Instantiate(acceleratorPowerup, pos,Quaternion.identity);
                return true;
            case 2:
                return false;
            case 3:
                Instantiate(explosionPowerup, pos, Quaternion.identity);
                return true;
            case 4:
                return false;
            case 5:
                Instantiate(extraBombPowerup, pos, Quaternion.identity);
                return true;
            case 6:
                return false;
            case 7:
                Instantiate(kickPowerup, pos, Quaternion.identity);
                return true;
            case 8:
                return false;
            case 9:
                Instantiate(maxExplosionPowerup, pos, Quaternion.identity);
                return true;
            case 10:
                return false;
            case 11:
                Instantiate(remoteControlPowerup, pos, Quaternion.identity);
                return true;
            case 12:
                return false;
            case 13:
                Instantiate(skullPowerup, pos, Quaternion.identity);
                return true;
            case 14:
                return false;
            case 15:
                Instantiate(powerGlovePowerup, pos, Quaternion.identity);
                return true;
            case 16:
                return false;

        }
        return true;
    }
}
