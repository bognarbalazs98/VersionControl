﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week08.Abstraction;

namespace week08.Entities
{
    public class BallFactory : IToyFactory
    {
        public Toy CreateNew()
        {
            return new Ball();
        }

        public static implicit operator BallFactory(CarFactory v)
        {
            throw new NotImplementedException();
        }
    }
}
