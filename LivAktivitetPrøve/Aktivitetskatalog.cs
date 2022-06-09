using System;
using System.Collections.Generic;
using System.Text;

namespace LivAktivitetPrøve
{
    public class Aktivitetskatalog
    {
        private string _aktivitetesNavn;
        private string _lokation;
        private List<Aktivitet> _aktiviteter;
        private Dictionary<int, Aktivitet> _dicAktiviteter;

        public Aktivitetskatalog(string aktivitetsNavn, string lokation)
        {
            _aktivitetesNavn = aktivitetsNavn;
            _lokation = lokation;
            _aktiviteter = new List<Aktivitet>();
            _dicAktiviteter = new Dictionary<int, Aktivitet>();
        }
        #region Properties
        public string AktivitetsNavn { get { return _aktivitetesNavn; } set { _aktivitetesNavn = value; } }
        public string Lokation { get { return _lokation; } set { _lokation = value; } }
        public List<Aktivitet> Aktiviteter { get { return _aktiviteter; } set { _aktiviteter = value; } }
        public Dictionary<int, Aktivitet> DicAktivitet { get { return _dicAktiviteter; } set { _dicAktiviteter = value; } }
        #endregion

        #region Dictionary
        public void DicAddAktivitet(Aktivitet a)
        {
            _dicAktiviteter.Add(a.ID, a);
        }
        public void DicDeleteAktivitet(int id)
        {
            _dicAktiviteter.Remove(id);
        }

        //public override string ToString()
        //{
        //    string strToReturn = string.Empty;
        //    while (_dicAktiviteter.Count > 0)
        //    {
        //        strToReturn += "Aktiviteter:\n";
        //        foreach (Aktivitet a in _dicAktiviteter.Values)
        //        {
        //            strToReturn += a + "\n";
        //        }
        //        break;
        //    }
        //    return $"{_aktivitetesNavn} på {_lokation} \n{strToReturn}";
        //}
        #endregion
        #region List
        public void AddAktivitet(Aktivitet a)
        {
            _aktiviteter.Add(a);
        }
        public void DeleteAktivitet(int id)
        {
            foreach (Aktivitet a in _aktiviteter)
            {
                if (a.ID == id)
                {
                    _aktiviteter.Remove(a);
                    break;
                }
            }
        }

        public override string ToString()
        {
            string strToReturn = string.Empty;
            while (_aktiviteter.Count > 0)
            {
                strToReturn += "Aktiviteter:\n";
                int x = 0;
                while (x < _aktiviteter.Count)
                {
                    strToReturn += _aktiviteter[x] + "\n";
                    x++;
                }
                //foreach (Aktivitet a in _aktiviteter)
                //{
                //    strToReturn += a + "\n";
                //}
                break;
            }
            return $"{_aktivitetesNavn} på {_lokation} \n{strToReturn}";
        }
        #endregion
    }
}
