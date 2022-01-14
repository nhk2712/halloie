using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementM : MonoBehaviour
{
    public GameObject bg;
    public GameObject ghost;
    float curX;
    float curY;
    public float spd;
    Touch touch;

    void Start()
    {
        curX=touch.position.x;
        curY=touch.position.y;
        bg.transform.position = new Vector3(0,0,0);
        Time.timeScale=1;  
    }

    void Update()
    {
        if (Input.touchCount>0) touch = Input.GetTouch(0);
        
        if (touch.position.x>curX
         && bg.transform.position.x>-18.4f
         && touch.position.x<Screen.width-10){
            bg.transform.position+=Vector3.left*spd*16*Time.deltaTime;
            ghost.transform.position+=Vector3.left*spd*16*Time.deltaTime;
            curX=touch.position.x;
        }
        else if (touch.position.x<curX
         && bg.transform.position.x<18.4f
         && touch.position.x>10){
            bg.transform.position+=Vector3.right*spd*16*Time.deltaTime;
            ghost.transform.position+=Vector3.right*spd*16*Time.deltaTime;
            curX=touch.position.x;
        }

        if (touch.position.y>curY
         && bg.transform.position.y>-12.4f
         && touch.position.y<Screen.height-10){
            bg.transform.position+=Vector3.down*spd*9*Time.deltaTime;
            ghost.transform.position+=Vector3.down*spd*9*Time.deltaTime;
            curY=touch.position.y;
        }
        else if (touch.position.y<curY
         && bg.transform.position.y<12.4f
         && touch.position.y>10){
            bg.transform.position+=Vector3.up*spd*9*Time.deltaTime;
            ghost.transform.position+=Vector3.up*spd*9*Time.deltaTime;
            curY=touch.position.y;
        }
    }
}
