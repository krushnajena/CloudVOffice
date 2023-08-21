using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Emp;
using CloudVOffice.Data.DTO.Emp;

namespace CloudVOffice.Services.Emp
{
    public interface IEmployeeService
    {
        public MessageEnum CreateEmployee(EmployeeCreateDTO employeeCreateDTO);
        public List<Employee> GetEmployees();
        public List<Employee> GetProjectManagerEmployees();
        public List<Employee> GetShiftEmployees();
        public Employee GetEmployeeByCode(string employeecode);
        public Employee GetEmployeeById(Int64 employeeid);
        public MessageEnum UpdateEmployee(EmployeeCreateDTO employeeCreateDTO);
        public MessageEnum DeleteEmployee(Int64 employeeid, Int64 DeletedBy);

        public List<Employee> GetEmployeeSubContinent(Int64 EmployeeId);
        public Employee GetEmployeeDetailsByUserId(Int64 UserId);
        object GetTaskList(long userId);
    }
}
