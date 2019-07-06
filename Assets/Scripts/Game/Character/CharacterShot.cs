using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterShot : MonoBehaviour
{
    [SerializeField] private GameObject Bullet;

    [SerializeField] private Transform PositionOnPlayer;
    void Start()
    {
        
    }

    void Update()
    {
        Shot();
    }

    void Shot()
    {
        if(Input.GetKeyDown(KeyCode.P)&& !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            Instantiate(Bullet,PositionOnPlayer.position + new Vector3(0.5f,0.1f,0),Quaternion.identity);
        }
        else if(Input.GetKeyDown(KeyCode.P) && Input.GetKey(KeyCode.S))
        {
            //Escale of image 0,4
            Instantiate(Bullet,PositionOnPlayer.position + new Vector3(0.5f,0.1f,0),Quaternion.identity);
        }
        else if(Input.GetKeyDown(KeyCode.P) && Input.GetKey(KeyCode.A))
        {
            //Escale of image 0,5
            Instantiate(Bullet,PositionOnPlayer.position + new Vector3(-0.7f,0.1f,0),Quaternion.identity);
        }
         else if(Input.GetKeyDown(KeyCode.P) && Input.GetKey(KeyCode.D))
        {
            //Escale of image 0,4
            Instantiate(Bullet,PositionOnPlayer.position + new Vector3(0.8f,0.1f,0),Quaternion.identity);
        }
        else if(Input.GetKeyDown(KeyCode.P) && Input.GetKey(KeyCode.W))
        {
            //Escale of image 0,4
            Instantiate(Bullet,PositionOnPlayer.position + new Vector3(-0.5f,0.1f,0),Quaternion.identity);
        }
    }
}
