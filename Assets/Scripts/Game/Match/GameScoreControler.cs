using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScoreControler : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Player2;

    public int Player1Score;
    public int Player2Score;
    void Start()
    {
        Player1 = GameObject.FindGameObjectWithTag("Player 1");
        Player2 = GameObject.FindGameObjectWithTag("Player 2");
        
    }

    public void PunctuationOfPlayer1()
    {
        Player1Score++;
        //Instantiate(Player2,new Vector3(-5,3.5f,0),Quaternion.identity);
        Player2.transform.position = new Vector3(5,3.5f,0);
        Player2.GetComponent<CharacterLifeBehavior>().RestarLife();
        Player2.GetComponent<CharacterShot>().RestarBullets();
    }
    public void PunctuationOfPlayer2()
    {
        Player2Score++;
        //Instantiate(Player1,new Vector3(5,3.5f,0),Quaternion.identity);
        Player1.transform.position = new Vector3(-5,3.5f,0);
        Player1.GetComponent<CharacterLifeBehavior>().RestarLife();
        Player1.GetComponent<CharacterShot>().RestarBullets();
    }
    void Update()
    {
        
    }
}
