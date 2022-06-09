using System;
using System.Collections.Generic;
using System.Text;

namespace LivAktivitetPrøve
{
    public class Aktivitet
    {
        public int _id;
        protected int _minAlder;
        protected int _maxAlder;
        protected DateTime _startTidspunkt;
        protected DateTime _slutTidspunkt;

        public Aktivitet(int id, int minAlder, int maxAlder, DateTime start, DateTime slut)
        {
            _id = id;
            _minAlder = minAlder;
            _maxAlder = maxAlder;
            _startTidspunkt = start;
            _slutTidspunkt = slut;
            try
            {
                if (_minAlder > _maxAlder)
                {
                    throw new ArgumentException();
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"ID: {_id} Minimums alder må ikke være større en maximums alder");
            }
            try
            {
                if (_startTidspunkt >= _slutTidspunkt)
                {
                    throw new ArgumentException();
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"Start tidspunkt er den samme eller senere end slut tidspunkt");
            }
        }

        public int ID
        { get { return _id; } set { _id = value; } }
        public int MinAlder
        { get { return _minAlder; } set { _minAlder = value; } }
        public int MaxAlder
        { get { return _maxAlder; } set { _maxAlder = value; } }

        public DateTime StartTidspunkt
        {
            get { return _startTidspunkt; }
            set { _startTidspunkt = value; }
        }

        public DateTime SlutTidspunkt
        { get { return _slutTidspunkt; } set { _slutTidspunkt = value; } }

        public override string ToString()
        {
            return $"ID: {_id}, Minimums alder: {_minAlder}, Maximums alder: {_maxAlder}, Start Tidspunkt: {_startTidspunkt}, Slut tidspunkt: {_slutTidspunkt}";
        }
    }
}
