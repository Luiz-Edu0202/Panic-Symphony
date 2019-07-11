using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovimentControler : MonoBehaviour
{
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
        Bullet = GameObject.FindGameObjectWithTag("Bullet");
    }
    void Update()
    {
        Moviment();
    }
    // Update is called once per frame
    void Moviment()
    {
        SpeedX = Input.GetAxis("Horizontal") * standardSpeed;
        /*The velocity on the x-axis is multiplication 
        of the return of the horizontal get axis method and the standard velocity*/
        SpeedY = Input.GetAxis("Vertical") * standardSpeed;
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
        else if( Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.D))
        {
            BulletWayOnWalking = BulletWay.Down;
        }
        
    }
    //This method do the moviment of the character
}
