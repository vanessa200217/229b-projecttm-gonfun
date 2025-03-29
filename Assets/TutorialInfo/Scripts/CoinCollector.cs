using UnityEngine;
using UnityEngine.UI;

public class CoinCollector : MonoBehaviour
{
    private int score = 0;
    public Text scoreText;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            score++;
            Destroy(other.gameObject);
            UpdateScoreText();
        }
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}
