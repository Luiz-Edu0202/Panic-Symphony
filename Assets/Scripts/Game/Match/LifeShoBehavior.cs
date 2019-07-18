using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeShoBehavior : MonoBehaviour
{
    public GameObject ThisPlayer;

    [SerializeField] Sprite[] Life = new Sprite[6];
    void Start()
    {
        GetComponent<Image>().sprite = Life[0];

    }

    // Update is called once per frame
    void Update()
    {
        if(ThisPlayer.GetComponent<CharacterLifeBehavior>().LifeCounter == 5)
        {
            GetComponent<Image>().sprite = Life[0];
        }
        else if(ThisPlayer.GetComponent<CharacterLifeBehavior>().LifeCounter == 4)
        {
            GetComponent<Image>().sprite = Life[1];
        }
        else if(ThisPlayer.GetComponent<CharacterLifeBehavior>().LifeCounter == 3)
        {
            GetComponent<Image>().sprite = Life[2];
        }
        else if(ThisPlayer.GetComponent<CharacterLifeBehavior>().LifeCounter == 2)
        {
            GetComponent<Image>().sprite = Life[3];
        }
        else if(ThisPlayer.GetComponent<CharacterLifeBehavior>().LifeCounter == 1)
        {
            GetComponent<Image>().sprite = Life[4];
        }
        else if(ThisPlayer.GetComponent<CharacterLifeBehavior>().LifeCounter == 0)
        {
            GetComponent<Image>().sprite = Life[5];
        }
    }
}
