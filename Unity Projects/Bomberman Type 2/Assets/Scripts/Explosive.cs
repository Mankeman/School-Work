using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Explosive : MonoBehaviour
{
    public LayerMask levelMask;
    public float countdown = .65f;
    public Tilemap tMap;

    public void Explode(Vector3Int worldPos)
    {
        Vector3Int originCell = tMap.WorldToCell(worldPos);

        Explode(originCell);
        Explode(originCell + new Vector3Int(1, 0, 0));
        Explode(originCell + new Vector3Int(-1, 0, 0));
        Explode(originCell + new Vector3Int(0, 1, 0));
        Explode(originCell + new Vector3Int(0, -1, 0));
    }
    private void Update()
    {
        countdown -= Time.deltaTime;

        

        if (countdown <= 0f)
        {
            Destroy(gameObject);
        }
    }
}
