using UnityEngine;

public class ObjectAppear : MonoBehaviour
{
    public GameObject objectToAppear; // Referência para o objeto que deve aparecer
    public float time;
    void Start()
    {
        // Inicia a chamada recursiva da função "Appear"
        InvokeRepeating("Appear", 0f, time);
    }

    void Appear()
    {
        // Ativa o objeto
        objectToAppear.SetActive(true);

        // Inicia a chamada recursiva da função "Disappear"
        Invoke("Disappear", 1.5f);
    }

    void Disappear()
    {
        // Desativa o objeto
        objectToAppear.SetActive(false);
    }
}