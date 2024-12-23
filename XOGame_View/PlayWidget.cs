using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using XOGame_Model;
using System;

namespace XOGame_View
{
    public partial class PlayWidget : Form
    {
        private TableLayoutPanel my_layout;
        private Button[,] buttons;

        public Game Game;

        public PlayWidget(Settings s)
        {
            Game = new Game(s.Size);
            Game.Win += EndGame;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Text = "XOGame";
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            buttons = new Button[Game.Size, Game.Size];

            my_layout = new TableLayoutPanel();
            my_layout.ColumnCount = Game.Size;
            my_layout.RowCount = Game.Size;
            my_layout.AutoSize = true;
            my_layout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            my_layout.SuspendLayout();
            SuspendLayout();

            Controls.Add(my_layout);

            for (int i = 0; i < Game.Size; i++) 
            { 
                for (int j = 0; j < Game.Size; j++)
                {
                    Button button = new Button() { Size = new Size(500 / Game.Size, 500 / Game.Size) };
                    button.Click += (o, e) => ButtonClicked(o, e);
                    buttons[i, j] = button;
                    my_layout.SetColumn(button, j);
                    my_layout.SetRow(button, i);
                    my_layout.Controls.Add(button);
                }
            }
            
            my_layout.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;            
            (int x, int y) o = FindIndex(buttons, button);

            button.Text = Game.CurrentTurn();
            button.Enabled = false;
            Game.MakeMove(o.x, o.y);
        }

        private (int x, int y) FindIndex(object[,] matrix, object val)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    if (matrix[i, j] == val)
                        return (i, j);
            return (-1, -1);
        }

        private void EndGame(string message)
        {
            foreach (Button b in buttons)
            {
                b.Enabled = false;
            }
            if (MessageBox.Show(message) != DialogResult.None)
            {
                Close();
            }
        }
    }
}
