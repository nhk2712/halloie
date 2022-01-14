using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Math;
using System.Globalization;
using UnityEngine.UI;
using System.IO;

public class getSens : MonoBehaviour
{
    string txt;
    double num;
    public Slider slider;

    void Start()
    {
        if (File.Exists(Application.persistentDataPath+"\\sens.txt")==false){
            Debug.Log("no file");
            File.WriteAllText(Application.persistentDataPath+"\\sens.txt","0,5");
        }
        
        txt = File.ReadAllText(Application.persistentDataPath+"\\sens.txt");
        setSens();
    }

    void setSens(){
        Debug.Log(txt);

        if (txt!="1"){
            num = double.Parse(txt,CultureInfo.InvariantCulture.NumberFormat);
            num/=Pow(10,txt.Length-2);
        }
        else{
            num=1;
        }
        
        Debug.Log(num);
        slider.value = (float)num;
        FindObjectOfType<movementM>().spd=(float)num;
    }

    public void change(){
        FindObjectOfType<movementM>().spd=slider.value;
        File.WriteAllText(Application.persistentDataPath+"\\sens.txt",slider.value.ToString());
    }
}
