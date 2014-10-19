using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    float speed = 25.0f;

    public Rigidbody TempBasketball;
    public Transform hand;
    Rigidbody Basketball;
    float angles;
    float speedX, speedY;
    //bool CanControl = true;
    public static bool isPlay = true;

    // Use this for initialization
    void Start ()
    {
        Basketball = Instantiate (TempBasketball, hand.position, hand.rotation) as Rigidbody;
        Basketball.transform.parent = hand;
        Basketball.rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update ()
    {
        if (isPlay) {
            gameObject.transform.RotateAround (
            new Vector3 (0.09215456f, -0.8153586f, 3.342688f),
            new Vector3 (0, 1.0f, 0),
            speed * Time.deltaTime * Input.GetAxis ("Horizontal"));
            if (Input.GetButtonDown ("Play")) {
                gameObject.animation.PlayQueued ("aim");
            }
        //else if(Input.GetButtonUp("Play") && CanControl)
        else if (Input.GetButtonUp ("Play")) {
                gameObject.animation.PlayQueued ("fire");
                Basketball.transform.parent = null;
                Basketball.rigidbody.useGravity = true;
                angles = gameObject.transform.eulerAngles.y - 200;
                speedX = -3.3f * Mathf.Tan (angles * Mathf.Deg2Rad);
                speedY = -6.0f * Mathf.Cos (angles * Mathf.Deg2Rad);
                Basketball.rigidbody.velocity = new Vector3 (speedX, 3.3f, speedY);
                StartCoroutine (MakeNextBall (hand, 1.0f));
                StartCoroutine (DestroyPreviouwsBall (Basketball, 5.0f));
                gameObject.animation.PlayQueued ("idle");
                //CanControl = false;
            }
            //CanControl = true;
        }
    }

    IEnumerator MakeNextBall (Transform Pos, float time)
    {
        yield return new WaitForSeconds (time);
        Basketball = Instantiate (TempBasketball, hand.position, hand.rotation) as Rigidbody;
        Basketball.transform.parent = hand;
        Basketball.rigidbody.useGravity = false;
        //CanControl = true;
    }

    IEnumerator DestroyPreviouwsBall (Rigidbody ball, float time)
    {
        yield return new WaitForSeconds (time);
        Destroy (ball.gameObject);
    }
}
