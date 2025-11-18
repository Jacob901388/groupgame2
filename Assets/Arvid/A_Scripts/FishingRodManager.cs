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

        string fishName = CaughtFishData.GetComponent<Fish>().fishData.fishName;
        int fishValue = CaughtFishData.GetComponent<Fish>().fishData.value;

        FindAnyObjectByType<MoneyCounter>().AddScore(fishValue);

        

        //fishManeger.fishOnScene.Remove(CaughtFishData);

        Debug.Log(CaughtFish);

        Debug.Log(fishName);

        Destroy(FindAnyObjectByType<FishManeger>().fishOnScene[CaughtFish]);
    }

    
}
