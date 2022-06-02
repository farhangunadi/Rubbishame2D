using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject mainUI;

    // Start is called before the first frame update
    public void ChangeScene(string sceneName)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneName);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Home(string sceneName)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneName);
    }

    public void Restart(){
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void NextLevel(string nextLevelScene){
        Time.timeScale = 1f;
        SceneManager.LoadScene(nextLevelScene);
    }

    public void ShowInfo(GameObject infoMenu)
    {
        mainUI.SetActive(false);
        infoMenu.SetActive(true);
        // Time.timeScale = 0f;
    }
    public void UnshowInfo(GameObject infoMenu)
    {
        infoMenu.SetActive(false);
        mainUI.SetActive(true);
        // Time.timeScale = 1f;
    }

}
