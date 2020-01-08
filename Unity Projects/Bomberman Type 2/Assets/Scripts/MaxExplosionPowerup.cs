﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxExplosionPowerup : MonoBehaviour
{
    public void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "WhiteChar" && collision.GetComponent<BombSpawnerWhite>().firePower <= 10)
        {
            collision.gameObject.GetComponent<BombSpawnerWhite>().firePower=10;
            Destroy(gameObject);
        }
        if (collision.gameObject.name == "BlueChar" && collision.GetComponent<BombSpawnerBlue>().firePower <= 10)
        {
            collision.gameObject.GetComponent<BombSpawnerBlue>().firePower=10;
            Destroy(gameObject);
        }
        if (collision.gameObject.name == "BlackChar" && collision.GetComponent<BombSpawnerBlack>().firePower <= 10)
        {
            collision.gameObject.GetComponent<BombSpawnerBlack>().firePower=10;
            Destroy(gameObject);
        }
        if (collision.gameObject.name == "OrangeChar" && collision.GetComponent<BombSpawnerOrange>().firePower <= 10)
        {
            collision.gameObject.GetComponent<BombSpawnerOrange>().firePower=10;
            Destroy(gameObject);
        }
    }
}
