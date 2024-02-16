global using EcommerceDDD.Core.CQRS.CommandHandling;
global using EcommerceDDD.Core.CQRS.QueryHandling;
global using EcommerceDDD.Core.Exceptions;
global using EcommerceDDD.Core.Infrastructure.Integration;
global using EcommerceDDD.Core.Infrastructure.SignalR;
global using EcommerceDDD.Core.Infrastructure.WebApi;
global using EcommerceDDD.Core.Testing;
global using EcommerceDDD.OrderProcessing.API.Controllers;
global using EcommerceDDD.OrderProcessing.Application.GettingOrderEventHistory;
global using EcommerceDDD.OrderProcessing.Application.Orders.CancelingOrder;
global using EcommerceDDD.OrderProcessing.Application.Orders.CompletingOrder;
global using EcommerceDDD.OrderProcessing.Application.Orders.GettingOrders;
global using EcommerceDDD.OrderProcessing.Application.Orders.PlacingOrder;
global using EcommerceDDD.OrderProcessing.Application.Payments.RecordingPayment;
global using EcommerceDDD.OrderProcessing.Domain;
global using EcommerceDDD.OrderProcessing.Domain.Commands;
global using EcommerceDDD.OrderProcessing.Domain.Events;
global using FluentAssertions;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.Extensions.Configuration;
global using NSubstitute;
global using System;
global using System.Collections.Generic;
global using System.Linq;
global using System.Threading;
global using System.Threading.Tasks;
global using Xunit;