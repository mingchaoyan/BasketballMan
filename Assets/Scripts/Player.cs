using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //if (Input.GetKeyDown(KeyCode.A))
        if(Input.GetButtonDown("Play"))
        {
            gameObject.animation.PlayQueued("aim");
        }
        //else if (Input.GetKeyUp(KeyCode.A))
        else if(Input.GetButtonUp("Play"))
        {
            gameObject.animation.PlayQueued("fire");
            gameObject.animation.PlayQueued("idle");
        }
	
	}
}
