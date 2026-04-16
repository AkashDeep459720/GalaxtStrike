using UnityEngine;
using TMPro;

public class Scoreboard : MonoBehaviour
{
        [SerializeField]  TextMeshProUGUI scoreboardText;

    int score = 0;

    public void IncreaseScore(int amount)
    {
        score = score + amount;
        scoreboardText.text = score.ToString();
    }
}
