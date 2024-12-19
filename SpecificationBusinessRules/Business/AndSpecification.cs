using SpecificationBusinessRules.Interfaces;

namespace SpecificationBusinessRules.Business;

public class AndSpecification<T> : ISpecification<T>
{
    private readonly ISpecification<T> _left;
    private readonly ISpecification<T> _right;

    public AndSpecification(ISpecification<T> left, ISpecification<T> right)
    {
        _left = left;
        _right = right;
    }

    public bool IsSatisfied(T entity)
    {
        return _left.IsSatisfied(entity) && _right.IsSatisfied(entity);
    }
}