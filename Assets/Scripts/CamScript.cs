using UnityEngine;

public class CamScript : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.3f;

    private void LateUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = new Vector3(target.position.x, target.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        }
    }

    public void SetNewTarget(Transform newTarget)
    {
        target = newTarget;
    }
}
