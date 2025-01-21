using System;
class Program
{
    static void Main()
    {
        Personagem jogador = new Personagem("Herói");

        jogador.PegarItem("Espada");
        jogador.PegarItem("Poção de vida");
        jogador.MostrarInventario();

        jogador.Atacar("Dragão");
        jogador.LargarItem("Espada");
        jogador.MostrarInventario();
    }
}