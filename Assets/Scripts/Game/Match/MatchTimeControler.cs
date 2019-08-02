using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MatchTimeControler : MonoBehaviour
{
    [SerializeField] private float TimerOfMatch;
    public GameObject TimerTex;
    public GameObject WinShower;
    void Start()
    {
        TimerTex = GameObject.FindGameObjectWithTag("Timer Text");
        StartCoroutine("Timer");
    }

    void Update()
    {
        TimerTex.GetComponent<Text>().text = TimerOfMatch.ToString();
        if(TimerOfMatch <= 0)
            {
                Time.timeScale = 0;
                EndOfMatch();
            }
        else if (TimerOfMatch > 0)
            {
                Time.timeScale = 1f;
            }
    }
    IEnumerator Timer()
    {
        for(;TimerOfMatch >= 0 ;TimerOfMatch--)
        {
            yield return new WaitForSeconds(1f);
            
        }
    }

    void EndOfMatch()
    {
        if(GetComponent<GameScoreControler>().Player1Score > GetComponent<GameScoreControler>().Player2Score)
        {
            WinShower.transform.position = new Vector3(960f,531,0);
        }
        else if(GetComponent<GameScoreControler>().Player1Score < GetComponent<GameScoreControler>().Player2Score)
        {
            WinShower.transform.position = new Vector3(960f,531,0);
        }
    }
}
