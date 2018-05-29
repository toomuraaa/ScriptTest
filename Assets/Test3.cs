using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
    private int hp = 100;       //体力
    private int power = 25;     //攻撃力
    private int mp = 53;　　　　//mp

    //攻撃用の関数
    public void Attack() {
        Debug.Log(this.power + "のダメージを与えた");
    }
    //防御用の関数
    public void Defene(int damage) {
        Debug.Log(damage + "のダメージを受けた");
        //残りhpを減らす
        this.hp -= damage;
    }
    //魔法攻撃用の関数
    public void Magic(int loss) {
        //残りmpを減らす
        if (this.mp >= loss) {
            //魔法攻撃を実行
            this.mp -= loss;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        } else{
            //mp不足で魔法子攻撃実行不可
            Debug.Log("MPが足りないため魔法が使えない。"); }
        
    }
}
public class Test3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        //攻撃用の関数を呼び出す
        lastboss.Attack();
        //防御用の関数を呼び出す
        lastboss.Defene(3);
        //魔法攻撃用の関数を10回呼び出す
        for (int i = 0; i < 10; i++) { 
            lastboss.Magic(5);
        }
        //Magic関数を10回使った後に、更にMagic関数を呼び出す
        lastboss.Magic(5);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
