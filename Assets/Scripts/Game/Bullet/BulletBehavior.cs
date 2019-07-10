using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    // public Rigidbody2D BulletRb;

    public Vector3 direção;
    // public CharacterMovimentControler BulletMoviment;

    // [SerializeField]private BulletWay BulletWaySide = BulletWay.Down;

    [SerializeField] private float Speed = 20f;   

    void Start()
    {
        // BulletRb = BulletRb.GetComponent<Rigidbody2D>();
        // BulletMoviment = BulletMoviment.GetComponent<CharacterMovimentControler>();
    }
    void Update()
    {   
        transform.Translate(direção * Speed * Time.deltaTime);
        // SayBulletWay();
        // ShotsSide();
    }
    // Update is called once per frame
    // public void ShotsSide()
    // {
    //     if(BulletWaySide == BulletWay.Down)
    //     {
    //         BulletRb.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,-Speed));
    //     }
    //     else if(BulletWaySide == BulletWay.Up)
    //     {
    //         BulletRb.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,Speed));
    //     }
    //     else if(BulletWaySide == BulletWay.Left)
    //     {
    //         BulletRb.GetComponent<Rigidbody2D>().AddForce(new Vector2(-Speed,0));
    //     }
    //     else if(BulletWaySide == BulletWay.Rigth)
    //     {
    //         BulletRb.GetComponent<Rigidbody2D>().AddForce(new Vector2(Speed,0));
    //     }
    // }

    // public void SayBulletWay()
    // {
    //     BulletWaySide = BulletMoviment.BulletWayOnWalking;
    // }

}
