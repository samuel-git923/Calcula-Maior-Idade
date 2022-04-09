﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooMaiorIdade
{
    public class Pessoa
    {
        // Construtores
        public Pessoa()
        {
            this.Nome = "";
            this.Idade = 0;
        }

        public Pessoa(String nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        // Propriedades
        private String nome;

        public String Nome
        {
            get { return this.nome; }
            set { this.nome = value.ToUpper(); }
        }

        private int idade;
        public int Idade { 
            get { return this.idade; }
            set
            {
                if (value >= 0)
                {
                    idade = value;
                }
                else
                {
                    this.idade = 0;
                }
            }
        }

        // Métodos (ações que os objetos podem executar)
        public void ExibirDados()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Idade: " + this.Idade);
        }
    }
}
