using TMPro;
using UnityEngine;

public class MoneyScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI ScoreText;
    float fishvalue = 2f;
    float fishamount = 2f;
    public float Money = 0f;
    string scoreValue = "0 $";

    private void FixedUpdate()
    {
        scoreValue = $"{Money} $";
    }

    public void GiveMoney()
    {
        Money = Money + fishamount * fishvalue;
        UpdateScore();
    }

    public void UpdateScore()
    {
        ScoreText.text = scoreValue;
    }
}
