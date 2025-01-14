﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PosiChange.Classes;

namespace PosiChange.Classes
{
    public class Enfermeiro
    {
        public int Cod { get; set; }
        public string Nome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public int Coren { get; set; }
        public string Turno { get; set; }
        public DateTime Intervalo { get; set; }
        public string Telefone { get; set; }
        internal Nivel Level { get; set; }
        
        public Enfermeiro() { }

        public Enfermeiro(int cod, string nome, string rg, string cpf, int coren, string turno, DateTime intervalo, string telefone, Nivel level)
        {
            Cod = cod;
            Nome = nome;
            RG = rg;
            CPF = cpf;
            Coren = coren;
            Turno = turno;
            Intervalo = intervalo;
            Telefone = telefone;
            Level = level;
        }

        public Enfermeiro(string nome, string rg, string cpf, int coren, string turno, DateTime intervalo, string telefone, Nivel level)
        {
            Nome = nome;
            RG = rg;
            CPF = cpf;
            Coren = coren;
            Turno = turno;
            Intervalo = intervalo;
            Telefone = telefone;
            Level = level;
        }

        public void Inserir()
        {
            var com = Banco.Abrir();
            com.CommandType = System.Data.CommandType.StoredProcedure;
            com.CommandText = "sp_insert_enfermeiro";
            com.Parameters.Add("sp_nome", MySqlDbType.VarChar).Value = Nome;
            com.Parameters.Add("sp_rg", MySqlDbType.VarChar).Value = RG;
            com.Parameters.Add("sp_cpf", MySqlDbType.VarChar).Value = CPF;
            com.Parameters.Add("sp_coren", MySqlDbType.Int32).Value = Coren;
            com.Parameters.Add("sp_turno", MySqlDbType.VarChar).Value = Turno;
            com.Parameters.Add("sp_intervalo", MySqlDbType.Timestamp).Value = Intervalo;
            com.Parameters.Add("sp_telefone", MySqlDbType.VarChar).Value = Telefone;
            com.Parameters.Add("sp_code_nivel", MySqlDbType.Int32).Value = Level.Cod;
            Cod = Convert.ToInt32(com.ExecuteScalar());
            com.Connection.Close();
        }

        public bool Alterar()
        {
            var com = Banco.Abrir();
            bool alterado = false;
            try
            {
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.CommandText = "sp_update_enfermeiro";
                com.Parameters.Add("sp_cod", MySqlDbType.Int32).Value = Cod;
                com.Parameters.Add("sp_nome", MySqlDbType.VarChar).Value = Nome;
                com.Parameters.Add("sp_coren", MySqlDbType.Int32).Value = Coren;
                com.Parameters.Add("sp_intervalo", MySqlDbType.Time).Value = Intervalo;
                com.Parameters.Add("sp_turno", MySqlDbType.VarChar).Value = Turno;
                com.Parameters.Add("sp_telefone", MySqlDbType.VarChar).Value = Telefone;
                com.Parameters.Add("sp_cod_nivel", MySqlDbType.Int32).Value = Level.Cod;
                com.ExecuteNonQuery();
                com.Connection.Close();
                alterado = true;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            return alterado;
        }

        public List<Enfermeiro> ListaEnfermeiro(string nome)
        {
            List<Enfermeiro> enfermeiros = new List<Enfermeiro>();
            
            var com = Banco.Abrir();
            com.CommandText = "select * from enfermagem where nome = '%" + nome + "%'";
            var dr = com.ExecuteReader();
            while (dr.Read())
            {
                Enfermeiro enf = new Enfermeiro();
                enf.Cod = dr.GetInt32(0);
                enf.Nome = dr.GetString(1);
                enf.RG = dr.GetString(2);
                enf.CPF = dr.GetString(3);
                enf.Coren = dr.GetInt32(4);
                enf.Intervalo = dr.GetDateTime(5);
                enf.Turno = dr.GetString(6);
                enf.Telefone = dr.GetString(7);
                enf.Level.Cod = dr.GetInt32(8);
                com.ExecuteNonQuery();
                enfermeiros.Add(enf);
            }
            com.Connection.Close();
            return enfermeiros;
        }

        public List<Enfermeiro> TodosEnfermeiro()
        {
            List<Enfermeiro> enfermeiros = new List<Enfermeiro>();

            var com = Banco.Abrir();
            com.CommandText = "select * from enfermagem";
            var dr = com.ExecuteReader();
            while (dr.Read())
            {
                Enfermeiro enf = new Enfermeiro();
                enf.Cod = dr.GetInt32(0);
                enf.Nome = dr.GetString(1);
                enf.RG = dr.GetString(2);
                enf.CPF = dr.GetString(3);
                enf.Coren = dr.GetInt32(4);
                DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
                enf.Intervalo =  origin.AddSeconds(Convert.ToDouble(dr.GetValue(5)));
                enf.Turno = dr.GetString(6);
                enf.Telefone = dr.GetString(7);
                enf.Level.Cod = dr.GetInt32(8);
                com.ExecuteNonQuery();
                enfermeiros.Add(enf);
            }
            com.Connection.Close();
            return enfermeiros;
        }

        public bool Verificalogin(int coren)
        {
            bool existe = false;
            var com = Banco.Abrir();
            try
            {
                com.CommandText = "select * from enfermagem where coren = " + coren;
                com.ExecuteNonQuery();
                com.Connection.Close();
                existe = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return existe;
        }

        public MySqlDataReader Enfermeiros()
        {

            var com = Banco.Abrir();
            com.CommandText = "select * from enfermagem";
            var dr = com.ExecuteReader();

            return dr;
        }

        public void Select(int cod)
        {
            Level = new Nivel();
            var com = Banco.Abrir();
            com.CommandText = "select * from enfermagem where cod_enf =" + cod;
            var dr = com.ExecuteReader();
            while (dr.Read())
            {
                Cod = dr.GetInt32(0);
                Nome = dr.GetString(1);
                RG = dr.GetString(2);
                CPF = dr.GetString(3);
                Coren = dr.GetInt32(4);
                Turno = dr.GetString(5);
                //Intervalo = dr.GetDateTime(6);
                Telefone = dr.GetString(7);
                Level.Cod = dr.GetInt32(8);
            }
            com.Connection.Close();
        }

        public void Buscar()
        {
            Level = new Nivel();
            var com = Banco.Abrir();
            com.CommandText = "select * from enfermagem";
            var dr = com.ExecuteReader();
            while (dr.Read())
            {
                Cod = dr.GetInt32(0);
                Nome = dr.GetString(1);
                RG = dr.GetString(2);
                CPF = dr.GetString(3);
                Coren = dr.GetInt32(4);
                Turno = dr.GetString(5);
                //Intervalo = dr.GetDateTime(6);
                Telefone = dr.GetString(7);
                Level.Cod = dr.GetInt32(8);
            }
            com.Connection.Close();
        }
    }
}
