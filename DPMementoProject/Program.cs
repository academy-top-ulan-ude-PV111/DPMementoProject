namespace DPMementoProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            Unit unit= new Unit();
            game.Games.Push(unit.Save());

            unit.Fire();

            game.Games.Push(unit.Save());

            unit.Fire();

            unit.Load(game.Games.Pop());

            unit.Fire();

        }
    }
}