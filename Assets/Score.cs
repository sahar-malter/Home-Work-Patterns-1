using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Score : MonoBehaviour
{
   private static Score _scoreInstance = new Score();
    public int realScore;

    public static Score GetScoreInstance()
    {
        return _scoreInstance;
    }

    private Score()
    {
        realScore = 0;
    }
    public void addScore()
    {
        realScore++;
    }
    
}


