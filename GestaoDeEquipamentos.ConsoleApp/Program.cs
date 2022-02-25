using System;

namespace GestaoDeEquipamentos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Arrays para armazenamento
            #region Equipamentos
            string[] nomeDoEquipamento = new string[1000];
            int[] idDosEquipamentos = new int[1000];
            decimal[] precoDoEquipamento = new decimal[1000];
            string[] numeroDeSerieDoEquipamento = new string[1000];
            string[] dataDeFabricacaoDoEquipamento = new string[1000];
            string[] fabricanteDoEquipamento = new string[1000];
            int registros = 0;
            #endregion


            #region Chamados
            string[] tituloDoChamado = new string[1000];
            string[] descricaoDoChamado = new string[1000];
            string[] dataAberturaChamado = new string[1000];
            string[] equipamentoAtreladoAoChamado = new string[1000];
            int[] idDosChamados = new int[1000];
            int[] diasEmAberto = new int[1000];
            int registrosChamado = 0;
            #endregion

            #endregion
            bool menu = true;
            while(menu == true)
            {
                Console.WriteLine("Qual opção deseja?");
                Console.WriteLine("1. Controle de Equipamentos\n2. Controle de Chamados\n3. Sair");
                int escolhaMenuInicial = int.Parse(Console.ReadLine());
                switch(escolhaMenuInicial)
                {
                    case 1: // Do menu geral
                        {
                            //Console.Clear();
                            Console.WriteLine("Equipamentos:");
                            Console.WriteLine("Qual opção deseja no menu de equipamentos?");
                            Console.WriteLine("1. Registrar equipamentos\n2. Visualizar equipamentos\n3. Editar equipamento\n4. Excluir equipamento");
                            int escolhaMenuEquipamentos = int.Parse(Console.ReadLine());
                            switch(escolhaMenuEquipamentos) 
                            {
                                case 1:
                                    {
                                        Console.WriteLine("Registrar");
                                        RegistrarEquipamentos(nomeDoEquipamento, precoDoEquipamento, numeroDeSerieDoEquipamento, dataDeFabricacaoDoEquipamento, fabricanteDoEquipamento, ref registros, idDosEquipamentos);
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine("Visualizar");
                                        VisualizarEquipamentos(nomeDoEquipamento, numeroDeSerieDoEquipamento, fabricanteDoEquipamento, registros, idDosEquipamentos);
                                        
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.WriteLine("Editar");
                                        EditarEquipamentos(nomeDoEquipamento, precoDoEquipamento, numeroDeSerieDoEquipamento, dataDeFabricacaoDoEquipamento, fabricanteDoEquipamento, ref registros, idDosEquipamentos);
                                        break;
                                    }
                                case 4:
                                    {
                                        Console.WriteLine("Excluir");
                                        break;
                                    }
                            }
                            break;
                        }



                    case 2: // Do menu geral
                        {
                            //Console.Clear();
                            Console.WriteLine("Chamados");
                            Console.WriteLine("Qual opção deseja no menu de chamados?");
                            Console.WriteLine("1. Registrar chamado\n2. Visualizar chamados\n3. Editar chamado\n4. Excluir chamado");
                            int escolhaMenuChamados = int.Parse(Console.ReadLine());
                            switch (escolhaMenuChamados)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("Registrar");
                                        RegistrarChamados(tituloDoChamado, descricaoDoChamado, dataAberturaChamado, equipamentoAtreladoAoChamado, nomeDoEquipamento, diasEmAberto, ref registrosChamado, ref registros, idDosEquipamentos, numeroDeSerieDoEquipamento, fabricanteDoEquipamento, idDosChamados);
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine("Visualizar");
                                        VisualizarChamados(tituloDoChamado, dataAberturaChamado, equipamentoAtreladoAoChamado, registrosChamado, idDosChamados);
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.WriteLine("Editar");
                                        EditarChamados(tituloDoChamado, descricaoDoChamado, dataAberturaChamado, equipamentoAtreladoAoChamado, nomeDoEquipamento, diasEmAberto, ref registrosChamado, ref registros, idDosEquipamentos, numeroDeSerieDoEquipamento, fabricanteDoEquipamento, idDosChamados);
                                        
                                        break;
                                    }
                                case 4:
                                    {
                                        Console.WriteLine("Excluir");
                                        break;
                                    }
                            }
                            break;
                        }

                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("Obrigado! :)");
                            menu = false;
                            break;
                        }
                }
            } // Fecha while
        } // Fecha main
        #region Métodos - Geral
        #region Métodos dos equipamentos
        static void RegistrarEquipamentos(string[] nomeDoEquipamento, decimal[] precoDoEquipamento, string[] numeroDeSerieDoEquipamento, string[] dataDeFabricacaoDoEquipamento, string[] fabricanteDoEquipamento, ref int registros, int[] idDosEquipamentos) 
        {
            
            Console.WriteLine("Registro de produtos:");
            ERROUMNOME:
            Console.Write("Digite o nome do produto: ");
            string nomeDoProduto = Console.ReadLine();
            if(nomeDoProduto.Length < 6)
            {
                Console.WriteLine("Nome inválido [Menos de 6 dígitos], tente novamente!");
                goto ERROUMNOME;
            }
            else
            {
                nomeDoEquipamento[registros] = nomeDoProduto;
            }

            Console.Write("Separado por vírgula, se necessário, digite o preço de compra do produto:\nR$");
            decimal preco = decimal.Parse(Console.ReadLine());
            precoDoEquipamento[registros] = preco;

            Console.Write("Informe o número de série do produto: ");
            numeroDeSerieDoEquipamento[registros] = Console.ReadLine();

            Console.Write("Insira a data (dia/mês/ano) de fabricação do produto: ");
            dataDeFabricacaoDoEquipamento[registros] = Console.ReadLine();

            Console.Write("Escreva o nome do fabricante do produto: ");
            fabricanteDoEquipamento[registros] = Console.ReadLine();

            Console.Write("ID do equipamento '" + nomeDoEquipamento[registros] + "': " + registros + "\n");
            idDosEquipamentos[registros] = registros;
            registros += 1;
        }
        static void VisualizarEquipamentos(string[] nomeDoEquipamento, string[] numeroDeSerieDoEquipamento, string[] fabricanteDoEquipamento, int registros, int[] idDosEquipamentos)
        {
            if(registros == 0)
            {
                Console.WriteLine("Ainda não há equipamentos registrados! :(");
            }
            else 
            { 
                for (int i = 0; i < registros; i++)
                {
                    if(nomeDoEquipamento[i] != "") { // Se o nome do equipamento for vazio, não tem equipamento na posicao [i] do array
                        Console.WriteLine("Posição: " + i);
                        Console.Write("Nome do equipamento " + (i+1) + ": ");
                        Console.WriteLine(nomeDoEquipamento[i]);
                        Console.Write("Nº de série: ");
                        Console.WriteLine(numeroDeSerieDoEquipamento[i]);
                        Console.Write("Fabricante: ");
                        Console.WriteLine(fabricanteDoEquipamento[i]);
                        Console.Write("ID: ");
                        Console.WriteLine(idDosEquipamentos[i]);
                        Console.WriteLine();
                    }
                }
            }
        }
        static void VisualizarParaEditar(string[] nomeDoEquipamento, decimal[] precoDoEquipamento, string[] numeroDeSerieDoEquipamento, string[] dataDeFabricacaoDoEquipamento, string[] fabricanteDoEquipamento, ref int registros, int[] idDosEquipamentos)
        {
            for (int i = 0; i < registros; i++)
            {
                if (nomeDoEquipamento[i] != "")
                { // Se o nome do equipament for vazio, não tem equipamento na posicao [i] do array
                    Console.WriteLine("Posição: " + i);
                    Console.Write("Nome do equipamento " + (i + 1) + ": ");
                    Console.WriteLine(nomeDoEquipamento[i]);
                    Console.Write("Preço de aquisiçao: ");
                    Console.WriteLine(precoDoEquipamento[i]);
                    Console.Write("Nº de série do equipamento: ");
                    Console.WriteLine(numeroDeSerieDoEquipamento[i]);
                    Console.Write("Data de fabricação:");
                    Console.WriteLine(dataDeFabricacaoDoEquipamento[i]);
                    Console.Write("Nome do fabricante: ");
                    Console.WriteLine(fabricanteDoEquipamento[i]);
                    Console.Write("ID (Não editável): ");
                    Console.WriteLine(idDosEquipamentos[i]);
                    Console.WriteLine();
                }
            }
        }
        static void EditarEquipamentos(string[] nomeDoEquipamento, decimal[] precoDoEquipamento, string[] numeroDeSerieDoEquipamento, string[] dataDeFabricacaoDoEquipamento, string[] fabricanteDoEquipamento, ref int registros, int[] idDosEquipamentos)
        {
            Console.WriteLine("Equipamentos registrados e suas posições:");
            VisualizarParaEditar(nomeDoEquipamento, precoDoEquipamento, numeroDeSerieDoEquipamento, dataDeFabricacaoDoEquipamento, fabricanteDoEquipamento, ref registros, idDosEquipamentos);
            Console.WriteLine("Gostaria de editar as informações do equipamentos de qual posição?");
            int posicaoParaEditar = int.Parse(Console.ReadLine());
        ERRODOISEDITAR:
            Console.WriteLine("Editar na posição " + posicaoParaEditar + ":\n" +
                "1. Nome | 2. Preço | 3. Nº de série | 4. Data de fabricação | 5. Fabricante");
            int escolha = int.Parse(Console.ReadLine());
            if(escolha == 1)
            {
                Console.Write("Digite novo nome: ");
                nomeDoEquipamento[posicaoParaEditar] = Console.ReadLine();
            } else if(escolha == 2)
            {
                Console.Write("Digite novo preço: ");
                precoDoEquipamento[posicaoParaEditar] = Convert.ToDecimal(Console.ReadLine());
            } else if(escolha == 3) 
            {
                Console.Write("Digite novo nº de série: ");
                numeroDeSerieDoEquipamento[posicaoParaEditar] = Console.ReadLine();
            } else if(escolha == 4)
            {
                Console.Write("Digite nova data (dia/mês/ano) de fabricação: ");
                dataDeFabricacaoDoEquipamento[posicaoParaEditar] = Console.ReadLine();
            } else if (escolha == 5)
            {
                Console.Write("Digite novo nome do fabricante: ");
                fabricanteDoEquipamento[posicaoParaEditar] = Console.ReadLine();
            } else
            {
                Console.Write("Opção inválida, tente novamente!\n");
                goto ERRODOISEDITAR;
            }
        }
        #endregion




        #region Métodos dos chamados
        static void RegistrarChamados(string[] tituloDoChamado, string[] descricaoDoChamado, string[] dataAberturaChamado, string[] equipamentoAtreladoAoChamado, string[] nomeDoEquipamento,int[] diasEmAberto, ref int registrosChamado, ref int registros, int[] idDosEquipamentos, string[] numeroDeSerieDoEquipamento, string[] fabricanteDoEquipamento, int[] idDosChamados)
        {
            if(registros == 0)
            {
                Console.WriteLine("É necessário cadastrar equipamentos para abrir um chamado do mesmo.\nRegistre e repita este processo!");
            } else
            {
                Console.WriteLine("Estes são os equipamentos disponíveis:");
                VisualizarEquipamentos(nomeDoEquipamento, numeroDeSerieDoEquipamento, fabricanteDoEquipamento, registros, idDosEquipamentos);
                Console.WriteLine("Informe o número 'ID' do equipamento que deseja abrir chamado: ");
                int equipamentoEscolhido = int.Parse(Console.ReadLine());
                equipamentoAtreladoAoChamado[registrosChamado] = nomeDoEquipamento[equipamentoEscolhido]; // Registro X terá equipamento (id) Y atrelado à si

                Console.Write("Digite o título do chamado (Resumo do problema): ");
                tituloDoChamado[registrosChamado] = Console.ReadLine();

                Console.Write("Informe uma breve descrição do problema: ");
                descricaoDoChamado[registrosChamado] = Console.ReadLine();

                Console.Write("Insira a data (dia/mês/ano) de criação do chamado: ");
                dataAberturaChamado[registrosChamado] = Console.ReadLine();
                idDosChamados[registrosChamado] = registrosChamado;
                registrosChamado += 1; // Registro criado
            }
            
        }
        static void VisualizarChamados(string[] tituloDoChamado, string [] dataAberturaChamado, string[] equipamentoAtreladoAoChamado, int registrosChamado, int[] idDosChamados)
        {
            if(registrosChamado == 0)
            {
                Console.WriteLine("Ainda não há chamados em aberto! :(");
            } else
            {
                for (int i = 0; i < registrosChamado; i++)
                {
                    if (tituloDoChamado[i] != "") // Se estiver com algo, existe um chamado nessa posição, caso contrário, não
                    {
                        Console.Write("ID do chamado: " + idDosChamados[i]);
                        Console.Write("Título do chamado: ");
                        Console.WriteLine(tituloDoChamado[i]);
                        Console.Write("Equipamento atrelado: ");
                        Console.WriteLine(equipamentoAtreladoAoChamado[i]);
                        Console.Write("Data de abertura: ");
                        Console.WriteLine(dataAberturaChamado[i]);
                        Console.Write("Dias em aberto: ");
                        Console.WriteLine("Resolvendo isso aqui...");
                        Console.WriteLine();
                    }
                }
            }
        }
        static void VisualizarParaEditar(string[] tituloDoChamado, string[] descricaoDoChamado, string[] equipamentoAtreladoAoChamado, string[] dataAberturaChamado, ref int registrosChamado, int[] idDosChamados)
        {
            for (int i = 0; i < registrosChamado; i++)
            {
                if (tituloDoChamado[i] != "")
                {
                    Console.Write("ID do chamado: " + idDosChamados[i]);
                    Console.Write("Título do chamado: ");
                    Console.WriteLine(tituloDoChamado[i]);
                    Console.Write("Descrição do chamado: ");
                    Console.WriteLine(descricaoDoChamado[i]);
                    Console.Write("Equipamento atrelado: ");
                    Console.WriteLine(equipamentoAtreladoAoChamado[i]);
                    Console.Write("Data de abertura:");
                    Console.WriteLine(dataAberturaChamado[i]);
                    Console.Write("ID (Não editável): ");
                    Console.WriteLine(idDosChamados[i]);
                    Console.WriteLine();
                }
            }
        }
        static void EditarChamados(string[] tituloDoChamado, string[] descricaoDoChamado, string[] dataAberturaChamado, string[] equipamentoAtreladoAoChamado, string[] nomeDoEquipamento, int[] diasEmAberto, ref int registrosChamado, ref int registros, int[] idDosEquipamentos, string[] numeroDeSerieDoEquipamento, string[] fabricanteDoEquipamento, int[] idDosChamados)
        {
            Console.WriteLine("Chamados em aberto: ");
            VisualizarParaEditar(tituloDoChamado, descricaoDoChamado, equipamentoAtreladoAoChamado, dataAberturaChamado, ref registrosChamado, idDosChamados);
            Console.Write("Escolha através do número do 'ID' do chamado para selecioná-lo para editar: ");
            int idChamadorParaEditar = int.Parse(Console.ReadLine());
            ERROTRESEDITAR:
            Console.WriteLine("Editar no 'ID' " + idChamadorParaEditar + ":\n" +
                "1. Título | 2. Descrição | 3. Equipamento atrelado | 4. Data de abertura");
            int escolha = int.Parse(Console.ReadLine());
            if(escolha == 1)
            {
                Console.Write("Digite novo título: ");
                tituloDoChamado[idChamadorParaEditar] = Console.ReadLine();
            } else if(escolha == 2)
            {
                Console.Write("Digite nova descrição: ");
                descricaoDoChamado[idChamadorParaEditar] = Console.ReadLine();
            } else if(escolha == 3)
            {
                Console.WriteLine("Estes são os equipamentos disponíveis:");
                VisualizarEquipamentos(nomeDoEquipamento, numeroDeSerieDoEquipamento, fabricanteDoEquipamento, registros, idDosEquipamentos);
                Console.Write("Através do 'ID', escolha qual equipamento gostaria de atrelar à esse chamado: ");
                int equipamentoEscolhido = int.Parse(Console.ReadLine());
                equipamentoAtreladoAoChamado[idChamadorParaEditar] = nomeDoEquipamento[equipamentoEscolhido];
            } else if(escolha == 4)
            {
                Console.Write("Escolha uma nova data (dia/mês/ano) de abertura: ");
                dataAberturaChamado[idChamadorParaEditar] = Console.ReadLine();
            } else
            {
                Console.WriteLine("Opção inválida, tente novamente!");
                goto ERROTRESEDITAR;
            }
        }
        #endregion

        #endregion
    }
}