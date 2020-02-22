﻿using ClassifiedAds.DomainServices.Entities;
using System;

namespace ClassifiedAds.DomainServices.Repositories
{
    public interface IStoreRepository : IRepository<Store, Guid>
    {
        Store GetStoreIncludeProducts(Guid Id);
    }
}
