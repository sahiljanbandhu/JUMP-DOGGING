using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HighScore : MonoBehaviour
{

    public Text text;
    private int s;
    private int s1;
    private int d1;
    private int d;
    public static int highscore;
    void Start()
    {

        d = Distance.distance;
        s = Score.score;
        highscore = s + d;
        text.text = highscore.ToString();
    }
}




