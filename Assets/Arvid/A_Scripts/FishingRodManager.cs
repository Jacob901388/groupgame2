using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FishingRodManager : MonoBehaviour
{
    [Header("Button Art")]

    [SerializeField] Image buttonImage;
    [SerializeField] TextMeshProUGUI buttonText;

    [Header("Button")]
    Button thisButton;
    [SerializeField] GameObject ReelImage;
    

    [Header("Coldown")]
    [SerializeField] Image ReelColdown;
    [SerializeField] GameObject onCoolDownText;

    [SerializeField] float coolDownMultiplyer;

    [SerializeField] bool isOnColDown;

    FishManeger fishManeger;

    
    Button rodUpgradeButton;


    private void Start()
    {
        thisButton = GetComponent<Button>();

        rodUpgradeButton = GetComponent<Button>();
        buttonPress();
        fishManeger = FindAnyObjectByType<FishManeger>();

       
    }

    private void Update()
    {
        ButtonColdown();
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
        if (ReelColdown.fillAmount > 0 && isOnColDown)
        {
            ReelColdown.fillAmount -= coolDownMultiplyer * Time.deltaTime;
        }
        else
        {
            ReelColdown.fillAmount = 0;
            ReelImage.SetActive(true);
            onCoolDownText.SetActive(false);
            thisButton.enabled = true;

            isOnColDown = false;
        }
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

        //Cooldown
        ReelColdown.fillAmount = 1;
        ReelImage.SetActive(false);
        onCoolDownText.SetActive(true);
        thisButton.enabled = false;

        isOnColDown = true;
    }



    
}
