using UnityEngine;

public class MoveController : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float gravity;
    private CharacterController character;
    private void Start()
    {
        character = GetComponent<CharacterController>();
    }
    private void Update()
    {
        Rotate();
        Move();
        UseFakeGravity();
    }
    private void UseFakeGravity()
    {
        character.Move(Vector3.down * gravity * Time.deltaTime);
    }
    private void Rotate()
    {
        Vector3 direction = Vector3.up * Input.GetAxis("Mouse X");
        transform.Rotate(direction * rotationSpeed * Time.deltaTime);
    }

    private void Move()
    {
        Vector3 direction = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
            direction += transform.forward;
        if (Input.GetKey(KeyCode.S))
            direction += -transform.forward;
        if (Input.GetKey(KeyCode.A))
            direction += -transform.right;
        if (Input.GetKey(KeyCode.D))
            direction += transform.right;

        character.Move(direction * moveSpeed * Time.deltaTime);
    }
}
