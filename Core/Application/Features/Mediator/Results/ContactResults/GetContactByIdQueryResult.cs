﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Results.ContactResults
{
    public class GetContactByIdQueryResult
    {
        public int ContactID { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}
