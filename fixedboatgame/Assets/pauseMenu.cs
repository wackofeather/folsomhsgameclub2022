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
    public GameObject renderdistancer;
    public GameObject controlUI;
    public GameObject boat;

    // Update is called once per frame
    void Start()
    {
        if (PlayerPrefs.GetFloat("FOV") != 0)
        {
            cameramain.fieldOfView = PlayerPrefs.GetFloat("FOV");
           
        }
        // controlUI.SetActive((PlayerPrefs.GetInt("controlUIint") != 0));
        if (PlayerPrefs.GetFloat("haschangedinversion") == 1f)
        {
            boat.GetComponent<boatrotation>().clickinversion = (PlayerPrefs.GetInt("inversionInt") != 0);
        }
        if (PlayerPrefs.GetFloat("haschangedcontrol") == 1f)
        {
            controlUI.SetActive((PlayerPrefs.GetInt("controlUIint") != 0));
        }


    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (isPaused)
            {
                Resume();
                optionsUI.SetActive(false);
            }
            else
            {
              if (optionsUI.activeSelf == false)
              {
                    Pause();
              }
                
            }
            
        }
    }
    public void ProperRenderDistance(float renderdistance) // all of the drawdistance stuff is broken
    {
       
        renderdistancer.GetComponent<GridGenerator>().columnLength =  Mathf.FloorToInt(renderdistance);
        renderdistancer.GetComponent<GridGenerator>().destroy = true;
    }
    public void ProperSimulationDistance(float flatdistance)
    {
        
       
        renderdistancer.GetComponent<GridGenerator>().flatextend =  Mathf.FloorToInt(flatdistance);
        renderdistancer.GetComponent<GridGenerator>().destroy = true;
    }
    public void ProperFillerDistance(float fillerdistance)
    {
     
       renderdistancer.GetComponent<GridGenerator>().plainextend = Mathf.FloorToInt(fillerdistance);
        renderdistancer.GetComponent<GridGenerator>().destroy = true;
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
        Cursor.lockState = CursorLockMode.None;
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
        PlayerPrefs.SetFloat("sensitivity", sensitivity); //check
    }
    public void FOVchange(float fov)
    {
        cameramain.fieldOfView = fov;
        PlayerPrefs.SetFloat("FOV", fov);
    }
    public void scrollsens(float scrollsensitivity)
    {
      //  Input.GetAxis("Mouse ScrollWheel").sen
    }
    public void ControlToggle(bool state)
    {
        controlUI.SetActive(state);
        PlayerPrefs.SetInt("controlUIint", (state ? 1 : 0));
        PlayerPrefs.SetFloat("haschangedcontrol", 1f);
    }
    public void InvertToggle(bool inversed)
    {
        boat.GetComponent<boatrotation>().clickinversion = inversed;
        PlayerPrefs.SetInt("inversionInt", (inversed ? 1 : 0));
        PlayerPrefs.SetFloat("haschangedinversion", 1f);
    }
}
