using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public GameObject bg;
    public GameObject ghost;
    float curX;
    float curY;
    public float spd;

    void Start()
    {
        curX=Input.mousePosition.x;
        curY=Input.mousePosition.y;
        bg.transform.position = new Vector3(0,0,0);
        Cursor.visible=false;
        Time.timeScale=1;
    }

    void Update()
    {
        if (Input.mousePosition.x>curX
         && bg.transform.position.x>-19f
         && Input.mousePosition.x<Screen.width-10){
            bg.transform.position+=Vector3.left*spd*16*Time.deltaTime;
            ghost.transform.position+=Vector3.left*spd*16*Time.deltaTime;
            curX=Input.mousePosition.x;
        }
        else if (Input.mousePosition.x<curX
         && bg.transform.position.x<19f
         && Input.mousePosition.x>10){
            bg.transform.position+=Vector3.right*spd*16*Time.deltaTime;
            ghost.transform.position+=Vector3.right*spd*16*Time.deltaTime;
            curX=Input.mousePosition.x;
        }

        if (Input.mousePosition.y>curY
         && bg.transform.position.y>-12f
         && Input.mousePosition.y<Screen.height-10){
            bg.transform.position+=Vector3.down*spd*9*Time.deltaTime;
            ghost.transform.position+=Vector3.down*spd*9*Time.deltaTime;
            curY=Input.mousePosition.y;
        }
        else if (Input.mousePosition.y<curY
         && bg.transform.position.y<12f
         && Input.mousePosition.y>10){
            bg.transform.position+=Vector3.up*spd*9*Time.deltaTime;
            ghost.transform.position+=Vector3.up*spd*9*Time.deltaTime;
            curY=Input.mousePosition.y;
        }
    }
}
