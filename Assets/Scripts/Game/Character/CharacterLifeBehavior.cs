using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterLifeBehavior : MonoBehaviour
{
    [SerializeField]private Player Player;
    [SerializeField] private Characters Character;
    //public GameObject RIP;
    //public GameObject RIPprefabs;
    [SerializeField] private GameObject MatchControler;
    private bool CanTakeDamage = true;
    //This boolean variable keeps whether the character can take damage or not
    [SerializeField] private int LifeCounter = 5;
    //This is the variable that holds the character's life counter
    [SerializeField] private float force;
    private bool move;
    private bool stop;

     void Update()
    {
        Death();
    }
    void Start()
    {
        Player = GetComponent<CharacterIdentity>().WhoIsThisPlayer;
        Character = GetComponent<CharacterIdentity>().WhoCharacterHeChoice;
        MatchControler = GameObject.FindGameObjectWithTag("Match Controler");

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.otherCollider.tag == "Bullet")
        {
            Damage();
            //The character take a damage
        }
        //If the collision object is a bullet

    }
    //This method takes the collision data and uses it
    public void RestarLife()
     {
         LifeCounter = 5;
     }

    public void Death()
    {
        
        if(LifeCounter <= 0)
        {   
            //Instantiate(RIP, transform.position,Quaternion.identity);
            //RIPprefabs = GameObject.FindGameObjectWithTag("RIP");
            transform.position = new Vector3(-11,4,0);
            StartCoroutine("TimerRestar");
            //Destroy(this.gameObject);
            GivePunctuation();
        }
    }
   
    void GivePunctuation()
    {
        if(Player == Player.Player1)
        {
            MatchControler.GetComponent<GameScoreControler>().PunctuationOfPlayer2();
        }
        else if(Player == Player.Player2)
        {
            MatchControler.GetComponent<GameScoreControler>().PunctuationOfPlayer1();
        }
    }
    public void Damage()
    {
        if(CanTakeDamage)
        {
        LifeCounter--;
        //this command take 1 of the counter life
        CanTakeDamage = false;
        //This set the variable to false
        this.gameObject.GetComponent<Collider2D>().enabled = false;
        //This command changes the state of the collider to off
        StartCoroutine("DamageTimer");
        //This command star the co-routine
        Shake();
        }
        //If the character can take damage, because of the variable, all of these commands are executable
    }
//This method is what causes the damage
    public void DamageOfThePowerUp()
    {
        if(CanTakeDamage)
        {
        LifeCounter -= 2;
        //this command take 1 of the counter life
        CanTakeDamage = false;
        //This set the variable to false
        this.gameObject.GetComponent<Collider2D>().enabled = false;
        //This command changes the state of the collider to off
        StartCoroutine("DamageTimer");
        //This command star the co-routine
        }
        //If the character can take damage, because of the variable, all of these commands are executable
    }
    //This method is what causes the damage

    void Shake()
    {
        stop = false;
        for(;stop;)
        {
            if(move)
            {
                transform.Translate(force,0,0);
                move = false;
            }
            else
            {
                transform.Translate(force,0,0);
                move = true;
            }
        }
    }
        
       
    IEnumerator DamageTimer()
    {
        yield return new WaitForSeconds(3f);
        //this command is the co-routine counter
        CanTakeDamage = true;
        //This set the variable to false
        stop = true;
        this.gameObject.GetComponent<Collider2D>().enabled = true;
        //This command changes the state of the collider to on
    }
    //This method,is a co-routine, is the timer for the character take other damage

    IEnumerator TimerRestar()
        {
            yield return new WaitForSeconds(3f);
            //Destroy(RIPprefabs);
        }
    
    }
    
    
