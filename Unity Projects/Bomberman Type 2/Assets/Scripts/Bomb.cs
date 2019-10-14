using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Bomb : MonoBehaviour
{
    public GameObject explosionPrefab;
    public LayerMask levelMask;
    public float countdown = 2f;

    

    void Update()
    {
        countdown -= Time.deltaTime;

        if (countdown <= 0f)
        {
            FindObjectOfType<MapDes>().Explode(transform.position);
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
