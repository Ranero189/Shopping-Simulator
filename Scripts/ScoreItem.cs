using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Animations;
public class ScoreItem : MonoBehaviour, IDropHandler
{
    public int pointsToAdd = 1;
    public string boolTrue;
    public string boolFalse;
    public string boolFalse1;
    public Animator playerAnimator;
    public Text scoreText;
    public Transform parentObject1;
    public Transform parentObject2;
    public Transform parentObject3;
    public Transform parentObject4;
    public Transform parentObject5;

    public void OnDrop(PointerEventData eventData)
    {
        // Get the object being dragged
        Transform objectBeingDragged = eventData.pointerDrag.transform;

        // Check if the object is being dropped on parentObject1
        if (objectBeingDragged.parent == parentObject1)
        {
            int currentScore = int.Parse(scoreText.text);
            currentScore -= pointsToAdd;
            scoreText.text = currentScore.ToString();
            playerAnimator.SetBool(boolFalse, false);
            playerAnimator.SetBool(boolFalse1, false);
            playerAnimator.SetBool(boolTrue, true);
            
        }
        // Check if the object is being dropped on parentObject2
        if (objectBeingDragged.parent == parentObject2)
        {
            int currentScore = int.Parse(scoreText.text);
            currentScore -= pointsToAdd;
            scoreText.text = currentScore.ToString();
            
        }

        // Check if the object is being dropped on parentObject3
        else if (objectBeingDragged.parent == parentObject3)
        {
            int currentScore = int.Parse(scoreText.text);
            currentScore += pointsToAdd;
            scoreText.text = currentScore.ToString();
        }

        // Check if the object is being dropped on parentObject4
        else if (objectBeingDragged.parent == parentObject4)
        {
            int currentScore = int.Parse(scoreText.text);
            currentScore += pointsToAdd;
            scoreText.text = currentScore.ToString();
        }
        // Check if the object is being dropped on parentObject5
        else if (objectBeingDragged.parent == parentObject5)
        {
            int currentScore = int.Parse(scoreText.text);
            currentScore += pointsToAdd;
            scoreText.text = currentScore.ToString();
        }
    }
}


