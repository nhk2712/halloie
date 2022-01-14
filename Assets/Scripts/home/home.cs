using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class home : MonoBehaviour
{
    public GameObject mode;
    public GameObject menuPan;
    public GameObject quitPan;

    public AudioSource btn;

    //For the quit button
    public void quit(){
        quitPan.SetActive(true);
    }

    public void no(){
        quitPan.SetActive(false);
    }

    public void yes(){
        Application.Quit();
    }

    // For the menu button
    public void menu(){
        menuPan.SetActive(true);
    }

    public void menuClose(){
        menuPan.SetActive(false);
    }

    // For the play button
    public void play(){
        mode.SetActive(true);
    }

    public void closeMode(){
        mode.SetActive(false);
    }

    public void easie(){
        SceneManager.LoadScene("easieM");
    }

    // For audio
    public void click(){
        btn.Play();
    }
}
