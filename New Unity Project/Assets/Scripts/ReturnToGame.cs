using UnityEngine;
using System.Collections;

public class ReturnToGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void onClick()
    {
        GameObject pauseControllerObject = GameObject.FindGameObjectWithTag("PauseControl"); //getting the pausecontroller in the level
        if (pauseControllerObject) //making sure it doesn't crash
        {
            PauseController pauseController = pauseControllerObject.GetComponent<PauseController>(); //getting the script from it
            if (pauseController) //if finds pause menu then close it
            {
                pauseController.ClosePauseMenu();
            }
        }
        
    }
}
