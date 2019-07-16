using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{

    [SerializeField] private Player Player;
    [SerializeField] private Characters Character;
    public Animator PlayerAnimator;
    public Animator BulletAnimator;
    public RuntimeAnimatorController BulletControlerAnimation;
    public RuntimeAnimatorController EugeneAnimation;
    public RuntimeAnimatorController MauriceAnimation;
    public RuntimeAnimatorController ChuthuluAnimation;
    

    // Start is called before the first frame update
    void Start()
    {
        PlayerAnimator = GetComponent<Animator>();
        Player = GetComponent<CharacterIdentity>().WhoIsThisPlayer;
        Character = this.gameObject.GetComponent<CharacterIdentity>().WhoCharacterHeChoice;
        CharacterAnimationChoicer();
        BulletAnimation();
    }

   

    void CharacterAnimationChoicer()
    {
        if(Character == Characters.Eugene)
        {
            PlayerAnimator.runtimeAnimatorController = EugeneAnimation;
        }
        else if(Character == Characters.Cthulhu)
        {
            PlayerAnimator.runtimeAnimatorController = ChuthuluAnimation;
        }
        else if(Character == Characters.Maurice)
        {
            PlayerAnimator.runtimeAnimatorController = MauriceAnimation;
        }
    }
    void Update()
    {
        MovimentateAnimation();
    }
    void BulletAnimation()
    {
        if(Character == Characters.Eugene)
        {   
            BulletAnimator.SetBool("Eugene", true);
            BulletAnimator.SetBool("Chuthulu", false);
            BulletAnimator.SetBool("Maurice", false);
        }
        else if(Character == Characters.Cthulhu)
        {
            BulletAnimator.SetBool("Eugene", false);
            BulletAnimator.SetBool("Chuthulu", true);
            BulletAnimator.SetBool("Maurice", false);
        }
        else if(Character == Characters.Maurice)
        {
            BulletAnimator.SetBool("Eugene", false);
            BulletAnimator.SetBool("Chuthulu", false);
            BulletAnimator.SetBool("Maurice", true);
        }
    }
    void MovimentateAnimation()
    {
        if(Player == Player.Player1)
        {
            if(Input.GetAxisRaw("Player1AD") > 0)
            {
                    PlayerAnimator.SetBool("Up", false);
                    PlayerAnimator.SetBool("Down", false);
                    PlayerAnimator.SetBool("Left", false);
                    PlayerAnimator.SetBool("Rigth",true );
                    PlayerAnimator.SetBool("Idle", false);
            }
            else if(Input.GetAxisRaw("Player1AD") < 0)
            {
                    PlayerAnimator.SetBool("Up", false);
                    PlayerAnimator.SetBool("Down", false);
                    PlayerAnimator.SetBool("Left", true);
                    PlayerAnimator.SetBool("Rigth", false);
                    PlayerAnimator.SetBool("Idle", false);
            }
            else if(Input.GetAxisRaw("Player1SW") > 0)
            {
                    PlayerAnimator.SetBool("Up", true);
                    PlayerAnimator.SetBool("Down", false);
                    PlayerAnimator.SetBool("Left", false);
                    PlayerAnimator.SetBool("Rigth", false);
                    PlayerAnimator.SetBool("Idle", false);
            }
            else if(Input.GetAxisRaw("Player1SW") < 0)
            {
                    PlayerAnimator.SetBool("Up", false);
                    PlayerAnimator.SetBool("Down", true);
                    PlayerAnimator.SetBool("Left", false);
                    PlayerAnimator.SetBool("Rigth", false);
                    PlayerAnimator.SetBool("Idle", false);
            }
            else if(Input.GetAxisRaw("Player1SW") == 0 && Input.GetAxisRaw("Player1AD") == 0)
            {
                    PlayerAnimator.SetBool("Up", false);
                    PlayerAnimator.SetBool("Down", false);
                    PlayerAnimator.SetBool("Left", false);
                    PlayerAnimator.SetBool("Rigth", false);
                    PlayerAnimator.SetBool("Idle", true);
            }
        }
        else if(Player == Player.Player2)
        {
                if(Input.GetAxisRaw("Player2LR") > 0)
            {
                    PlayerAnimator.SetBool("Up", false);
                    PlayerAnimator.SetBool("Down", false);
                    PlayerAnimator.SetBool("Left", false);
                    PlayerAnimator.SetBool("Rigth", true);
                    PlayerAnimator.SetBool("Idle", false);
            }
            else if(Input.GetAxisRaw("Player2LR") < 0)
            {
                    PlayerAnimator.SetBool("Up", false);
                    PlayerAnimator.SetBool("Down", false);
                    PlayerAnimator.SetBool("Left", true);
                    PlayerAnimator.SetBool("Rigth", false);
                    PlayerAnimator.SetBool("Idle", false);
            }
            else if(Input.GetAxisRaw("PlayerDU") > 0)
            {
                    PlayerAnimator.SetBool("Up", true);
                    PlayerAnimator.SetBool("Down", false);
                    PlayerAnimator.SetBool("Left", false);
                    PlayerAnimator.SetBool("Rigth", false);
                    PlayerAnimator.SetBool("Idle", false);
            }
            else if(Input.GetAxisRaw("PlayerDU") < 0)
            {
                    PlayerAnimator.SetBool("Up", false);
                    PlayerAnimator.SetBool("Down", true);
                    PlayerAnimator.SetBool("Left", false);
                    PlayerAnimator.SetBool("Rigth", false);
                    PlayerAnimator.SetBool("Idle", false);
            }
            else if(Input.GetAxisRaw("PlayerDU") == 0 && Input.GetAxisRaw("Player2LR") == 0)
            {
                    PlayerAnimator.SetBool("Up", false);
                    PlayerAnimator.SetBool("Down", false);
                    PlayerAnimator.SetBool("Left", false);
                    PlayerAnimator.SetBool("Rigth", false);
                    PlayerAnimator.SetBool("Idle", true);
            }
        }
    }
}
