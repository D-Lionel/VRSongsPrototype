using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] spheres;
    
    

    
    private float spawnLimitXLeft = -2;
    private float spawnLimitXRight = 3;
    private float spawnLimitYBottom = 0.52f;
    private float spawnLimitYTop = 3f;

    private float startDelay = 1.0f;
    public float spawnInterval = 2.5f;

    
    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("SpawnCube", startDelay, spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnCube()
    {
        GameObject camRig = GameObject.Find("CamRig");
        //spawnInterval = Random.Range(2f, 3f);
        // Generate random ball index and random spawn position
        Vector3 spawnPos =  new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), Random.Range(spawnLimitYBottom, spawnLimitYTop), 35 + camRig.transform.position.z) ;

        // instantiate ball at random spawn location
        int sphereIndex = Random.Range(0, spheres.Length);
        Instantiate(spheres[sphereIndex], spawnPos, spheres[sphereIndex].transform.rotation);

    }
}
