using bank.Data.Infrastructure;
using Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Service
{
    public class employeeService : IEmployeeService
    {

        static public DatabaseFactory dbFactory = new DatabaseFactory();
        UnitOfWork utwk = new UnitOfWork(dbFactory);
        public void AddEmployee(employee e)
        {
            utwk.getRepository<employee>().Add(e);
            utwk.Commit();
        }

        public void deleteEmployee(employee e, long id)
        {
            utwk.getRepository<employee>().Delete(utwk.getRepository<employee>().GetById(id));
            utwk.Commit();
        }

        public void editEmployee(employee e, long id)
        {

            utwk.getRepository<employee>().Update(utwk.getRepository<employee>().GetById(id));
            utwk.Commit();
        }

        public employee employeeDetails(long id)
        {
            return utwk.getRepository<employee>().GetById(id);
        }

        public employee findEmployee(long id)
        {
            return utwk.getRepository<employee>().GetById(id);
        }

        public List<employee> getAllEmployees()
        {
            return utwk.getRepository<employee>().GetMany(null, null).ToList();
        }

    




    }
    public interface IEmployeeService
    {
        void AddEmployee(employee e);
        List<employee> getAllEmployees();
        employee findEmployee(long id);
        void editEmployee(employee e, long id);
        void deleteEmployee(employee e, long id);
        employee employeeDetails(long id);

    }
}
