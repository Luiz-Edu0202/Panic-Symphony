using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControler : MonoBehaviour
{

    public void Click_On_Play()
    {
        SceneManager.LoadScene("GameSettings");
    }
    public void End_Choice_Character()
    {
        
        SceneManager.LoadScene("Game");
        DontDestroyOnLoad(this.gameObject);
    }

}
