using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovimentControler : MonoBehaviour
{
    [SerializeField] private Player WhoisThisPlayer;
    [SerializeField]private Characters WhoCharacterHeChoice;
 
    public BulletWay BulletWayOnWalking;
    public GameObject Bullet;
    //This Variable say whose side go the bullet
    [SerializeField] private float standardSpeed;
    //this variable is what the program uses as default for speed
    [SerializeField] private float SpeedX;
    //This variable is the speed of X axis
    [SerializeField] private float SpeedY;
        //This variable is the speed of Y axis
    void Star()
    {
        WhoisThisPlayer = this.gameObject.GetComponent<CharacterIdentity>().WhoIsThisPlayer;
        WhoCharacterHeChoice = this.gameObject.GetComponent<CharacterIdentity>().WhoCharacterHeChoice;
        Bullet = GameObject.FindGameObjectWithTag("Bullet");
    }
    void Update()
    {
        Moviment();
    }
    // Update is called once per frame
    void Moviment()
    {
        if(WhoisThisPlayer == Player.Player1)
        {
           Player1();
        }
        else if(WhoisThisPlayer == Player.Player2)
        {
            Player2();
        }
        
    }
    //This method do the moviment of the character

    void Player1()
    {
            SpeedX = Input.GetAxis("Player1AD") * standardSpeed;
            /*The velocity on the x-axis is multiplication 
            of the return of the horizontal get axis method and the standard velocity*/
            SpeedY = Input.GetAxis("Player1SW") * standardSpeed;
             /* The velocity on the Y-axis is multiplication 
            of the return of the Vertival get axis method and the standard velocity*/
            this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(SpeedX,SpeedY);
            //This method set the velocity(velocity of the Componet Rigidbody2D) to the two velocitys (Speed x, Speed Y)
            if(Input.GetKeyDown(KeyCode.W))
            {
                BulletWayOnWalking = BulletWay.Up;
            }
            else if(Input.GetKeyDown(KeyCode.S))
            {
                BulletWayOnWalking = BulletWay.Down;
            }
            else if(Input.GetKeyDown(KeyCode.A))
            {   
                BulletWayOnWalking = BulletWay.Left;
            }
            else if(Input.GetKeyDown(KeyCode.D))
            {
                BulletWayOnWalking = BulletWay.Rigth;
            }
            else if( Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
            {
                BulletWayOnWalking = BulletWay.Down;
            }
    }
    void Player2()
    {
            SpeedX = Input.GetAxis("Player2LR") * standardSpeed;
            /*The velocity on the x-axis is multiplication 
            of the return of the horizontal get axis method and the standard velocity*/
            SpeedY = Input.GetAxis("PlayerDU") * standardSpeed;
             /* The velocity on the Y-axis is multiplication 
            of the return of the Vertival get axis method and the standard velocity*/
            this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(SpeedX,SpeedY);
            //This method set the velocity(velocity of the Componet Rigidbody2D) to the two velocitys (Speed x, Speed Y)
            if(Input.GetKeyDown(KeyCode.UpArrow))
            {
                BulletWayOnWalking = BulletWay.Up;
            }
            else if(Input.GetKeyDown(KeyCode.DownArrow))
            {
                BulletWayOnWalking = BulletWay.Down;
            }
            else if(Input.GetKeyDown(KeyCode.LeftArrow))
            {   
                BulletWayOnWalking = BulletWay.Left;
            }
            else if(Input.GetKeyDown(KeyCode.RightArrow))
            {
                BulletWayOnWalking = BulletWay.Rigth;
            }
            else if( Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
            {
                BulletWayOnWalking = BulletWay.Down;
            }
    }
    public void SayBulletWay(BulletWay BulletWaySide)
    {
        BulletWaySide = BulletWayOnWalking;
    }
}
