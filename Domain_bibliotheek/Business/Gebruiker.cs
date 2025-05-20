using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_bibliotheek.Business
{
    public class Gebruiker
    {
        public string _naam, _voornaam, _email;
        public int _gebruikerId, _rechtId;

        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }
        public string Voornaam
        {
            get { return _voornaam; }
            set { _voornaam = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public int GebruikerId
        {
            get { return _gebruikerId; }
            set { _gebruikerId = value; }
        }
        public int RechtId
        {
            get { return _rechtId; }
            set { _rechtId = value; }
        }
        public Gebruiker()
        {
            _naam = "";
            _voornaam = "";
            _email = "";
            _gebruikerId = 0;
            _rechtId = 0;
        }
        public Gebruiker(string naam, string voornaam, string email, int gebruikerId, int rechtId)
        {
            _naam = naam;
            _voornaam = voornaam;
            _email = email;
            _gebruikerId = gebruikerId;
            _rechtId = rechtId;
        }
        public override string ToString()
        {
            return $"{_gebruikerId}, {_naam}, {_voornaam}";
        }
    }
}
