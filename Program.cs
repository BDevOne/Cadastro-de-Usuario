﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoa
{
    class Program
    {
        static void Main(string[] args)
        {

            Pad p1;
            Pad p3;
            Pad p2;
         // Pad p4; <- Usuário para teste do telefone

            // Cadastrar usuário -- Criado
            // Solicitar informações do usuário (Documentos) -- Criado
            // Implementar telefone do usuário -- Criar
            // Implementar Data de nascimento -- Criar

            Console.WriteLine("####Cadastro de usuário####\n");


            // Cadastro usuário 1
            Console.Write("Nome do 1 usuário: \n");
            p1 = new Pad();
            p1.Nome = Console.ReadLine();
            Console.Write("\nCPF do usuário: \n");
            p1.Cpf = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nIdade do 1 usuário: \n");
            p1.Idade = Convert.ToInt32(Console.ReadLine());

            // Cadastro usuário 2
            Console.Write("\nNome do 2 usuário: \n");
            p2 = new Pad();
            p2.Nome = Console.ReadLine();
            Console.Write("\nCPF do usuário: \n");
            p2.Cpf = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nIdade do 2 usuário: \n");
            p2.Idade = Convert.ToInt32(Console.ReadLine());

            // Cadastro usuário 3
            Console.Write("\nNome do 3 usuário: \n");
            p3 = new Pad();
            p3.Nome = Console.ReadLine();
            Console.Write("\nCPF do 3 usuário: \n");
            p3.Cpf = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nIdade do 3 usuário: \n");
            p3.Idade = Convert.ToInt32(Console.ReadLine());


            // Usuário cadastrado - Não foi possível cadastrar

            if ((p1.Idade >= 18)) 
            {
                Console.WriteLine("Usuário 1 cadastrado. \n"); // Se a idade for maior ou igual a 18 cadastrar usuário
                p1.ExibirDados(); 
            }
            else 
            {
                Console.WriteLine("Não foi possível cadastrar usuário 1 \n"); // Se o valor for menor que 18 exiber mensagem
            }

            {
                if ((p2.Idade >= 18))
                {
                    Console.WriteLine("Usuário 2 cadastrado. \n"); // Se a idade for maior ou igual a 18 cadastrar usuário
                    p2.ExibirDados(); 
                }
                else
                {
                    Console.WriteLine("Não foi possível cadastrar usuário 2 \n"); // Se o valor for menor que 18 exiber mensagem
                }

                if ((p3.Idade >= 18))
                {
                    Console.WriteLine("Usuário 3 cadastrado. \n"); // Se a idade for maior ou igual a 18 cadastrar usuário
                    p3.ExibirDados(); 
                }
                else
                {
                    {
                        Console.WriteLine("Não foi possível cadastrar usuário 3 \n"); // Se o valor for menor que 18 exiber mensagem
                    }
                }    
            }
            Console.ReadLine();
            }
        }
    }


