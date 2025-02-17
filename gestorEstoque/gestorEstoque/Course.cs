﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestorEstoque
{
    [System.Serializable]
    class Course : Product, IStock
    {
        public string autor;
        private int vagas;

        public Course(string nome, float preco, string autor)
        {
            this.nome = nome;
            this.preco = preco;
            this.autor = autor;
        }
        public void AdicionarEntrada()
        {
            Console.WriteLine($"Adicionar vagas no curso {nome}");
            Console.WriteLine("Digite a Qtd. de vagas que você quer dar entrada: ");
            int entrada = int.Parse(Console.ReadLine());
            // estoque = estoque + entrada;
            vagas += entrada;
            Console.WriteLine("Entrada registrada");
            Console.ReadLine();
        }

        public void AdicionarSaida()
        {
            Console.WriteLine($"Consumir vagas no curso {nome}");
            Console.WriteLine("Digite a Qtd. de vagas que você quer consumir: ");
            int entrada = int.Parse(Console.ReadLine());
            // estoque = estoque + entrada;
            vagas -= entrada;
            Console.WriteLine("Saida registrada");
            Console.ReadLine();
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Vagas restantes: {vagas}");
            Console.WriteLine("============================");
        }

    }
}
