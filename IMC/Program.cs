/*
    6- Faça um programa que leia o peso e a altura e o sexo de uma pessoa 
    e calcule o seu imc informando a situação da pessoa (sobrepeso, obesidade...)

    IMC = Indice de massa muscular
    peso = peso em kilogramas
    h = altura em metros
    IMC = peso / (h*h)

    Tabela IMC usada como referencia para o desenvolvimento do programa
		Situacao          Homem      Mulher
    Obesidade mórbida   | +39.9    | +38.9
    Obesidade Moderada  | 30-39.9  | 29-38.9
    Obesidade Leve      | 25-29.9  | 24-28.9
    Normal   	        | 20-24.9  | 19-23.9
    Abaixo do normal    | -20      | -19
 */

float altura = 0, peso = 0, imc = 0;
int sexo = 0;
string situacao;


Console.WriteLine("=====Calcular IMC=====");

do{
    Console.Write("Digite a sua altura(cm): ");
    altura = float.Parse(Console.ReadLine());

    if(altura <= 0) Console.WriteLine("Altura inválida.");
} while (altura <= 0);

do{
    Console.Write("Digite seu peso(kg): ");
    peso = float.Parse(Console.ReadLine());

    if (peso <= 0) Console.WriteLine("Peso inválido.");
} while (peso <= 0);

do{
    Console.WriteLine("Digite seu sexo:");  
    Console.WriteLine("(M) - Masculino");
    Console.WriteLine("(F) - Feminino");

    Console.Write("Sua escolha: ");
    sexo = char.Parse(Console.ReadLine());

    if(sexo != 'M' && sexo != 'F') Console.WriteLine("Escolha inválida.");
} while (sexo != 'M' && sexo != 'F');


// parse da altura de centimetros para metros
altura = altura / 100;

imc = peso / (altura * altura);

if(sexo == 'M')
{
    if (imc > 39.9)
        situacao = "Obesidade Mórbida";
    else if (imc >= 30 && imc <= 39.9)
        situacao = "Obesidade Moderada";
    else if (imc >= 25 && imc <= 29.9)
        situacao = "Obesidade Leve";
    else if (imc >= 20 && imc <= 24.9)
        situacao = "Normal";
    else
        situacao = "Abaixo do normal";
}
else
{
    if (imc > 38.9)
        situacao = "Obesidade Mórbida";
    else if (imc >= 29 && imc <= 38.9)
        situacao = "Obesidade Moderada";
    else if (imc >= 24 && imc <= 28.9)
        situacao = "Obesidade Leve";
    else if (imc >= 19 && imc <= 23.9)
        situacao = "Normal";
    else
        situacao = "Abaixo do normal";
}

Console.WriteLine("=============================");
Console.WriteLine($"IMC: {imc}");
Console.WriteLine($"Sexo: {sexo}");
Console.WriteLine($"Situação: {situacao}");
Console.WriteLine("=============================");

Console.Write("\nDigite qualquer tecla para sair: ");
Console.ReadKey();