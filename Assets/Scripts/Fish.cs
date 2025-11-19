using UnityEngine;
using System.Collections;
using NUnit.Framework;
using System.Collections.Generic;

public class Fish : MonoBehaviour
{
    Animator animator;
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
        animator = GetComponent<Animator>();
        fishManger = FindAnyObjectByType<FishManeger>();
        rb = GetComponent<Rigidbody2D>();

        fishLifeDuration = 3 * ((fishData.fishSpeed + 1.35f) * 2);


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
        if (!isCaught)
        {
            animator.SetTrigger("FishDieAnimation");
            fishManger.fishOnScene.RemoveAt(FishToKill);
            fishManger.FishSpawner();
            StartCoroutine(FishDieCooldown());
        }
    }

    IEnumerator FishDieCooldown()
    {


        yield return new WaitForSeconds(1);


        Destroy(gameObject);
    }
}
