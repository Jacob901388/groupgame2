using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FishingRodManager : MonoBehaviour
{
    [Header("Button Art")]

    [SerializeField] Image buttonImage;
    [SerializeField] TextMeshProUGUI buttonText;

    FishManeger fishManeger;

    
    Button rodUpgradeButton;


    private void Start()
    {   
        rodUpgradeButton = GetComponent<Button>();
        rodUpgradeButton.onClick.AddListener(OnClickButton);
        fishManeger = FindAnyObjectByType<FishManeger>();
    }
    void OnClickButton()
    {
        int CaughtFish = Random.Range(0, FindFirstObjectByType<FishManeger>().fishOnScene.Count);

        GameObject CaughtFishData = FindFirstObjectByType<FishManeger>().fishOnScene[CaughtFish];

        int fishValue = CaughtFishData.GetComponent<Fish>().fishData.value;
        Debug.Log(fishValue);

        FindAnyObjectByType<MoneyCounter>().AddScore(fishValue);

        CaughtFishData.GetComponent<Fish>().FishDie(CaughtFish);
    }

    
}
