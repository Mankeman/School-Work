using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawnerBlack : MonoBehaviour
{
    public GameObject bomb;
    private GameObject BlackChar;

    public int firePower = 1;
    public int numberOfBombs = 1;
    public float fuse = 2;

    public bool isKickActive = false;

    private Rigidbody2D rBody;

    public float speed = 5.0f;
    public float stop = 0f;


    void Update()
    {
        if (Input.GetButtonDown("JumpBlack") && numberOfBombs >= 1)
        {
            SpawnBomb();
        }
        if (isKickActive == true)
        {
            rBody = GetComponent<Rigidbody2D>();
            rBody.velocity = Vector2.right * speed;
        }
        if (Input.GetButtonDown("Fire1Black") && (isKickActive == true))
        {
            rBody.velocity = Vector2.right * stop;
        }
    }
    public void SpawnBomb()
    {
        //Make sure it spawns in the centre..
        var newBomb = Instantiate(bomb, transform.position, Quaternion.identity) as GameObject;
        newBomb.transform.position = new Vector3(Mathf.RoundToInt(newBomb.transform.position.x), Mathf.RoundToInt(newBomb.transform.position.y - 0.3f), Mathf.RoundToInt(newBomb.transform.position.z));
        //Changes the values of the "Bomb" script to the player's values.
        newBomb.GetComponent<Bomb>().firePower = firePower;
        newBomb.GetComponent<Bomb>().fuse = fuse;
        //Doesn't let you spawn bombs until the timer is up.
        numberOfBombs--;
        Invoke("AddBomb", fuse);
    }

    public void AddBomb()
    {
        numberOfBombs++;
    }
}
