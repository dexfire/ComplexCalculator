using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;

namespace ComplexCalculator
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Console.WriteLine("Please input the method you need");
            Console.WriteLine("\tAdd(+)\n\tSubstract(-)\n\tMultiply(*)\n\tDivide(/)\n\tPowerOnInteger(^)");
            String method = Console.ReadLine();
            switch (method)
            {
                case "Add":
                    {
                        add(); break;
                    }
                case "add":
                    {
                        add(); break;
                    }
                case "+":
                    {
                        add(); break;
                    }

                case "Substract":
                    {
                        substract(); break;
                    }
                case "substract":
                    {
                        substract(); break;
                    }
                case "-":
                    {
                        substract(); break;
                    }

                case "Multiply":
                    {
                        multiply(); break;
                    }
                case "multiply":
                    {
                        multiply(); break;
                    }
                case "*":
                    {
                        multiply(); break;
                    }

                case "Divide":
                    {
                        divide(); break;
                    }
                case "divide":
                    {
                        divide(); break;
                    }
                case "/":
                    {
                        divide(); break;
                    }

                case "Power":
                    {
                        power(); break;
                    }
                case "power":
                    {
                        power(); break;
                    }
                case "^":
                    {
                        power(); break;
                    }
            }
        }

        private static void power()
        {
            throw new NotImplementedException();
        }

        private static void multiply()
        {
            throw new NotImplementedException();
        }

        private static void divide()
        {
            throw new NotImplementedException();
        }

        private static void substract()
        {
            throw new NotImplementedException();
        }

        private static void add()
        {
            throw new NotImplementedException();
        }

    }
}
