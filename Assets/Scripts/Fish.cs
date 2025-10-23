using UnityEngine;
using System.Collections;
using NUnit.Framework;
using System.Collections.Generic;

public class Fish : MonoBehaviour
{
    [SerializeField] FishData fishData;

    [SerializeField] float fishLifeDuration;

    FishManeger fishManger;
    Rigidbody2D rb;

    void Start()
    {
        fishManger = FindAnyObjectByType<FishManeger>();
        rb = GetComponent<Rigidbody2D>();

        StartCoroutine(FishLifeDuration());
    }

    
    void Update()
    {
        rb.AddForce(transform.right * fishData.fishSpeed);
    }

    IEnumerator FishLifeDuration()
    {

        yield return new WaitForSeconds(fishLifeDuration);
        
        Destroy(gameObject);
        GameObject currentFish = fishManger.fishOnScene[fishManger.FishToSpawn];
        fishManger.fishOnScene.Remove(currentFish);

    }
}
