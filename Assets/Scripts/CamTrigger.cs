using UnityEngine;

public class CamTrigger : MonoBehaviour
{
    public Transform newTarget;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            CamScript cam = Camera.main.GetComponent<CamScript>();
            if (cam != null && newTarget != null)
            {
                cam.SetNewTarget(newTarget);
            }
        }
    }
}
