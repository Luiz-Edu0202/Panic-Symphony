using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    private CharacterShot Bullet;

    private string BulletWay;
    [SerializeField] private float Speed = 20;   
    void Start()
    {
        Bullet.GetComponent<CharacterShot>();
    }
    void Update()
    {
        Bullet.SayBulletWay(BulletWay);
        ShotsSide();
    }
    // Update is called once per frame

    public void ShotsSide()
    {
        if( BulletWay == "Down")
        {
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,-Speed));
        }
        else if(BulletWay == "Up")
        {
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,Speed));
        }
        else if(BulletWay == "Left")
        {
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-Speed,0));
        }
        else if(BulletWay == "Rigth")
        {
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(Speed,0));
        }
    }
}
