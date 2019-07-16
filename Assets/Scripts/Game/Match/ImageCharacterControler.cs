using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageCharacterControler : MonoBehaviour
{
    public GameObject ThisPlayer;
    [SerializeField] private Characters WhoIsThisCharacters;
    public Sprite EugeneImageCharacter;
    public Sprite ChuthuluImageCharacter;
    public Sprite MauriceImageCharacter;
    // Start is called before the first frame update
    void Start()
    {
         
        if(this.gameObject.name == "ImageOfPlayer1")
        {
            ThisPlayer = GameObject.FindGameObjectWithTag("Player 1");
        }
        else if(this.gameObject.name == "ImageOfPlayer2")
        {
            ThisPlayer = GameObject.FindGameObjectWithTag("Player 2");
        }
        

        
        if(ThisPlayer.GetComponent<CharacterIdentity>().WhoCharacterHeChoice == Characters.Eugene)
        {
            GetComponent<Image>().sprite = EugeneImageCharacter;
        }
        else if(ThisPlayer.GetComponent<CharacterIdentity>().WhoCharacterHeChoice == Characters.Cthulhu)
        {
            GetComponent<Image>().sprite = ChuthuluImageCharacter;
        }
        else if(ThisPlayer.GetComponent<CharacterIdentity>().WhoCharacterHeChoice == Characters.Maurice)
        {
            GetComponent<Image>().sprite = MauriceImageCharacter;
        }
    }
}
