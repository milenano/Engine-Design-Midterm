using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour

{
    public static ScoreManager instance;
    int score = 3;
    // Start is called before the first frame update
    void Awake()
    {
        if(!instance)
        {
            instance = this;
        }
    }

    public void ChangeScore(int liveCount)
    {
        score -= liveCount;
        Debug.Log(score);
    }

   // public void ChangeScore(int coinValue)
   // {
   //     score += coinValue;
   //     Debug.Log(score);
   // }
}
