using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MapDesctruction : MonoBehaviour
{
    public Tilemap tMap;
    public Tilemap wallTile;
    public Tilemap destructTile;
    public GameObject tilePrefab;

    public void Explode(Vector2 worldPos)
    {
        Vector3Int originCell = tMap.WorldToCell(worldPos);

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

        Tile tile = tMap.GetTile<Tile>(cell);
        if (tile == wallTile)
        {
            return false;
        }
        else if (tile == destructTile)
        {
            Destroy(destructTile);
        }
        Vector3 pos = tMap.GetCellCenterWorld(cell);
        return true;
    }
}
