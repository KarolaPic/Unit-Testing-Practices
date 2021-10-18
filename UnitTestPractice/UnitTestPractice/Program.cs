using System;
using UnitTestPractice;

//Console.WriteLine("Hello, World!");
var op = new Operations();
double[] numeros = new double[] { 1, 2, 2, 4 };
string[] simbolos = new string[] { "+", "-", "+" };
var result = op.DoOperation(numeros, simbolos);
Console.WriteLine(result);
