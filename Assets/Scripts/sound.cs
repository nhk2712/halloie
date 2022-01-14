using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sound : MonoBehaviour
{
    public Slider slider;
    public AudioSource fire;
    public AudioSource win;
    public AudioSource timeup;
    public AudioSource btn;

    void Start()
    {
        FindObjectOfType<getSound>().setSound();
    }

    void Update()
    {
        
    }

    public void change(){
        fire.volume=slider.value;
        win.volume=slider.value;
        timeup.volume=slider.value;
        btn.volume=slider.value;
        write();
    }

    void write(){
        System.IO.File.WriteAllText(Application.persistentDataPath+"\\sound.txt",slider.value.ToString());
    }
}
