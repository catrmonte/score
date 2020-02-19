using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class specialText : MonoBehaviour
{
    public Text text;

    private void OnEnable()
    {
        Score.OnScoreCountingStarted += startText;
        Score.OnHalfway += halfwayText;
        PlayerCollision.OnPlayerCollided += collisionText;
    }

    private void OnDisable()
    {
        Score.OnScoreCountingStarted -= startText;
        Score.OnHalfway -= halfwayText;
        PlayerCollision.OnPlayerCollided -= collisionText;
    }

    public void startText()
    {
        text.text = "Here we go!";
    }

    public void halfwayText()
    {
        text.text = "Almost there!";    
    }
}
