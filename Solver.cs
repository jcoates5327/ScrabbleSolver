using System.IO;
using System.Collections;

class Solver {
    private char[][] BOARD { get; set; }

    
    public Solver(string boardFile) {
        // initialize Board
        BOARD = ReadBoardFromFile(boardFile);
        foreach (char[] line in BOARD) {
            foreach(char letter in line) {
               if (letter != ' ')
                Console.WriteLine(GetPointValue(letter));
            }
        }
    }


    // reads a list of valid Scrabble words
    // returns a dictionary mapping each letter to a HashSet<string> of all words starting with that letter
    // {'a': {...}, 'b': {...}, ...}
    private Dictionary<char, HashSet<string>>? LoadWordList(string wordListFile) {
        



        return null;
    }

    // takes in a char
    // letter = 'A' to 'Z'
    // returns the point value of letter
    private int GetPointValue(char letter) {
        Dictionary<char, int> points = new Dictionary<char, int>() {
            {'A', 1}, {'E', 1}, {'I', 1}, {'O', 1}, {'U', 1}, {'L', 1}, {'N', 1}, {'S', 1}, {'T', 1}, {'R', 1},
            {'D', 2}, {'G', 2},
            {'B', 3}, {'C', 3}, {'M', 3}, {'P', 3},
            {'F', 4}, {'H', 4}, {'V', 4}, {'W', 4}, {'Y', 4},
            {'K', 5},
            {'J', 8}, {'X', 8},
            {'Q', 1}, {'Z', 1},
        };

        return points[letter];
    }


    /* 
     * returns: char[][]
     *    
     * [ ['r', 'o', 'w', '0'],
     *   ['r', 'o', 'w', '1'],
     *   ['r', 'o', 'w', '2'],
     *   [       ...        ] ]
    */
    private char[][] ReadBoardFromFile(string boardFile) {
        using (StreamReader sr = new(boardFile)) {
            List<char[]> lines = new();

            do {
                string line = sr.ReadLine();
                lines.Add(line.Trim().Replace(".", " ").ToCharArray());
            } while (sr.Peek() != -1);

            return lines.ToArray();
        }
    }








    
    
}
