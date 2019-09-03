using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainCreator : MonoBehaviour {

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

    /*void spawnAll(GameObject[] objects, Vector3 offset)
    {
        foreach (GameObject ob in objects)
        {
            Instantiate(ob, ob.transform.position + offset, ob.transform.rotation);
        }
    }*/

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
        for(int i = 0; i < spawnCount; i++)
        {
            int buildingHeight = Random.Range(40, 400);
            obOffset = new Vector3(Random.Range(-400, 400), (buildingHeight/2)-9, gap);
            GameObject newOb = Instantiate(buildings[0], buildings[0].transform.position + obOffset, buildings[0].transform.rotation);
            newOb.transform.localScale = new Vector3(newOb.transform.localScale.x + Random.Range(0, 20), buildingHeight, newOb.transform.localScale.z + Random.Range(0, 20));
        }
        /*switch (Random.Range(1, 4))
        {
            case 1:
                //spawnAll(middleOb, obOffset);
                Instantiate(ob, ob.transform.position + offset, ob.transform.rotation);
                break;
            case 2:
                spawnAll(jumpOb, obOffset);
                break;
            case 3:
                spawnAll(archOb, obOffset);
                break;
            default:
                break;
        }
        Debug.Log(obOffset);*/
    }

    void spawnCollectables(int count, float gap)
    {
        Vector3 collectableOffset;
        for(int i = 0; i<count; i++)
        {
            collectableOffset = new Vector3(Random.Range(-200, 200), Random.Range(-40, 200), gap);
            Instantiate(collectable, collectable.transform.position + collectableOffset, collectable.transform.rotation);
        }
    }

    // Update is called once per frame
    void Update () {

        if (movement.enabled)
        {
            if(playerTransform.position.z > playerdist + 1050)
            {
                playerdist += 1050;
                SpawnChunck();

            }
            //tf.localScale = new Vector3(15, 1, playerTransform.position.z*2 + 400);
            /*spawnerTimer--;
            //Debug.Log(spawnerTimer);
            if (spawnerTimer == 0 && playerTransform.position.z < 8000)
            {
                //obstacles = null;
                spawnerTimer = 30;
                //spawnRandomObstacles(0);
                SpawnChunck();
                //spawnCollectables(Random.Range(1, 2));
            }
            */
        }
    }
}


/*switch(Random.Range(1, 3))
                {
                    case 1:
                        obstacles = GameObject.FindGameObjectsWithTag("middleRectObstacle");
                        spawnAll(obstacles, obOffset);
                        /*foreach(GameObject obstacle in obstacles)
                        {
                            Instantiate(obstacle, obstacle.transform.position, obstacle.transform.rotation);
                        }*//*
                        break;
                    case 2:
                        obstacles = GameObject.FindGameObjectsWithTag("archObstacle");
                        spawnAll(obstacles, obOffset);
                        break;
                    case 3:
                        obstacles = GameObject.FindGameObjectsWithTag("jumpObstacle");
                        spawnAll(obstacles, obOffset);
                        break;
                    default:
                        break;
                }
                obOffset = new Vector3(0, 0, playerTransform.position.z + 40 + Random.Range(1, 20)) + obOffset;
                Debug.Log(obOffset);*/
