using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RensoArrayScript : MonoBehaviour {

    /*
    //配列の宣言例
    Dictionary<string, int> a = new Dictionary<string, int>();

    //配列の初期化
    Dictionary<string, int> a = new Dictionary<string, int>(){
        {"item1",8},
        {"item2",4},
        {"block1",12}
    };

    //配列の要素数
    a.Count;

    //要素の追加、上書き
    a["item1"] = 3;
    a["item1"] = 3;

    //要素の参照
    a["item1"]

    //要素の消去
    a.Remove("item1");
    a.Clear();

    */

    // Use this for initialization
    void Start()
    {

    }

    Dictionary<string, int> scores = new Dictionary<string, int>()
    {
        {"taro",0},
        {"jiro",0}

    };

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            scores["taro"]++;
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            scores["jiro"]++;
        }

        foreach (KeyValuePair<string, int> s in scores)
        {
            Debug.Log(s.Key + " " + s.Value);
        }

    }
}
