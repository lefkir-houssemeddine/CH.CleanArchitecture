﻿using System;
using System.Threading.Tasks;
using CH.CleanArchitecture.Core.Domain;

namespace CH.CleanArchitecture.Core.Application
{
    /// <summary>
    /// Interface for fetching/saving snapshot aggregates
    /// </summary>
    public interface IEventStoreSnapshotProvider
    {
        Task<T> GetAggregateFromSnapshotAsync<T, TAggregateId>(TAggregateId aggregateId, string aggregateName) where T : class, IAggregateRoot<TAggregateId>;

        Task SaveSnapshotAsync<T, TId>(T aggregate, Guid lastEventId) where T : class, IAggregateRoot<TId>;
    }
}