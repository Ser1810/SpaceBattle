﻿using System.Numerics;

namespace SpaceBattle
{
    public interface IMovingObject
    {
        Vector2 GetLocation();

        Vector2 GetVelocity();

        void SetLocation(Vector2 newValue);
    }
}
