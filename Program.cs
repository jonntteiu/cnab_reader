using System;
using CnabReader.Models.Classes;
using CnabReader.Models.Cnabs.BancoDoBrasil;

namespace CnabReader;
public class Program
{
    public static void Main(string[] args) 
    {
        // var bbCnab = new BancoDoBrasil();

        Cnab.ValidateMapping<BancoDoBrasil>();
    }
}
