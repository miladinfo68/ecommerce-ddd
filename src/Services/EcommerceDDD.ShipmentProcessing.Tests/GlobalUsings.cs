global using EcommerceDDD.Core.CQRS.CommandHandling;
global using EcommerceDDD.Core.CQRS.QueryHandling;
global using EcommerceDDD.Core.Exceptions;
global using EcommerceDDD.Core.Testing;
global using EcommerceDDD.ShipmentProcessing.API.Controllers;
global using EcommerceDDD.ShipmentProcessing.API.Controllers.Requests;
global using EcommerceDDD.ShipmentProcessing.Application.ProcessingPayment.IntegrationEvents;
global using EcommerceDDD.ShipmentProcessing.Application.RequestingShipment;
global using EcommerceDDD.ShipmentProcessing.Domain;
global using EcommerceDDD.ShipmentProcessing.Domain.Commands;
global using EcommerceDDD.ShipmentProcessing.Domain.Events;
global using FluentAssertions;
global using Microsoft.AspNetCore.Mvc;
global using NSubstitute;
global using Xunit;
