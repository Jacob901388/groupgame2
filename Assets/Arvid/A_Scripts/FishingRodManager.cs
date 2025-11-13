using NUnit.Framework;
using System.Collections.Generic;
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
        int CaughtFish = Random.Range(0, FindFirstObjectByType<FishManeger>().fishOnScene.Count);


        GameObject CaughtFishData = FindFirstObjectByType<FishManeger>().fishOnScene[CaughtFish];

        Debug.Log(CaughtFishData);
        string fishName = CaughtFishData.GetComponent<Fish>().fishData.fishName;
        int fishValue = CaughtFishData.GetComponent<Fish>().fishData.value;

        FindAnyObjectByType<MoneyCounter>().AddScore(fishValue);


        Destroy(FindAnyObjectByType<FishManeger>().fishOnScene[CaughtFish]);
        
        //NOW WE NEED TO REMOVE THE FISH FROM THE LIST
    }

    
}
