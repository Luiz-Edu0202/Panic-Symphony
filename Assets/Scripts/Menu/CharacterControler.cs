using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControler : MonoBehaviour
{
    public enum Characters{Eugene,Cthulhu,Maurice};

    public bool firstChoicing = true;
    [SerializeField]Characters player1;
    [SerializeField]Characters player2;

    public void ShowWhoIsChoicing(bool Choicer)
    {
        Choicer = firstChoicing;
    }
    public void PlayerClickEugene()
    {
        if(firstChoicing)
        {
            player1 = Characters.Eugene;
            firstChoicing = false;
        }
        else
        {
            player2 = Characters.Eugene;
            this.gameObject.GetComponent<SceneControler>().End_Choice_Character();
        }
        
    }
   public void PlayerClickCthulhu()
    {
        if(firstChoicing)
        {
            player1 = Characters.Cthulhu;
            firstChoicing = false;
        }
        else
        {
            player2 = Characters.Cthulhu;
            this.gameObject.GetComponent<SceneControler>().End_Choice_Character();
        }
    }
   public void PlayerClickMaurice()
    {
        if(firstChoicing)
        {
            player1 = Characters.Maurice;
            firstChoicing = false;
        }
        else
        {
            player2 = Characters.Maurice;
            this.gameObject.GetComponent<SceneControler>().End_Choice_Character();
        }
    }
     
}
