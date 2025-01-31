﻿namespace SpaceBattle
{
    public interface IUObject
    {
        public object GetProperty(string propName);
        public void SetProperty(string propName, object newVal);
    }
}
