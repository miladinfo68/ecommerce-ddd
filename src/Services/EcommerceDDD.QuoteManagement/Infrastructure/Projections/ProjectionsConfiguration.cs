﻿namespace EcommerceDDD.QuoteManagement.Infrastructure.Projections;

public static class ProjectionsConfiguration
{
    internal static void ConfigureProjections(this StoreOptions options)
    {
        options.Projections.Add<QuoteDetailsProjection>(ProjectionLifecycle.Inline);
        options.Projections.Add<QuoteEventHistoryTransform>(ProjectionLifecycle.Inline);
    }
}
