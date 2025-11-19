using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PopUpSpawner : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI PopupText;
    string Popup = "";
    [SerializeField] string fishname;
    [SerializeField] int amountoffish;
    [SerializeField] RectTransform Startpos;
    [SerializeField] RectTransform Endpos;
    [SerializeField] RectTransform popuptarget;
    [SerializeField] GameObject PrefabPopup;
    [SerializeField] Transform PopupHolder;

    [SerializeField] bool canmove = false;

    private void FixedUpdate()
    {

        Popup = $"you have cought {amountoffish} amount of {fishname}";

        if(canmove == true)
        {
            popuptarget.anchoredPosition = Vector3.Lerp(popuptarget.anchoredPosition, Endpos.anchoredPosition, 0.1f);
            StartCoroutine(DestroyPopup());
            canmove = false;
        }
    }

    public void UpdatePopup()
    {
        PopupText.text = Popup;
        MovePopup();
    }
    public void MovePopup()
    {
        canmove = true;
        Instantiate(PrefabPopup, PopupHolder);
    }

    IEnumerator DestroyPopup()
    {
        yield return new WaitForSeconds(2);
    }
}

