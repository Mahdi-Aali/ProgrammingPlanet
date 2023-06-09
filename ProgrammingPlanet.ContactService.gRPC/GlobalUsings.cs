﻿global using ProgrammingPlanet.ContactService.gRPC.Services;
global using ProgrammingPlanet.ContactService.DAL.Database;
global using Microsoft.EntityFrameworkCore;
global using Grpc.Core;
global using ProgrammingPlanet.ContactService.Domain.Models;
global using ProgrammingPlanet.ContactService.Domain.Services;
global using ProgrammingPlanet.ContactService.gRPC.Protos;
global using static ProgrammingPlanet.ContactService.gRPC.Protos.WebContactService;
global using Microsoft.AspNetCore.Mvc;
global using ProgrammingPlanet.ContactService.DAL.Repositories;
global using ProgrammingPlanet.ContactService.Domain.Repositories;
global using BLL = ProgrammingPlanet.ContactService.BLL.Services;
global using Services = ProgrammingPlanet.ContactService.gRPC.Services;
global using Grpc.Net.Compression;
global using System.IO.Compression;
