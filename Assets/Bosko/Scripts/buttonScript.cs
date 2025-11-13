using UnityEngine;
using UnityEngine.UI;
public class buttonScript : MonoBehaviour
{

    [Header("Shop")]
    public int shop1prize;
    public Text shop1text;

    public int shop2prize;
    public Text shop2text;

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
        //Clicker
        currentScore = 0;
        hitPower--;
        scoreIncreasedPerSecond++;
        x = 0f;

        //Imports values from MoneyScript
        //FindObjectOfType<Money>

        //Set all varibals to default before loading
        shop1prize = 25;
        shop2prize = 125;
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
        currentScore = 0;
        hitPower--;
        scoreIncreasedPerSecond = 1;
        x = 0f;



        //Upgrade
        upgradeText.text = "cost" + upgradePrize + " $";

        //shop
        shop1text.text = "Tier 1: " + shop1prize + " $: ";
        shop2text.text = "Tier 2: " + shop1prize + " $: ";

        //amounts
        amount1Text.text = "Tier 1: " + amount1 + " arts $: " + amount1Profit + "/s";
        amount2Text.text = "Tier 2: " + amount1 + " arts $: " + amount2Profit + "/s";

        //Reload
        PlayerPrefs.SetInt("currentScore", 0);
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
        if (currentScore >= shop1prize)
        {
            currentScore = currentScore - shop1prize;
            amount1++;
            amount1Profit++;
            x++;
            shop1prize += 25;
        }
    }

    public void Shop2()
    {
        if (currentScore >= shop2prize)
        {
            currentScore = currentScore - shop2prize;
            amount2++;
            amount2Profit += 5;
            x += 5;
            shop2prize += 125;
        }
    }

    public void addScore(int scoreToAdd)
    {

    }

}
