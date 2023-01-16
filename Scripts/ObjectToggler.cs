using UnityEngine;

public class ObjectToggler : MonoBehaviour
{
    public AudioClip music;
    public GameObject objectToToggle;
    private bool isObjectVisible = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            AudioSource.PlayClipAtPoint(music, Vector3.zero);
            isObjectVisible = !isObjectVisible;
            objectToToggle.SetActive(isObjectVisible);
        }
    }
}