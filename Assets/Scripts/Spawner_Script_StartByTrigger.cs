using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_Script_StartByTrigger : MonoBehaviour
{

    [SerializeField]
    [Tooltip("Prefab Object")]
    public GameObject spawnableObject;
    public int maxCubeAmount = 10;
    public float spawnRate = 5;
    private bool running = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleSpawningObjects()
    {
        if (spawnableObject != null)
        {
            if (running)
            {
                CancelInvoke();
                running = false;
            }
            else
            {
                InvokeRepeating("SpawnObjectLoop", 0, spawnRate);
                running = true;
            }
        }
    }

    void SpawnObjectLoop()
    {
        Debug.Log("SpawnObject Runs");

        if (maxCubeAmount > 0)
        {
            Instantiate(spawnableObject, transform.position, Quaternion.identity);
            maxCubeAmount--;
            Debug.Log("Cube Spawned");
        }
        else
        {
            CancelInvoke();
        }

    }
}
