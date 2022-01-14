using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Math;
using System.Globalization;
using UnityEngine.UI;
using System.IO;

public class getSound : MonoBehaviour
{
    string txt;
    double num;

    public AudioSource fire;
    public Slider slider;
    public AudioSource win;
    public AudioSource timeup;
    public AudioSource btn;

    void Start()
    {
        if (File.Exists(Application.persistentDataPath+"\\sound.txt")==false){
            Debug.Log("no file");
            File.WriteAllText(Application.persistentDataPath+"\\sound.txt","0,5");
        }
        
        txt = File.ReadAllText(Application.persistentDataPath+"\\sound.txt");

        setSound();
    }

    public void setSound(){
        // Get the sound volume
        Debug.Log(txt);

        if (txt!="1"){
            num = double.Parse(txt,CultureInfo.InvariantCulture.NumberFormat);
            num/=Pow(10,txt.Length-2);
        }
        else{
            num=1;
        }
        
        // Set the sound volume
        Debug.Log(num);
        fire.volume = (float)num;
        win.volume = (float)num;
        timeup.volume = (float)num;
        btn.volume = (float)num;
        slider.value = (float)num;
    }
}
