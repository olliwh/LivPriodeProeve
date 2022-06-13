using System;
using System.Collections.Generic;

namespace LivAktivitetPrøve
{
    public class HoldAktivitet : Aktivitet
    {
        private List<Deltager> _deltagere;
        public int HoldId { get; set; }

        public HoldAktivitet(int holdID, int id, int minAlder, int maxAlder, DateTime start, DateTime slut)
            : base(id, minAlder, maxAlder, start, slut)
        {
            HoldId = holdID;
            _deltagere = new List<Deltager>();
        }

        public void AddDeltager(Deltager d)
        {
            bool isIDTaken = false;
            foreach (Deltager deltager in _deltagere)
            {
                if (deltager.ID == d.ID)
                {
                    isIDTaken = true;
                    Console.WriteLine($"{deltager.Navn} er allerede tilmeldt");
                    break;
                }
            }
            if (d.Alder < _minAlder || d.Alder > MaxAlder)
            {
                isIDTaken = true;
                Console.WriteLine("Deltager ikke inde for aldersgrænsen");
            }
            if (isIDTaken == false) _deltagere.Add(d);
        }

        public void DeleteDeltager(int id)
        {
            foreach (Deltager d in _deltagere)
            {
                if (d.ID == id)
                {
                    _deltagere.Remove(d);
                    break;
                }
            }
        }

        public void SeeDeltagere()
        {
            Console.WriteLine("Deltagere: ");
            foreach (var d in _deltagere)
            {
                Console.WriteLine($"{d.Navn} {d.Alder} år");
            }
        }

        public override string ToString()
        {
            string strToReturn = string.Empty;
            while (_deltagere.Count > 0)
            {
                strToReturn += "Deltagere:\n";
                foreach (Deltager d in _deltagere)
                {
                    strToReturn += d + "\n";
                }
                break;
            }

            return $"Hold ID: {HoldId} {base.ToString()} \n{strToReturn}";
        }
    }
}