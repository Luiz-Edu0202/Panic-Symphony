using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MatchTimeControler : MonoBehaviour
{
    [SerializeField] private float TimerOfMatch;
    public GameObject TimerTex;
    void Start()
    {
        TimerTex = GameObject.FindGameObjectWithTag("Timer Text");
        StartCoroutine("Timer");
    }

    void Update()
    {
        TimerTex.GetComponent<Text>().text = TimerOfMatch.ToString();
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
}
