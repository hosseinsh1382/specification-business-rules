namespace SpecificationBusinessRules.Interfaces;

public interface ISpecification<T>
{
    bool IsSatisfied(T entity);
}