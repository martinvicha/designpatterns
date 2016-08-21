﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interpreter.Codeproject {
    public class AddExpression : IExpression {
        readonly IExpression _leftExpression;
        readonly IExpression _rightExpression;

        public AddExpression(IExpression leftExpression, IExpression rightExpression) {
            _leftExpression = leftExpression;
            _rightExpression = rightExpression;
        }

        public int Interpret() {
            return _leftExpression.Interpret() + _rightExpression.Interpret();
        }
    }
}
