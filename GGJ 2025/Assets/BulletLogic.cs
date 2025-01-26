using UnityEngine;

public class BulletLogic : MonoBehaviour
{
    [SerializeField] private Vector3 direction = Vector3.forward; // Dirección predeterminada
    [SerializeField] private float speed = 5f; // Velocidad de movimiento

    // Método que mueve el objeto
    public void MoveObject()
    {
        transform.position += direction.normalized * speed * Time.deltaTime;
    }

    // Método opcional para establecer la dirección y la velocidad
    public void SetMovement(Vector3 newDirection, float newSpeed)
    {
        direction = newDirection;
        speed = newSpeed;
    }

    private void Update()
    {
        // Llamamos a MoveObject() para mover el objeto de forma continua
        MoveObject();
    }
}
