using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoa
{
    public class Pad
    {
        // Construtores
        public Pad()
        {
            this.Nome = " ";
            this.Idade = 0;
            this.Cpf = " ";
            this.Sexo = " ";
            this.Telefone = " ";
            this.Date = " ";
        }

        public Pad(String nome, int idade, String cpf)
        {
            this.Nome = "nome";
            this.Idade = idade;
            this.Cpf = cpf;
            this.Telefone = telefone;
        }

        // Propriedades

        private String nome;
        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private int idade;
        public int Idade
        {
            get { return idade; }
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

        private String cpf; 
        public String Cpf 

        {
            get { return cpf; }


            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    // Remove formatação do CPF 
                    value  = value.Replace(".", "").Replace("-", "");

                    if (value.Length == 11)
                    {
                        cpf = value.Insert(3, ".").Insert(7, ".").Insert(11, "-");
                    }
                    else
                    {
                        cpf = "CPF inválido";
                    }
                }
                
            }
        }

        private string sexo;
        public string Sexo
        {
            get { return sexo; }
            set => sexo = value;
        }

        private string date;
        public string Date

        {
            get { return date; } 

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    value = value.Replace("/", "");

                    if (value.Length == 8)
                    {
                        date = value.Insert(2, "/").Insert(5, "/");
                    }
                    else
                    {
                        date = "Formato inválido";
                    }
                }
            }
        }

        private string telefone;
        public string Telefone

        {
            get { return telefone; }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    if (value.Length == 9)
                    {
                        if (int.TryParse(value, out int parsedTelefone))
                        {
                            telefone = parsedTelefone.ToString();
                        }
                    }
                    else
                    {
                        telefone = "Telefone não cadastrado";
                    }
                }
            }
        }

        public void ExibirDados()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Idade: " + this.Idade);
            Console.WriteLine("CPF: " + this.Cpf);
            Console.WriteLine("Telefone: " + this.Telefone);
            Console.WriteLine("Data de Nascimento: " + this.Date);
            Console.WriteLine("Sexo: " + Sexo);
        }
    }
}
