using System.Collections;
using UnityEngine;

public class VanishPopup : MonoBehaviour
{
    float secondsbeforedestroy = 2f;
    private void Awake()
    {
        StartCoroutine(DestroyPopup());
    }

    IEnumerator DestroyPopup()
    {
        yield return new WaitForSeconds(secondsbeforedestroy);
        Destroy(transform.gameObject);
    }
}
