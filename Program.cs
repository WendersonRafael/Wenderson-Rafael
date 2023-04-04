using System;
using System.Speech.Synthesis;
using System.Net;
using System.IO;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Devices;
using System.Management;
using System.Speech.Recognition;
using System.Globalization;
using System.Data.SqlClient;



namespace ProjetoSara
{
    class Program
    {

        static void Main(string[] args)
        {

           

            Console.ForegroundColor = ConsoleColor.Green;


                Console.WriteLine("                ><< <<                    ><                     ><<<<<<<                       ><\n");
                Console.WriteLine("              ><<    ><<                 >< <<                   ><<    ><<                    >< <<\n");
                Console.WriteLine("               ><<                      ><  ><<                  ><<    ><<                   ><  ><<\n");
                Console.WriteLine("                ><<                    ><<   ><<                 >< ><<                      ><<   ><<\n");
                Console.WriteLine("                    ><<                ><<<<<< ><<               ><<  ><<                   ><<<<<< ><<\n");
                Console.WriteLine("              ><<    ><<              ><<       ><<              ><<    ><<                ><<       ><<\n");
                Console.WriteLine("                ><< <<       ><<     ><<         ><<     ><<     ><<      ><<     ><<     ><<         ><<\n");
                Console.WriteLine("                                    Sistema Autonomo Racional Artificial V:1.3\n\n\n\n");



                SpeechSynthesizer synth = new SpeechSynthesizer();
                synth.SetOutputToDefaultAudioDevice();
                synth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen, 0, new System.Globalization.CultureInfo("pt-BR"));


            //data base


                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Bem Vindo de volta. Como posso ajudar?");
                synth.Speak("Bem Vindo de volta. Como posso ajudar ?");

            while (true)
            {


                string input = Console.ReadLine().ToLower();

                if (input.Contains("oi") || input.Contains("olá"))
                {

                    Console.WriteLine("Olá! Como você está?");
                    synth.Speak("Olá! Como você está?");
                }
                else if(input.Contains("busque respostas no database") || input.Contains("abrir database") || input.Contains("banco de dados"))
                { /*omando extremamente importantee que se conecta ao  banco de dados SQL e busca a resposta para a pergunta.
                  lembre de que a pergunta deve ser a mesma registrada no banco de dados pois é uma assistente sem rede neural,
                  sendo assim ela nao tem a capacidade de interpretar uma pergunta diferente, mesmo que seja para a mesma resposta*/
                  
                    string connectionString = @"Data Source=OWFROSTPC;Initial Catalog=sara;User ID=sa;Password=we200845";
                    SqlConnection connection = new SqlConnection(connectionString); 
                    connection.Open();

                    Console.WriteLine("Digite uma pergunta:");
                    string pergunta_usuario = Console.ReadLine();

                    string query = "SELECT resposta FROM perguntas_respostas WHERE pergunta = @pergunta";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@pergunta", pergunta_usuario);

                    string resposta = "";
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            resposta = reader.GetString(0);
                        }
                    }

                    Console.WriteLine(resposta);
                    synth.Speak(resposta);

                    connection.Close();
                    
                }
                else if (input.Contains("que horas são"))
                {
                    DateTime currentTime = DateTime.Now;
                    string hora = currentTime.ToString("HH:mm");
                    Console.WriteLine($"Agora são {hora}");
                    synth.Speak($"Agora são {hora}");
                }
                else if (input.Contains("limpar"))
                {
                    Console.Clear(); // Limpa todo o console
                    Console.SetCursorPosition(0, Console.CursorTop + 0); // Volta para a linha da logo
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("                ><< <<                    ><                     ><<<<<<<                       ><\n");
                    Console.WriteLine("              ><<    ><<                 >< <<                   ><<    ><<                    >< <<\n");
                    Console.WriteLine("               ><<                      ><  ><<                  ><<    ><<                   ><  ><<\n");
                    Console.WriteLine("                ><<                    ><<   ><<                 >< ><<                      ><<   ><<\n");
                    Console.WriteLine("                    ><<                ><<<<<< ><<               ><<  ><<                   ><<<<<< ><<\n");
                    Console.WriteLine("              ><<    ><<              ><<       ><<              ><<    ><<                ><<       ><<\n");
                    Console.WriteLine("                ><< <<       ><<     ><<         ><<     ><<     ><<      ><<     ><<     ><<         ><<\n");
                    Console.WriteLine("                                    Sistema Autonomo Racional Artificial V:1.3\n\n\n\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(0, Console.CursorTop + 1); // Volta para a linha de baixo da logo
                }
                else if (input.Contains("qual a data de hoje"))

                {

                    DateTime now = DateTime.Now;
                    Console.WriteLine($"Hoje é {now.ToString("dd/MM/yyyy")}");
                    synth.Speak($"Hoje é {now.ToString("dd de MMMM, yyyy")}");
                }
                else if (input.Contains("crie um backup do seu sistema"))
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



                else if (input.Contains("modo segurança"))
                {
                    Console.WriteLine("Modo segurança ativado.");
                    Process.Start("rundll32.exe", "user32.dll,LockWorkStation");
                    synth.Speak("Modo segurança ativado, o computador foi bloqueado.");


                }
                else if (input.Contains("modo standby"))
                {
                    Console.WriteLine("Saindo do modo ativo. Digite qualquer tecla para voltar.");
                    synth.Speak("Saindo do modo ativo. Digite qualquer tecla para voltar.");

                    Console.ReadKey();

                    Console.WriteLine("Voltando ao modo ativo.");
                    synth.Speak("Voltando ao modo ativo.");
                }
                else if (input.Contains("modo repouso"))
                {
                    Console.WriteLine("Modo repouso ativado. Digite qualquer tecla para voltar.");
                    synth.Speak("Modo repouso ativado. Digite qualquer tecla para voltar.");

                    Console.ReadKey();
                }
                else if (input.Contains("obrigado"))
                {

                    Console.WriteLine("Fico feliz em ajudar! Oque mais posso fazer por você?");
                    synth.Speak("Fico feliz em ajudar! Oque mais posso fazer por você?");
                }
                else if (input.Contains("bem") || input.Contains("ótimo") || input.Contains("excelente"))
                {

                    Console.WriteLine("Que bom! Em que posso ajudá-lo?");
                    synth.Speak("Que bom! Em que posso ajudá-lo?");
                }
                else if (input.Contains("quem é você"))
                {

                    Console.WriteLine("Eu sou um chatbot. Estou aqui para ajudá-lo!");
                    synth.Speak("Eu sou um chatbot. Estou aqui para ajudá-lo!");
                }
                else if (input.Contains("rede"))
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
                else if (input.Contains("tchau") || input.Contains("até logo"))
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
    }
 }
    