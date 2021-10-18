using System;

namespace UnitTestPractice
{
    public class Operations
    {
        public double DoOperation(double[] numeros, string[] operaciones)
        {
            double res=0;
            // Supported operations: *,/,+,-
            for (int i=1 , j=0; i< numeros.Length; j++, i++)
            {
                if (i == 1)
                {
                    double num1 = numeros[i-1];
                    double num2 = numeros[i];
                    switch (operaciones[j])
                    {
                        case "+":
                            res = num1 + num2;
                            break;
                        case "-":
                            res = num1 - num2;
                            break;
                        case "*":
                            res= num1 * num2;
                            break;
                        case "/":
                            res= num1 / num2;
                            break;
                        default:
                            Console.WriteLine("Introduce una operación valida");
                            break;
                    }                
                }

                else
                {
                    double num1 = res;
                    double num2 = numeros[i];                  
                    switch (operaciones[j])
                    {
                        case "+":
                            res = num1 + num2;
                            break;
                        case "-":
                            res = num1 - num2;
                            break;
                        case "*":
                            res = num1 * num2;
                            break;
                        case "/":
                            res = num1 / num2;
                            break;
                        default:
                            Console.WriteLine("Introduce una operación valida");
                            break;
                    }
                }
                
              
            }
            return res;
          
        }
    }
}
