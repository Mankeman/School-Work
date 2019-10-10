using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Explosive : MonoBehaviour
{
    public GameObject explosionPrefab;
    public LayerMask levelMask;
    public float countdown = .65f;
    public Tilemap tMap;

    public void Explode(Vector2 worldPos)
    {
    }
    void ExplodeCell (Vector3Int cell)
    {
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
