using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosive : MonoBehaviour
{
    public GameObject explosionPrefab;
    public LayerMask levelMask;
    public float countdown = .65f;

    void Start()
    {
        StartCoroutine(CreateExplosions(Vector3.forward));
        StartCoroutine(CreateExplosions(Vector3.right));
        StartCoroutine(CreateExplosions(Vector3.back));
        StartCoroutine(CreateExplosions(Vector3.left));
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
    private IEnumerator CreateExplosions(Vector3 direction)
    {
        
            for (int i = 1; i < 3; i++)
        {
     
            RaycastHit hit;
  
            Physics.Raycast(transform.position + new Vector3(0, .5f, 0), direction, out hit,
              i, levelMask);

 
            if (!hit.collider)
            {
                Instantiate(explosionPrefab, transform.position + (i * direction),
           
                  explosionPrefab.transform.rotation);
             
            }
            else
            {
                break;
            }
            
            yield return new WaitForSeconds(.05f);
        }

    }
}
