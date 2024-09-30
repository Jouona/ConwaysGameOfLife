using ConwaysGameOfLife;

class Program {
    static void Main(string[] args) {
        GameOfLife gameOfLife = new GameOfLife();
        Console.WriteLine(gameOfLife);

        for (int i = 0; i < 10; i++) {
            gameOfLife.NextGeneration();
            Console.WriteLine(gameOfLife);
        }
    }
}