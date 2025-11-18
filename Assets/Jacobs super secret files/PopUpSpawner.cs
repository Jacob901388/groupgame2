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
    [SerializeField] Transform Startpos;
    [SerializeField] Transform Endpos;
    [SerializeField] Transform popuptarget;

    bool canmove = false;
    Vector3 velocity = Vector3.zero;
    private void FixedUpdate()
    {
        Popup = $"you have cought {amountoffish} amount of {fishname}";

        if(canmove == true)
        {
        popuptarget.position = Vector3.SmoothDamp(Startpos.position, Endpos.position, ref velocity, 0.1f);
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
    }
}

