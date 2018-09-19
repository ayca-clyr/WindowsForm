using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8__Polymorphism
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        //Initialization
        //private fieldların ilk değerleri (initialization) constructor metot çalışmadan hemen önce atanır.
        Chessboard _board = new Chessboard();

        // fieldların ilk değerleri kendi verir atanmamşısa nulldır.
        //Chessboard _board; dersek _board değeri null atanır.
        private void Form1_Load(object sender, EventArgs e)
        {

            int y=0;
            // int x = 0;

            for (int i = 0; i < _board.WhitePieces.Length; i++)
            {
                Button button = new Button();
                button.Text = _board.WhitePieces[i].ToString();
                button.Tag = _board.WhitePieces[i];

                button.Width = 50;
                button.Height = 50;
                button.BackColor = Color.White;
                button.Left = (i%8) * 50; // x*50;
                button.Top = y * 50;
                button.FlatStyle = FlatStyle.Flat;
                button.TabStop = false;
                button.Click += button_Click;
                if (i % 8 == 7)
                {
                    y++;
                    //x=0;
                }
                Controls.Add(button);
            }

        }

        void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            // polimorfizm bunları yapmamak için var,
            // zaten bir hareket fonksiyonumuz vardır.
           /*
            if (button.Text == "Fil")
            {

            }
            else if(button.Text == "At")
            {

            }
            */

            ChessPiece piece = (ChessPiece)button.Tag;

            // Polimorfizm 1 satır.
            // tek bir tipin çok biçimde davranması
            string moveMessage = piece.Move();

            MessageBox.Show(moveMessage);

            //if (piece is Knight)
            //    MessageBox.Show("L ilerlerim");
            //else if (piece is Bishop)             ----->>>Alternatif
            //    MessageBox.Show("Çapraz ilerlerim"); 
            //if(pieceButton.Text=="Fil")


            //    MessageBox.Show("Çapraz"); Yapılabilir ama doğru bir kullanım olmaz.
            //else if(pieceButton.Text=="AT")           ----->>>Alternatif
            //    MessageBox.Show("L şeklinde giderim");

        }
    }
}
