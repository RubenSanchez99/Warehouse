using Warehouse.Application.Common.Interfaces;
using System;

namespace Warehouse.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
