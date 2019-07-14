using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchTimeControler : MonoBehaviour
{
    [SerializeField] private float TimerOfMatch;
    void Start()
    {
        StartCoroutine("Timer");
    }

    IEnumerator Timer()
    {
        for(;TimerOfMatch >= 0 ;TimerOfMatch--)
        {
            yield return new WaitForSeconds(1f);
            if(TimerOfMatch <= 0)
            {
                Time.timeScale = 0;
            }
        }
    }
    void Update()
    {
        
    }

}
