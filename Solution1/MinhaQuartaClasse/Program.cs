﻿using MinhaQuartaClasse.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaQuartaClasse
{ class Program
{
    static List<Pessoa> listaPessoa = new List<Pessoa>();


    static void Main(string[] args)
    {
        Console.WriteLine("Digite 1 para inserir. ");
        //Console.WriteLine("Digite 2 para listar. ");
        var opcao = Console.ReadLine();

        //switch (opcao)
        //{
        //    case "1":
        //        AdicionaLista();
        //        break;
        //    case "2":
        //        listar();
        //        break;
        //    default:

        //}

        while (opcao == "1")
        {
            AdicionaLista();
            Console.WriteLine("Digite 1 para inserir. ");
            opcao = Console.ReadLine();
        }
        listar();
        Console.ReadKey();
    }

    public static void AdicionaLista()
    {
        Pessoa objetoPessoa = new Pessoa();

        Console.WriteLine("Informe nome:");
        objetoPessoa.Nome = Console.ReadLine();

        Console.WriteLine("Informe a idade:");
        objetoPessoa.Idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe o sexo:");
        objetoPessoa.Sexo = char.Parse(Console.ReadLine());

        Console.WriteLine("Informe a altura:");
        objetoPessoa.Altura = double.Parse(Console.ReadLine());

        listaPessoa.Add(objetoPessoa);
    }

    public static void listar()
    {
        listaPessoa.ForEach(ob => Console.WriteLine($"Nome: {ob.Nome} Idade: {ob.Idade} Sexo: {ob.Sexo} Altura: {ob.Altura}"));
    }
   } 
}