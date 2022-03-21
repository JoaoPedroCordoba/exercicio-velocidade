double d, t, v;

Console.WriteLine("digite a distancia(m), por favor:");
d = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o tempo(s), por favor:");
t = Convert.ToDouble(Console.ReadLine());

v = d / t;

Console.WriteLine($"A velocidade media é:{v:N2}m/s");