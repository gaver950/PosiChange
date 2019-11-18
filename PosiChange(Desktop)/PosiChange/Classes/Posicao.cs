﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace PosiChange.Classes
{
    public class Posicao
    {
        public int Cod { get; set; }
        public string Position { get; set; }
        public byte Imagem { get; set; }

        public Posicao() { }

        public Posicao(int cod, string position, byte imagem)
        {
            Cod = cod;
            Position = position;
            Imagem = imagem;
        }

        public Posicao(string position, byte imagem)
        {
            Position = position;
            Imagem = imagem;
        }

        public void Inserir()
        {
            var com = Banco.Abrir();
            com.CommandType = System.Data.CommandType.StoredProcedure;
            com.CommandText = "sp_insert_posicao";
            com.Parameters.Add("sp_posicao", MySqlDbType.VarChar).Value = Position;
            com.Parameters.Add("sp_img", MySqlDbType.LongBlob).Value = Imagem;
            Cod = Convert.ToInt32(com.ExecuteScalar());
            com.Connection.Close();
        }
    }
}
