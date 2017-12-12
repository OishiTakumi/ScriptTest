using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;      // 体力
    private int power = 25;    // 攻撃力
    private int mp = 53;       //mp


    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

    //mp用の関数
    public void Magic()
    {
        Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。" );
        //残りのmpを減らす
        this.mp -= 5;
    }

}

public class Test : MonoBehaviour
{
   　　 private int mp = 53;       //mp

    void Start()
    {
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);
        // mpの関数を呼び出す
        lastboss.Magic();
        for (int i = mp; i < 53; i++)
        {

            if (i >= 5)
            {
                i -= 5;
                Debug.Log("魔法攻撃をした。残りMPは" + i + "。");

            }
            else
            {
                Debug.Log("MPが足りないため魔法が使えない。");
            }

        }
    }
        // Update is called once per frame
        void Update(){


        }
    
}

