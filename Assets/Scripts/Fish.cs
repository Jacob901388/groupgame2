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
    public int fishValue;

    [Header("Other Info")]
    FishManeger fishManger;
    Rigidbody2D rb;

    void Start()
    {
        fishManger = FindAnyObjectByType<FishManeger>();
        rb = GetComponent<Rigidbody2D>();

        fishLifeDuration = 3 * (fishData.fishSpeed + 2);


        fishValue = Random.Range(fishData.minFishValue, fishData.maxFishValue);
        gameObject.transform.localScale = new Vector3(fishData.fishSize, fishData.fishSize, fishData.fishSize);
    }

    
    void Update()
    {
        rb.AddForce(transform.right * fishData.fishSpeed);
    }

    private void OnBecameInvisible()
    {
        GameObject currentFish = fishManger.fishOnScene[fishManger.FishToSpawn];
        fishManger.fishOnScene.Remove(currentFish);
        Destroy(gameObject);
    }
}
