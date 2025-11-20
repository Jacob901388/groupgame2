using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class buttonScript : MonoBehaviour
{
    FishingRodManager fishingRodManagerScript;
    MoneyCounter moneyCounter;
    FishManeger fishManeger;

    [Header("Shop")]
    public int shop1prize;
    public TextMeshProUGUI shop1text;

    public int shop2prize;
    public TextMeshProUGUI shop2text;

    public int shop3prize;
    public TextMeshProUGUI shop3text;

    [Header("Click")]
    public Text scoreText;
    public int currentScore;
    public float hitPower;
    public float scoreIncreasedPerSecond;
    public float x;

    [Header("Amount")]
    public Text amount1Text;
    public int amount1;
    public float amount1Profit;

    public Text amount2Text;
    public int amount2;
    public float amount2Profit;

    [Header("upgrades")]
    public int upgradePrize;
    public Text upgradeText;

    void Start ()
    {
        fishManeger = FindAnyObjectByType<FishManeger>();
        moneyCounter = FindAnyObjectByType<MoneyCounter>();
        fishingRodManagerScript = FindAnyObjectByType<FishingRodManager>();

        shop1text.text = "Reduce click cooldown Price: " + shop1prize;
        shop2text.text = "Increase The Value of Fish Value: " + shop2prize;
        shop3text.text = "Increase The Amount of Fish: " + shop3prize;

        //Clicker
        currentScore = 0;
        hitPower--;
        scoreIncreasedPerSecond++;
        x = 0f;

        //Imports values from MoneyScript
        //FindObjectOfType<Money>

        //Set all varibals to default before loading
        shop1prize = 25;
        shop2prize = 35;
        shop3prize = 100;
        amount1 = 0;
        amount1Profit = 1;
        amount2 = 0;
        amount2Profit = 5;


        //Reset line
        //PlayerPrefs.DeleteALL();

        //Load
        currentScore = PlayerPrefs.GetInt("currentScore", (int)currentScore);

    }


    void Update()
    {
        //Clicker
        //currentScore = 0;
        //hitPower--;
        //scoreIncreasedPerSecond = 1;
        //x = 0f;



        //Upgrade
        //upgradeText.text = "cost" + upgradePrize + " $";

        //shop
        //shop1text.text = "Tier 1: " + shop1prize + " $: ";
        //shop2text.text = "Tier 2: " + shop1prize + " $: ";

        //amounts
        //amount1Text.text = "Tier 1: " + amount1 + " arts $: " + amount1Profit + "/s";
        //amount2Text.text = "Tier 2: " + amount1 + " arts $: " + amount2Profit + "/s";

        //Reload
        //PlayerPrefs.SetInt("currentScore", 0);
    }

    public void Upgrade()
    {
        if (currentScore >= upgradePrize)
        {
            currentScore -= upgradePrize;
           hitPower *= 2;
            upgradePrize *= 3;
        }
    }



    public void Shop1()
    {
        if (moneyCounter.currentMoney >= shop1prize)
        {
            moneyCounter.DeductScore(shop1prize);
            fishingRodManagerScript.coolDownMultiplyer += 0.15f;
            shop1prize *= 2;
            shop1text.text = "Reduce click cooldown Price: " + shop1prize;
        }
    }

    public void Shop2()
    {
        if (moneyCounter.currentMoney >= shop2prize)
        {
            moneyCounter.DeductScore(shop2prize);
            fishingRodManagerScript.fishValueMultiplier += 2;
            shop2prize *= 2;
            shop2text.text = "Increase The Value of Fish Value: " + shop2prize;
        }
    }

    public void Shop3()
    {
        if (moneyCounter.currentMoney >= shop3prize)
        {
            moneyCounter.DeductScore(shop3prize);
            fishManeger.fishMaxAmount += 1;
            fishManeger.FishSpawner();
            shop3prize *= 2;
            shop3text.text = "Increase The Amount of Fish: " + shop3prize;
        }
    }

}
