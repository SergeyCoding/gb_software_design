﻿namespace InMemoryModel
{
    public interface IModelChanger
    {
        void NotifyChange(IModelChanger sender);
    }
}
