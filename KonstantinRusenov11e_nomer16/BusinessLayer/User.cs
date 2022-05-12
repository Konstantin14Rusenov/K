using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
    public class User
    {
        [Key]
        public int ID { get; private set; }

        [Required, MaxLength(20)]
        public string ParvoIme { get; set; }

        [Required, MaxLength(20)]
        public string SemeinoIme { get; set; }

        [Required, Range(10, 80)]
        public int NaKolkoSiGodini { get; set; } //na iosif lubimiq vaprso

        [Required, MaxLength(20)]
        public string PotrebitelIme { get; set; }

        [Required, MaxLength(70)]
        public string Pasduma { get; set; }

        [Required, MaxLength(20)]
        public string Eposhta { get; set; }

        public IEnumerable<User> DrugarchetaKomsomolci { get; set; }

        public IEnumerable<Game> Games { get; set; }

        private User()
        {

        }

        public User(string parvoIme, string semeinoIme, int naKolkoSiGodini, string potrebitelIme, string pasduma, string eposhta)
        {
            ParvoIme = parvoIme;
            SemeinoIme = semeinoIme;
            NaKolkoSiGodini = naKolkoSiGodini;
            PotrebitelIme = potrebitelIme;
            Pasduma = pasduma;
            Eposhta = eposhta;
        }
    }
}