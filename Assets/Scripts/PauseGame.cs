using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public PlayerHealth hp;
    public GameObject pauseMenu;
    public bool isPuased;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
        PauseGamee();
        ResumeGamee();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(isPuased){
                ResumeGamee();
                
            }else{
                PauseGamee();
            }
        }
        if(isPuased){
            if(Input.GetKeyDown(KeyCode.F)){
                    Debug.Log("F kliknut");
                    RestartScene();
                    //PlayerHealth.instance.Death();
                    //PlayerHealth.Death();
                }
                if(Input.GetKeyDown(KeyCode.T)){
                    Debug.Log("T kliknut");
                    Application.Quit();
                }
        }
    }
    public void PauseGamee(){
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPuased = true;
    }
    public void ResumeGamee(){
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPuased = false;
    }
    public void RestartScene()
    {
        Scene thisScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(thisScene.name);
    }
}
