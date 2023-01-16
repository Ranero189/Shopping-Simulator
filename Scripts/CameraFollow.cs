using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // O objeto que a câmera deve seguir
    public float smoothing = 5f; // A suavidade com que a câmera segue o alvo

    Vector3 offset; // A distância entre a câmera e o jogador

    void Start()
    {
        // Calcula a distância inicial entre a câmera e o jogador
        offset = transform.position - target.position;
    }

    void FixedUpdate()
    {
        // Calcula a posição desejada da câmera com base na posição do jogador
        Vector3 targetCamPos = target.position + offset;

        // Move a câmera suavemente para a posição desejada
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
    }
}
