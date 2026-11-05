using UnityEngine;
using UnityEngine.InputSystem;

public class playerMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 5f;
    [SerializeField] InputActionReference moveAction;

    void OnEnable()
    {
        moveAction.action.Enable();
    }

    void OnDisable()
    {
        moveAction.action.Disable();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 move = moveAction.action.ReadValue<Vector2>();
        rb.linearVelocity = move * moveSpeed;
    }
}
