using System;
using System.Collections.Generic;
using System.Text;

namespace LivAktivitetPrøve
{
    public class Deltager
    {
        private int _id;
        private string _navn;
        private int _alder;

        public Deltager(int id, string navn, int alder)
        {
            _id = id;
            _navn = navn;
            _alder = alder;
        }
        public int ID { get { return _id; } set { _id = value; } }
        public string Navn { get { return _navn; } set { _navn = value; } }
        public int Alder { get { return _alder; } set { _alder = value; } }

        public override string ToString()
        {
            return $"{_navn} {_alder}år.";
        }
    }
}
