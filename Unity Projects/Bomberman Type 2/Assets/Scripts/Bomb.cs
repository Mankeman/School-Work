using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Bomb : MonoBehaviour
{
    public GameObject explosionPrefab;
    public LayerMask levelMask;
    public int firePower;
    private float countdown = 2;

    void Start()
    {
        Invoke("Explode", countdown);
    }

    public void Explode()
    {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);

            for (int i = 0; i <= firePower; i++)
            {
                SpawnFire(i + 1);
            }
            Destroy(gameObject);
    }

    private void SpawnFire(int offset)
    {
        Instantiate(explosionPrefab, transform.position + new Vector3(1, 0, 0), Quaternion.identity);
        Instantiate(explosionPrefab, transform.position - new Vector3(1, 0, 0), Quaternion.identity);
        Instantiate(explosionPrefab, transform.position + new Vector3(0, 1, 0), Quaternion.identity);
        Instantiate(explosionPrefab, transform.position - new Vector3(0, 1, 0), Quaternion.identity);
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        GetComponent<BoxCollider2D>().isTrigger = false;
    }
}
