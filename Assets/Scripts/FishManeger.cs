using System.Collections.Generic;
using UnityEngine;

public class FishManeger : MonoBehaviour
{
    

    public GameObject[] fishTypes;
    
    public List<GameObject> fishOnScene;

    public GameObject fishSpawn;
    public GameObject leftFishSpawn;
    public GameObject rightFishSpawn;

    public GameObject ParentToFish;
    public int FishToSpawn;

    public void spawnFish()
    {
        FishToSpawn = Random.Range(0,fishTypes.Length);

        int FishLeftOrRight = Random.Range(0, 2);

        float FishSpawnHight = Random.Range(2.5f, -2.5f);

        if(FishLeftOrRight == 0)
        {
            GameObject fishToSpawn = Instantiate(fishTypes[FishToSpawn], new Vector3(leftFishSpawn.transform.position.x, leftFishSpawn.transform.position.y + FishSpawnHight, 0), Quaternion.Euler(0,180,0));
            fishToSpawn.transform.SetParent(ParentToFish.transform);
        }
        else if (FishLeftOrRight == 1)
        {
            GameObject fishToSpawn = Instantiate(fishTypes[FishToSpawn], new Vector3(rightFishSpawn.transform.position.x, rightFishSpawn.transform.position.y + FishSpawnHight, 0), Quaternion.Euler(0,0,0));
            fishToSpawn.transform.SetParent(ParentToFish.transform);
        }

        



        fishOnScene.Add(fishTypes[FishToSpawn]);
    }

}
