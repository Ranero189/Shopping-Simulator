using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreTrigger : MonoBehaviour
{
    public int pointsToAdd = 1;
    public Text scoreText;
    public AudioClip music;
    private bool isPlayerOnTrigger = false;
    private float timer = 5.0f;

    void Update()
    {
        if(isPlayerOnTrigger){
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                AudioSource.PlayClipAtPoint(music, transform.position);
                timer = 5.0f;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isPlayerOnTrigger = true;
            StartCoroutine(AddPoints());
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isPlayerOnTrigger = false;
            StopCoroutine(AddPoints());
        }
    }

    IEnumerator AddPoints()
    {
        while (isPlayerOnTrigger)
        {
            yield return new WaitForSeconds(5);
            int currentScore = int.Parse(scoreText.text);
            currentScore += pointsToAdd;
            scoreText.text = currentScore.ToString();
        }
    }
}
