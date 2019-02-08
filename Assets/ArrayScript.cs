using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayScript : MonoBehaviour {
    /*
    //配列の宣言例
    int[] a = new int[10];
    float a = new float[10];
    string a = new string[10];

    //配列の初期化
    int[] a = new int[] { 1, 5, 2, 3 };
    float[] a = new float { 1f, 2f, 43.3f };
    string[] a = new string { "abc", "ddd", "ggg" };

    //配列の要素数
    a.Length
     */

     /*
     //可変長配列 配列の中身を増やしたり、減らしたりすることができる
    //配列の宣言例
    List<int> a = new List<int>();
    Light<string> b = new List<string>();

    //配列の初期化
    List<int> b = new List<int>(){
        1,2,3
    };
    List<string> b = new List<string>(){
        "a","b","c"
    };

    //配列の要素数
    a.Count

     //要素の追加
     a.Add(3);
    a.Insert(2,1);

    //要素の参照、上書き
    a[0]=1;

    //要素の消去
    a.Remove(1);
    a.RemoveAt(1);
    a.Clear();
    */

    // Use this for initialization
    void Start () {

        List<int> a = new List<int>{
            1,2,3
        };
        int sum = 0;
        foreach(int c in a){
            sum += c;
        }
        Debug.Log(sum);

        a.Add(4);
        a.Add(5);
        sum = 0;
        foreach(int c in a){
            sum += c;
        }
        Debug.Log(sum);
        /*
        int[] a = new int[]{

            1,2,3,4,5
        };

        int sum = 0;
       //for (int cnt = 0; cnt < a.Length;cnt++){
        foreach(int c in a){
            if (c % 2 == 0)
            {
                sum += c;
            }

        }
        Debug.Log(sum);
*/


    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
