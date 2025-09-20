using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score;

    public void IncreaseScore()
    {
        score += 1;
    }
    public void IncreaseScore(int amount)
    {
        score += amount;
    }
}
