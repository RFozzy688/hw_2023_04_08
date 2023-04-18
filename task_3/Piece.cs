using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal class Piece
    {
        public string NamePiece { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }

        public Piece(string namePiece, string author, string genre, int year)
        {
            NamePiece = namePiece;
            Author = author;
            Genre = genre;
            Year = year;
        }

        public override string ToString()
        {
            return $"Название: {NamePiece}\nАвтор: {Author}\nЖанр: {Genre}\nГод: {Year}";
        }
        ~Piece()
        {
            Console.WriteLine("Отработал финализатор");
        }
    }
}
