using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControler : MonoBehaviour
{
    public void AudioMute()
    {
        GetComponent<AudioSource>().mute = true;
    }
    public void AudioRevert()
    {
        GetComponent<AudioSource>().mute = false;
    }
    public void Click_On_Play()
    {
        SceneManager.LoadScene("GameSettings");
        //this comand load the other scene
    }
    //This method is used by the button for change the scene from the menu to the Game Settings
    public void Click_On_Retry()
    {
        SceneManager.LoadScene("GameSettings");
        //this comand load the other scene
    }
   
   public void Click_On_Credits()
    {
        SceneManager.LoadScene("Credits");
        //this comand load the other scene
    }
    public void End_Choice_Character()
    {   
        SceneManager.LoadScene("Game");
        //this comand to load the other scene
        DontDestroyOnLoad(this.gameObject);
        //this comand keeps the data of the game to other scene
        GetComponent<AudioSource>().enabled = false;
    }
     //This method is used by the Game Settings Buttons for change the scene and take the game data for the other scene

}
