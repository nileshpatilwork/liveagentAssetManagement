﻿using DataAccess;

namespace LiveAgentAssetManagement.DAL.DataRepository
{
    public interface IRepository
    {
        IDataAccess DataAccess { get; }
    }
}