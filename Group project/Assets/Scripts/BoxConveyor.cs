using UnityEngine;

public class BoxConveyor : MonoBehaviour
{

    public float distanceZ = 1.0f;
    public float speed = 2.0f;

    private Vector3 targetPosition;
    private bool isMoving = false;

    private void Update()
    {
        if (isMoving)
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                targetPosition,
                speed * Time.deltaTime
                );
        }

        if (Vector3.Distance(transform.position, targetPosition) < 0.001f)
        {
            transform.position = targetPosition;
            isMoving = false;
        }
    }
        public void StartMoving()
    {
        // Prevent spamming the button while it's already sliding
        if (!isMoving)
        {
            targetPosition = transform.position + new Vector3(0f, 0f, distanceZ);
            isMoving = true;
        }
    }

}
