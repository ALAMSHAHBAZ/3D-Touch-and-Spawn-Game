﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControlScript : MonoBehaviour
{
	public GameObject timeIsUp, restartButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(TimeLeftScript.timeLeft <= 0.0f){
        	Time.timeScale=0;
        	timeIsUp.gameObject.SetActive(true);
        	restartButton.gameObject.SetActive(true);
        }
    }

    public void restartScene(){
    	    timeIsUp.gameObject.SetActive(false);
        	restartButton.gameObject.SetActive(false);
        	Time.timeScale=1;
        	TimeLeftScript.timeLeft = 60f;
           ScoreScript.scoreValue = 0;
           SceneManager.LoadScene("Scene1");
    }
}
