using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Player{Player1, Player2};
public class CharacterIdentity : MonoBehaviour
{
    public Player WhoIsThisPlayer;
    public Characters WhoCharacterHeChoice;
    public GameObject GameData;
    void Awake()
    {
      GameData = GameObject.FindGameObjectWithTag("Data");
      if(GameData != null)
      {
        if(WhoIsThisPlayer == Player.Player1)
        {
            WhoCharacterHeChoice = GameData.GetComponent<CharacterControler>().player1; 
        }
        if(WhoIsThisPlayer == Player.Player2)
        {
            WhoCharacterHeChoice = GameData.GetComponent<CharacterControler>().player2; 
        } 
      }
      if(GameData == null)
        {
            if(this.gameObject.name == "Player 1")
            {
                WhoIsThisPlayer = Player.Player1; 
            }
            if(this.gameObject.name == "Player 2")
            {
                WhoIsThisPlayer = Player.Player2;
            }
        }
    }
    

   
}
