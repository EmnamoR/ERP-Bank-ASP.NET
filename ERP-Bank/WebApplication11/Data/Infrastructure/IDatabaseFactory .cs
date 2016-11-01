using Data.Models;
using System;

namespace bank.Data.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        bankContext DataContext { get; }
    }

}
