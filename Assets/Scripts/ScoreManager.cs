using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    public float _score;

    public TextMeshProUGUI scoreText;

    public void RiseScore(int amount)
    {
        _score += amount;
        scoreText.text = _score.ToString();
    }
}
