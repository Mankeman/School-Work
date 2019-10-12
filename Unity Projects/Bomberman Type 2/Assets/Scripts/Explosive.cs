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

    void (Explode){
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
