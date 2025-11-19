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

            //fishManeger.fishOnScene.RemoveAt(CaughtFish);
            //Destroy(CaughtFishData);

        } else
        {
            int fishValue = CaughtFishData.GetComponent<Fish>().fishData.value;
            

            FindAnyObjectByType<MoneyCounter>().AddScore(fishValue);

            CaughtFishData.GetComponent<Fish>().FishDie(CaughtFish);

            
            //fishManeger.fishOnScene.RemoveAt(CaughtFish);
            //Destroy(CaughtFishData);
        }


    }

    
}
