using System.Collections.Generic;
using UnityEngine;

public class FishManeger : MonoBehaviour
{
    
    public GameObject[] fishTypes;
    
    public List<GameObject> fishOnScene;

    public GameObject fishSpawn;
    public GameObject leftFishSpawn;
    public GameObject rightFishSpawn;

    public void spawnFish()
    {
        int FishToSpawn = Random.Range(0,fishTypes.Length);

        int FishLeftOrRight = Random.Range(0, 1);

        if(FishLeftOrRight == 0)
        {
            
        }
        else if (FishLeftOrRight == 1)
        {

        }

        

        Instantiate(fishTypes[FishToSpawn], fishSpawn.transform.position, Quaternion.identity);

        fishOnScene.Add(fishTypes[FishToSpawn]);
    }

}
