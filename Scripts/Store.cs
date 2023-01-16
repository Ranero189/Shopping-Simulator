using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Store : MonoBehaviour
{
    public AudioClip music;
    public GameObject objectToToggle;
    public GameObject objectToToggle2;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(music, transform.position);
        objectToToggle.SetActive(true);
        objectToToggle2.SetActive(true);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(music, transform.position);
        objectToToggle.SetActive(false);
        objectToToggle2.SetActive(false);
    }
}
