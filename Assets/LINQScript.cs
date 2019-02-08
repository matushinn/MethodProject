using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class LINQScript : MonoBehaviour {

    /*
//以下のものをクリアして新しい配列を作る

    //合計、平均、最大、最小
    Sum,Average,Max,Min

    //データを交換してコピーする
    Select

    //データを選択する
    Where

    //データをソートする
    OrderBy

        */
	// Use this for initialization
	void Start () {
        Dictionary<string, int> scores = new Dictionary<string, int>()
        {
            {"taro",1},
            {"jiro",2},
            {"sabu",3}
        };

        /*
        int sum = 0;
        foreach(KeyValuePair<string,int> v in scores){
            sum += v.Value;

        }
        */
        int sum = scores.Sum((v) =>  v.Value );
        Debug.Log(sum);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
