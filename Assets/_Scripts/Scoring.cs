﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour {

    public Text score;
    public static float point;

    
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        score.text = "Score : " + point;
    }
}
