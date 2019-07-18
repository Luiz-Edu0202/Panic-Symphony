using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerShowControler : MonoBehaviour
{
    public Text ControlsP1;
    public Text ControlsP2;
    public Sprite Player1Show;
    public Sprite Player2Show;
    [SerializeField] private GameObject GameData;
    private bool WhoisChoicing;
    // Start is called before the first frame update
    void Start()
    {
        GameData = GameObject.FindGameObjectWithTag("Data");
    }

    // Update is called once per frame
    void Update()
    {
         WhoisChoicing = GameData.GetComponent<CharacterControler>().firstChoicing;
         if(WhoisChoicing)
         {
             GetComponent<SpriteRenderer>().sprite = Player1Show;
             ControlsP1.enabled = true;
             ControlsP2.enabled = false;

         }
         else
         {
             GetComponent<SpriteRenderer>().sprite = Player2Show;
             ControlsP1.enabled = false;
             ControlsP2.enabled = true;
         }
    }
}
