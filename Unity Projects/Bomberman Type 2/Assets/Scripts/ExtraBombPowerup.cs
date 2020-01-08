using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraBombPowerup : MonoBehaviour
{
    public void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "WhiteChar" && collision.GetComponent<BombSpawnerWhite>().numberOfBombs <= 10)
        {
            collision.gameObject.GetComponent<BombSpawnerWhite>().numberOfBombs++;
            Destroy(gameObject);
        }
        if (collision.gameObject.name == "BlueChar" && collision.GetComponent<BombSpawnerBlue>().numberOfBombs <= 10)
        {
            collision.gameObject.GetComponent<BombSpawnerBlue>().numberOfBombs++;
            Destroy(gameObject);
        }
        if (collision.gameObject.name == "BlackChar" && collision.GetComponent<BombSpawnerBlack>().numberOfBombs <= 10)
        {
            collision.gameObject.GetComponent<BombSpawnerBlack>().numberOfBombs++;
            Destroy(gameObject);
        }
        if (collision.gameObject.name == "OrangeChar" && collision.GetComponent<BombSpawnerOrange>().numberOfBombs <= 10)
        {
            collision.gameObject.GetComponent<BombSpawnerOrange>().numberOfBombs++;
            Destroy(gameObject);
        }
    }
}

