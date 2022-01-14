using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shot : MonoBehaviour
{
    public GameObject ghost;
    public GameObject bg;
    public Slider health;
    public Slider time;

    public GameObject win,timeup;
    public AudioSource bgm,gun;

    void Start()
    {
        show();
    }

    void Update()
    {
        /* For PC
        if (ghost.transform.position.x>-0.55
         && ghost.transform.position.x<0.34
         && ghost.transform.position.y>-1.48
         && ghost.transform.position.y<1.26
         && Input.GetMouseButtonDown(0)){
            Debug.Log("Fired");
            show();
            if (bg.transform.position.x<-10f
             || bg.transform.position.x>10f
             || bg.transform.position.y<-5f
             || bg.transform.position.y>5f) health.value-=0.1f;
            else health.value-=0.05f;
        }

        if (Input.GetMouseButtonDown(0) 
            && FindObjectOfType<ui>().pauseState()==false)
        gun.Play();
        */

        time.value-=0.0018f*Time.deltaTime;

        if (health.value==0){
            win.SetActive(true);
            end();
        }
        else if (time.value==0){
            timeup.SetActive(true);
            end();
        }
    }

    void show(){
        ghost.transform.position = bg.transform.position + new Vector3(
            Random.Range(-10.3f,10.3f),
            Random.Range(-5.8f,5.8f),
            0
        );
    }

    void end(){
        Cursor.visible = true;
        Time.timeScale=0;
        gun.mute=true;
        bgm.mute=true;
    }

    public void fire(){ //For mobile
        if (ghost.transform.position.x>-0.55
         && ghost.transform.position.x<0.34
         && ghost.transform.position.y>-1.48
         && ghost.transform.position.y<1.26){
            Debug.Log("Fired");
            show();
            if (bg.transform.position.x<-10f
             || bg.transform.position.x>10f
             || bg.transform.position.y<-5f
             || bg.transform.position.y>5f) health.value-=0.1f;
            else health.value-=0.05f;
        }

        if (FindObjectOfType<ui>().pauseState()==false) gun.Play();
    }
}
