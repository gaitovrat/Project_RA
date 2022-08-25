using UnityEngine;

namespace Assets.Scripts
{
    public class AxisTransformMove : AbstractTransformMove
    {
        public AxisTransformMove(Transform transform, float speed) : base(transform, speed)
        {
        }

        public override void Move()
        {
            Move(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        }
    }
}
