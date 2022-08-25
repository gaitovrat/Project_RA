using UnityEngine;

namespace Assets.Scripts
{
    public class MoveManager : MonoBehaviour
    {

        private void Start()
        {
            
            if (!TryGetComponent<Rigidbody>(out var rigidbody))
            {
                _baseMove = new AxisTransformMove(transform, _speed);
            } else
            {
                _baseMove = new AxisRigidbodyMove(rigidbody, _speed);
            }
        }

        private void FixedUpdate()
        {
            if (_baseMove != null)
            {
                _baseMove.Move();
            }
        }

        [SerializeField]
        private float _speed;
        private IMove _baseMove;
    }
}
