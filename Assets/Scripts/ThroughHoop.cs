using UnityEngine;
using System.Collections;

public class ThroughHoop : MonoBehaviour {
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "prefabBasketball(Clone)")
        {
            Debug.Log("hit");
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
