using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;

    public float speed;
    public GameObject bulletPrefab;
    public float bulletForce;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 moveVector = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(moveVector * speed);

        float angle = Mathf.Atan2(moveVertical, moveHorizontal) * Mathf.Rad2Deg;
        Vector3 rotation = new Vector3(0, angle+90, 0);
        transform.eulerAngles = rotation;
    }

    void OnShoot(InputValue value)
    {
        print("Shoot is called! (Space bar has been pressed)");
    }

}
