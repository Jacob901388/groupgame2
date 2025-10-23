using UnityEngine;

public class Fish : MonoBehaviour
{
    [SerializeField] FishData fishData;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        rb.AddForce(transform.right * fishData.fishSpeed);
    }
}
