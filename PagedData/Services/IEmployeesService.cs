using System;
using DynamicData;
using PagedData.Models;

namespace PagedData.Services
{
    public interface IEmployeesService
    {
        IObservable<IChangeSet<Employee, int>> EmployeesConnection();
        void LoadData();
    }
}