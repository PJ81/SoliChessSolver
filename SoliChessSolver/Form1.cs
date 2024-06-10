using System.Drawing;

namespace SoliChessSolver {
    public partial class Form1 : Form {

        private string[,] board = new string[4, 4];
        private List<Tuple<Point, Point>> points = [];

        public Form1() {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e) {
            foreach (Control control in this.Controls) {
                if (control is ComboBox) {
                    control.Text = string.Empty;
                }
            }

            lstResults.Items.Clear();
            points.Clear();
        }

        private void btnSolve_Click(object sender, EventArgs e) {

            lstResults.Items.Clear();
            points.Clear();

            board = new string[4, 4];
            
            for (int i = 0; i < 4; i++) {
                for (int j = 0; j < 4; j++) {
                    board[j, i] = "";
                }
            }

            foreach (Control control in this.Controls) {
                if (control is ComboBox) {
                    string? s = Convert.ToString(control.Tag);
                    if (s is not null) {
                        string[] t = s.Split(';');
                        int x = Convert.ToInt32(t[0]), y = Convert.ToInt32(t[1]);
                        board[x, y] = control.Text;
                    }
                }
            }

            if (solveBoard()) {
                foreach (Tuple<Point, Point> p in points) {
                    lstResults.Items.Add($"{pt2String(p.Item1)}->{pt2String(p.Item2)} ");
                }
            }
        }

        private string pt2String(Point p) {
            return $"{(char)(p.X + 65)}{(char)(48 + 4 - p.Y)}";
        }

        private bool inBounds(Point p) {
            return p.X >= 0 && p.Y >= 0 && p.X < 4 && p.Y < 4;
        }

        private Point[] getMoves(string s) {
            return s switch
            {
                "K" or "Q" => [
                        new(-1,  0),    new( 1,  0),
                new( 0, -1),    new( 0,  1),
                new(-1,  1),    new( 1, -1),
                new(-1, -1),    new( 1,  1)],
                "B" => [
                        new(-1,  1),    new( 1, -1),
                new(-1, -1),    new( 1,  1)],
                "N" => [
                        new(-2,  1),    new( 2,  1),
                new(-2, -1),    new( 2, -1),
                new(-1,  2),    new( 1,  2),
                new(-1, -2),    new( 1, -2)],
                "R" => [
                       new(-1,  0),     new( 1,  0),
               new( 0, -1),     new( 0,  1)],
                "P" => [
                       new( 1, -1),     new(-1, -1)],
                _ => [],
            };
        }

        private List<Point> tryCapture(int x, int y) {
            string s = board[x, y];

            List<Point> possibilities = [];

            Point[] moves = getMoves(s);
            if (moves.Length == 0) return [];

            Point origin = new(x, y);

            if (s.Equals("K") || s.Equals("N") || s.Equals("P")) {

                foreach (Point move in moves) {
                    Point target = new(origin.X + move.X, origin.Y + move.Y);

                    if (inBounds(target) && board[target.X, target.Y] != "" && !target.Equals(origin))
                        possibilities.Add(target);
                }
            }
            else {
                foreach (Point move in moves) {
                    int a = x, b = y;
                    while (true) {
                        a += move.X;
                        b += move.Y;

                        Point target = new(a, b);
                        if (!inBounds(target)) break;

                        if (board[target.X, target.Y] != "" && !target.Equals(origin)) {
                            possibilities.Add(target);
                            break;
                        }
                    }
                }
            }

            return possibilities;
        }

        private bool solveBoard() {

            if (board.Cast<string>().Count(cell => !string.IsNullOrEmpty(cell)) == 1) {
                return true;
            }

            for (int y = 0; y < 4; y++) {
                for (int x = 0; x < 4; x++) {

                    if (board[x, y] == "") continue;

                    List<Point> moves = tryCapture(x, y);

                    if (moves.Count == 0) continue;

                    foreach (Point pt in moves) {

                        Tuple<Point, Point> move = new(new Point(x, y), pt);
                        points.Add(move);

                        string f = board[move.Item1.X, move.Item1.Y],
                                t = board[move.Item2.X, move.Item2.Y];

                        board[move.Item2.X, move.Item2.Y] = f;
                        board[move.Item1.X, move.Item1.Y] = "";

                        if (solveBoard()) return true;

                        board[move.Item2.X, move.Item2.Y] = t;
                        board[move.Item1.X, move.Item1.Y] = f;

                        points.Remove(move);

                    }
                }
            }
            return false;
        }
    }
}
