using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BulletWay{Down,Up,Rigth,Left};
public class BulletBehavior : MonoBehaviour
{
    public GameObject Player;
    public GameObject Bullet;

    // public CharacterMovimentControler BulletMoviment;

    [SerializeField]private BulletWay BulletWaySide;

    [SerializeField] private float Speed = 200f;   

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Bullet = GameObject.FindGameObjectWithTag("Bullet");
        SayBulletWay();

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
            print("a");
            GetComponent<Rigidbody2D>().velocity = new Vector2(0,-Speed);
        }
        else if(BulletWaySide == BulletWay.Up)
        {
            print("b");
            GetComponent<Rigidbody2D>().velocity = new Vector2(0,Speed);
        }
        else if(BulletWaySide == BulletWay.Left)
        {
            print("c");
            GetComponent<Rigidbody2D>().velocity = new Vector2(-Speed,0);
        }
        else if(BulletWaySide == BulletWay.Rigth)
        {
            print("d");
            GetComponent<Rigidbody2D>().velocity = new Vector2(Speed,0);
        }
        print("chablau");
    }

    public void SayBulletWay()
    {
        BulletWaySide = Player.GetComponent<CharacterMovimentControler>().BulletWayOnWalking;
    }

}
