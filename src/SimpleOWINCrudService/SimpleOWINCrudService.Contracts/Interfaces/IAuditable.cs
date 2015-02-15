using System;

namespace SimpleOWINCrudService.Contracts.Interfaces
{
    public interface IAuditable
    {
        DateTime CreatedDate { get; set; }
        DateTime LastUpdatedDate { get; set; }
    }
}
