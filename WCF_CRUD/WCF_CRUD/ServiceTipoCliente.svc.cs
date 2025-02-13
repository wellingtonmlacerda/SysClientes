﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_CRUD
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceTipoCliente" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceTipoCliente.svc or ServiceTipoCliente.svc.cs at the Solution Explorer and start debugging.
    public class ServiceTipoCliente : IServiceTipoCliente
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString);
        public string InsertTipoCliente(TipoCliente eDetails)
        {
            try
            {
                string Status;
                SqlCommand cmd = new SqlCommand("TIPO_CLIENTE_INSERT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TIPO", eDetails.GetSetTICL_TIPO);
                cmd.Parameters.AddWithValue("@DESCRICAO", eDetails.GetSetTICL_DESCRICAO);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    Status = eDetails.GetSetTICL_DESCRICAO + " salvo com sucesso";
                }
                else
                {
                    Status = eDetails.GetSetTICL_DESCRICAO + " não foi possível salvar o registro";
                }
                con.Close();
                return Status;
            }catch(Exception ex)
            {
                return ex.Message;
            }
        }

        public DataSet GetTipoCliente(TipoCliente eDetails)
        {
            SqlCommand cmd = new SqlCommand("TIPO_CLIENTES_LISTA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", eDetails.GetSetTICL_PK_ID);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            con.Close();
            return ds;
        }
        public DataSet FetchUpdatedRecords(TipoCliente eDetails)
        {
            SqlCommand cmd = new SqlCommand("TIPO_CLIENTES_LISTA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", eDetails.GetSetTICL_PK_ID);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            con.Close();
            return ds;
        }
        public string UpdateTipoCliente(TipoCliente eDetails)
        {
            try
            {
                string Status;
                SqlCommand cmd = new SqlCommand("TIPO_CLIENTE_UPDATE", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", eDetails.GetSetTICL_PK_ID);
                cmd.Parameters.AddWithValue("@TIPO", eDetails.GetSetTICL_TIPO);
                cmd.Parameters.AddWithValue("@DESCRICAO", eDetails.GetSetTICL_DESCRICAO);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    Status = "Registro atualizado com sucesso";
                }
                else
                {
                    Status = "Não foi possível atualizar o registro";
                }
                con.Close();
                return Status;

            }catch(Exception ex)
            {
                return ex.Message;
            }
        }
        public bool DeleteTipoCliente(TipoCliente eDetails)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("TIPO_CLIENTE_DELETE", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", eDetails.GetSetTICL_PK_ID);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
