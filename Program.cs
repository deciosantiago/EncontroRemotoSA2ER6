using System;
using System.Threading;

namespace Encontro_Remoto
{

    class Program
    {

        static void Main(string[] args)
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(@$"

============================================
| Seja bem vindo ao cadastro de usuários   |
============================================
");

            BarraCarregamento("Iniciando");

            String? opcao;

            do
            {

                Console.WriteLine(@$"

        
============================================
| Escolha uma das opções abaixo:           |
| 1 - Pessoa Física                        |  
| 2 - Pessoa Jurídica                      |
| 3 - Calcula Imposto Pf
| 4 - Calcula Imposto Pj                   |
| 0 - Sair                                 |
|                                          |
============================================        
");


                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":

                        Endereco end = new Endereco();

                        end.logradouro = "Rua Dr Manoel Nogueira";
                        end.numero = 100;
                        end.complemento = "Próximo a Acdemia Movimento";
                        end.enderecoComercial = false;

                        PessoaFisica Pf = new PessoaFisica();

                        Pf.nome = "Décio Santiago dos Santos";
                        Pf.cpf = 80170734538;
                        Pf.dataDeNascimento = new DateTime(1982, 05, 24);
                        Pf.endereco = end;
                        Pf.rendimento = 1500;


                        Console.WriteLine(Pf.PagarImposto(Pf.rendimento));


                        PessoaFisica NovaPf = new PessoaFisica();
                        //NovaPf.ValidarDataNascimento(NovaPf.dataDeNascimento);



                        bool idadeValida = NovaPf.ValidarDataNascimento(NovaPf.dataDeNascimento);


                        Console.WriteLine("Maior de idade: " + idadeValida);

                        if (idadeValida == true)
                        {

                            Console.WriteLine("Cadastro Aprovado");

                        }
                        else
                        {

                            Console.WriteLine("Cadastro inválido");
                        }


                        break;

                    case "2":


                        PessoaJuridica pj = new PessoaJuridica();


                        PessoaJuridica novapj = new PessoaJuridica();

                        Endereco endPj = new Endereco();

                        endPj.logradouro = "Rua Dr Manoel Nogueira";
                        endPj.numero = 100;
                        endPj.complemento = "Próximo a Acdemia Movimento";
                        endPj.enderecoComercial = true;


                        novapj.endereco = endPj;
                        novapj.cnpj = "12345678910001";
                        novapj.razaoSocial = "Pessoa Juririca";
                        

                        if (pj.ValidarCNPJ(novapj.cnpj))
                        {

                            Console.WriteLine("Cnpj Válido");
                        }
                        else
                        {

                            Console.WriteLine("Cnpj inválido");


                        }
                        break;


                    case "3":

                        PessoaFisica Rendpf = new PessoaFisica();
                        PessoaFisica Pgpf = new PessoaFisica();
                        Rendpf.rendimento = 4500;

                        double DescontoPf = Pgpf.PagarImposto(Rendpf.rendimento);

                        Console.WriteLine(Pgpf.PagarImposto(Rendpf.rendimento));

                        break;


                    case "4":

                        PessoaJuridica Rendpj = new PessoaJuridica();
                        PessoaJuridica Pgpj = new PessoaJuridica();
                        Rendpj.rendimento = 15000;

                        double DescontoPj = Pgpj.PagarImposto(Rendpj.rendimento);

                        Console.WriteLine(Pgpj.PagarImposto(Rendpj.rendimento));

                        break;


                    case "0":

                        BarraCarregamento("Finalizando");

                        break;

                    default:

                        Console.WriteLine($"Opção inválida, digite uma opção válida");

                        break;



                }



            } while (opcao != "0");











            // Endereco end = new Endereco();

            // end.logradouro = "Rua Dr Manoel Nogueira";
            // end.numero = 100;
            // end.complemento = "Próximo a Acdemia Movimento";
            // end.enderecoComercial = false;

            // PessoaFisica Pf = new PessoaFisica();

            // Pf.nome = "Décio Santiago dos Santos";
            // Pf.cpf = 80170734538;
            // Pf.dataDeNascimento = new DateTime(1982, 05, 24);
            // Pf.endereco = end;


            // PessoaJuridica Pj = new PessoaJuridica();

            // Pj.cnpj = 21345762000102;
            // Pj.endereco = end;
            // Pj.razaoSocial = "DECIO S SANTOS ME";


            // PessoaFisica NovaPf = new PessoaFisica();
            // //NovaPf.ValidarDataNascimento(NovaPf.dataDeNascimento);

            // Console.WriteLine("Endereço: " + Pf.endereco.logradouro + ", " + Pf.endereco.numero);
            // Console.WriteLine("Pessoa Juridica:  \r\n" + "Cnpj: " + Pj.cnpj + ", " + "Razão social: " + Pj.razaoSocial);
            // Console.WriteLine("Pessoa Fisica:  \r\n" + "Nome: " + Pf.nome + ", " + "Cpf: " + Pf.cpf + ", " + "Data de Nasc: " + Pf.dataDeNascimento);
            // //Console.WriteLine("Maior de 18 anos? " + NovaPf.ValidarDataNascimento(Pf.dataDeNascimento) );

            // bool idadeValida = NovaPf.ValidarDataNascimento(NovaPf.dataDeNascimento);


            // Console.WriteLine("Maior de idade: " + idadeValida);

            // if (idadeValida == true)
            // {

            //     Console.WriteLine("Cadastro Aprovado");

            // }
            // else
            // {

            //     Console.WriteLine("Cadastro inválido");
            // }

            // PessoaJuridica pj = new PessoaJuridica();


            // PessoaJuridica novapj = new PessoaJuridica();

            // Endereco end = new Endereco();

            // end.logradouro = "Rua Dr Manoel Nogueira";
            // end.numero = 100;
            // end.complemento = "Próximo a Acdemia Movimento";
            // end.enderecoComercial = true;


            // novapj.endereco = end;
            // novapj.cnpj = "12345678910001";
            // novapj.razaoSocial = "Pessoa Juririca";

            // if (pj.ValidarCNPJ(novapj.cnpj)){

            //     Console.WriteLine("Cnpj Válido");
            // }else{

            //     Console.WriteLine("Cnpj inválido");


            // }






        }
        static void BarraCarregamento(string textoCarregamento)

        {

            Console.ResetColor();
            Console.WriteLine(textoCarregamento);
            Thread.Sleep(500);


            for (var contador = 0; contador < 10; contador++)
            {

                Console.Write($".");
                Thread.Sleep(500);

            }


            Console.ResetColor();

        }



    }



}

