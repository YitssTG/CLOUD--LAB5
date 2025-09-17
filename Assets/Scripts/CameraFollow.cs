using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // El objeto que la c�mara va a seguir
    public float smoothSpeed = 0.125f; // Velocidad de suavizado del movimiento
    public Vector3 offset; // Desplazamiento de la c�mara respecto al objetivo

    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset; // Calcula la posici�n deseada de la c�mara
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); // Suaviza el movimiento
        transform.position = smoothedPosition; // Actualiza la posici�n de la c�mara

        transform.LookAt(target); // La c�mara siempre mira al objeto
    }
}
