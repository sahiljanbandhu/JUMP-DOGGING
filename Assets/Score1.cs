using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score1 : MonoBehaviour
{
    public static int score1;
    public Text text1;    
    void Start()
    {
        score1 = 0;
    }

    void Update()
    {
        text1.text = score1.ToString();
    }
}
