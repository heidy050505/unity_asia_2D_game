using UnityEngine;
using UnityEngine.SceneManagement;

public class levelManager : MonoBehaviour
{
    //(參數1, 參數2, 參數3,...,參數N)
    //語法
    //類型 名稱
    public void Nextlevel(string nameLV)
    {
        SceneManager.LoadScene(nameLV);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("選單");
    }

    public void Quit()
    {
        Application.Quit();
     }
}
