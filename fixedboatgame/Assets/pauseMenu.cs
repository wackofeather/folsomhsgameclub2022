using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class pauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool isPaused = false;
    public GameObject pauseMenuUI;
    public GameObject optionsUI;
    public Camera cameramain;
    public AudioMixer audiomixer;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume ()
    {
        Cursor.lockState = CursorLockMode.Locked;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    void Pause ()
    {
        Cursor.lockState = CursorLockMode.Confined;
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("quitting game");
    }
    public void OptionsClick()
    {
        pauseMenuUI.SetActive(false);
        optionsUI.SetActive(true);
    }
    public void ExitOptions()
    {
        pauseMenuUI.SetActive(true);
        optionsUI.SetActive(false);
    }
   
    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
    public void SensChange(float sensitivity)
    {
        cameramain.GetComponent<mouselook>().sens = sensitivity;
    }
    public void FOVchange(float fov)
    {
        cameramain.fieldOfView = fov;
    }
}
