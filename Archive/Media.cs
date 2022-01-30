using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archive
{
    internal class Media
    {
        protected string name;
        protected string genre;
        protected int release_year;
        protected string creator; //Author if it's a book, director if it's a film, developer if it's a game        
    }

    internal class Film:Media
    {
        private int length;
        private string studio;

        //Film constructor
        public Film(string name, string genre, int release_year, string director, int minutes, string studio)
        {
            this.name = name;
            this.genre = genre;
            this.release_year = release_year;
            creator = director;
            length = minutes;
            this.studio = studio;
        }

        public override string ToString()
        {            
            return $"Name: {name}\r\nGenre: {genre}\r\nReleased: {release_year}\r\nDirected by: {creator}\r\nMinutes: {length}\r\nStudio: {studio}\r\n\r\n";
        }
    }

    internal class Book : Media
    {
        private int length;

        //Book constructor
        public Book(string name, string genre, int release_year, string author, int pages)
        {
            this.name = name;
            this.genre = genre;
            this.release_year = release_year;
            creator = author;
            length = pages;
        }

        public override string ToString()
        {
            return $"Name: {name}\r\nGenre: {genre}\r\nReleased: {release_year}\r\nWritten by: {creator}\r\nPages: {length}\r\n\r\n";
        }
    }

    internal class Game : Media
    {
        private string publisher;

        //Game constructor
        public Game(string name, string genre, int release_year, string developer, string publisher)
        {
            this.name = name;
            this.genre = genre;
            this.release_year= release_year;
            creator = developer;
            this.publisher = publisher;
        }

        public override string ToString()
        {
            return $"Name: {name}\r\nGenre: {genre}\r\nReleased: {release_year}\r\nDevloper: {creator}\r\nPublisher: {publisher}\r\n\r\n";
        }

    }
}
