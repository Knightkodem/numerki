﻿namespace Zadanie3.Model;

public readonly record struct Function(
    Func<double, double> Expr,
    string ExprString);
