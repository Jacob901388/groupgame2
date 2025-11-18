using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishManeger : MonoBehaviour
{

    [Header("Fish Info")]
    public GameObject[] fishTypes;
    
    public List<GameObject> fishOnScene;

    [Header("FishSpawn Info")]
    public GameObject fishSpawn;
    public GameObject leftFishSpawn;
    public GameObject rightFishSpawn;
    public GameObject ParentToFish;
    public int FishToSpawn;

    [Header("Automatik Fish Spanwer Info")]
    public int fishMaxAmount;


    private void Start()
    {
        fishMaxAmount = 4;
        FishSpawner();
        FishSpawner();
        FishSpawner();
        FishSpawner();
    }

    public void Update()
    {
        
    }

    public void FishSpawner()
    {
        if(fishOnScene.Count != fishMaxAmount + 1)
        {
            spawnFish();
        }
    }

    public void spawnFish()
    {
        FishToSpawn = Random.Range(0,fishTypes.Length);

        int FishLeftOrRight = Random.Range(0, 2);

        float FishSpawnHight = Random.Range(2.5f, -2.5f);

        if(FishLeftOrRight == 0)
        {
            GameObject fishToSpawn = Instantiate(fishTypes[FishToSpawn], new Vector3(leftFishSpawn.transform.position.x, leftFishSpawn.transform.position.y + FishSpawnHight, 0), Quaternion.Euler(0,180,0));
            fishOnScene.Add(fishToSpawn);
            fishToSpawn.transform.SetParent(ParentToFish.transform);
        }
        else if (FishLeftOrRight == 1)
        {
            GameObject fishToSpawn = Instantiate(fishTypes[FishToSpawn], new Vector3(rightFishSpawn.transform.position.x, rightFishSpawn.transform.position.y + FishSpawnHight, 0), Quaternion.Euler(0,0,0));
            fishOnScene.Add(fishToSpawn);
            fishToSpawn.transform.SetParent(ParentToFish.transform);
        }
    }



}
