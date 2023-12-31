using Contracts;
using Entities;

namespace Repository;

public class CompanyRepository: RepositoryBase<Company>, ICompanyRepository
{
    public CompanyRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }

    public IEnumerable<Company> GetAllCompanies(bool trackChanges) =>
        FindAll(trackChanges)
            .OrderBy(c => c.Name)
            .ToList();

    public Company GetCompany(Guid companyId, bool trackChanges) => 
        FindByCondition(c => c.Id == companyId, trackChanges).SingleOrDefault();
}