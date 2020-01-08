using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerUp : MonoBehaviour
{

    public void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "WhiteChar")
        {
            collision.gameObject.GetComponent<PlayerControllerWhite>().speed ++;
            Destroy(gameObject);
        }
        if (collision.gameObject.name == "BlueChar")
        {
            collision.gameObject.GetComponent<PlayerControllerBlue>().speed++;
            Destroy(gameObject);
        }
        if (collision.gameObject.name == "BlackChar")
        {
            collision.gameObject.GetComponent<PlayerControllerBlack>().speed++;
            Destroy(gameObject);
        }
        if (collision.gameObject.name == "OrangeChar")
        {
            collision.gameObject.GetComponent<PlayerControllerOrange>().speed++;
            Destroy(gameObject);
        }
    }
}
