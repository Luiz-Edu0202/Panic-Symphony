using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterShot : MonoBehaviour
{
    [SerializeField] private GameObject BulletPrefab;
    //This Variable keep the prefab of the bullet
    [SerializeField] private Transform PositionOnPlayer;
    //This Variable Keep the Component Tranform of the player
    void Update()
    {
        Shot();
    }
    // Update is called once per frame

    void Shot()
    {
        if(Input.GetKeyDown(KeyCode.P)&& !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            Instantiate(BulletPrefab,PositionOnPlayer.position + new Vector3(0.5f,0.1f,0),Quaternion.identity);
            //This command instance(Create) a bullet prefab close to the position of player, on down
        }
        //If the button P is pressed and the buttons W A S D are loosened these commands are executed
        else if(Input.GetKeyDown(KeyCode.P) && Input.GetKey(KeyCode.S))
        {
            //Escale of image 0,4
            Instantiate(BulletPrefab,PositionOnPlayer.position + new Vector3(0.5f,0.1f,0),Quaternion.identity);
            //This command instance(Create) a bullet prefab close to the position of player on down
        }
        //If the buttons P and S are pressed these commands are executed
        else if(Input.GetKeyDown(KeyCode.P) && Input.GetKey(KeyCode.A))
        {
            //Escale of image 0,5
            Instantiate(BulletPrefab,PositionOnPlayer.position + new Vector3(-0.7f,0.1f,0),Quaternion.identity);
            //This command instance(Create) a bullet prefab close to the position of player at left
        }
        //If the buttons P and A are pressed these commands are executed
         else if(Input.GetKeyDown(KeyCode.P) && Input.GetKey(KeyCode.D))
        {
            //Escale of image 0,4
            Instantiate(BulletPrefab,PositionOnPlayer.position + new Vector3(0.8f,0.1f,0),Quaternion.identity);
            //This command instance(Create) a bullet prefab close to the position of player on rigth
        }
        //If the buttons P and D are pressed these commands are executed
        else if(Input.GetKeyDown(KeyCode.P) && Input.GetKey(KeyCode.W))
        {
            //Escale of image 0,4
            Instantiate(BulletPrefab,PositionOnPlayer.position + new Vector3(-0.5f,0.1f,0),Quaternion.identity);
            //This command instance(Create) a bullet prefab close to the position of player on Up
        }
        //If the buttons P and W are pressed these commands are executed
    }
}
