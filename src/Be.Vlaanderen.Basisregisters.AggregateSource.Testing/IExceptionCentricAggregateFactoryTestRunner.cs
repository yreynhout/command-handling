﻿namespace Be.Vlaanderen.Basisregisters.AggregateSource.Testing
{
    using System;

    /// <summary>
    /// Represents an aggregate factory test specification runner.
    /// </summary>
    public interface IExceptionCentricAggregateFactoryTestRunner
    {
        /// <summary>
        /// Runs the specified test specification.
        /// </summary>
        /// <param name="specification">The test specification to run.</param>
        /// <returns>The result of running the test specification.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="specification"/> is <c>null</c>.</exception>
        ExceptionCentricAggregateFactoryTestResult Run(ExceptionCentricAggregateFactoryTestSpecification specification);
    }
}