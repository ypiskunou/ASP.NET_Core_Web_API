using Contracts;
using Service.Contracts;

namespace Service;

public sealed class ServiceManager: IServiceManager
{
    private Lazy<ICompanyService> _companyService;
    private Lazy<IEmployeeService> _employeeService;

    public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger)
    {
        _companyService = new Lazy<ICompanyService>(() => 
            new CompanyService(repositoryManager, logger));
        _employeeService = new Lazy<IEmployeeService>(() => 
            new EmployeeService(repositoryManager, logger));
    }

    public ICompanyService CompanyService { get; }
    public IEmployeeService EmployeeService { get; }
}