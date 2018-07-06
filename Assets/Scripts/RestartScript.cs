using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        Cursor.visible = false;

        Invoke("ResetScene", 40f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
