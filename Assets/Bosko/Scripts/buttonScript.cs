using UnityEngine;
using UnityEngine.UI;
public class buttonScript : MonoBehaviour
{

    [Header("Shop")]
    public int shop1prize;
    public Text shop1text;

    public int shop2prize;
    public Text shop2text;


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



    void Update()
    {
        //Upgrade
        upgradeText.text = "cost" + upgradePrize + " $";

        //shop
        shop1text.text = "Tier 1: " + shop1prize + " $: ";
        shop2text.text = "Tier 2: " + shop1prize + " $: ";

        //amounts
        amount1Text.text = "Tier 1: " + amount1 + " arts $: " + amount1Profit + "/s";

    }

    public void Upgrade()
    {
        //if (currentScore >= upgradePrize)
        //{
        //    currentScore -= upgradePrize;
        //    hitPower *= 2;
        //    upgradePrize *= 3;
        //}
    }


}
