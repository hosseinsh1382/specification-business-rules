using SpecificationBusinessRules.Interfaces;

namespace SpecificationBusinessRules.Business;

public class NotSpecification<T> : ISpecification<T>
{
    private readonly ISpecification<T> _rule;


    public NotSpecification(ISpecification<T> rule)
    {
        _rule = rule;
    }

    public bool IsSatisfied(T entity)
    {
        return !_rule.IsSatisfied(entity);
    }
}