using UnityEngine;
using System.Collections;

public class win : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        // 如果是玩家进入
        if (col.tag == "Player")
        {
            // ... 播放动画
           
            Debug.Log("xxx");
            Application.LoadLevel(2);
            //GetComponent<Sprite Renderer>().enabled = true;
        }
    }
}