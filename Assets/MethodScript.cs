using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodScript : MonoBehaviour {

    void Right(Dictionary<string,int> cond){
        if (cond["right"] != 1)
        {
            Debug.Log("右手をあげる");
            cond["right"] = 1;
        }
        if (cond["left"] != -1)
        {
            Debug.Log("左手を下げる");
            cond["left"] = -1;
        }
    }
    void Left(Dictionary<string,int> cond){
        if (cond["right"] != -1)
        {
            Debug.Log("右手を下げる");
            cond["right"] = -1;
        }
        if (cond["left"] != 1)
        {
            Debug.Log("左手をあげる");
            cond["left"] = 1;
        }
    }
    void Both(Dictionary<string,int> cond){
        if (cond["right"] != 1)
        {
            Debug.Log("右手をあげる");
            cond["right"] = 1;
        }
        if (cond["left"] != 1)
        {
            Debug.Log("左手をあげる");
            cond["left"] = 1;
        }
    }
	// Use this for initialization
	void Start () {

        Dictionary<string, int> cond = new Dictionary<string, int>(){
            {"right",0},
            {"left",0},
        };

        foreach(KeyValuePair<string,int> c in cond){
            Debug.Log(c.Key + ":" + c.Value);
        }

        Both(cond);
        Debug.Log("最初の状態に戻す");

        Left(cond);




    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
