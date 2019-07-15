using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterShot : MonoBehaviour
{
    [SerializeField] private Player Player;
    [SerializeField] private Characters Character;
    [SerializeField] private int bulletsCount;
    [SerializeField] private GameObject BulletPrefab;
    //This Variable keep the prefab of the bullet
    [SerializeField] private Transform PositionOnPlayer;
    //This Variable Keep the Component Tranform of the player
    void Start()
    {
        Player = GetComponent<CharacterIdentity>().WhoIsThisPlayer;
        Character = GetComponent<CharacterIdentity>().WhoCharacterHeChoice;
    }
    void Update()
    {
        Shot();
        Recharge();
    }
    // Update is called once per frame
    void Shot()
    {
            if(bulletsCount >  0)
            {
                if(Player == Player.Player1)
                {
                    if(Input.GetKeyDown(KeyCode.T) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
                    {
                        Instantiate(BulletPrefab,PositionOnPlayer.position + new Vector3(0.5f,0.1f,0),Quaternion.identity);
                        //This command instance(Create) a bullet prefab close to the position of player, on down
                        bulletsCount--;
                    }
                    //If the button P is pressed and the buttons W A S D are loosened these commands are executed
                    else if(Input.GetKeyDown(KeyCode.T) && Input.GetKey(KeyCode.S))
                    {
                        //Escale of image 0,4
                        Instantiate(BulletPrefab,PositionOnPlayer.position + new Vector3(0.5f,0.1f,0),Quaternion.identity);
                        //This command instance(Create) a bullet prefab close to the position of player on down
                        bulletsCount--;
                    }
                    //If the buttons P and S are pressed these commands are executed
                    else if(Input.GetKeyDown(KeyCode.T) && Input.GetKey(KeyCode.A))
                    {
                        //Escale of image 0,5
                        Instantiate(BulletPrefab,PositionOnPlayer.position + new Vector3(-0.7f,0.1f,0),Quaternion.identity);
                        //This command instance(Create) a bullet prefab close to the position of player at left
                        bulletsCount--;
                    }
                    //If the buttons P and A are pressed these commands are executed
                    else if(Input.GetKeyDown(KeyCode.T) && Input.GetKey(KeyCode.D))
                    {
                        //Escale of image 0,4
                        Instantiate(BulletPrefab,PositionOnPlayer.position + new Vector3(0.8f,0.1f,0),Quaternion.identity);
                        //This command instance(Create) a bullet prefab close to the position of player on rigth
                        bulletsCount--;
                    }
                    //If the buttons P and D are pressed these commands are executed
                    else if(Input.GetKeyDown(KeyCode.T) && Input.GetKey(KeyCode.W))
                    {
                        //Escale of image 0,4
                        Instantiate(BulletPrefab,PositionOnPlayer.position + new Vector3(-0.5f,0.1f,0),Quaternion.identity);
                        //This command instance(Create) a bullet prefab close to the position of player on Up
                        bulletsCount--;
                    }
                    //If the buttons P and W are pressed these commands are executed
                }
                else if(Player == Player.Player2)
                {
                    if(Input.GetKeyDown(KeyCode.O)&& !Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow))
                    {
                        Instantiate(BulletPrefab,PositionOnPlayer.position + new Vector3(0.5f,0.1f,0),Quaternion.identity);
                        //This command instance(Create) a bullet prefab close to the position of player, on down
                        bulletsCount--;
                    }
                    //If the button RightControl is pressed and the buttons UpArrow LeftArrow DownArrow RightArrow are loosened these commands are executed
                    else if(Input.GetKeyDown(KeyCode.O) && Input.GetKey(KeyCode.DownArrow))
                    {
                        //Escale of image 0,4
                        Instantiate(BulletPrefab,PositionOnPlayer.position + new Vector3(0.5f,0.1f,0),Quaternion.identity);
                        //This command instance(Create) a bullet prefab close to the position of player on down
                        bulletsCount--;
                    }
                    //If the buttons RightControl and DownArrow are pressed these commands are executed
                    else if(Input.GetKeyDown(KeyCode.O) && Input.GetKey(KeyCode.LeftArrow))
                    {
                        //Escale of image 0,5
                        Instantiate(BulletPrefab,PositionOnPlayer.position + new Vector3(-0.7f,0.1f,0),Quaternion.identity);
                        //This command instance(Create) a bullet prefab close to the position of player at left
                        bulletsCount--;
                    }
                    //If the buttons RightControl and LeftArrow are pressed these commands are executed
                    else if(Input.GetKeyDown(KeyCode.O) && Input.GetKey(KeyCode.RightArrow))
                    {
                        //Escale of image 0,4
                        Instantiate(BulletPrefab,PositionOnPlayer.position + new Vector3(0.8f,0.1f,0),Quaternion.identity);
                        //This command instance(Create) a bullet prefab close to the position of player on rigth
                        bulletsCount--;
                    }
                    //If the buttons RightControl and RightArrow are pressed these commands are executed
                    else if(Input.GetKeyDown(KeyCode.O) && Input.GetKey(KeyCode.UpArrow))
                    {
                        //Escale of image 0,4
                        Instantiate(BulletPrefab,PositionOnPlayer.position + new Vector3(-0.5f,0.1f,0),Quaternion.identity);
                        //This command instance(Create) a bullet prefab close to the position of player on Up
                        bulletsCount--;
                    }
                    //If the buttons RightControl and UpArrow are pressed these commands are executed
                }
            }
            else
            {
                print("Recarregar");
            }
    }
    void Recharge()
    {
        
        if(Player == Player.Player1)
        {
            if(Input.GetKeyDown(KeyCode.R))
            {
                this.gameObject.GetComponent<CharacterMovimentControler>().CanMovimentate = false;
                StartCoroutine("StarRecharge");
            }
            else if(Input.GetKeyUp(KeyCode.R))
            {
                this.gameObject.GetComponent<CharacterMovimentControler>().CanMovimentate = true;
                StopCoroutine("StarRecharge");
            }
        }
        else if(Player == Player.Player2)
        {
            if(Input.GetKeyDown(KeyCode.P))
            {
                this.gameObject.GetComponent<CharacterMovimentControler>().CanMovimentate = false;
                StartCoroutine("StarRecharge");
            }
            else if(Input.GetKeyUp(KeyCode.P))
            {
                this.gameObject.GetComponent<CharacterMovimentControler>().CanMovimentate = true;
                StopCoroutine("StarRecharge");
                
            }
        }

    }
    public void RestarBullets()
    {
        bulletsCount = 5;
    }
    
    IEnumerator StarRecharge()
    {
        yield return new WaitForSeconds(3f);
        this.gameObject.GetComponent<CharacterMovimentControler>().CanMovimentate = true;
        bulletsCount = 5;
    }
    
}
