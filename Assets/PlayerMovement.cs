using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;

    [Header("Shooting")]
    public GameObject fireballPrefab;
    public Transform firePoint;
    public float fireballSpeed = 10f;
    public float fireRate = 0.5f;
    private float nextFireTime;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // Debug check for missing components
        if (fireballPrefab == null) Debug.LogError("Fireball prefab not assigned!");
        if (firePoint == null) Debug.LogError("FirePoint not assigned!");
        if (fireballPrefab != null && fireballPrefab.GetComponent<Rigidbody2D>() == null)
            Debug.LogError("Fireball prefab needs a Rigidbody2D!");
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (Input.GetMouseButton(0) && Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + fireRate;
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement.normalized * moveSpeed * Time.fixedDeltaTime);
    }

    void Shoot()
    {
        if (fireballPrefab == null || firePoint == null) return;

        // Get mouse position in world coordinates (2D space)
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;

        // Calculate direction
        Vector2 direction = (mousePos - firePoint.position).normalized;

        // Create fireball
        GameObject fireball = Instantiate(fireballPrefab, firePoint.position, Quaternion.identity);

        // Set velocity - IMPORTANT PART
        Rigidbody2D fireballRb = fireball.GetComponent<Rigidbody2D>();
        if (fireballRb != null)
        {
            fireballRb.velocity = direction * fireballSpeed;
        }
        else
        {
            Debug.LogError("Fireball has no Rigidbody2D!");
            Destroy(fireball);
            return;
        }

        // Rotate fireball to face direction
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        fireball.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        Debug.Log("Fireball spawned with velocity: " + fireballRb.velocity);
    }
}