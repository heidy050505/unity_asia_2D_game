using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    //按鈕透過方法(函式，功能)跟程式溝通
    //語法:類型 方法名稱(){}
    //void無類型
    //修飾詞:public 公開    private 私人
    public void GameStart()
    {
        print("開始遊戲");
        SceneManager.LoadScene("背景");    //字串
        //SceneManager.LoadScene(1);    //int
    }
    public void GameQuit()
    {
        print("結束遊戲");
        Application.Quit();
    }
}
