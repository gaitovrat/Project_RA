namespace Assets.Scripts
{
    public interface IMove : IPosition
    {
        void Move(float x, float y, float z);
        void Move();
    }
}
