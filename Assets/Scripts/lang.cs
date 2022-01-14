using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class lang : MonoBehaviour
{
    string txt;
    int num;
    public AudioSource aud;

    public Text settingLabel;
    public Text langLabel;
    public Text sensLabel;
    public Text musLabel;
    public Text soundLabel;

    public Text supportLabel;
    public Text supportTxt;

    public Text creditLabel;
    public Text creditTxt;

    public Text menuLabel;
    public Text menuBtn;

    public Text playBtn,quitBtn;
    public Text quitLabel,yesBtn,noBtn;

    public Text modeLabel,easieLabel;
    public Text soon1,soon2,soon3;

    public Dropdown drop;

    void Start()
    {
        if (File.Exists(Application.persistentDataPath+"\\lang.txt")==false){
            Debug.Log("no file");
            File.WriteAllText(Application.persistentDataPath+"\\lang.txt","0");
        }
        
        txt = File.ReadAllText(Application.persistentDataPath+"\\lang.txt");

        num=int.Parse(txt);
        drop.value = num;
        setup();
    }

    public void change(){
        File.WriteAllText(Application.persistentDataPath+"\\lang.txt",drop.value.ToString());
        setup();
        aud.Play();
    }

    void setup(){
        if (drop.value==1){
            settingLabel.text="Cài đặt";
            langLabel.text="Ngôn ngữ";
            sensLabel.text="Độ nhạy";
            musLabel.text="Nhạc nền";
            soundLabel.text="Âm thanh";

            supportLabel.text="Hỗ trợ và phản hồi";
            supportTxt.text="Mọi hỗ trợ xin vui lòng liên hệ support.halloie@khanhnguyen.com.\nMọi phản hồi vui lòng liên hệ feedback.halloie@khanhnguyen.com.";

            creditLabel.text="Thông tin";
            creditTxt.text="Trò chơi này được sản xuất bởi KhanhNguyen Software vào 2021. Vui lòng không sao chép nếu không có sự cho phép.\n\nTất cả âm thanh và tài nguyên trong trò chơi đều thuộc về Unity. Vui lòng tham khảo Unity Asset Store để có thêm thông tin.\n\nGhé thăm trang fanpage của chúng tôi: fb.com/khanhnguyen\nCảm ơn bạn đã chơi trò chơi của chúng tôi!";
        
            menuLabel.text = "Tùy chọn";
            menuBtn.text = "Tùy chọn";

            playBtn.text="Chơi game";
            quitBtn.text="Thoát game";

            quitLabel.text="Bạn có chắc muốn thoát game?";
            yesBtn.text="Có";
            noBtn.text="Không";

            modeLabel.text="Chọn chế độ";
            easieLabel.text="Hạ sát con ma trong 3 phút. Thích hợp cho người mới chơi.";
            soon1.text="Sắp có";
            soon2.text="Sắp có";
            soon3.text="Sắp có";
        }
        else if (drop.value==0){
            settingLabel.text="Settings";
            langLabel.text="Language";
            sensLabel.text="Sensitivity";
            musLabel.text="Music";
            soundLabel.text="Sound effect";

            supportLabel.text="Support and feedback";
            supportTxt.text="For any support, please contact via email support.halloie@khanhnguyen.com.\nFor any feedback, please contact via this: feedback.halloie@khanhnguyen.com.";

            creditLabel.text="Information";
            creditTxt.text="This game was made by KhanhNguyen Software in 2021. Please do not copy without any permission.\n\nAll of the sounds and assets in this game belong to Unity. Please refer to Unity Asset Store for more information.\n\nVisit our facebook fanpage: fb.com/khanhnguyen\nThank you for playing our game!";
        
            menuLabel.text = "Menu";
            menuBtn.text = "Menu";

            playBtn.text="Play game";
            quitBtn.text="Quit game";

            quitLabel.text="Are you sure to quit game?";
            yesBtn.text="Yes";
            noBtn.text="No";

            modeLabel.text="Choose a mode";
            easieLabel.text="Kill the ghost in 3 mins. Suitable for beginners.";
            soon1.text="Coming soon";
            soon2.text="Coming soon";
            soon3.text="Coming soon";
        }
    }
}
