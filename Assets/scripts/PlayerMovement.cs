using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private float _speed;
    private Vector2 _PlayerPosition = Vector2.zero;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    private void OnEnable()
    {
        EventsHolder.ON_INPUTS += OnMovement;
    }

    private void OnDisable()
    {
        EventsHolder.ON_INPUTS -= OnMovement;
    }

    private void OnMovement(Vector2 _Input)
    {

        _PlayerPosition = _Input;

    }

    private void FixedUpdate()
    {
        _rb.MovePosition(_rb.position + _PlayerPosition * _speed);
    }
}
