﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero.DataAccess.Entities.Api
{
    public class Response
    {

        public string Content { get; set; }
        public bool HasError { get; set; }
        public string ErrorMessage { get; set; }

    }
}
