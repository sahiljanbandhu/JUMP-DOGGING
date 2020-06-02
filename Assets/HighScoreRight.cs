using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreRight : MonoBehaviour
{
    public Text text1;
    private int s1;
    private int d1;
    public static int highscoreright;
   
    void Start()
    {
        s1 = Score1.score1;
        d1 = Distance1.distance1;
        highscoreright = s1 + d1;
        text1.text = highscoreright.ToString();
    }
}
