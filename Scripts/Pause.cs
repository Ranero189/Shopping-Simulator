using UnityEngine;

public class Pause : MonoBehaviour
{
    public AudioClip music;
    public GameObject objectToActivate;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1)
            {
                AudioSource.PlayClipAtPoint(music, Vector3.zero);
                objectToActivate.SetActive(true);
                Time.timeScale = 0;
            }
            else
            {
                objectToActivate.SetActive(false);
                Time.timeScale = 1;
                AudioSource.PlayClipAtPoint(music, Vector3.zero);
            }
        }
    }
}
