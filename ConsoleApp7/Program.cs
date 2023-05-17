using System.Reflection;

int[,] bois = new int[5, 6];
int somapeso = 0;
int mediapeso;
int boipesado = 0;
int boileve = 600;
int l, c;
Random x = new Random();
int poslinha = 0, poscoluna = 0;
int poslinha1 = 0, poscoluna1 = 0;

for(l = 0; l < 5; l++)
{
    for(c = 0; c < 6; c++)
    {
        bois[l, c] = x.Next(200, 600);              // gerar o peso aleatorio de 30 bois entre 200kg e 600 kg
    }
  

}
Console.WriteLine("Os bois registrados foram:");

for(l = 0; l<5; l++)
{
    for(c =0; c<6; c++)
    {
        Console.Write(bois[l, c] +"kg" + "\t");     // dar um print em todos os bois da matriz

    }
    Console.WriteLine();
}


for( l = 0; l < 5; l++)                             //descobrir qual o boi mais pesado
{
    for (c = 0; c < 6; c++)
    {
        if (boipesado < bois[l, c])
        {
            boipesado = bois[l, c];
            poslinha = l;
            poscoluna = c;
        }
    }
}
for (l = 0; l < 5; l++)
{
    for (c = 0; c < 6; c++)
    {
        if (boileve > bois[l, c])                   // descobrir o boi mais leve
        {
            boileve = bois[l, c];
            poslinha1 = l;
            poscoluna1 = c;
        }
    }
}
for( l = 0; l < 5; l++)
{
    for (c = 0; c < 6; c++)
    {
        somapeso += bois[l, c];                 // somar o peso de todos os bois
        
    }
}
Console.WriteLine();



Console.Write("O boi mais pesado possui: " + boipesado + "kg");
Console.Write(" - E sua posição é linha:" + poslinha + " coluna " + poscoluna);

Console.Write("\nO boi mais leve possui: " + boileve + "kg");
Console.Write(" - E sua posição é linha:" + poslinha1 + " coluna " + poscoluna1);

Console.Write("\nA média de peso dos bois selecionados é de: " + somapeso / 30 + "kg");

Console.ReadKey();