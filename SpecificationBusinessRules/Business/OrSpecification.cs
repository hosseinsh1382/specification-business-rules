using SpecificationBusinessRules.Interfaces;

namespace SpecificationBusinessRules.Business;

public class OrSpecification<T> : ISpecification<T>
{
    private readonly ISpecification<T> _left;
    private readonly ISpecification<T> _right;

    public OrSpecification(ISpecification<T> left, ISpecification<T> right)
    {
        _right = right;
        _left = left;
    }

    public bool IsSatisfied(T entity)
    {
        return _left.IsSatisfied(entity) || _right.IsSatisfied(entity);
    }
}