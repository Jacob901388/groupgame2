using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FishingRodManager : MonoBehaviour
{
    [Header("Button Art")]

    [SerializeField] Image buttonImage;
    [SerializeField] TextMeshProUGUI buttonText;

    [Header("Button")]
    [SerializeField] GameObject ReelImage;
    [SerializeField] Image ReelColdown;

    [Header("Coldown")]
    [SerializeField] bool isOnColDown;

    FishManeger fishManeger;

    
    Button rodUpgradeButton;


    private void Start()
    {
        


        rodUpgradeButton = GetComponent<Button>();
        buttonPress();
        fishManeger = FindAnyObjectByType<FishManeger>();
    }

    void buttonPress()
    {
        if (!isOnColDown)
        {
            rodUpgradeButton.onClick.AddListener(OnClickButton);
        }
    }

    void ButtonColdown()
    {

    }


    void OnClickButton()
    {
        int CaughtFish = Random.Range(0, FindFirstObjectByType<FishManeger>().fishOnScene.Count);

        GameObject CaughtFishData = FindFirstObjectByType<FishManeger>().fishOnScene[CaughtFish];
        if (CaughtFishData == null)
        {
            CaughtFishData = FindFirstObjectByType<FishManeger>().fishOnScene[CaughtFish + 1];
            

            int fishValue = CaughtFishData.GetComponent<Fish>().fishData.value;


            FindAnyObjectByType<MoneyCounter>().AddScore(fishValue);

            CaughtFishData.GetComponent<Fish>().FishDie(CaughtFish);

        } else
        {
            int fishValue = CaughtFishData.GetComponent<Fish>().fishData.value;
            

            FindAnyObjectByType<MoneyCounter>().AddScore(fishValue);

            CaughtFishData.GetComponent<Fish>().FishDie(CaughtFish);
        }
    }



    
}
