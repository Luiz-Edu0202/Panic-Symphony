using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterLifeBehavior : MonoBehaviour
{
    public GameObject RIP;
    public GameObject RIPprefabs;
    public Player WhoIsThisPlayer;
    [SerializeField] private GameObject MatchControler;
    private bool CanTakeDamage = true;
    //This boolean variable keeps whether the character can take damage or not
    [SerializeField] private int LifeCounter = 5;
    //This is the variable that holds the character's life counter
     public void RestarLife()
     {
         LifeCounter = 5;
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

    void Update()
    {
        Death();
    }
    void Start()
    {
        MatchControler = GameObject.FindGameObjectWithTag("Match Controler");
    }
    IEnumerator TimerRestar()
    {
        yield return new WaitForSeconds(3f);
        //Destroy(RIPprefabs);
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
        if(WhoIsThisPlayer == Player.Player1)
        {
            MatchControler.GetComponent<GameScoreControler>().PunctuationOfPlayer2();
        }
        else if(WhoIsThisPlayer == Player.Player2)
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

    IEnumerator DamageTimer()
    {
        yield return new WaitForSeconds(3f);
        //this command is the co-routine counter
        CanTakeDamage = true;
        //This set the variable to false
        this.gameObject.GetComponent<Collider2D>().enabled = true;
        //This command changes the state of the collider to on
    }
//This method,is a co-routine, is the timer for the character take other damage

}
