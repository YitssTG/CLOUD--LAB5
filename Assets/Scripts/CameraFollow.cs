using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // El objeto que la cámara va a seguir
    public float smoothSpeed = 0.125f; // Velocidad de suavizado del movimiento
    public Vector3 offset; // Desplazamiento de la cámara respecto al objetivo

    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset; // Calcula la posición deseada de la cámara
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); // Suaviza el movimiento
        transform.position = smoothedPosition; // Actualiza la posición de la cámara

        transform.LookAt(target); // La cámara siempre mira al objeto
    }
}
