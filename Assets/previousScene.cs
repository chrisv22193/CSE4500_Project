﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class previousScene : MonoBehaviour{

    private int previousSceneToLoad;


    // Start is called before the first frame update
    void Start(){
        previousSceneToLoad = SceneManager.GetActiveScene().buildIndex - 1;
    }

    private void OnTriggerEnter2D(Collider2D collision){
        SceneManager.LoadScene(previousSceneToLoad);
    }
}
