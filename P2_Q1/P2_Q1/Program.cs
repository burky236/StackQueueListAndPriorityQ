using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace P2_Q1
{

    class Customer
    {
        public string custName;
        public int productNo;

        public Customer(string custName, int productNo)
        {
            this.custName = custName;
            this.productNo = productNo;
        }
    }

    class Program
    {
        private static readonly Random random = new Random();

        private static int RandomNumberBetween(int minValue, int maxValue)
        {
            var next = random.Next(minValue, maxValue + 1);//Verilen aralıklar içinde rastgele sayılar üretildi.

            return next;
        }

        static void Main(string[] args)
        {
            string[] custName = { "Ali", "Merve", "Veli", "Gülay", "Okan", "Zekiye", "Kemal", "Banu", "İlker", "Songül", "Nuri", "Deniz" };
            int[] productNo = { 8, 11, 16, 5, 15, 14, 19, 3, 18, 17, 13, 15 };

            ArrayList arrayList = new ArrayList();

            int count = 0;
            int gListcount = 0;
            int minValue = 1;
            int maxValue = 5;

            Customer customer1;

            List<Customer> genericList;

            while (count < custName.Length)
            {
                genericList = new List<Customer>();
                int genericListLength = (int)RandomNumberBetween(minValue, maxValue);

                for (int i = 0; i < genericListLength; i++)
                {
                    customer1 = new Customer(custName[count], productNo[count]);
                    genericList.Add(customer1);
                    count++;

                    if (count == custName.Length)
                        break;
                }
                arrayList.Add(genericList);
                gListcount++;
            }

            foreach (List<Customer> temp in arrayList)
            {
                foreach (Customer temp2 in temp)
                {
                    Console.WriteLine(temp2.custName + " " + temp2.productNo);
                }
                Console.WriteLine();
            }

            double dcustName = custName.Length;
            double darrayList = arrayList.Count;
            double ave = dcustName / darrayList;

            Console.WriteLine("Average element number: " + ave);
            Console.ReadKey();
        }
    }
}
