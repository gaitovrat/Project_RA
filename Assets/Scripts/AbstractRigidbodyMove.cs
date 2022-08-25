using UnityEngine;

namespace Assets.Scripts
{
    public abstract class AbstractRigidbodyMove : IMove
    {
        public AbstractRigidbodyMove(Rigidbody rigidbody, float speed)
        {
            _speed = speed;
            _rigidbody = rigidbody;
        }

        public void Move(float x, float y, float z)
        {
            _rigidbody.velocity = new Vector3(x, y, z) * _speed;
        }

        public float X => _rigidbody.velocity.x;
        public float Y => _rigidbody.velocity.y;
        public float Z => _rigidbody.velocity.z;
        
        public abstract void Move();

        private float _speed;
        private Rigidbody _rigidbody;
    }
}
