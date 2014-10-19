<<<<<<< Upstream, based on origin/master
﻿using UnityEngine;
using System.Collections;

public class HoopMove : MonoBehaviour
{
    public float speed = 0.3f;
    bool moveLeft = true;

    // Use this for initialization
    void Start ()
    {
	
    }

    // Update is called once per frame
    void Update ()
    {
        if (Player.isPlay) {
            if (moveLeft)
                transform.Translate (-Vector3.left * speed * Time.deltaTime);
            else
                transform.Translate (Vector3.left * speed * Time.deltaTime);

            if (transform.position.x > 2.92)
                moveLeft = false;
            if (transform.position.x < -2.92)
                moveLeft = true;
        }
	
    }
}
=======
﻿using UnityEngine;
using System.Collections;

public class HoopMove : MonoBehaviour
{
    public float speed = 0.3f;
    bool moveLeft = true;

    // Use this for initialization
    void Start ()
    {
	
    }
	
    // Update is called once per frame
    void Update ()
    {
        if (Player.isPlay) {
            if (moveLeft)
                transform.Translate (-Vector3.left * speed * Time.deltaTime);
            else
                transform.Translate (Vector3.left * speed * Time.deltaTime);

            if (transform.position.x > 2.92)
                moveLeft = false;
            if (transform.position.x < -2.92)
                moveLeft = true;
        }
    }
}
>>>>>>> 103514c 修正风格
