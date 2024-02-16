global using EcommerceDDD.Core.CQRS.CommandHandling;
global using EcommerceDDD.Core.CQRS.QueryHandling;
global using EcommerceDDD.Core.Domain;
global using EcommerceDDD.Core.EventBus;
global using EcommerceDDD.Core.Exceptions;
global using EcommerceDDD.Core.Infrastructure;
global using EcommerceDDD.Core.Infrastructure.Identity;
global using EcommerceDDD.Core.Infrastructure.Integration;
global using EcommerceDDD.Core.Infrastructure.Kafka;
global using EcommerceDDD.Core.Infrastructure.Marten;
global using EcommerceDDD.Core.Infrastructure.Outbox;
global using EcommerceDDD.Core.Infrastructure.WebApi;
global using EcommerceDDD.Core.Persistence;
global using EcommerceDDD.ShipmentProcessing.API.Controllers.Requests;
global using EcommerceDDD.ShipmentProcessing.Application.ProcessingShipment.IntegrationEvents;
global using EcommerceDDD.ShipmentProcessing.Application.RequestingShipment;
global using EcommerceDDD.ShipmentProcessing.Domain;
global using EcommerceDDD.ShipmentProcessing.Domain.Commands;
global using EcommerceDDD.ShipmentProcessing.Domain.Events;
global using EcommerceDDD.ShipmentProcessing.Infrastructure.Projections;
global using Marten;
global using Marten.Events.Aggregation;
global using Marten.Events.Projections;
global using Microsoft.AspNetCore.Authorization;
global using Microsoft.AspNetCore.Mvc;
global using Newtonsoft.Json;
global using System.ComponentModel.DataAnnotations;