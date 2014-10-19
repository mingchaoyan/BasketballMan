using UnityEngine;
using System.Collections;

public class HoopSound : MonoBehaviour
{
    public AudioClip hitSound;
    void OnCollisionEnter (Collision collision)
    {
        AudioSource.PlayClipAtPoint (hitSound, new Vector3 (0, 0, 6));
    }
}
