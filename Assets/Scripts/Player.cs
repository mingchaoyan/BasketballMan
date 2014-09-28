using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    float speed = 25.0f;

    public Rigidbody TempBasketball;
    public Transform hand;
    Rigidbody Basketball;

	// Use this for initialization
	void Start () {
        Basketball = Instantiate(TempBasketball, hand.position, hand.rotation) as Rigidbody;
        Basketball.transform.parent = hand;
        Basketball.rigidbody.useGravity = false;
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.RotateAround(
            new Vector3(0.09215456f, -0.8153586f, 3.342688f),
            new Vector3(0, 1.0f, 0),
            speed*Time.deltaTime*Input.GetAxis("Horizontal"));
        if(Input.GetButtonDown("Play"))
        {
            gameObject.animation.PlayQueued("aim");
        }
        else if(Input.GetButtonUp("Play"))
        {
            gameObject.animation.PlayQueued("fire");
            Basketball.transform.parent = null;
            gameObject.animation.PlayQueued("idle");
        }
	
	}
}
