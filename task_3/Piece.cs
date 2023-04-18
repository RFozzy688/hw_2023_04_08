using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal class Piece : IDisposable
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

        public void Dispose()
        {
            Console.WriteLine("Отработал метод Dispose() class Piece"); ;
        }

        ~Piece()
        {
            Console.WriteLine("Отработал финализатор class Piece");
        }
    }
}
