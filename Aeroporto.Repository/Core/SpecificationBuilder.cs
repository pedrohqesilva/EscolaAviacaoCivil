using Aeroportos.Repository.Core.Interfaces;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Aeroportos.Repository.Core
{
    public sealed class SpecificationBuilder<T> : ISpecification<T>
    {
        public Expression<Func<T, bool>> Predicate { get; private set; } = (_) => true;
        public Func<IQueryable<T>, IOrderedQueryable<T>> Sort { get; private set; }
        public Func<IQueryable<T>, IQueryable<T>> PostProcess { get; private set; }

        private SpecificationBuilder()
        {
        }

        public static SpecificationBuilder<T> Create()
        {
            return new SpecificationBuilder<T>();
        }

        public bool IsSatisfiedBy(T entity)
        {
            Func<T, bool> predicate = Predicate.Compile();
            return predicate(entity);
        }

        public T SatisfyingItemFrom(IQueryable<T> query)
        {
            return Prepare(query).SingleOrDefault();
        }

        public IQueryable<T> SatisfyingItemsFrom(IQueryable<T> query)
        {
            return Prepare(query);
        }

        public IQueryable<T> Prepare(IQueryable<T> query)
        {
            var q = query.Where(Predicate);

            if (Sort != null)
                q = Sort(q);

            if (PostProcess != null)
                q = PostProcess(q);

            return q;
        }

        public ISpecification<T> OrderBy<TProperty>(Expression<Func<T, TProperty>> property)
        {
            var newSpecification = new SpecificationBuilder<T>()
            {
                Predicate = this.Predicate,
                PostProcess = this.PostProcess
            };

            if (Sort != null)
                newSpecification.Sort = items => Sort(items).ThenBy(property);
            else
                newSpecification.Sort = items => items.OrderBy(property);

            return newSpecification;
        }

        public ISpecification<T> OrderByDescending<TProperty>(Expression<Func<T, TProperty>> property)
        {
            var newSpecification = new SpecificationBuilder<T>()
            {
                Predicate = this.Predicate,
                PostProcess = this.PostProcess
            };

            if (Sort != null)
                newSpecification.Sort = items => Sort(items).ThenByDescending(property);
            else
                newSpecification.Sort = items => items.OrderByDescending(property);

            return newSpecification;
        }

        public ISpecification<T> Take(int amount)
        {
            var newSpecification = new SpecificationBuilder<T>()
            {
                Predicate = this.Predicate,
                Sort = this.Sort
            };

            if (PostProcess != null)
                newSpecification.PostProcess = items => PostProcess(items).Take(amount);
            else
                newSpecification.PostProcess = items => items.Take(amount);

            return newSpecification;
        }

        public ISpecification<T> Skip(int amount)
        {
            var newSpecification = new SpecificationBuilder<T>()
            {
                Predicate = this.Predicate,
                Sort = this.Sort
            };

            if (PostProcess != null)
                newSpecification.PostProcess = items => PostProcess(items).Skip(amount);
            else
                newSpecification.PostProcess = items => items.Skip(amount);

            return newSpecification;
        }

        public ISpecification<T> And(ISpecification<T> that)
        {
            var specification = new SpecificationBuilder<T>()
            {
                Predicate = And(this.Predicate, that.Predicate),
                Sort = that.Sort ?? this.Sort,
                PostProcess = that.PostProcess ?? this.PostProcess
            };

            return specification;
        }

        public ISpecification<T> And(Expression<Func<T, bool>> right)
        {
            var specification = new SpecificationBuilder<T>()
            {
                Predicate = And(this.Predicate, right),
                Sort = this.Sort,
                PostProcess = this.PostProcess
            };

            return specification;
        }

        public static Expression<Func<T, bool>> And(Expression<Func<T, bool>> left, Expression<Func<T, bool>> right)
        {
            var visitor = new SwapVisitor(left.Parameters[0], right.Parameters[0]);
            var binaryExpression = Expression.AndAlso(visitor.Visit(left.Body), right.Body);
            var lambda = Expression.Lambda<Func<T, bool>>(binaryExpression, right.Parameters);
            return lambda;
        }

        public ISpecification<T> Or(ISpecification<T> that)
        {
            var specification = new SpecificationBuilder<T>()
            {
                Predicate = Or(this.Predicate, that.Predicate),
                Sort = that.Sort ?? this.Sort,
                PostProcess = that.PostProcess ?? this.PostProcess
            };

            return specification;
        }

        public ISpecification<T> Or(Expression<Func<T, bool>> right)
        {
            var specification = new SpecificationBuilder<T>()
            {
                Predicate = Or(this.Predicate, right),
                Sort = this.Sort,
                PostProcess = this.PostProcess
            };

            return specification;
        }

        public static Expression<Func<T, bool>> Or(Expression<Func<T, bool>> left, Expression<Func<T, bool>> right)
        {
            var visitor = new SwapVisitor(left.Parameters[0], right.Parameters[0]);
            var binaryExpression = Expression.OrElse(visitor.Visit(left.Body), right.Body);
            var lambda = Expression.Lambda<Func<T, bool>>(binaryExpression, right.Parameters);
            return lambda;
        }

        public ISpecification<T> Not()
        {
            var specification = new SpecificationBuilder<T>()
            {
                Predicate = Not(this.Predicate),
                Sort = this.Sort,
                PostProcess = this.PostProcess
            };

            return specification;
        }

        public static Expression<Func<T, bool>> Not(Expression<Func<T, bool>> left)
        {
            var notExpression = Expression.Not(left.Body);
            var lambda = Expression.Lambda<Func<T, bool>>(notExpression, left.Parameters.Single());
            return lambda;
        }

        public static ISpecification<T> operator |(SpecificationBuilder<T> left, SpecificationBuilder<T> right)
        {
            return left.Or(right);
        }

        public static ISpecification<T> operator |(SpecificationBuilder<T> left, Expression<Func<T, bool>> right)
        {
            return left.Or(right);
        }

        public static ISpecification<T> operator &(SpecificationBuilder<T> left, SpecificationBuilder<T> right)
        {
            return left.And(right);
        }

        public static ISpecification<T> operator &(SpecificationBuilder<T> left, Expression<Func<T, bool>> right)
        {
            return left.And(right);
        }

        public static ISpecification<T> operator !(SpecificationBuilder<T> left)
        {
            return left.Not();
        }

        private class SwapVisitor : ExpressionVisitor
        {
            private readonly Expression from, to;

            public SwapVisitor(Expression from, Expression to)
            {
                this.from = from;
                this.to = to;
            }

            public override Expression Visit(Expression node)
            {
                return node == from ? to : base.Visit(node);
            }
        }
    }
}