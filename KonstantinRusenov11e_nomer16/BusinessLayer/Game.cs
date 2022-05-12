﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
    public class Game
    {
        [Key]
        public int ID { get; private set; }

        [Required, MaxLength(20)]
        public string Name { get; set; }

        public List<User> Users { get; set; }

        public IEnumerable<Genre> Genres { get; set; }

        private Game()
        {

        }

        public Game(string name)
        {
            Name = name;
        }
    }
}