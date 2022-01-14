using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class langEasie : MonoBehaviour
{
    string txt;
    public Text control;

    public Text sensLabel;
    public Text musLabel;
    public Text soundLabel;

    public Text pauseLabel;
    public Text resumeLabel;
    public Text againLabel;
    public Text quitLabel;

    public Text win,timeup;
    public Text again1,again2,quit1,quit2;

    void Start()
    {        
        txt = File.ReadAllText(Application.persistentDataPath+"\\lang.txt");
        setup();
    }

    void setup()
    {
        if (txt=="0"){
            control.text="Press Q to pause game";

            sensLabel.text="Sensitivity";
            musLabel.text="Music";
            soundLabel.text="Sound effect";

            pauseLabel.text="Paused";
            resumeLabel.text="Resume";
            againLabel.text="Play again";
            quitLabel.text="Quit game";

            win.text="YOU WIN!";
            timeup.text="TIME'S UP!";

            again1.text="Play again";
            again2.text="Try again";
            quit1.text="Quit to lobby";
            quit2.text="Quit game";
        }
        else if (txt=="1"){
            control.text="Nhấn Q để tạm dừng game";

            sensLabel.text="Độ nhạy";
            musLabel.text="Nhạc nền";
            soundLabel.text="Âm thanh";

            pauseLabel.text="Đã tạm dừng";
            resumeLabel.text="Tiếp tục";
            againLabel.text="Chơi lại";
            quitLabel.text="Thoát game";

            win.text="BẠN ĐÃ THẮNG!";
            timeup.text="ĐÃ HẾT GIỜ!";

            again1.text="Chơi lại";
            again2.text="Thử lại";
            quit1.text="Thoát về sảnh";
            quit2.text="Thoát game";
        }
    }
}
