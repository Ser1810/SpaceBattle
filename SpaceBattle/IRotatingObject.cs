namespace SpaceBattle
{
    public interface IRotatingObject
    {
        int GetDirection();
        int GetAngularVelocity();
        int GetDirectionsNumber();
        void SetDirection(int newValue);
    }
}
