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
}
