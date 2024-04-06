using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GlassSpawner : MonoBehaviour
{
    [SerializeField] GameObject prefb;
    [SerializeField] Transform[] spawnPoints;
    [SerializeField] float delay;

    GameObject Crystal = null;
    void Start()
    {
        StartCoroutine("Spawn");
    }


    IEnumerator Spawn()
    {
        while (true)
        {
            if (Crystal == null)
            {
                yield return new WaitForSeconds(delay);
                Vector3 position = spawnPoints[Random.Range(0, spawnPoints.Length)].position;
                Crystal = Instantiate(prefb, position, Quaternion.identity);
            }
            yield return new WaitForSeconds(0.5f);
        }

    }
}
