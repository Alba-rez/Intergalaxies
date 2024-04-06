using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawner : MonoBehaviour
{

    [SerializeField] GameObject prefab;
    [SerializeField] Transform[] spawnPoints;
    [SerializeField] float delay;

    GameObject BoxpowerUp = null;
    void Start()
    {
        StartCoroutine("Spawn");
    }
    

    IEnumerator Spawn()
    {
        while (true)
        {
            if (BoxpowerUp == null)
            {
                yield return new WaitForSeconds(delay);
                Vector3 position = spawnPoints[Random.Range(0, spawnPoints.Length)].position;
                BoxpowerUp = Instantiate(prefab, position, Quaternion.identity);
            }
            yield return new WaitForSeconds(0.5f);
        }

    }

   
}
