using UnityEngine;

public class PopUpSpawner : MonoBehaviour
{
    [SerializeField] GameObject PrefabPopup;
    [SerializeField] Transform PopupHolder;
    public void SpawnPopup()
    {
        Instantiate(PrefabPopup, PopupHolder);
    }
}