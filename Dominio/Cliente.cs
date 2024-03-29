﻿namespace Dominio
{
    public class Cliente
    {
        private int codigo;
        private string nome;
        private string endereco;
        private string telefone;

        public Cliente(int codigo, string nome, string endereco, string telefone)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Endereco = endereco;
            this.Telefone = telefone;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Telefone { get => telefone; set => telefone = value; }
    }
}