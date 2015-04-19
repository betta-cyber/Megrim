using UnityEngine;
using System.Collections;

public class run : MonoBehaviour {
    private Animator anim;
    public float speed;
    public AudioClip[] walk;
    private CharacterController controller;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 horizontalVelocity = controller.velocity;
        horizontalVelocity = new Vector3(controller.velocity.x, 0, controller.velocity.z);
		float horizontalSpeed = horizontalVelocity.magnitude;

        anim.SetFloat("speed", Mathf.Abs(horizontalSpeed));
        //if (horizontalSpeed != 0)
        //{
            //AudioSource.PlayClipAtPoint(walk[0], transform.position);
        //}

	}
    void OnTriggerEnter2D(Collider2D col)
    {
        // 如果是玩家进入
        if (col.tag == "win")
        {
            // ... 播放动画
            Application.LoadLevel(0);
            Debug.Log("xxx");
            //GetComponent<Sprite Renderer>().enabled = true;
        }
    }
}