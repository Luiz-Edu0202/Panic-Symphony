﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
public class SceneCredits : MonoBehaviour
{

    // Start is called before the first frame update
    void Awake()
    {
        StartCoroutine("EndOfVideo");
    }

    // Update is called once per frame
    IEnumerator EndOfVideo()
    {
        yield return new WaitForSeconds(15f);
        print("Termino");
        SceneManager.LoadScene("GameSettings");
    }
   
}
