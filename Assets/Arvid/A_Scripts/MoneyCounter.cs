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
    }
    public void AddScore(int ScoreToAdd)
    {
        currentMoney += ScoreToAdd;
    }
    public void DeductScore(int ScoreToDeduct)
    {
        currentMoney -= ScoreToDeduct;
    }
    void Update()
    {
        moneyCounter.text = ("$ " + currentMoney.ToString());
    }
}
