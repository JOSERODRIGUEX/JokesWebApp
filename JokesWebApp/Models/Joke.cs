using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokesWebApp.Models
{
    public class Joke
    {
        //Properties, default type of project property
        //Getter and setter, get; set; in C#
        public int Id { get; set; }
        public string JokeQuestion { get; set; }
        public string JokeAnswer { get; set; }

        //Creating method constructor, ctor
        public Joke()
        {

        }
    }
}
