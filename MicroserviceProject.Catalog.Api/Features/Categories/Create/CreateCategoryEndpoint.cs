﻿using MediatR;
using MicroserviceProject.Shared.Extensions;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace MicroserviceProject.Catalog.Api.Features.Categories.Create
{
    public static class CreateCategoryEndpoint
    {
        public static RouteGroupBuilder CreateCategoryGroupItemEndpoint(this RouteGroupBuilder group)
        {
            group.MapPost("/",
                async (CreateCategoryCommand command, IMediator mediator) => 
                     (await mediator.Send(command)).ToGenericResult());

            return group;
        }
    }
}