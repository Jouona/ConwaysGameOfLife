namespace ConwaysGameOfLife;

public class GameOfLife {
    bool[][] grid = {
        [false, false, false, false, false],
        [false, false, true, false, false],
        [false, false, true, false, false],
        [false, false, true, false, false],
        [false, false, false, false, false]
    };

    public void NextGeneration() {
        bool[][] newGrid = Helpers.CopyDimensionsGrid(grid);
        for (int i = 0; i < grid.Length; i++) {
            for (int j = 0; j < grid[i].Length; j++) {
                if (LivesInNextGen(grid[i][j], i, j)) {
                    newGrid[i][j] = true;
                }
            }
        }

        grid = newGrid;
    }

    bool LivesInNextGen(bool currentState, int x, int y) {
        int count = 0;

        for (int i = -1; i <= 1; i++) {
            for (int j = -1; j <= 1; j++) {
                if (i == 0 && j == 0) continue;

                try {
                    if (grid[x + i][y + j]) count++;
                }
                catch {
                    /* kein guter Practice hier nur den möglichen Overflow zu catchen, aber es erlaubt hier
                    sehr einfachen Code */
                    return false;
                }
            }
        }

        return currentState ? count is 2 or 3 : count is 3;
    }

    public override String ToString() {
        String output = "";
        for (int i = 0; i < grid.Length; i++) {
            output += Environment.NewLine;
            for (int j = 0; j < grid[i].Length; j++) {
                if (grid[i][j]) {
                    output += "1";
                }
                else {
                    output += "0";
                }
            }
        }

        return output;
    }
}