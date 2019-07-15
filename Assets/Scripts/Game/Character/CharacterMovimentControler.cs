using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterMovimentControler : MonoBehaviour
{
    [SerializeField] private Player Player;
    [SerializeField] private Characters Character;

    public Animator anim;
    public RuntimeAnimatorController EugeneAnimation;
    public RuntimeAnimatorController MauriceAnimation;
    public RuntimeAnimatorController ChuthuluAnimation;
    public bool CanMovimentate = true; 
    public BulletWay BulletWayOnWalking;
    //This Variable say whose side go the bullet
    [SerializeField] private float standardSpeed;
    //this variable is what the program uses as default for speed
    [SerializeField] private float SpeedX;
    //This variable is the speed of X axis
    [SerializeField] private float SpeedY;
        //This variable is the speed of Y axis
    void Start()
    {
        anim = GetComponent<Animator>();
        Player = GetComponent<CharacterIdentity>().WhoIsThisPlayer;
        Character = this.gameObject.GetComponent<CharacterIdentity>().WhoCharacterHeChoice;
        CharacterAnimationChoicer();
    }
    void Update()
    {
        Animation();
        Moviment();
        
    }
    // Update is called once per frame
    void CharacterAnimationChoicer()
    {
        if(Character == Characters.Eugene)
        {
            anim.runtimeAnimatorController = EugeneAnimation;
        }
        else if(Character == Characters.Cthulhu)
        {
            anim.runtimeAnimatorController = ChuthuluAnimation;
        }
        else if(Character == Characters.Maurice)
        {
            anim.runtimeAnimatorController = MauriceAnimation;
        }
    }
    void Moviment()
    {
        if(CanMovimentate)
        {
            if(Player == Player.Player1)
            {
                Player1();
            }
            else if(Player == Player.Player2)
            {
                Player2();
            }
        }
        else
        {
            this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
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
            {   anim.SetBool("Up", true);
                anim.SetBool("Down", false);
                anim.SetBool("Left", false);
                anim.SetBool("Rigth", false);
                anim.SetBool("Idle", false);
                BulletWayOnWalking = BulletWay.Up;
            }
            else if(Input.GetKeyDown(KeyCode.S))
            {   anim.SetBool("Up", false);
                anim.SetBool("Down", true);
                anim.SetBool("Left", false);
                anim.SetBool("Rigth", false);
                anim.SetBool("Idle", false);
                BulletWayOnWalking = BulletWay.Down;
            }
            else if(Input.GetKeyDown(KeyCode.A))
            {   anim.SetBool("Up", false);
                anim.SetBool("Down", false);
                anim.SetBool("Left", true);
                anim.SetBool("Rigth", false);
                anim.SetBool("Idle", false);
                BulletWayOnWalking = BulletWay.Left;
            }
            else if(Input.GetKeyDown(KeyCode.D))
            {   anim.SetBool("Up", false);
                anim.SetBool("Down", false);
                anim.SetBool("Left", false);
                anim.SetBool("Rigth", true);
                anim.SetBool("Idle", false);
                BulletWayOnWalking = BulletWay.Rigth;
            }
            else if( Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
            {
                anim.SetBool("Up", false);
                anim.SetBool("Down", false);
                anim.SetBool("Left", false);
                anim.SetBool("Rigth", false);
                anim.SetBool("Idle", true);
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

    void Animation()
    {
        if(Player == Player.Player1)
        {
            if(Input.GetAxisRaw("Player1AD") > 0)
            {
                    anim.SetBool("Up", false);
                    anim.SetBool("Down", false);
                    anim.SetBool("Left", false);
                    anim.SetBool("Rigth",true );
                    anim.SetBool("Idle", false);
            }
            else if(Input.GetAxisRaw("Player1AD") < 0)
            {
                    anim.SetBool("Up", false);
                    anim.SetBool("Down", false);
                    anim.SetBool("Left", true);
                    anim.SetBool("Rigth", false);
                    anim.SetBool("Idle", false);
            }
            else if(Input.GetAxisRaw("Player1SW") > 0)
            {
                    anim.SetBool("Up", true);
                    anim.SetBool("Down", false);
                    anim.SetBool("Left", false);
                    anim.SetBool("Rigth", false);
                    anim.SetBool("Idle", false);
            }
            else if(Input.GetAxisRaw("Player1SW") < 0)
            {
                    anim.SetBool("Up", false);
                    anim.SetBool("Down", true);
                    anim.SetBool("Left", false);
                    anim.SetBool("Rigth", false);
                    anim.SetBool("Idle", false);
            }
            else if(Input.GetAxisRaw("Player1SW") == 0 && Input.GetAxisRaw("Player1AD") == 0)
            {
                    anim.SetBool("Up", false);
                    anim.SetBool("Down", false);
                    anim.SetBool("Left", false);
                    anim.SetBool("Rigth", false);
                    anim.SetBool("Idle", true);
            }
        }
        else if(Player == Player.Player2)
        {
                if(Input.GetAxisRaw("Player2LR") > 0)
            {
                    anim.SetBool("Up", false);
                    anim.SetBool("Down", false);
                    anim.SetBool("Left", false);
                    anim.SetBool("Rigth", true);
                    anim.SetBool("Idle", false);
            }
            else if(Input.GetAxisRaw("Player2LR") < 0)
            {
                    anim.SetBool("Up", false);
                    anim.SetBool("Down", false);
                    anim.SetBool("Left", true);
                    anim.SetBool("Rigth", false);
                    anim.SetBool("Idle", false);
            }
            else if(Input.GetAxisRaw("PlayerDU") > 0)
            {
                    anim.SetBool("Up", true);
                    anim.SetBool("Down", false);
                    anim.SetBool("Left", false);
                    anim.SetBool("Rigth", false);
                    anim.SetBool("Idle", false);
            }
            else if(Input.GetAxisRaw("PlayerDU") < 0)
            {
                    anim.SetBool("Up", false);
                    anim.SetBool("Down", true);
                    anim.SetBool("Left", false);
                    anim.SetBool("Rigth", false);
                    anim.SetBool("Idle", false);
            }
            else if(Input.GetAxisRaw("PlayerDU") == 0 && Input.GetAxisRaw("Player2LR") == 0)
            {
                    anim.SetBool("Up", false);
                    anim.SetBool("Down", false);
                    anim.SetBool("Left", false);
                    anim.SetBool("Rigth", false);
                    anim.SetBool("Idle", true);
            }
        }
    }
    public void SayBulletWay(BulletWay BulletWaySide)
    {
        BulletWaySide = BulletWayOnWalking;
    }
}
