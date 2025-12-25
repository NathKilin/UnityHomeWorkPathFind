using UnityEngine;

public class BoxMoveSideToSide : MonoBehaviour
{
    private float _edge = 5 , _dir = 1 , _speed = 2;
    
    void Update()
    {
        transform.position = new Vector3(transform.position.x + _dir * _speed * Time.deltaTime, transform.position.y, transform.position.z);
        if (transform.position.x >= _edge || transform.position.x <= -_edge)
        {
            _dir *= -1;
        }
    }
}
