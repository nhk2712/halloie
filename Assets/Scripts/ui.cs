using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ui : MonoBehaviour
{
    public GameObject pausePan;
    bool isPaused;
    public AudioSource button;
    
    void Start()
    {
        isPaused = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)){
            if (isPaused==false){
                pause();
            }
            else{
                play();
            }
        }
    }

    public void pause(){
        pausePan.SetActive(true);
        Time.timeScale=0;
        //Cursor.visible=true;
        isPaused=true;
    }

    public void play(){
        pausePan.SetActive(false);
        Time.timeScale=1;
        //Cursor.visible=false;
        isPaused=false;
    }

    public bool pauseState(){
        return isPaused;
    }

    public void again(){
        SceneManager.LoadScene("easieM");
        Time.timeScale=1;
    }

    public void quit(){
        SceneManager.LoadScene("home");
        Time.timeScale=1;
    }

    public void click(){
        button.Play();
    }
}
