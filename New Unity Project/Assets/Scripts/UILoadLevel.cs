using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class UILoadLevel : MonoBehaviour {
    
    public AudioClip clickSound;
    private AudioSource source;

    void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    public void ChangeScene(string sceneName)
    {
        source.PlayOneShot(clickSound);
        SceneManager.LoadScene(sceneName);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
