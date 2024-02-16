global using EcommerceDDD.Core.CQRS.CommandHandling;
global using EcommerceDDD.Core.CQRS.QueryHandling;
global using EcommerceDDD.Core.Domain;
global using EcommerceDDD.Core.Exceptions;
global using EcommerceDDD.Core.Infrastructure;
global using EcommerceDDD.Core.Infrastructure.Identity;
global using EcommerceDDD.Core.Infrastructure.Integration;
global using EcommerceDDD.Core.Infrastructure.Marten;
global using EcommerceDDD.Core.Infrastructure.WebApi;
global using EcommerceDDD.Core.Persistence;
global using EcommerceDDD.QuoteManagement.API.Controllers.Requests;
global using EcommerceDDD.QuoteManagement.Application.Products;
global using EcommerceDDD.QuoteManagement.Application.Quotes;
global using EcommerceDDD.QuoteManagement.Application.Quotes.GettingOpenQuote;
global using EcommerceDDD.QuoteManagement.Application.Quotes.GettingQuoteHistory;
global using EcommerceDDD.QuoteManagement.Application.Quotes.OpeningQuote;
global using EcommerceDDD.QuoteManagement.Domain;
global using EcommerceDDD.QuoteManagement.Domain.Commands;
global using EcommerceDDD.QuoteManagement.Domain.Events;
global using EcommerceDDD.QuoteManagement.Infrastructure.ProductMapping;
global using EcommerceDDD.QuoteManagement.Infrastructure.Projections;
global using FluentAssertions;
global using Marten;
global using Marten.Events;
global using Marten.Events.Aggregation;
global using Marten.Events.Projections;
global using Microsoft.AspNetCore.Authorization;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.EntityFrameworkCore;
global using Newtonsoft.Json;
global using System.ComponentModel.DataAnnotations;