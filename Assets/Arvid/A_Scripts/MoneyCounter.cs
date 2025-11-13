using TMPro;
using UnityEngine;

public class MoneyCounter : MonoBehaviour
{
    [SerializeField] int currentMoney;

    buttonScript buttonScript;

    [SerializeField] TextMeshProUGUI moneyCounter;

    private void Start()
    {
        buttonScript = FindAnyObjectByType<buttonScript>();

        moneyCounter.text = ("$ " + currentMoney.ToString());
    }
    public void AddScore(int ScoreToAdd)
    {
        currentMoney += ScoreToAdd;

        moneyCounter.text = ("$ " + currentMoney.ToString());
    }
    public void DeductScore(int ScoreToDeduct)
    {
        currentMoney -= ScoreToDeduct;

        moneyCounter.text = ("$ " + currentMoney.ToString());
    }
}
