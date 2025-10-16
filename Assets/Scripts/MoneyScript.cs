using TMPro;
using UnityEngine;

public class MoneyScript : MonoBehaviour
{
    [SerializeField] TextMesh ScoreText;
    //TextMeshPro FishAmountPrompt;
    float fishvalue = 2f;
    float amountoffish = 2f;
    float currentScore = 1;
    public void GiveMoney()
    {
        currentScore = currentScore + amountoffish * fishvalue;
    }

    public void UpdateScore()
    {
        ScoreText.text = "a";
    }
    
}
