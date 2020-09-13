using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;

    public float scoreCount;
    public float pointsPerSecond;

    public bool scoreIncreasing;

    void Update()
    {
        if(scoreIncreasing)
        {
            scoreCount += pointsPerSecond = Time.deltaTime;
        }
        

        ScoreText.text = "Score: " + Mathf.Round(scoreCount);
            
    }
}
