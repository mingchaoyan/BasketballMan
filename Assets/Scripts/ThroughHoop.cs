using UnityEngine;
using System.Collections;

public class ThroughHoop : MonoBehaviour {
    public static int score = 0;
    int timeLength = 10;
    int timeLeft = 10;
    float totalTime = 0;
    bool showEndbutton = false;
    bool isPlay = true;

    void Update()
    {
        if (isPlay)
        {
            totalTime += Time.deltaTime;
            if (timeLeft > 0)
                timeLeft = (int)(timeLength - totalTime);
            else if (timeLeft == 0)
            {
                isPlay = false;
                Player.isPlay = false;
                StartCoroutine(delayForSometime(5.0f));
            }
        }
    }

    IEnumerator delayForSometime(float time)
    {
        yield return new WaitForSeconds(time);
        showEndbutton = true;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "prefabBasketball(Clone)")
        {
            score += 2;
        }
    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), "Time Left:" + timeLeft.ToString()); 
        GUI.Label(new Rect(10, 30, 100, 20), "Score:" + score.ToString());
        if (showEndbutton)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 50, 100, 40), "Restart Game"))
            {
                showEndbutton = false;
                Player.isPlay = true;
                isPlay = true;
                totalTime = 0;
                timeLeft = timeLength;
                score = 0;
            }
            if(GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2, 100, 40), "Exit Game"))
            {
                Application.Quit();
            }
        }
    }

}
