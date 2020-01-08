using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullPowerup : MonoBehaviour
{
    private float countdown = 10f;
    private float timer1 = 4f;
    private float timer2 = 2f;
    private float timer3 = 8f;
    private float timer4 = 1f;
    private float timer5 = 5f;
    private float gameLength = 300f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "WhiteChar")
        {
            System.Random debuffLottery = new System.Random();
            int spawnChoice;
            spawnChoice = debuffLottery.Next(1, 8);
            switch (spawnChoice)
            {
                case 1:
                    countdown -= Time.deltaTime;
                    collision.GetComponent<PlayerControllerWhite>().speed = 2;
                    if (countdown <= 0)
                    {
                        collision.GetComponent<PlayerControllerWhite>().speed = 5;
                    }
                    Destroy(gameObject);
                    return;
                case 2:
                    collision.GetComponent<PlayerControllerWhite>().speed = 25;
                    Destroy(gameObject);
                    return;
                case 3:
                    System.Random timer = new System.Random();
                    int timerToSpawn;
                    timerToSpawn = timer.Next(1, 6);
                    do
                    {
                        switch (timerToSpawn)
                        {
                            case 1:
                                timer1 -= Time.deltaTime;
                                if (timer1 <= 0)
                                {
                                    GetComponent<BombSpawnerWhite>().SpawnBomb();
                                }
                                return;
                            case 2:
                                timer2 -= Time.deltaTime;
                                if (timer2 <= 0)
                                {
                                    GetComponent<BombSpawnerWhite>().SpawnBomb();
                                }
                                return;
                            case 3:
                                timer3 -= Time.deltaTime;
                                if (timer3 <= 0)
                                {
                                    GetComponent<BombSpawnerWhite>().SpawnBomb();
                                }
                                return;
                            case 4:
                                timer4 -= Time.deltaTime;
                                if (timer4 <= 0)
                                {
                                    GetComponent<BombSpawnerWhite>().SpawnBomb();
                                }
                                return;
                            case 5:
                                timer5 -= Time.deltaTime;
                                if (timer5 <= 0)
                                {
                                    GetComponent<BombSpawnerWhite>().SpawnBomb();
                                }
                                return;
                        }
                    } while (gameLength != 0);
                    Destroy(gameObject);
                    return;
                case 4:
                    GetComponent<BombSpawnerWhite>().numberOfBombs = 0;
                    GetComponent<BombSpawnerWhite>().firePower = 0;
                    Destroy(gameObject);
                    return;
                case 5:
                    GetComponent<SpriteRenderer>().gameObject.SetActive(false);
                    Destroy(gameObject);
                    return;
                case 6:
                    do
                    {
                        GetComponent<BombSpawnerWhite>().SpawnBomb();

                    } while (gameLength != 0);
                    Destroy(gameObject);
                    return;
                case 7:
                    GetComponent<BombSpawnerWhite>().firePower = 1;
                    GetComponent<BombSpawnerWhite>().numberOfBombs = 1;
                    Destroy(gameObject);
                    return;
            }
        }
        if (collision.gameObject.name == "BlueChar")
        {
            System.Random debuffLottery = new System.Random();
            int spawnChoice;
            spawnChoice = debuffLottery.Next(1, 8);
            switch (spawnChoice)
            {
                case 1:
                    countdown -= Time.deltaTime;
                    collision.GetComponent<PlayerControllerBlue>().speed = 2;
                    if (countdown <= 0)
                    {
                        collision.GetComponent<PlayerControllerBlue>().speed = 5;
                    }
                    Destroy(gameObject);
                    return;
                case 2:
                    collision.GetComponent<PlayerControllerBlue>().speed = 25;
                    Destroy(gameObject);
                    return;
                case 3:
                    System.Random timer = new System.Random();
                    int timerToSpawn;
                    timerToSpawn = timer.Next(1, 6);
                    do
                    {
                        switch (timerToSpawn)
                        {
                            case 1:
                                timer1 -= Time.deltaTime;
                                if (timer1 <= 0)
                                {
                                    GetComponent<BombSpawnerBlue>().SpawnBomb();
                                }
                                return;
                            case 2:
                                timer2 -= Time.deltaTime;
                                if (timer2 <= 0)
                                {
                                    GetComponent<BombSpawnerBlue>().SpawnBomb();
                                }
                                return;
                            case 3:
                                timer3 -= Time.deltaTime;
                                if (timer3 <= 0)
                                {
                                    GetComponent<BombSpawnerBlue>().SpawnBomb();
                                }
                                return;
                            case 4:
                                timer4 -= Time.deltaTime;
                                if (timer4 <= 0)
                                {
                                    GetComponent<BombSpawnerBlue>().SpawnBomb();
                                }
                                return;
                            case 5:
                                timer5 -= Time.deltaTime;
                                if (timer5 <= 0)
                                {
                                    GetComponent<BombSpawnerBlue>().SpawnBomb();
                                }
                                return;
                        }
                    } while (gameLength != 0);
                    Destroy(gameObject);
                    return;
                case 4:
                    GetComponent<BombSpawnerBlue>().numberOfBombs = 0;
                    GetComponent<BombSpawnerBlue>().firePower = 0;
                    Destroy(gameObject);
                    return;
                case 5:
                    GetComponent<SpriteRenderer>().gameObject.SetActive(false);
                    Destroy(gameObject);
                    return;
                case 6:
                    do
                    {
                        GetComponent<BombSpawnerBlue>().SpawnBomb();

                    } while (gameLength != 0);
                    Destroy(gameObject);
                    return;
                case 7:
                    GetComponent<BombSpawnerBlue>().firePower = 1;
                    GetComponent<BombSpawnerBlue>().numberOfBombs = 1;
                    Destroy(gameObject);
                    return;
            }
        }
        if (collision.gameObject.name == "BlackChar")
        {
            System.Random debuffLottery = new System.Random();
            int spawnChoice;
            spawnChoice = debuffLottery.Next(1, 8);
            switch (spawnChoice)
            {
                case 1:
                    countdown -= Time.deltaTime;
                    collision.GetComponent<PlayerControllerBlack>().speed = 2;
                    if (countdown <= 0)
                    {
                        collision.GetComponent<PlayerControllerBlack>().speed = 5;
                    }
                    Destroy(gameObject);
                    return;
                case 2:
                    collision.GetComponent<PlayerControllerBlack>().speed = 25;
                    Destroy(gameObject);
                    return;
                case 3:
                    System.Random timer = new System.Random();
                    int timerToSpawn;
                    timerToSpawn = timer.Next(1, 6);
                    do
                    {
                        switch (timerToSpawn)
                        {
                            case 1:
                                timer1 -= Time.deltaTime;
                                if (timer1 <= 0)
                                {
                                    GetComponent<BombSpawnerBlack>().SpawnBomb();
                                }
                                return;
                            case 2:
                                timer2 -= Time.deltaTime;
                                if (timer2 <= 0)
                                {
                                    GetComponent<BombSpawnerBlack>().SpawnBomb();
                                }
                                return;
                            case 3:
                                timer3 -= Time.deltaTime;
                                if (timer3 <= 0)
                                {
                                    GetComponent<BombSpawnerBlack>().SpawnBomb();
                                }
                                return;
                            case 4:
                                timer4 -= Time.deltaTime;
                                if (timer4 <= 0)
                                {
                                    GetComponent<BombSpawnerBlack>().SpawnBomb();
                                }
                                return;
                            case 5:
                                timer5 -= Time.deltaTime;
                                if (timer5 <= 0)
                                {
                                    GetComponent<BombSpawnerBlack>().SpawnBomb();
                                }
                                return;
                        }
                    } while (gameLength != 0);
                    Destroy(gameObject);
                    return;
                case 4:
                    GetComponent<BombSpawnerBlack>().numberOfBombs = 0;
                    GetComponent<BombSpawnerBlack>().firePower = 0;
                    Destroy(gameObject);
                    return;
                case 5:
                    GetComponent<SpriteRenderer>().gameObject.SetActive(false);
                    Destroy(gameObject);
                    return;
                case 6:
                    do
                    {
                        GetComponent<BombSpawnerBlack>().SpawnBomb();

                    } while (gameLength != 0);
                    Destroy(gameObject);
                    return;
                case 7:
                    GetComponent<BombSpawnerBlack>().firePower = 1;
                    GetComponent<BombSpawnerBlack>().numberOfBombs = 1;
                    Destroy(gameObject);
                    return;
            }
        }
        if (collision.gameObject.name == "OrangeChar")
        {
            System.Random debuffLottery = new System.Random();
            int spawnChoice;
            spawnChoice = debuffLottery.Next(1, 8);
            switch (spawnChoice)
            {
                case 1:
                    countdown -= Time.deltaTime;
                    collision.GetComponent<PlayerControllerOrange>().speed = 2;
                    if (countdown <= 0)
                    {
                        collision.GetComponent<PlayerControllerOrange>().speed = 5;
                    }
                    Destroy(gameObject);
                    return;
                case 2:
                    collision.GetComponent<PlayerControllerOrange>().speed = 25;
                    Destroy(gameObject);
                    return;
                case 3:
                    System.Random timer = new System.Random();
                    int timerToSpawn;
                    timerToSpawn = timer.Next(1, 6);
                    do
                    {
                        switch (timerToSpawn)
                        {
                            case 1:
                                timer1 -= Time.deltaTime;
                                if (timer1 <= 0)
                                {
                                    GetComponent<BombSpawnerOrange>().SpawnBomb();
                                }
                                return;
                            case 2:
                                timer2 -= Time.deltaTime;
                                if (timer2 <= 0)
                                {
                                    GetComponent<BombSpawnerOrange>().SpawnBomb();
                                }
                                return;
                            case 3:
                                timer3 -= Time.deltaTime;
                                if (timer3 <= 0)
                                {
                                    GetComponent<BombSpawnerOrange>().SpawnBomb();
                                }
                                return;
                            case 4:
                                timer4 -= Time.deltaTime;
                                if (timer4 <= 0)
                                {
                                    GetComponent<BombSpawnerOrange>().SpawnBomb();
                                }
                                return;
                            case 5:
                                timer5 -= Time.deltaTime;
                                if (timer5 <= 0)
                                {
                                    GetComponent<BombSpawnerOrange>().SpawnBomb();
                                }
                                return;
                        }
                    } while (gameLength != 0);
                    Destroy(gameObject);
                    return;
                case 4:
                    GetComponent<BombSpawnerOrange>().numberOfBombs = 0;
                    GetComponent<BombSpawnerOrange>().firePower = 0;
                    Destroy(gameObject);
                    return;
                case 5:
                    GetComponent<SpriteRenderer>().gameObject.SetActive(false);
                    Destroy(gameObject);
                    return;
                case 6:
                    do
                    {
                        GetComponent<BombSpawnerOrange>().SpawnBomb();

                    } while (gameLength != 0);
                    Destroy(gameObject);
                    return;
                case 7:
                    GetComponent<BombSpawnerOrange>().firePower = 1;
                    GetComponent<BombSpawnerOrange>().numberOfBombs = 1;
                    Destroy(gameObject);
                    return;
            }
        }
    }
}
