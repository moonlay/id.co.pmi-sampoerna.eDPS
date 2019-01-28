﻿using Core.Domain;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Core
{
    public class ErrorPropertyItem
    {
        public ErrorPropertyItem(string propName, string message)
        {
            PropertyName = propName;
            Message = message;
        }

        public string Message { get; }
        public string PropertyName { get; }
    }

    public static class Validator
    {
        public static void ThrowIfNull(Expression<Func<object>> expression)
        {
            if (!(expression.Body is MemberExpression))
            {
                throw new DomainException(
                  "expected property or field expression.");
            }
            var body = expression.Body as MemberExpression;
            var compiled = expression.Compile();
            var value = compiled();
            if (value == null)
            {
                throw new DomainNullException(body.Member.Name);
            }
        }

        public static void ThrowWhenTrue(Expression<Func<bool>> expression, string message = "invalid")
        {
            var compiled = expression.Compile();
            var value = compiled();
            if (value)
                throw new DomainException(message);
        }

        public static void ThrowIfNullOrEmpty<T>(Expression<Func<IEnumerable<T>>> expression)
        {
            if (!(expression.Body is MemberExpression))
            {
                throw new DomainException("expected property or field expression.");
            }

            var body = expression.Body as MemberExpression;

            var compiled = expression.Compile();
            var value = compiled();
            if (value == null || !value.Any())
            {
                throw new DomainNullException(body.Member.Name);
            }
        }

        public static void ThrowIfNullOrEmpty(Expression<Func<string>> expression)
        {
            if (!(expression.Body is MemberExpression))
            {
                throw new DomainException("expected property or field expression.");
            }

            var body = expression.Body as MemberExpression;
            var compiled = expression.Compile();
            var value = compiled();

            if (string.IsNullOrEmpty(value))
            {
                throw new DomainNullException(body.Member.Name, "String is null or empty");
            }
        }

        public static ValidationException ErrorValidation(params ErrorPropertyItem[] errors)
        {
            IEnumerable<FluentValidation.Results.ValidationFailure> failures = errors.Select(o => new FluentValidation.Results.ValidationFailure(o.PropertyName, o.Message));

            return new ValidationException(failures);
        }

        public static void ErrorValidationAndThrow(params ErrorPropertyItem[] errors)
        {
            throw ErrorValidation(errors);
        }
    }
}