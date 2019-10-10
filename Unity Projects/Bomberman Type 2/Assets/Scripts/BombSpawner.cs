using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour
{

    public GameObject bomb;
    private GameObject Player1;

    int numberOfBombs = 1;

    // Start is called before the first frame update
    void Start()
    {

    }


    void Update()
    {
        if (Input.GetButtonDown("Jump") && numberOfBombs >= 1)
        {

            GameObject newObj = Instantiate(bomb, transform.position, Quaternion.identity);
            newObj.transform.position = new Vector3(Mathf.RoundToInt(newObj.transform.position.x), Mathf.RoundToInt(newObj.transform.position.y - 0.3f), Mathf.RoundToInt(newObj.transform.position.z));
            numberOfBombs--;
            Invoke("AddBomb", 1);
        }
    }

    public void AddBomb()
    {
        numberOfBombs++;
    }
}