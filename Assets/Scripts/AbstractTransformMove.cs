using UnityEngine;

namespace Assets.Scripts
{
    public abstract class AbstractTransformMove : IMove
    {
        public AbstractTransformMove(Transform transform, float speed)
        {
            _transform = transform;
            _speed = speed;
        }

        public void Move(float x, float y, float z)
        {
            _transform.position += new Vector3(x, y, z);
        }

        public float X => _transform.position.x;
        public float Y => _transform.position.y;
        public float Z => _transform.position.z;

        public abstract void Move();

        private Transform _transform;
        private float _speed;
    }
}
