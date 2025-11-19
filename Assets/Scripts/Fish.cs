using UnityEngine;
using System.Collections;
using NUnit.Framework;
using System.Collections.Generic;

public class Fish : MonoBehaviour
{
    [Header("fishData")]
    [SerializeField] public FishData fishData;

    [Header("fish values")]
    [SerializeField] float fishLifeDuration;

    [Header("Other Info")]
    public bool isCaught;

    FishManeger fishManger;
    Rigidbody2D rb;

    void Start()
    {
        fishManger = FindAnyObjectByType<FishManeger>();
        rb = GetComponent<Rigidbody2D>();

        fishLifeDuration = 3 * ((fishData.fishSpeed + 1.45f) * 2);


        gameObject.transform.localScale = new Vector3(fishData.fishSize, fishData.fishSize, fishData.fishSize);

        StartCoroutine(FishLifeTime());
    }

    
    void FixedUpdate()
    {
        rb.AddForce(transform.right * fishData.fishSpeed);
    }

    IEnumerator FishLifeTime()
    {

        yield return new WaitForSeconds(fishLifeDuration);
        if (!isCaught)
        {
            int currentFish = fishManger.FishToSpawn;
            FishDie(currentFish);
        }

    }

    public void FishDie(int FishToKill)
    {
        fishManger.fishOnScene.RemoveAt(FishToKill);
        fishManger.FishSpawner();
        Destroy(gameObject);
    }
}
