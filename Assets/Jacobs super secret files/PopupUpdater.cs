using System.Collections;
using TMPro;
using UnityEngine;

public class PopupUpdater : MonoBehaviour
{
    TextMeshProUGUI PopupText;
    string Popup = "";
    [SerializeField] public string fishname;
    [SerializeField] public int moneyamount;
    float secondsbeforedestroy = 2f;
    Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
        animator.SetTrigger("Fade");
        Popup = $"You got a {fishname} worth {moneyamount}$";
        PopupText = transform.GetComponentInChildren<TextMeshProUGUI>();
        PopupText.text = Popup;
        StartCoroutine(DestroyPopup());
    }
    IEnumerator DestroyPopup()
    {
        yield return new WaitForSeconds(secondsbeforedestroy);
        Destroy(transform.gameObject);
    }
}