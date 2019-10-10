using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosive : MonoBehaviour
{
    public LayerMask levelMask;
    public float countdown = .65f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {





        countdown -= Time.deltaTime;

        if (countdown <= 0f)
        {
            Destroy(gameObject);
        }


    }
}
