using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BulletWay{Down,Up,Rigth,Left};
public class BulletBehavior : MonoBehaviour
{
    public Player WhoIsThePlayerWhoThrew;
    public Characters WhoCharacterHeChoice;
    public GameObject Player1;
    public GameObject Player2;
    public GameObject Bullet;

    [SerializeField]private BulletWay BulletWaySide;

    [SerializeField] private float Speed;   

    void Start()
    {
        Player1 = GameObject.FindGameObjectWithTag("Player 1");
        Player2 = GameObject.FindGameObjectWithTag("Player 2");
        Bullet = GameObject.FindGameObjectWithTag("Bullet");
        if(WhoIsThePlayerWhoThrew == Player.Player1)
        {
            BulletWaySide = Player1.GetComponent<CharacterMovimentControler>().BulletWayOnWalking;
        }
        else if(WhoIsThePlayerWhoThrew == Player.Player2)
        {
            BulletWaySide = Player2.GetComponent<CharacterMovimentControler>().BulletWayOnWalking;
        }
        
    }
    void Update()
    {   
        ShotsSide();
    }
    //Update is called once per frame
    public void ShotsSide()
    {
         if(BulletWaySide == BulletWay.Down)
        {
            // print("a");
            GetComponent<Rigidbody2D>().velocity = new Vector2(0,-Speed);
        }
        else if(BulletWaySide == BulletWay.Up)
        {
            // print("b");
            GetComponent<Rigidbody2D>().velocity = new Vector2(0,Speed);
        }
        else if(BulletWaySide == BulletWay.Left)
        {
            // print("c");
            GetComponent<Rigidbody2D>().velocity = new Vector2(-Speed,0);
        }
        else if(BulletWaySide == BulletWay.Rigth)
        {
            // print("d");
            GetComponent<Rigidbody2D>().velocity = new Vector2(Speed,0);
        }
        // print("chablau");
    }

    // public void SayBulletWay()
    // {

    //     BulletWaySide = Player.GetComponent<CharacterMovimentControler>().BulletWayOnWalking;
    // }

    void OnCollisionEnter2D(Collision2D col)
    {
        // print("delicia");
        print(col.collider.tag);
        if(col.collider.tag == "Wall")
        {
            // print("Demais");
            Destroy(this.gameObject);
        }
        else if(col.collider.tag == "Chair")
        {
            Destroy(this.gameObject);
        }
        else if(col.collider.tag == "Player 1" || col.collider.tag == "Player 2")
        {
            if(WhoIsThePlayerWhoThrew == Player.Player1)
            {
                if(col.collider.tag == "Player 2")
                {
                    Player2.GetComponent<CharacterLifeBehavior>().Damage();
                    Destroy(this.gameObject);
                }
                
            }
            else if(WhoIsThePlayerWhoThrew == Player.Player2)
            {
                if(col.collider.tag == "Player 1")
                {
                    Player1.GetComponent<CharacterLifeBehavior>().Damage();
                    Destroy(this.gameObject);
                }
                
            }

            
        }
         
    }

}
