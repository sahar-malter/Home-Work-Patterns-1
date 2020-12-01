using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text score_text;
    Score score = Score.GetScoreInstance();

    private void Update()
    {
        score_text.text = score.realScore.ToString();
    }

}
