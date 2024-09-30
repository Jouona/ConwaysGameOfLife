namespace ConwaysGameOfLife;

public class Helpers {
    public static bool[][] CopyDimensionsGrid(bool[][] oldGrid) {
        bool[][] newGrid = new bool[oldGrid.Length][];

        for (int i = 0; i < oldGrid.Length; i++) {
            newGrid[i] = new bool[oldGrid[i].Length];
        }

        return newGrid;
    }
}