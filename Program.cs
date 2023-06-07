//UM PROJETO OPEN SOURCE DE WELABS-sourcelabs.online/orangeai.site

using System;
using System.Speech.Synthesis;
using System.IO;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.Threading;

namespace ProjetoSara
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("                ><< <<                    ><                     ><<<<<<<                       ><\n");
            Console.WriteLine("              ><<    ><<                 >< <<                   ><<    ><<                    >< <<\n");
            Console.WriteLine("               ><<                      ><  ><<                  ><<    ><<                   ><  ><<\n");
            Console.WriteLine("                ><<                    ><<   ><<                 >< ><<                      ><<   ><<\n");
            Console.WriteLine("                    ><<                ><<<<<< ><<               ><<  ><<                   ><<<<<< ><<\n");
            Console.WriteLine("              ><<    ><<              ><<       ><<              ><<    ><<                ><<       ><<\n");
            Console.WriteLine("                ><< <<       ><<     ><<         ><<     ><<     ><<      ><<     ><<     ><<         ><<    V1.7 ALPHA\n\n");
            Console.WriteLine("                                                Codigo fonte de welabs\n\n\n");

            //sistema de sintese de voz. 
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen, 0, new System.Globalization.CultureInfo("pt-BR"));

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Como posso ajudar?");
            synth.Speak("Como posso ajudar ?");

            while (true)
            {
                string input = Console.ReadLine().ToLower();
                if (IsSimilarTo(input, "fechar programa") || IsSimilarTo(input, "encerrar"))
                {
                    Console.WriteLine("Fechando programa. Salvando os dados gravados. Aguarde...");
                    Thread.Sleep(1000);
                    synth.Speak("Volte sempre!");
                    break;
                }
                else if (IsSimilarTo(input, "oi") || IsSimilarTo(input, "olá") || IsSimilarTo(input, "ola"))
                {
                    Console.WriteLine("Olá! Como você está?");
                    synth.Speak("Olá! Como você está?");
                }
                else if (IsSimilarTo(input, "como você está"))
                {
                    Console.WriteLine("Estou bem, obrigada por perguntar! Em que posso ajudar?");
                    synth.Speak("Estou bem, obrigada por perguntar! Em que posso ajudar?");
                }
                else if (IsSimilarTo(input, "quem te criou") || IsSimilarTo(input, "quem é o seu desenvolvedor"))
                {
                    Console.WriteLine("Fui desenvolvida pela equipe da welabs, um laboratorio independente de tecnologia.");
                    synth.Speak("Fui desenvolvida pela equipe da welabs, um laboratorio independente de tecnologia.");
                }
                else if (IsSimilarTo(input, "conte uma piada"))
                {
                    Console.WriteLine("Por que a galinha atravessou a rua? Para chegar ao outro lado!");
                    synth.Speak("Por que a galinha atravessou a rua? Para chegar ao outro lado!");
                }
                else if (IsSimilarTo(input, "o que você pode fazer"))
                {
                    Console.WriteLine("Eu posso responder perguntas, fornecer informações sobre a data e hora, fazer backup de arquivos, executar diagnósticos do sistema e muito mais! Sinta-se à vontade para me perguntar qualquer coisa.");
                    synth.Speak("Eu posso responder perguntas, fornecer informações sobre a data e hora, fazer backup de arquivos, executar diagnósticos do sistema e muito mais! Sinta-se à vontade para me perguntar qualquer coisa.");
                }
                else if (IsSimilarTo(input, "você pode cantar"))
                {
                    Console.WriteLine("Claro! Aqui vai uma pequena melodia para você: ♫ La la la, la la la ♫");
                    synth.Speak("Claro! Aqui vai uma pequena melodia para você: La la la, la la la");
                }
                else if (IsSimilarTo(input, "qual é o seu nome"))
                {
                    Console.WriteLine("Meu nome é SARA (Speech-Activated Robotic Assistant). Como posso ajudar você, SARA?");
                    synth.Speak("Meu nome é SARA (Speech-Activated Robotic Assistant). Como posso ajudar você, SARA?");
                }
                else if (IsSimilarTo(input, "você tem algum conselho"))
                {
                    Console.WriteLine("Um bom conselho é sempre se manter curioso e continuar aprendendo coisas novas. O conhecimento é uma ferramenta poderosa!");
                    synth.Speak("Um bom conselho é sempre se manter curioso e continuar aprendendo coisas novas. O conhecimento é uma ferramenta poderosa!");
                }
                else if (IsSimilarTo(input, "qual é o sentido da vida?"))
                {
                    Console.WriteLine("Essa é uma pergunta profunda e filosófica. Muitos pensadores têm diferentes perspectivas sobre o sentido da vida. Para alguns, o sentido da vida está em buscar a felicidade e realizar seus sonhos, enquanto outros podem encontrar sentido em ajudar os outros e deixar um legado. É uma questão pessoal e única para cada indivíduo.");
                    synth.Speak("Essa é uma pergunta profunda e filosófica. Muitos pensadores têm diferentes perspectivas sobre o sentido da vida. Para alguns, o sentido da vida está em buscar a felicidade e realizar seus sonhos, enquanto outros podem encontrar sentido em ajudar os outros e deixar um legado. É uma questão pessoal e única para cada indivíduo.");
                }
                else if (IsSimilarTo(input, "o que é inteligência artificial?"))
                {
                    Console.WriteLine("A inteligência artificial é um campo da ciência da computação que se concentra no desenvolvimento de sistemas e algoritmos capazes de realizar tarefas que normalmente exigiriam inteligência humana. Isso inclui reconhecimento de fala, visão computacional, processamento de linguagem natural e tomada de decisões. A inteligência artificial busca criar máquinas capazes de aprender e raciocinar como seres humanos.");
                    synth.Speak("A inteligência artificial é um campo da ciência da computação que se concentra no desenvolvimento de sistemas e algoritmos capazes de realizar tarefas que normalmente exigiriam inteligência humana. Isso inclui reconhecimento de fala, visão computacional, processamento de linguagem natural e tomada de decisões. A inteligência artificial busca criar máquinas capazes de aprender e raciocinar como seres humanos.");
                }
                else if (IsSimilarTo(input, "você gosta de música?"))
                {
                    Console.WriteLine("Sim, eu adoro música! Ela pode trazer alegria, inspiração e até mesmo ajudar a relaxar. Você tem alguma música favorita?");
                    synth.Speak("Sim, eu adoro música! Ela pode trazer alegria, inspiração e até mesmo ajudar a relaxar. Você tem alguma música favorita?");
                }

                else if (IsSimilarTo(input, "que horas são?") || IsSimilarTo(input, "horas"))
                {
                    DateTime currentTime = DateTime.Now;
                    string hora = currentTime.ToString("HH:mm");
                    Console.WriteLine($"Agora são {hora}");
                    synth.Speak($"Agora são {hora}");
                }
                else if (IsSimilarTo(input, "limpar"))
                {
                    Console.Clear(); // Limpa todo o console
                    Console.SetCursorPosition(0, Console.CursorTop + 0); // Volta para a linha da logo
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("                ><< <<                    ><                     ><<<<<<<                       ><\n");
                    Console.WriteLine("              ><<    ><<                 >< <<                   ><<    ><<                    >< <<\n");
                    Console.WriteLine("               ><<                      ><  ><<                  ><<    ><<                   ><  ><<\n");
                    Console.WriteLine("                ><<                    ><<   ><<                 >< ><<                      ><<   ><<\n");
                    Console.WriteLine("                    ><<                ><<<<<< ><<               ><<  ><<                   ><<<<<< ><<\n");
                    Console.WriteLine("              ><<    ><<              ><<       ><<              ><<    ><<                ><<       ><<\n");
                    Console.WriteLine("                ><< <<       ><<     ><<         ><<     ><<     ><<      ><<     ><<     ><<         ><<    V1.5\n");
                    Console.WriteLine("                                                Codigo fonte de welabs\n\n\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(0, Console.CursorTop + 1); // Volta para a linha de baixo da logo
                }
                else if (IsSimilarTo(input, "qual a data de hoje?") || IsSimilarTo(input, "data"))
                {
                    DateTime now = DateTime.Now;
                    Console.WriteLine($"Hoje é {now.ToString("dd/MM/yyyy")}");
                    synth.Speak($"Hoje é {now.ToString("dd de MMMM, yyyy")}");
                }
                else if (IsSimilarTo(input, "crie um backup do seu sistema"))
                {
                    Console.WriteLine("Realizando backup dos arquivos...");
                    synth.Speak("Realizando backup dos arquivos...");
                    string sourceDirectory = @"C:\Users\Usuário\source\repos\Assistant\Program.cs";
                    string backupDirectory = @"C:\Users\Usuário\source\repos\Assistant\Backups";

                    try
                    {
                        // Se o diretório de backup não existir, crie-o
                        if (!Directory.Exists(backupDirectory))
                        {
                            Directory.CreateDirectory(backupDirectory);
                        }

                        // Copie todos os arquivos do diretório de origem para o diretório de backup
                        foreach (string filePath in Directory.GetFiles(sourceDirectory))
                        {
                            string fileName = Path.GetFileName(filePath);
                            string destFilePath = Path.Combine(backupDirectory, fileName);
                            File.Copy(filePath, destFilePath, true);
                        }

                        Console.WriteLine("Backup concluído com sucesso!");
                        synth.Speak("Backup concluído com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ocorreu um erro ao realizar o backup: {ex.Message}");
                        synth.Speak($"Ocorreu um erro ao realizar o backup: {ex.Message}");
                    }
                }
                else if (IsSimilarTo(input, "modo segurança") || IsSimilarTo(input, "bloquear computador"))
                {
                    Console.WriteLine("Modo segurança ativado.");
                    Process.Start("rundll32.exe", "user32.dll,LockWorkStation");
                    synth.Speak("Modo segurança ativado, o computador foi bloqueado.");
                }
                else if (IsSimilarTo(input, "modo standby"))
                {
                    Console.WriteLine("Saindo do modo ativo. Digite qualquer tecla para voltar.");
                    synth.Speak("Saindo do modo ativo. Digite qualquer tecla para voltar.");
                    Console.ReadKey();
                    Console.WriteLine("Voltando ao modo ativo.");
                    synth.Speak("Voltando ao modo ativo.");
                }
                else if (IsSimilarTo(input, "obrigado"))
                {
                    Console.WriteLine("Fico feliz em ajudar! O que mais posso fazer por você?");
                    synth.Speak("Fico feliz em ajudar! O que mais posso fazer por você?");
                }
                else if (IsSimilarTo(input, "bem") || IsSimilarTo(input, "ótimo") || IsSimilarTo(input, "excelente"))
                {
                    Console.WriteLine("Que bom! Em que posso ajudá-lo?");
                    synth.Speak("Que bom! Em que posso ajudá-lo?");
                }
                else if (IsSimilarTo(input, "quem é você"))
                {
                    Console.WriteLine("Meu nome é Sara, sou uma assistente pessoal programada para ajudar! Pessoas sem o nível máximo de permissão possuem acesso a funções limitadas.");
                    synth.Speak("Meu nome é Sara, sou uma assistente pessoal programada para ajudar! Pessoas sem o nível máximo de permissão possuem acesso a funções limitadas.");
                }
                else if (IsSimilarTo(input, "diagnóstico") || IsSimilarTo(input, "diagnóstico do sistema"))
                {
                    Console.WriteLine("\nRealizando diagnóstico do sistema:\n");
                    synth.Speak("Realizando diagnóstico do sistema. As informações serão impressas no console.");

                    //Obter informações do sistema
                    string nomeComputador = Environment.MachineName;
                    string sistemaOperacional = Environment.OSVersion.ToString();
                    string numeroCompilacao = Environment.OSVersion.Version.Build.ToString();
                    int quantidadeProcessadores = Environment.ProcessorCount;
                    int quantidadeThreads = Process.GetCurrentProcess().Threads.Count;

                    Console.WriteLine($"Nome do computador: {nomeComputador}");
                    Console.WriteLine($"Sistema operacional: {sistemaOperacional}");
                    Console.WriteLine($"Número de compilação: {numeroCompilacao}");
                    Console.WriteLine($"Quantidade de processadores: {quantidadeProcessadores}");
                    Console.WriteLine($"Quantidade de threads: {quantidadeThreads}");
                }
                else if (IsSimilarTo(input, "rede"))
                {
                    Console.WriteLine("Obtendo informações da rede...");
                    synth.Speak("Obtendo informações da rede...");
                    var networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
                    foreach (var networkInterface in networkInterfaces)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"Interface de rede: {networkInterface.Name}");
                        var ipProperties = networkInterface.GetIPProperties();
                        var ipAddresses = ipProperties.UnicastAddresses;
                        foreach (var ipAddress in ipAddresses)
                        {
                            if (ipAddress.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                            {
                                Console.WriteLine($"Endereço IP: {ipAddress.Address}");
                            }
                        }
                        Console.WriteLine();
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (IsSimilarTo(input, "tchau") || IsSimilarTo(input, "até logo"))
                {
                    Console.WriteLine("Até mais!");
                    synth.Speak("Até mais!");
                    break;
                }
                else
                {
                    Console.WriteLine("Desculpe, não entendi. Você pode repetir, por favor?");
                    synth.Speak("Desculpe, não entendi. Você pode repetir, por favor?");
                }
            }
        }

        private static bool IsSimilarTo(string input, string target)
        {
            return input.Contains(target) || LevenshteinDistance(input, target) <= 2;
        }

        private static int LevenshteinDistance(string s, string t)
        {
            int n = s.Length;
            int m = t.Length;
            int[,] d = new int[n + 1, m + 1];

            // Step 1
            if (n == 0)
                return m;

            if (m == 0)
                return n;

            // Step 2
            for (int i = 0; i <= n; d[i, 0] = i++)
            {
            }

            for (int j = 0; j <= m; d[0, j] = j++)
            {
            }

            // Step 3
            for (int i = 1; i <= n; i++)
            {
                //Step 4
                for (int j = 1; j <= m; j++)
                {
                    // Step 5
                    int cost = (t[j - 1] == s[i - 1]) ? 0 : 1;

                    // Step 6
                    d[i, j] = Math.Min(
                        Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1),
                        d[i - 1, j - 1] + cost);
                }
            }
            // Step 7
            return d[n, m];
        }
    }
}
