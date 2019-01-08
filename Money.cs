using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
   public class Money
    {
        private int _value;
        private int _number;
        public Money(int par, int number)
        {
            _value = value;
            _number = number;
        }
        //public int GetPar()
        //{
        //    return _par;
        //}
        //public void SetPar(int par)
        //{
        //    _par = par;
        //}
        //public int GetNumber()
        //{
        //    return _number;
        //}
        //public void SetNumber(int number)
        //{
        //    _number = number;
        //}
        public void Show()
        {
            Console.WriteLine("Номинал" + _value, "Количество купюр" + _number);
        }
        public void Buy()
        {
            int sum;
            int product = 10000;
            Console.WriteLine("Введите сколько у вас денежных средств");
            sum = int.Parse(Console.ReadLine());

            if (sum>product)
            {
                Console.WriteLine("У вас достаточно денег, чтобы купить данный продукт");
            }
            else
            {
                Console.WriteLine("У вас не хватает денег, чтобы купить данный продукт");
            }
            

        }
        public void Number()
        {
            int product = 10000;
            int sum;
            Console.WriteLine("Введите сколько у вас денежных средств");
            sum = int.Parse(Console.ReadLine());
            Console.WriteLine("На данную сумму вы можете купить " + sum / product + "штук данного продукта");


        }
           
            

       
     
    }
}
