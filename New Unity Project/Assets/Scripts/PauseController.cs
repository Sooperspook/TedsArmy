using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour {
    private bool isShown = false; //is pause menu shown?

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKeyDown(KeyCode.Escape)) //if statement for pause
        {
            if (isShown)
            {
                ClosePauseMenu();
            }
            else
            {
                ShowPauseMenu();
            }
        }
	}
    public void ClosePauseMenu() //if shown
    {
        GameObject Pause = GameObject.FindGameObjectWithTag("PauseMenuRoot"); //finding the gameobject in pause and destroying it
        GameObject.Destroy(Pause);
        Time.timeScale = 1;
        isShown = false;
    }
    private void ShowPauseMenu() //if not shown
    {
        SceneManager.LoadScene("PauseMenu", LoadSceneMode.Additive); //loading the pause menu on top
        Time.timeScale = 0;
        isShown = true;
    }
}
