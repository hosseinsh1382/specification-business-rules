using SpecificationBusinessRules.Interfaces;

namespace SpecificationBusinessRules.Business;

public class Specification<T> : ISpecification<T>
{
    private readonly Func<T, bool> Rule;

    public Specification(Func<T, bool> rule)
    {
        Rule = rule;
    }

    public bool IsSatisfied(T entity)
    {
        return Rule(entity);
    }
}