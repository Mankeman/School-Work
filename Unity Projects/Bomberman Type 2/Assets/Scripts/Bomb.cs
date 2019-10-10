using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public GameObject explosionPrefab;
    public LayerMask levelMask;
    public float countdown = 2f;

    void Start()
    {
        Invoke("Explode", 3f);
    }

    // Update is called once per frame
    void Update()
    {
        void Explode()
        {

            Instantiate(explosionPrefab, transform.position, Quaternion.identity);

            GetComponent<SpriteRenderer>().enabled = false;
            transform.Find("Collider").gameObject.SetActive(false);
            Destroy(gameObject, .3f);
            
        }




        countdown -= Time.deltaTime;

        if (countdown <= 0f)
        {

            Destroy(gameObject);
        }

        
    }
}
