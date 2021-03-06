namespace Be.Vlaanderen.Basisregisters.CommandHandling.Idempotency
{
    using System;

    internal class IdempotencyConnectionInfo
    {
        public string ConnectionString { get; }

        public IdempotencyConnectionInfo(string connectionString)
            => ConnectionString = string.IsNullOrWhiteSpace(connectionString)
                ? throw new ArgumentException(nameof(connectionString))
                : connectionString;
    }
}
