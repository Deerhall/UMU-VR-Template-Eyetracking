using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_Script : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Prefab Object")]
    public GameObject spawnableObject;
    public int cubeAmount = 10;
    public float spawnRate = 5;

    // Start is called before the first frame update
    void Start()
    {
        if (spawnableObject != null)
        {
            InvokeRepeating("SpawnObjectLoop", spawnRate, spawnRate);
        }
    }
    public void SpawnObject()
    {
        Instantiate(spawnableObject, transform.position, Quaternion.identity);
    }

    void SpawnObjectLoop()
    {
        Debug.Log("SpawnObject Runs");

        if (cubeAmount > 0)
        {
            Instantiate(spawnableObject, transform.position, Quaternion.identity);
            cubeAmount--;
            Debug.Log("Cube Spawned");
        }
        else
        {
            CancelInvoke();
        }

    }
}

