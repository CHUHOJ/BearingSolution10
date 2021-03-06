﻿using System.Threading.Tasks;

namespace BearingSolution10.Infrastructure.Base
{
    public interface IDetailViewModel
    {
        Task LoadAsync(int id);
        bool HasChanges { get; }
        int Id { get; }
    }
}
