using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject sizeButton;
    public GameObject colorButton;
    public GameObject speedButton;
    public GameObject backButton;
    public GameObject playButton;
    public GameObject settingsButton;
    public GameObject quitButton;
    public static int size;
    public static int color;
    public static int speed;
    public GameObject chooseSize;
    public GameObject chooseColor;
    public GameObject chooseSpeed;
    void Start()
        
    {
        
        sizeButton.gameObject.SetActive(false);
        colorButton.gameObject.SetActive(false);
        speedButton.gameObject.SetActive(false);
        backButton.gameObject.SetActive(false);
        playButton.gameObject.SetActive(true);
        settingsButton.gameObject.SetActive(true);
        quitButton.gameObject.SetActive(true);
        chooseSize.gameObject.SetActive(false);
        chooseColor.gameObject.SetActive(false);
        chooseSpeed.gameObject.SetActive(false);
    }

    public void PlayGame()
    {
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void QuitGame()
    {
        Application.Quit();
        
    }

    public void changeColor()
    {
        
    }

    public void changeSpeed()
    {

    }

    public void SettingsButton()
    {
        sizeButton.gameObject.SetActive(true);
        colorButton.gameObject.SetActive(true);
        speedButton.gameObject.SetActive(true);
        backButton.gameObject.SetActive(true);
        playButton.gameObject.SetActive(false);
        settingsButton.gameObject.SetActive(false);
        quitButton.gameObject.SetActive(false);
        chooseSize.gameObject.SetActive(true);
        chooseColor.gameObject.SetActive(true);
        chooseSpeed.gameObject.SetActive(true);
    }

    public void BackButton()
    {
        sizeButton.gameObject.SetActive(false);
        colorButton.gameObject.SetActive(false);
        speedButton.gameObject.SetActive(false);
        backButton.gameObject.SetActive(false);
        playButton.gameObject.SetActive(true);
        settingsButton.gameObject.SetActive(true);
        quitButton.gameObject.SetActive(true);
        chooseSize.gameObject.SetActive(false);
        chooseColor.gameObject.SetActive(false);
        chooseSpeed.gameObject.SetActive(false);
        size = DropDownSize.size;
        color = DropDownColor.color;
        speed = DropDownSpeed.speed;
    }

}
