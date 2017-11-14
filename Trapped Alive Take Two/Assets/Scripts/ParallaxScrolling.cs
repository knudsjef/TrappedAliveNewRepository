using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxScrolling : MonoBehaviour {

    [SerializeField]
    Rigidbody2D playerRigid;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = new Vector2(this.transform.position.x + 0.01f * playerRigid.velocity.x, this.transform.position.y + 0.01f * playerRigid.velocity.y);
	}
}
