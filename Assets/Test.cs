using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        // 配列を初期化する
        int[] array = new int[5];

        //配列の各要素に値を代入する
        array[0] = 10;
        array[1] = 20;
        array[2] = 30;
        array[3] = 40;
        array[4] = 50;

        //配列をすべて表示する
        for (int i = array. Length -1 ; 0<=i; i--)
        {          
            Debug.Log(array[i]);
        }
    }

   
    // Update is called once per frame
    void Update () {
		
	}
}
