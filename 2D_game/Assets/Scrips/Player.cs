using UnityEngine;

public class Player : MonoBehaviour
{
    //語法:
    //修飾詞 類型 名稱 (指定 值);
    public GameObject final;

    //碰撞偵測條件
    //兩個collider(碰撞)   一個rigidbody(鋼體)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("碰到傳送門");
        final.SetActive(true);
    }
}
