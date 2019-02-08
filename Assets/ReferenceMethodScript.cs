using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReferenceMethodScript : MonoBehaviour {

    int Dance(out int b){
        //outの場合下の行がなければエラー
        //method側が値を決めるもの
        b = 1;
        return 0;
    }
    int Dances(ref int b){
        return 0;
    }
	// Use this for initialization
	void Start () {
        //refの場合、呼び出し側が値を指定するもの
        int a = 0;
        //int suc = Dance(out a);

        int suc = Dances(ref a);
        Debug.Log(a);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
