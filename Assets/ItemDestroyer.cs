using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroyer : MonoBehaviour {
    //unitychanを取得する
    private GameObject unitychan;

    // Use this for initialization
    void Start(){
        //unitychanを取得
        this.unitychan = GameObject.Find("unitychan");
    }
	
	// Update is called once per frame
	void Update () {
        if(this.unitychan.transform.position.z - this.gameObject.transform.position.z > 5) {
            Destroy(this.gameObject);
        }
	}
}
