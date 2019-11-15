
using UnityEngine;

public class GeneradorObstaculos : MonoBehaviour {

    public Transform[] spawnPoints;

    public GameObject BlockPrefab;

    private float timeToSpawn = 2f;

    public float TimeBetweenWaves = 1f;

    

    //public float toTheObjectForce = 1000f;



    void SpawnBlocks()
    {
        int RandomIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i< spawnPoints.Length; i++) {
            if (RandomIndex != i) {
                Instantiate(BlockPrefab,spawnPoints[i].position,Quaternion.identity);
                
            }
        }

       
    }

    
    // Update is called once per frame
    void Update()
    {
        
        
        if (Time.time >= timeToSpawn)
        {
            SpawnBlocks();
            timeToSpawn = TimeBetweenWaves + Time.time;
           
        }
        


    }
}
