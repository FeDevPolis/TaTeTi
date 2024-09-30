using System;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Button[,] buttons;  // Array de botones
        private string currentPlayer = "X";  // Jugador actual
        private bool gameWon = false;  // Verificar si el juego ha sido ganado
        private int scoreX = 0; // Puntuación para el jugador X
        private int scoreO = 0; // Puntuación para el jugador O
        private Label scoreLabel; // Label para mostrar el marcador


        public Form1()
        {
            InitializeComponent();

            // Inicializar el array de botones
            buttons = new Button[3, 3]
            {
                { btn1, btn2, btn3 },
                { btn4, btn5, btn6 },
                { btn7, btn8, btn9 }
            };

            CreateScoreLabel(); // Crear el marcador

        }

        // Método que se ejecuta cuando un botón es clickeado
        private void Button_Click(object sender, EventArgs e)
        {
            if (gameWon)
            {
                label1.Text = "El juego ya ha terminado";
                return;
            }

            Button clickedButton = sender as Button;

            // Verificar si el botón ya fue clickeado
            if (clickedButton.Text != "")
            {
                label1.Text = "Casilla ya ocupada!";
                return;
            }

            // Establecer la marca del jugador actual
            clickedButton.Text = currentPlayer;

            // Verificar si hay un ganador
            if (CheckWinner())
            {
                label1.Text = $"¡Jugador {currentPlayer} ganó!";

                if (currentPlayer == "X")
                {
                    scoreX++; // Incrementa la puntuación de X
                }
                else
                {
                    scoreO++; // Incrementa la puntuación de O
                }

                UpdateScoreLabel(); // Actualiza el marcador

                gameWon = true;  // Marcar que el juego ha terminado
                return;
            }

            // Verificar si hay empate
            if (CheckDraw())
            {
                label1.Text = "¡Es un empate!";
                return;
            }

            // Cambiar al otro jugador
            currentPlayer = (currentPlayer == "X") ? "O" : "X";
            label1.Text = $"Turno del jugador {currentPlayer}";
        }

        // Verificar si hay un ganador
        private bool CheckWinner()
        {
            // Verificar filas y columnas
            for (int i = 0; i < 3; i++)
            {
                // Verificar filas
                if (buttons[i, 0] != null && buttons[i, 1] != null && buttons[i, 2] != null &&
                    buttons[i, 0].Text == currentPlayer &&
                    buttons[i, 1].Text == currentPlayer &&
                    buttons[i, 2].Text == currentPlayer)
                {
                    return true;
                }

                // Verificar columnas
                if (buttons[0, i] != null && buttons[1, i] != null && buttons[2, i] != null &&
                    buttons[0, i].Text == currentPlayer &&
                    buttons[1, i].Text == currentPlayer &&
                    buttons[2, i].Text == currentPlayer)
                {
                    return true;
                }
            }

            // Verificar diagonales
            if (buttons[0, 0] != null && buttons[1, 1] != null && buttons[2, 2] != null &&
                buttons[0, 0].Text == currentPlayer &&
                buttons[1, 1].Text == currentPlayer &&
                buttons[2, 2].Text == currentPlayer)
            {
                return true;
            }

            if (buttons[0, 2] != null && buttons[1, 1] != null && buttons[2, 0] != null &&
                buttons[0, 2].Text == currentPlayer &&
                buttons[1, 1].Text == currentPlayer &&
                buttons[2, 0].Text == currentPlayer)
            {
                return true;
            }

            return false;
        }

        // Verificar si el juego ha terminado en empate
        private bool CheckDraw()
        {
            foreach (Button button in buttons)
            {
                if (button.Text == "")
                {
                    return false;  // Si alguna casilla está vacía, no hay empate
                }
            }

            return true;  // Todas las casillas están ocupadas, es un empate
        }
              
        private void CreateScoreLabel()
        {
            scoreLabel = new Label();
            scoreLabel.Text = $"X: {scoreX} - O: {scoreO}"; // Inicializa el texto del marcador
            scoreLabel.Location = new Point(600, 50); // Ajusta la ubicación según sea necesario
            scoreLabel.AutoSize = true; // Hace que el label ajuste su tamaño automáticamente
            Controls.Add(scoreLabel);
        }

        // Actualiza el texto del marcador
        private void UpdateScoreLabel()
        {
            scoreLabel.Text = $"X: {scoreX} - O: {scoreO}";
        }

        // Método para reiniciar el juego
        private void ResetGame()
        {
            // Limpiar el texto de todos los botones
            foreach (Button button in buttons)
            {
                button.Text = "";
            }

            // Restablecer las variables del juego
            currentPlayer = "X";
            gameWon = false;
            label1.Text = "Turno del jugador X";
        }

        // Evento del botón de reinicio
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void ExitGame()
        {
            Application.Exit();
        }
    }
}
