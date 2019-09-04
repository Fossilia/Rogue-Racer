using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone2_TerrainCreator : MonoBehaviour
{

    public GameObject[] buildings;
    public GameObject collectable;
    public Transform playerTransform;
    public Transform tf;
    public PlayerMovement movement;
    public Vector3 obOffset;
    public static GameObject[] gameObjects;
    public int spawnCount;
    float distBetweenBuildings = 0;

    //int spawnerTimer = 1;
    int playerdist = 0;

    private void Start()
    {
        //spawnCollectables(1);
        SpawnChunck();
    }

    void SpawnChunck()
    {
        distBetweenBuildings = playerTransform.position.z + 1000 + Random.Range(1, 10);

        for (int i = 0; i < 10; i++)
        {
            spawnRandomObstacles(distBetweenBuildings);
            spawnCollectables(3, distBetweenBuildings);
            distBetweenBuildings += 100;
        }
    }

    void spawnRandomObstacles(float gap)
    {
        for (int i = 0; i < spawnCount; i++)
        {
            int buildingHeight = Random.Range(40, 400);
            obOffset = new Vector3(Random.Range(-400, 400), (buildingHeight / 2) - 9, gap);
            GameObject newOb = Instantiate(buildings[0], buildings[0].transform.position + obOffset, buildings[0].transform.rotation);
            //newOb.transform.localScale = new Vector3(newOb.transform.localScale.x + Random.Range(0, 20), buildingHeight, newOb.transform.localScale.z + Random.Range(0, 20));
        }
    }

    void spawnCollectables(int count, float gap)
    {
        Vector3 collectableOffset;
        for (int i = 0; i < count; i++)
        {
            collectableOffset = new Vector3(Random.Range(-200, 200), Random.Range(-40, 200), gap);
            Instantiate(collectable, collectable.transform.position + collectableOffset, collectable.transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (movement.enabled)
        {
            if (playerTransform.position.z > playerdist + 1050)
            {
                playerdist += 1050;
                SpawnChunck();

            }
        }
    }
}


