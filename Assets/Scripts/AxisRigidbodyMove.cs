using UnityEngine;

namespace Assets.Scripts
{
    public class AxisRigidbodyMove : AbstractRigidbodyMove
    {
        public AxisRigidbodyMove(Rigidbody rigidbody, float speed) : base(rigidbody, speed)
        {
        }

        public override void Move()
        {
            Move(Input.GetAxisRaw("Horizontal"), Y, Input.GetAxisRaw("Vertical"));
        }
    }
}
