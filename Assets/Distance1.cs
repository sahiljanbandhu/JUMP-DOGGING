using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Distance1 : MonoBehaviour
{
    public static int distance1;
    public float t1 = 0;
    public Text text1;
    void Start()
    {
        distance1 = 0;
    }


    void Update()
    {
        t1 = t1 + Time.deltaTime;
        if (t1 > 1)
        {
            t1 = 0;
            distance1++;
        }
        text1.text = distance1.ToString();
    }
}
