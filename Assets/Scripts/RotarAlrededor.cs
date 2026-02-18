using UnityEngine;

public class RotarAlrededor : MonoBehaviour
{
    // Objeto alrededor del cual va a girar
    public Transform centro;

    // Velocidad de rotación (grados por segundo)
    public float velocidad = 50f;

    // Eje de rotación (por defecto, eje Y)
    public Vector3 eje = Vector3.up;

    void Update()
    {
        if (centro == null) return;

        transform.RotateAround(
            centro.position,
            eje,
            velocidad * Time.deltaTime
        );
    }
}