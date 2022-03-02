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
            #region Solicitantes
            string[] nomeDoSolicitante = new string[1000];
            string[] emailDoSolicitante = new string[1000];
            string[] telefoneDoSolicitante = new string[1000];
            string[] solicitanteAtreladoAoChamado = new string[1000];
            int[] idDosSolicitantes = new int[1000];
            int solicitantes = 0;
            #endregion

            #endregion
            bool menu = true;
            while (menu == true)
            {
                Console.WriteLine("Menu\n\nQual opção deseja?\n");
                Console.Write("1. Controle de Equipamentos\n2. Controle de Chamados\n3. Solicitantes\n4. Sair\n> ");
                int escolhaMenuInicial = int.Parse(Console.ReadLine());
                switch (escolhaMenuInicial)
                {
                    case 1: // Do menu geral
                        {
                            Console.Clear();
                            Console.WriteLine("Menu > Equipamentos:\n");
                            Console.WriteLine("Qual opção deseja no menu de equipamentos?\n");
                            Console.Write("1. Registrar equipamentos\n2. Visualizar equipamentos\n3. Editar equipamento\n4. Excluir equipamento\n5. Voltar\n> ");
                            int escolhaMenuEquipamentos = int.Parse(Console.ReadLine());
                            switch (escolhaMenuEquipamentos)
                            {
                                case 1:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Menu > Equipamentos > Registrar:\n");
                                        RegistrarEquipamentos(nomeDoEquipamento, precoDoEquipamento, numeroDeSerieDoEquipamento, dataDeFabricacaoDoEquipamento, fabricanteDoEquipamento, ref registros, idDosEquipamentos);
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Menu > Equipamentos > Visualizar:\n");
                                        VisualizarEquipamentos(nomeDoEquipamento, numeroDeSerieDoEquipamento, fabricanteDoEquipamento, registros, idDosEquipamentos);

                                        break;
                                    }
                                case 3:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Menu > Equipamentos > Editar:\n");
                                        EditarEquipamentos(nomeDoEquipamento, precoDoEquipamento, numeroDeSerieDoEquipamento, dataDeFabricacaoDoEquipamento, fabricanteDoEquipamento, ref registros, idDosEquipamentos);
                                        break;
                                    }
                                case 4:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Menu > Equipamentos > Excluir:\n");
                                        ExcluirEquipamentos(nomeDoEquipamento, precoDoEquipamento, numeroDeSerieDoEquipamento, dataDeFabricacaoDoEquipamento, fabricanteDoEquipamento, ref registros, idDosEquipamentos, equipamentoAtreladoAoChamado, ref registrosChamado);
                                        break;
                                    }
                                case 5:
                                    {
                                        Console.Clear();
                                        break;
                                    }
                                default:
                                    Console.WriteLine("Opção inválida!");
                                    break;
                            }
                            break;
                        }

                    case 2: // Do menu geral
                        {
                            Console.Clear();
                            Console.WriteLine("Menu > Chamados:\n");
                            Console.WriteLine("Qual opção deseja no menu de chamados?\n");
                            Console.Write("1. Registrar chamado\n2. Visualizar chamados\n3. Editar chamado\n4. Excluir chamado\n5. Voltar\n> ");
                            int escolhaMenuChamados = int.Parse(Console.ReadLine());
                            switch (escolhaMenuChamados)
                            {
                                case 1:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Menu > Chamados > Registrar:\n");
                                        RegistrarChamados(tituloDoChamado, descricaoDoChamado, dataAberturaChamado, equipamentoAtreladoAoChamado, nomeDoEquipamento, diasEmAberto, ref registrosChamado, ref registros, idDosEquipamentos, numeroDeSerieDoEquipamento, fabricanteDoEquipamento, idDosChamados);
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Menu > Chamados > Visualizar:\n");
                                        VisualizarChamados(tituloDoChamado, dataAberturaChamado, equipamentoAtreladoAoChamado, registrosChamado, idDosChamados);
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Menu > Chamados > Editar:\n");
                                        EditarChamados(tituloDoChamado, descricaoDoChamado, dataAberturaChamado, equipamentoAtreladoAoChamado, nomeDoEquipamento, diasEmAberto, ref registrosChamado, ref registros, idDosEquipamentos, numeroDeSerieDoEquipamento, fabricanteDoEquipamento, idDosChamados);

                                        break;
                                    }
                                case 4:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Menu > Chamados > Excluir:\n");
                                        ExcluirChamado(tituloDoChamado, descricaoDoChamado, dataAberturaChamado, equipamentoAtreladoAoChamado, nomeDoEquipamento, ref registrosChamado, ref registros, idDosEquipamentos, numeroDeSerieDoEquipamento, fabricanteDoEquipamento, idDosChamados);
                                        break;
                                    }
                                case 5:
                                    {
                                        Console.Clear();
                                        break;
                                    }
                                default:
                                    Console.WriteLine("Opção inválida!");
                                    break;
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("Menu > Solicitantes:\n");
                            Console.WriteLine("Qual opção deseja no menu de solicitantes?\n");
                            Console.Write("1. Registrar solicitante\n2. Visualizar solicitantes\n3. Editar solicitante\n4. Excluir solicitante\n5. Voltar\n> ");
                            int escolhaMenuSolicitantes = int.Parse(Console.ReadLine());
                            switch (escolhaMenuSolicitantes)
                            {
                                case 1:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Menu > Solicitantes > Registrar:\n");
                                        RegistrarSolicitantes(nomeDoSolicitante, emailDoSolicitante, telefoneDoSolicitante, solicitanteAtreladoAoChamado, idDosSolicitantes, ref solicitantes);
                                        break;
                                    }

                                case 2:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Menu > Solicitantes > Visualizar:\n");
                                        VisualizarSolicitantes(nomeDoSolicitante, emailDoSolicitante, telefoneDoSolicitante, solicitanteAtreladoAoChamado, idDosSolicitantes, ref solicitantes);
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Menu > Solicitantes > Editar:\n");
                                        EditarSolicitantes(nomeDoSolicitante, emailDoSolicitante, telefoneDoSolicitante, solicitanteAtreladoAoChamado, idDosSolicitantes, ref solicitantes);
                                        break;
                                    }
                                case 4:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Menu > Solicitantes > Excluir:\n");
                                        ExcluirSolicitante(nomeDoSolicitante, emailDoSolicitante, telefoneDoSolicitante, solicitanteAtreladoAoChamado, idDosSolicitantes, ref solicitantes);
                                        break;
                                    }
                                case 5:
                                    {
                                        Console.Clear();
                                        break;
                                    }
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("Obrigado! :)");
                            menu = false;
                            break;
                        }
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        } // Fecha main
        #region Métodos - Geral

        #region Métodos dos equipamentos
        static void RegistrarEquipamentos(string[] nomeDoEquipamento, decimal[] precoDoEquipamento, string[] numeroDeSerieDoEquipamento, string[] dataDeFabricacaoDoEquipamento, string[] fabricanteDoEquipamento, ref int registros, int[] idDosEquipamentos)
        {
        ERROUMNOME:
            Console.Write("Nome......................: ");
            string nomeDoProduto = Console.ReadLine();
            if (nomeDoProduto.Length < 6)
            {
                Console.WriteLine("Nome inválido [Menos de 6 dígitos], tente novamente!");
                goto ERROUMNOME;
            }
            else
            {
                nomeDoEquipamento[registros] = nomeDoProduto;
            }

            Console.Write("ID '" + nomeDoEquipamento[registros] + "'........: " + registros + "\n");
            idDosEquipamentos[registros] = registros;

            Console.Write("Custo.....................: R$");
            decimal preco = decimal.Parse(Console.ReadLine());
            precoDoEquipamento[registros] = preco;

            Console.Write("Nº de série...............: ");
            numeroDeSerieDoEquipamento[registros] = Console.ReadLine();

            Console.Write("Data (D/M/A) de fabricação: ");
            dataDeFabricacaoDoEquipamento[registros] = Console.ReadLine();

            Console.Write("Fabricante................: ");
            fabricanteDoEquipamento[registros] = Console.ReadLine();

            registros += 1;
            Console.Clear();
            MensagemInformativa("Equipamento registrado com sucesso!", ConsoleColor.Green);
        }
        static void VisualizarEquipamentos(string[] nomeDoEquipamento, string[] numeroDeSerieDoEquipamento, string[] fabricanteDoEquipamento, int registros, int[] idDosEquipamentos)
        {
            if (registros == 0)
            {
                Console.WriteLine("\nAinda não há equipamentos registrados! :(\n");
            }
            else
            {
                for (int i = 0; i < registros; i++)
                {
                    if (nomeDoEquipamento[i] != "")
                    { // Se o nome do equipamento for vazio, não tem equipamento na posicao [i] do array
                        Console.WriteLine("ID.........: " + idDosEquipamentos[i]);
                        Console.Write("Nome.......: ");
                        Console.WriteLine(nomeDoEquipamento[i]);
                        Console.Write("Nº de série: ");
                        Console.WriteLine(numeroDeSerieDoEquipamento[i]);
                        Console.Write("Fabricante.: ");
                        Console.WriteLine(fabricanteDoEquipamento[i]);
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
                    Console.Write("ID.........: ");
                    Console.WriteLine(idDosEquipamentos[i]);
                    Console.Write("Nome.......: ");
                    Console.WriteLine(nomeDoEquipamento[i]);
                    Console.Write("Custo......: ");
                    Console.WriteLine(precoDoEquipamento[i]);
                    Console.Write("Nº de série: ");
                    Console.WriteLine(numeroDeSerieDoEquipamento[i]);
                    Console.Write("Fabricação.: ");
                    Console.WriteLine(dataDeFabricacaoDoEquipamento[i]);
                    Console.Write("Fabricante.: ");
                    Console.WriteLine(fabricanteDoEquipamento[i]);
                    Console.WriteLine();
                }
            }
        }
        static void EditarEquipamentos(string[] nomeDoEquipamento, decimal[] precoDoEquipamento, string[] numeroDeSerieDoEquipamento, string[] dataDeFabricacaoDoEquipamento, string[] fabricanteDoEquipamento, ref int registros, int[] idDosEquipamentos)
        {
            if (registros == 0)
            {
                Console.WriteLine("\nAinda não há equipamentos registrados! :(\n");
            }
            else
            {
                Console.WriteLine("Equipamentos registrados e suas posições:\n");
                VisualizarParaEditar(nomeDoEquipamento, precoDoEquipamento, numeroDeSerieDoEquipamento, dataDeFabricacaoDoEquipamento, fabricanteDoEquipamento, ref registros, idDosEquipamentos);
                Console.Write("Gostaria de editar as informações do equipamentos de qual ID?\n> ");
                int posicaoParaEditar = int.Parse(Console.ReadLine());
            ERRODOISEDITAR:
                Console.WriteLine("Editar ID '" + posicaoParaEditar + "' (" + nomeDoEquipamento[posicaoParaEditar] + ")" + ":\n" +
                    "1. Nome | 2. Custo | 3. Nº de série | 4. Data de fabricação | 5. Fabricante");
                int escolha = int.Parse(Console.ReadLine());
                if (escolha == 1)
                {
                ERROQUATRONOMEEDITCAO:
                    Console.Write("Digite novo nome: ");
                    string novoNome = Console.ReadLine();
                    if (novoNome.Length < 6)
                    {
                        Console.WriteLine("Nome inválido [Menos de 6 dígitos], tente novamente!");
                        goto ERROQUATRONOMEEDITCAO;
                    }
                    nomeDoEquipamento[posicaoParaEditar] = novoNome;
                }
                else if (escolha == 2)
                {
                    Console.Write("Digite novo custo: ");
                    precoDoEquipamento[posicaoParaEditar] = Convert.ToDecimal(Console.ReadLine());
                }
                else if (escolha == 3)
                {
                    Console.Write("Digite novo nº de série: ");
                    numeroDeSerieDoEquipamento[posicaoParaEditar] = Console.ReadLine();
                }
                else if (escolha == 4)
                {
                    Console.Write("Digite nova data (dia/mês/ano) de fabricação: ");
                    dataDeFabricacaoDoEquipamento[posicaoParaEditar] = Console.ReadLine();
                }
                else if (escolha == 5)
                {
                    Console.Write("Digite novo nome do fabricante: ");
                    fabricanteDoEquipamento[posicaoParaEditar] = Console.ReadLine();
                }
                else
                {
                    Console.Write("Opção inválida, tente novamente!\n");
                    goto ERRODOISEDITAR;
                }
                Console.Clear();
                MensagemInformativa("Equipamento editado com sucesso!", ConsoleColor.DarkYellow);
            }
        }
        static void VisualizarParaExcluir(string[] nomeDoEquipamento, decimal[] precoDoEquipamento, string[] numeroDeSerieDoEquipamento, string[] dataDeFabricacaoDoEquipamento, string[] fabricanteDoEquipamento, ref int registros, int[] idDosEquipamentos, string[] equipamentoAtreladoAoChamado)
        {
            for (int i = 0; i < registros; i++)
            {
                if (nomeDoEquipamento[i] != "")
                {
                    Console.Write("ID.........: ");
                    Console.WriteLine(idDosEquipamentos[i]);
                    Console.Write("Nome.......: ");
                    Console.WriteLine(nomeDoEquipamento[i]);
                    Console.Write("Custo......: ");
                    Console.WriteLine(precoDoEquipamento[i]);
                    Console.Write("Nº de série: ");
                    Console.WriteLine(numeroDeSerieDoEquipamento[i]);
                    Console.Write("Fabricação.: ");
                    Console.WriteLine(dataDeFabricacaoDoEquipamento[i]);
                    Console.Write("Fabricante.: ");
                    Console.WriteLine(fabricanteDoEquipamento[i]);
                    Console.WriteLine();
                }
            }
        }
        static void ExcluirEquipamentos(string[] nomeDoEquipamento, decimal[] precoDoEquipamento, string[] numeroDeSerieDoEquipamento, string[] dataDeFabricacaoDoEquipamento, string[] fabricanteDoEquipamento, ref int registros, int[] idDosEquipamentos, string[] equipamentoAtreladoAoChamado, ref int registrosChamado)
        {
            int quantiaDeGiros = 0;
            bool podeExcluir = true;
            if (registros == 0)
            {
                Console.WriteLine("\nAinda não há equipamentos registrados! :(\n");
            }
            else
            {
                Console.WriteLine("Equipamentos registrados: \n");
                VisualizarParaExcluir(nomeDoEquipamento, precoDoEquipamento, numeroDeSerieDoEquipamento, dataDeFabricacaoDoEquipamento, fabricanteDoEquipamento, ref registros, idDosEquipamentos, equipamentoAtreladoAoChamado);
                Console.Write("Digite o 'ID' do equipamento para excluir: ");
                int idParaExcluir = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (registros > registrosChamado)
                {
                    quantiaDeGiros = registros;
                }
                else
                {
                    quantiaDeGiros = registrosChamado;
                }
                for (int i = 0; i < quantiaDeGiros; i++)
                {
                    if (equipamentoAtreladoAoChamado[i] == nomeDoEquipamento[idParaExcluir])
                    {
                        podeExcluir = false;
                    }
                }
                if (podeExcluir == false)
                {
                    Console.WriteLine();
                    MensagemInformativa("Desculpe! Não posso excluir esse equipamento pois ele está atrelado a um chamado", ConsoleColor.DarkRed);
                }
                if (podeExcluir == true)
                {
                    for (int i = idParaExcluir; i < registros; i++)
                    {
                        nomeDoEquipamento[i] = nomeDoEquipamento[i + 1];
                        precoDoEquipamento[i] = precoDoEquipamento[i + 1];
                        numeroDeSerieDoEquipamento[i] = numeroDeSerieDoEquipamento[i + 1];
                        dataDeFabricacaoDoEquipamento[i] = numeroDeSerieDoEquipamento[i + 1];
                        fabricanteDoEquipamento[i] = fabricanteDoEquipamento[i + 1];
                    }
                    registros -= 1;
                    Console.Clear();
                    MensagemInformativa("Equipamento excluído com sucesso!", ConsoleColor.Red);
                }
            }
        }
        #endregion

        #region Métodos dos chamados
        static void RegistrarChamados(string[] tituloDoChamado, string[] descricaoDoChamado, string[] dataAberturaChamado, string[] equipamentoAtreladoAoChamado, string[] nomeDoEquipamento, int[] diasEmAberto, ref int registrosChamado, ref int registros, int[] idDosEquipamentos, string[] numeroDeSerieDoEquipamento, string[] fabricanteDoEquipamento, int[] idDosChamados)
        {
            if (registros == 0)
            {
                Console.WriteLine("É necessário cadastrar equipamentos para abrir um chamado.\nRegistre e repita este processo!\n");
            }
            else
            {
                Console.WriteLine("Estes são os equipamentos disponíveis:");
                VisualizarEquipamentos(nomeDoEquipamento, numeroDeSerieDoEquipamento, fabricanteDoEquipamento, registros, idDosEquipamentos);
                Console.WriteLine("Informe o número 'ID' do equipamento que deseja abrir chamado: ");
                int idEscolhido = int.Parse(Console.ReadLine());
                equipamentoAtreladoAoChamado[registrosChamado] = nomeDoEquipamento[idEscolhido]; // Registro X terá equipamento (id) Y atrelado à si

                Console.Write("Digite o título do chamado (Resumo do problema): ");
                tituloDoChamado[registrosChamado] = Console.ReadLine();

                Console.Write("Informe uma breve descrição do problema: ");
                descricaoDoChamado[registrosChamado] = Console.ReadLine();

                Console.Write("Insira a data (dia/mês/ano) de criação do chamado: ");
                dataAberturaChamado[registrosChamado] = Console.ReadLine();
                idDosChamados[registrosChamado] = registrosChamado;
                registrosChamado += 1; // Registro criado
                Console.Clear();
            }

        }
        static void VisualizarChamados(string[] tituloDoChamado, string[] dataAberturaChamado, string[] equipamentoAtreladoAoChamado, int registrosChamado, int[] idDosChamados)
        {
            if (registrosChamado == 0)
            {
                Console.WriteLine("Ainda não há chamados em aberto! :(\n");
            }
            else
            {
                for (int i = 0; i < registrosChamado; i++)
                {
                    if (tituloDoChamado[i] != "") // Se estiver com algo, existe um chamado nessa posição, caso contrário, não
                    {
                        Console.WriteLine("ID do chamado.......: " + idDosChamados[i]);
                        Console.Write("Título do chamado...: ");
                        Console.WriteLine(tituloDoChamado[i]);
                        Console.Write("Equipamento atrelado: ");
                        Console.WriteLine(equipamentoAtreladoAoChamado[i]);
                        Console.Write("Data de abertura....: ");
                        Console.WriteLine(dataAberturaChamado[i]);
                        DateTime hoje = DateTime.Now;
                        string strDataAbertoChamado = dataAberturaChamado[i];
                        string[] dataSeparada = strDataAbertoChamado.Split("/");
                        int dia = int.Parse(dataSeparada[0]);
                        int mes = int.Parse(dataSeparada[1]);
                        int ano = int.Parse(dataSeparada[2]);
                        DateTime criacaoDoChamado = new DateTime(ano, mes, dia);
                        int diasEmAberto = (hoje - criacaoDoChamado).Days;
                        Console.Write("Dias em aberto......: ");
                        Console.WriteLine(diasEmAberto + " dias...");
                        Console.WriteLine();
                    }
                }
            }
        }
        static void VisualizarParaEditarOuExcluir(string[] tituloDoChamado, string[] descricaoDoChamado, string[] equipamentoAtreladoAoChamado, string[] dataAberturaChamado, ref int registrosChamado, int[] idDosChamados)
        {
            for (int i = 0; i < registrosChamado; i++)
            {
                if (tituloDoChamado[i] != "")
                {
                    Console.WriteLine("ID do chamado.......: " + idDosChamados[i]);
                    Console.Write("Título do chamado...: ");
                    Console.WriteLine(tituloDoChamado[i]);
                    Console.Write("Descrição do chamado: ");
                    Console.WriteLine(descricaoDoChamado[i]);
                    Console.Write("Equipamento atrelado: ");
                    Console.WriteLine(equipamentoAtreladoAoChamado[i]);
                    Console.Write("Data de abertura....: ");
                    Console.WriteLine(dataAberturaChamado[i]);
                    Console.WriteLine();
                }
            }
        }
        static void EditarChamados(string[] tituloDoChamado, string[] descricaoDoChamado, string[] dataAberturaChamado, string[] equipamentoAtreladoAoChamado, string[] nomeDoEquipamento, int[] diasEmAberto, ref int registrosChamado, ref int registros, int[] idDosEquipamentos, string[] numeroDeSerieDoEquipamento, string[] fabricanteDoEquipamento, int[] idDosChamados)
        {
            if (registrosChamado == 0)
            {
                Console.WriteLine("Ainda não há chamados em aberto! :(\n");
            }
            else
            {
                Console.WriteLine("Chamados em aberto: \n");
                VisualizarParaEditarOuExcluir(tituloDoChamado, descricaoDoChamado, equipamentoAtreladoAoChamado, dataAberturaChamado, ref registrosChamado, idDosChamados);
                Console.Write("Escolha através do número do 'ID' do chamado para selecioná-lo para editar: ");
                int idChamadorParaEditar = int.Parse(Console.ReadLine());
            ERROTRESEDITAR:
                Console.WriteLine("Editar no 'ID' " + idChamadorParaEditar + ":\n" +
                    "1. Título | 2. Descrição | 3. Equipamento atrelado | 4. Data de abertura");
                int escolha = int.Parse(Console.ReadLine());
                if (escolha == 1)
                {
                    Console.Write("Digite novo título: ");
                    tituloDoChamado[idChamadorParaEditar] = Console.ReadLine();
                }
                else if (escolha == 2)
                {
                    Console.Write("Digite nova descrição: ");
                    descricaoDoChamado[idChamadorParaEditar] = Console.ReadLine();
                }
                else if (escolha == 3)
                {
                    Console.WriteLine("Estes são os equipamentos disponíveis:");
                    VisualizarEquipamentos(nomeDoEquipamento, numeroDeSerieDoEquipamento, fabricanteDoEquipamento, registros, idDosEquipamentos);
                    Console.Write("Através do 'ID', escolha qual equipamento gostaria de atrelar à esse chamado: ");
                    int equipamentoEscolhido = int.Parse(Console.ReadLine());
                    equipamentoAtreladoAoChamado[idChamadorParaEditar] = nomeDoEquipamento[equipamentoEscolhido];
                }
                else if (escolha == 4)
                {
                    Console.Write("Escolha uma nova data (dia/mês/ano) de abertura: ");
                    dataAberturaChamado[idChamadorParaEditar] = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Opção inválida, tente novamente!");
                    goto ERROTRESEDITAR;
                }
                Console.Clear();
                MensagemInformativa("Chamado atualizado com sucesso!", ConsoleColor.Cyan);
            }
        }
        static void ExcluirChamado(string[] tituloDoChamado, string[] descricaoDoChamado, string[] dataAberturaChamado, string[] equipamentoAtreladoAoChamado, string[] nomeDoEquipamento, ref int registrosChamado, ref int registros, int[] idDosEquipamentos, string[] numeroDeSerieDoEquipamento, string[] fabricanteDoEquipamento, int[] idDosChamados)
        {
            if (registrosChamado == 0)
            {
                Console.WriteLine("Ainda não há chamados em aberto! :(\n");
            }
            else
            {
                Console.WriteLine("Chamados em aberto: ");
                VisualizarParaEditarOuExcluir(tituloDoChamado, descricaoDoChamado, equipamentoAtreladoAoChamado, dataAberturaChamado, ref registrosChamado, idDosChamados);
                Console.Write("Escolha através do número do 'ID' do chamado para selecioná-lo para excluir: ");
                int idParaExcluir = int.Parse(Console.ReadLine());
                for (int i = idParaExcluir; i < registrosChamado; i++)
                {
                    tituloDoChamado[i] = tituloDoChamado[i + 1];
                    descricaoDoChamado[i] = descricaoDoChamado[i + 1];
                    dataAberturaChamado[i] = descricaoDoChamado[i + 1];
                    equipamentoAtreladoAoChamado[i] = equipamentoAtreladoAoChamado[i + 1];
                }
                registrosChamado -= 1;
                Console.Clear();
                MensagemInformativa("Chamado excluído com sucesso!", ConsoleColor.DarkRed);
            }
        }
        #endregion

        #region Métodos dos solicitantes
        static void RegistrarSolicitantes(string[] nomeDoSolicitante, string[] emailDoSolicitante, string[] telefoneDoSolicitante, string[] solicitanteAtreladoAoChamado, int[] idDosSolicitantes, ref int solicitantes)
        {
        ERROQUATRONOME:
            Console.Write("Nome......................: ");
            string nomeSolicitante = Console.ReadLine();
            if (nomeSolicitante.Length < 6)
            {
                Console.WriteLine("Nome inválido [Menos de 6 dígitos], tente novamente!");
                goto ERROQUATRONOME;
            }
            else
            {
                nomeDoSolicitante[solicitantes] = nomeSolicitante;
            }
            Console.Write("ID '" + nomeDoSolicitante[solicitantes] + "'........: " + solicitantes + "\n");
            idDosSolicitantes[solicitantes] = solicitantes;
            Console.Write("E-mail....................: ");
            string email = Console.ReadLine();
            emailDoSolicitante[solicitantes] = email;
            Console.Write("Telefone..................: ");
            string telefone = Console.ReadLine();
            telefoneDoSolicitante[solicitantes] = telefone;
            Console.Clear();
            MensagemInformativa("Solicitante cadastrado com sucesso!", ConsoleColor.Green);
            solicitantes += 1; // Solicitante criado
        }
        static void VisualizarSolicitantes(string[] nomeDoSolicitante, string[] emailDoSolicitante, string[] telefoneDoSolicitante, string[] solicitanteAtreladoAoChamado, int[] idDosSolicitantes, ref int solicitantes)
        {
            if(solicitantes == 0)
            {
                Console.WriteLine("\nAinda não há solicitantes registrados! :(\n");
            }
            else
            {
                for (int i = 0; i < solicitantes; i++)
                {
                    if (nomeDoSolicitante[i] != null)
                    {
                        Console.WriteLine("ID.........: " + idDosSolicitantes[i]);
                        Console.Write("Nome.......: ");
                        Console.WriteLine(nomeDoSolicitante[i]);
                        Console.Write("E-mail.....: ");
                        Console.WriteLine(emailDoSolicitante[i]);
                        Console.Write("Telefone...: ");
                        Console.WriteLine(telefoneDoSolicitante[i]);
                        Console.WriteLine();
                    }
                }
            }
        }
        static void EditarSolicitantes(string[] nomeDoSolicitante, string[] emailDoSolicitante, string[] telefoneDoSolicitante, string[] solicitanteAtreladoAoChamado, int[] idDosSolicitantes, ref int solicitantes)
        {
            if (solicitantes == 0)
            {
                Console.WriteLine("\nAinda não há solicitantes registrados! :(\n");
            }
            else
            {
                for (int i = 0; i < solicitantes; i++)
                {
                    if (nomeDoSolicitante[i] != null)
                    {
                        Console.WriteLine("ID.........: " + idDosSolicitantes[i]);
                        Console.Write("Nome.......: ");
                        Console.WriteLine(nomeDoSolicitante[i]);
                        Console.Write("E-mail.....: ");
                        Console.WriteLine(emailDoSolicitante[i]);
                        Console.Write("Telefone...: ");
                        Console.WriteLine(telefoneDoSolicitante[i]);
                        Console.WriteLine();
                    }
                }
                Console.Write("Escolha o 'ID' do solicitante para editar: ");
                int idSolicitanteParaEditar = int.Parse(Console.ReadLine());
            ERROCINCOSEDITAR:
                Console.WriteLine("Editar no 'ID' " + idSolicitanteParaEditar + ":\n" +
                    "1. Nome | 2. E-mail | 3. Telefone");
                int escolha = int.Parse(Console.ReadLine());
                if (escolha == 1)
                {
                    Console.Write("Digite novo nome: ");
                    nomeDoSolicitante[idSolicitanteParaEditar] = Console.ReadLine();
                }
                else if (escolha == 2)
                {
                    Console.Write("Digite novo e-mail: ");
                    emailDoSolicitante[idSolicitanteParaEditar] = Console.ReadLine();
                }
                else if (escolha == 3)
                {
                    Console.WriteLine("Digite novo telefone:");
                    telefoneDoSolicitante[idSolicitanteParaEditar] = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Opção inválida, tente novamente!");
                    goto ERROCINCOSEDITAR;
                }
                Console.Clear();
                MensagemInformativa("Solicitante atualizado com sucesso!", ConsoleColor.Cyan);
            }
        }
        static void ExcluirSolicitante(string[] nomeDoSolicitante, string[] emailDoSolicitante, string[] telefoneDoSolicitante, string[] solicitanteAtreladoAoChamado, int[] idDosSolicitantes, ref int solicitantes)
        {
            if (solicitantes == 0)
            {
                Console.WriteLine("\nAinda não há solicitantes registrados! :(\n");
            }
            else
            {
                for (int i = 0; i < solicitantes; i++)
                {
                    if (nomeDoSolicitante[i] != null)
                    {
                        Console.WriteLine("ID.........: " + idDosSolicitantes[i]);
                        Console.Write("Nome.......: ");
                        Console.WriteLine(nomeDoSolicitante[i]);
                        Console.Write("E-mail.....: ");
                        Console.WriteLine(emailDoSolicitante[i]);
                        Console.Write("Telefone...: ");
                        Console.WriteLine(telefoneDoSolicitante[i]);
                        Console.WriteLine();
                    }
                }
                Console.Write("Escolha o 'ID' do solicitante para excluir: ");
                int idSolicitanteParaExcluir = int.Parse(Console.ReadLine());
                for (int i = idSolicitanteParaExcluir; i < solicitantes; i++)
                {
                    nomeDoSolicitante[i] = nomeDoSolicitante[i + 1];
                    emailDoSolicitante[i] = emailDoSolicitante[i + 1];
                    telefoneDoSolicitante[i] = telefoneDoSolicitante[i + 1];
                }
                solicitantes -= 1;
                Console.Clear();
                MensagemInformativa("Solicitante excluído com sucesso!", ConsoleColor.DarkRed);
            }
        }
        #endregion

        #region Métodos complementares
        static void MensagemInformativa(string mensagem, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(mensagem + "\n");
            Console.ResetColor();
        }
        #endregion

        #endregion
    }
}