using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMethod {

    class Program {

        static void Main(string[] args) {
            int hasil;

            Calculator calc = new Calculator();

            hasil = calc.Penjumlahan(10, 2);
            cetakHasil("Hasil penjumlaham: "+ hasil);

            hasil = calc.Penjumlahan(10, 2, 3);
            cetakHasil("Hasil penjumlaham 3 bilangan: " + hasil);

            hasil = calc.Pengurangan(7, 2);
            cetakHasil("Hasil Pengurangan: " + hasil);

            hasil = Calculator.Perkalian(5, 2);
            cetakHasil("Hasil Perkalian: " + hasil);

            Console.ReadKey();
        }

        static void cetakHasil(string output) {
            Console.WriteLine(output);
        }
    }
}
