﻿using TesteEmprego.Questoes;

Console.WriteLine("Bem-vindo!");
Console.WriteLine("Cada uma das questões será executada em 2 segundos após a execução da anterior.");
Thread.Sleep(2000);
Console.WriteLine("---------------------------------------------------------------------------");

Console.WriteLine("Questão 1 - Calcular soma com valor fixo");
Questao1.CalcularSoma();
Thread.Sleep(2000);
Console.WriteLine("---------------------------------------------------------------------------");

Console.WriteLine("Questão 2 - Verificar se um número pertence à sequência de Fibonacci");
Questao2.VerificarFibonacci();
Thread.Sleep(2000);
Console.WriteLine("---------------------------------------------------------------------------");

Console.WriteLine("Questão 3 - Analisar faturamento diário");
Questao3.AnalisarFaturamento();
Thread.Sleep(2000);
Console.WriteLine("---------------------------------------------------------------------------");

Console.WriteLine("Questão 4 - Calcular percentuais de faturamento por estado");
Questao4.CalcularPercentualEstados();
Thread.Sleep(2000);
Console.WriteLine("---------------------------------------------------------------------------");

Console.WriteLine("Questao 5 - Inverter string");
Questao5.InverterString();
Thread.Sleep(2000);
Console.WriteLine("---------------------------------------------------------------------------");

Console.WriteLine("Obrigada por executar todas as questões!");