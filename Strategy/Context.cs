﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Context
    {
        private IStrategy _strategy;

        public Context() { }
        public Context(IStrategy strategy) 
        {
            _strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public int ExecuteStategy(int a, int b)
        {
            return _strategy.Execute(a, b);
        }
    }
}
