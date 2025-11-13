using UnityEngine;
using UnityEngine.EventSystems;

public class PanelManager : MonoBehaviour
{
    [SerializeField] GameObject Menu;
    [SerializeField] GameObject Options;

    [SerializeField] GameObject optionStartButton;
    [SerializeField] GameObject StartButton;


    public void OpenOptions()
    {
        Menu.SetActive(false);
        Options.SetActive(true);

        EventSystem.current.SetSelectedGameObject(optionStartButton);
    }

    public void CloseOptions()
    {
        Menu.SetActive(true);
        Options.SetActive(false);

        EventSystem.current.SetSelectedGameObject(StartButton);
    }

}