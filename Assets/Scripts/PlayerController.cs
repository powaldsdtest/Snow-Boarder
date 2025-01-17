using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] InputAction movement;
    [SerializeField] float torqueSpeed = 5f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void OnEnable()
    {
        movement.Enable();
    }

    void OnDisable()
    {
        movement.Disable();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Application.Quit();
        }
        float horizonatlFlow = movement.ReadValue<Vector2>().x;
        rb.AddTorque(-horizonatlFlow * ( torqueSpeed * Time.deltaTime));
    }
}
