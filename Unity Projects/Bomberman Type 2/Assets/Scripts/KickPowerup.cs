using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KickPowerup : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "WhiteChar")
        {
            collision.GetComponent<BombSpawnerWhite>().isKickActive=true;
            Destroy(gameObject);
        }
        if (collision.gameObject.name == "BlueChar")
        {
            collision.GetComponent<BombSpawnerBlue>().isKickActive = true;
            Destroy(gameObject);
        }
        if (collision.gameObject.name == "BlackChar")
        {
            collision.GetComponent<BombSpawnerBlack>().isKickActive = true;
            Destroy(gameObject);
        }
        if (collision.gameObject.name == "OrangeChar")
        {
            collision.GetComponent<BombSpawnerOrange>().isKickActive = true;
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
