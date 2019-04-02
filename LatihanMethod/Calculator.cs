using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMethod {

    class Calculator {

        public int Penjumlahan(int a, int b) {
            return a + b;
        }

        public int Penjumlahan(int a, int b, int c) {
            return a + b + c;
        }

        public int Pengurangan(int a, int b) {
            return a - b;
        }

        //method static
        /// <summary>
        /// Static method perkalian
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Perkalian(int a, int b) {
            return a * b;
        }
    }
}
