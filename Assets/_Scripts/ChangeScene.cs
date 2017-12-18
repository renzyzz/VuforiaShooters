using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class ChangeScene : MonoBehaviour {

    public string sceneNameToload;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

   public void ChangerScene()
    {

        //  Application.loadedLevelName(0);
        SceneManager.LoadScene(sceneNameToload);

    }
}
