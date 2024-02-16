global using EcommerceDDD.Core.CQRS.CommandHandling;
global using EcommerceDDD.Core.CQRS.QueryHandling;
global using EcommerceDDD.Core.Domain;
global using EcommerceDDD.Core.EventBus;
global using EcommerceDDD.Core.Exceptions;
global using EcommerceDDD.Core.Infrastructure;
global using EcommerceDDD.Core.Infrastructure.Extensions;
global using EcommerceDDD.Core.Infrastructure.Identity;
global using EcommerceDDD.Core.Infrastructure.Integration;
global using EcommerceDDD.Core.Infrastructure.Kafka;
global using EcommerceDDD.Core.Infrastructure.Marten;
global using EcommerceDDD.Core.Infrastructure.SignalR;
global using EcommerceDDD.Core.Infrastructure.WebApi;
global using EcommerceDDD.Core.Persistence;
global using EcommerceDDD.OrderProcessing.Application.GettingOrderEventHistory;
global using EcommerceDDD.OrderProcessing.Application.Orders.GettingOrders;
global using EcommerceDDD.OrderProcessing.Application.Orders.PlacingOrder;
global using EcommerceDDD.OrderProcessing.Application.Payments.CancelingPayment;
global using EcommerceDDD.OrderProcessing.Application.Payments.ProcessingPayment.IntegrationEvents;
global using EcommerceDDD.OrderProcessing.Application.Payments.RequestingPayment;
global using EcommerceDDD.OrderProcessing.Application.Shipments.ProcessingShipment.IntegrationEvents;
global using EcommerceDDD.OrderProcessing.Application.Shipments.RequestingShipment;
global using EcommerceDDD.OrderProcessing.Domain;
global using EcommerceDDD.OrderProcessing.Domain.Commands;
global using EcommerceDDD.OrderProcessing.Domain.Events;
global using EcommerceDDD.OrderProcessing.Infrastructure.Projections;
global using Marten;
global using Marten.Events;
global using Marten.Events.Aggregation;
global using Marten.Events.Projections;
global using Microsoft.AspNetCore.Authorization;
global using Microsoft.AspNetCore.Mvc;
global using Newtonsoft.Json;
global using System.ComponentModel;
global using System.ComponentModel.DataAnnotations;