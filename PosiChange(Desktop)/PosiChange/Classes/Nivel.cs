﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PosiChange.Classes
{
    public class Nivel
    {
        public int Cod { get; set; }
        public string Level { get; set; }
        public string Sigla { get; set; }

        public Nivel() { }

        public Nivel(int cod, string level, string sigla)
        {
            Cod = cod;
            Level = level;
            Sigla = sigla;
        }

        public Nivel(string level, string sigla)
        {
            Level = level;
            Sigla = sigla;
        }

        public List<Nivel> ListaNiveis()
        {
            List<Nivel> nivels = new List<Nivel>();
            var com = Banco.Abrir();
            com.CommandText = "select * from nivel";
            var dr = com.ExecuteReader();
            while (dr.Read())
            {
                Nivel lvl = new Nivel();
                lvl.Cod = dr.GetInt32(0);
                lvl.Level = dr.GetString(1);
                lvl.Sigla = dr.GetString(2);
                com.ExecuteNonQuery();
                nivels.Add(lvl);
            }
            com.Connection.Close();
            return nivels;
        }

        public MySqlDataReader Niveis()
        {
            
            var com = Banco.Abrir();
            com.CommandText = "select * from nivel";
            var dr = com.ExecuteReader();
            
            return dr;
        }
    }
}