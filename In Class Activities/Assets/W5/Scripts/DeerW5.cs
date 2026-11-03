using UnityEngine;
using UnityEngine.AI;

public class Deer : MonoBehaviour
{
    [SerializeField] private GameObject _target;

    [SerializeField] private float _speed;      // Added to allow the developer to set the speed to extremely small numbers like 0.01
    private NavMeshAgent _Agent;

    private void Start()
    {
        Debug.Log("Started");
        _Agent = gameObject.GetComponent<NavMeshAgent>();

        Debug.Assert(_Agent != null, "Cannot fetch the navigation mesh agent from the Deer.");  // Throws an error IN CASE you dont know. An advanced potato could probably run Unity.
        _Agent.SetDestination(_target.transform.position);
    }

    private void Update()
    {
        _Agent.speed = _speed;
    }
}


// Write your DeerW5 class in here :)
// Hint: if you don't remember what a class is supposed to look like,
//      maybe check out CatW5...
// If you copied the class declaration from CatW5, you'd only need to change one thing...