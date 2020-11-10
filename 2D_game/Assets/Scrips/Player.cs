using UnityEngine;
using UnityEngine.UI; //引用 使用者介面

public class Player : MonoBehaviour
{
    //語法:
    //修飾詞 類型 名稱 (指定 值);
    public GameObject final;

    //道具數量
    public Text textCount;
    //數量
    public int count;

    //碰撞偵測條件
    //兩個collider(碰撞)   一個rigidbody(鋼體)
    private void OnTriggerEnter2D(Collider2D collision)//collision儲存碰撞資訊
    {

        if (collision.name == "door")
        {
            final.SetActive(true);
        }
        //print("碰到傳送門");
        //final.SetActive(true);


        //如果碰到物件的標籤是櫻桃
        if (collision.tag == "櫻桃")
        {
            //刪除(碰到的遊戲物件)
            Destroy(collision.gameObject);

            //遞增
            count++;
            //道具數量的文字 = "櫻桃數量:" + 數量
            textCount.text = "櫻桃數量:" + count;
        }
    }
}
