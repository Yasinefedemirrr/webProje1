﻿using Application.Features.Mediator.Results.ContactResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Queries.ContactQueries
{
    public class GetContactQuery : IRequest<List<GetContactQueryResult>>
    {
    }
}
