using TMPro;
using UnityEngine;

public class MoneyScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI ScoreText;
    float fishvalue = 2f;
    float fishamount = 2f;
    public float Money = 0f;
    string scoretext = "0 $";

    private void FixedUpdate()
    {
        scoretext = $"{Money} $";
    }

    public void GiveMoney()
    {
        Money = Money + fishamount * fishvalue;
        UpdateScore();
    }

    public void UpdateScore()
    {
        ScoreText.text = scoretext;
    }
}
