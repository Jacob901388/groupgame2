using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FishingRodManager : MonoBehaviour
{
    [Header("Button Art")]

    [SerializeField] Image buttonImage;
    [SerializeField] TextMeshProUGUI buttonText;


    
    Button rodUpgradeButton;

    private void Start()
    {   
        rodUpgradeButton = GetComponent<Button>();
        rodUpgradeButton.onClick.AddListener(OnClickButton);
    }
    void OnClickButton()
    {
        //int CaughtFish = Random.Range(0, FindFirstObjectByType<FishManeger>().fishOnScene.Count);

        
        
        //Doesn't work right now
        //GameObject CaughtFishData = FindFirstObjectByType<FishManeger>().fishOnScene[CaughtFish];
        //CaughtFishData.GetComponent<FishData>();

        Debug.Log("Pluh");
    }
}
