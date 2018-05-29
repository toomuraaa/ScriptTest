using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化
        int[] array = { 10, 13, 32, 23, 14 };



        //for文を使い、配列の各要素の値を逆順に表示
        for (int i = 4; i >= 0; i--) { Debug.Log(array[i]); }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
