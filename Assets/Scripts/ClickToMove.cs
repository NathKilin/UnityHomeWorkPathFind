using UnityEngine;

using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

public class ClickToMove : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent; 
    [SerializeField] private Camera cam;
    
    public void OnClickToMove()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame) // Left click
        {
            Ray ray = cam.ScreenPointToRay(Mouse.current.position.ReadValue());
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }
        }
    }
}
