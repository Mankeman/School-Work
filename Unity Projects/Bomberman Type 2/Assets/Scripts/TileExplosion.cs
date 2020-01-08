using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileExplosion : MonoBehaviour
{
    private float cDown = 0.75f;


    private void Update()
    {

        cDown -= Time.deltaTime;
        if (cDown <= 0f)
        {
            Destroy(gameObject);
        }
    }
}
