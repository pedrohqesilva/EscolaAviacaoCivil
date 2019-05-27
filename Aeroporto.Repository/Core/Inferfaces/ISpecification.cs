using System;
using System.Linq;
using System.Linq.Expressions;

namespace Aeroportos.Repository.Core.Interfaces
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>> Predicate { get; }
        Func<IQueryable<T>, IOrderedQueryable<T>> Sort { get; }
        Func<IQueryable<T>, IQueryable<T>> PostProcess { get; }

        bool IsSatisfiedBy(T entity);

        IQueryable<T> Prepare(IQueryable<T> query);

        T SatisfyingItemFrom(IQueryable<T> query);

        IQueryable<T> SatisfyingItemsFrom(IQueryable<T> query);

        ISpecification<T> OrderBy<TProperty>(Expression<Func<T, TProperty>> property);

        ISpecification<T> OrderByDescending<TProperty>(Expression<Func<T, TProperty>> property);

        ISpecification<T> Take(int amount);

        ISpecification<T> Skip(int amount);

        ISpecification<T> And(ISpecification<T> specification);

        ISpecification<T> And(Expression<Func<T, bool>> right);

        ISpecification<T> Or(ISpecification<T> specification);

        ISpecification<T> Or(Expression<Func<T, bool>> right);

        ISpecification<T> Not();
    }
}