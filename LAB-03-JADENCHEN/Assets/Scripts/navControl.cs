using UnityEngine;
using UnityEngine.AI;

public class navControl : MonoBehaviour
{
    private NavMeshAgent _agent;
    private Animator _animator;
    private bool _isWalking;
    
    [SerializeField] private Transform target;
    [SerializeField] private Transform boss;
    
    [SerializeField] private float moveSpeed;
    [SerializeField] private float animSpeed;
    
    private static readonly int Attack = Animator.StringToHash("attack");
    private static readonly int Walk = Animator.StringToHash("walk");
    
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _animator = GetComponent<Animator>();

        _isWalking = true;
        _animator.SetTrigger(Walk);
    }

    void Update()
    {
        SpeedControl();
        HandleMovement();
    }

    private void SpeedControl()
    {
        _agent.speed = moveSpeed;
        _animator.speed = animSpeed;
    }

    private void HandleMovement()
    {
        if (_isWalking)
            _agent.destination = target.transform.position;
        else
        {
            _agent.destination = transform.position;
            transform.LookAt(boss);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("boss"))
        {
            _isWalking = false;
            _animator.SetTrigger(Attack);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("boss"))
        {
            _isWalking = true;
            _animator.SetTrigger(Walk);
        }
    }
}
