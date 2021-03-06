﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace PASITOS
{
    class AccesoDatos
    {
        private SqlCommand comando = null;
        private DataTable dTable = null;

        // CAPTURAR ////////////////////////////////////////////////////////// 

        public void NuevoBeneficiario(O_Beneficiario B)
        {
            comando = new SqlCommand();
            comando.Connection = A_AConexion.ObtenerConexion();

            comando.CommandText =
                "Insert into Beneficiario(Nombre_Ben, Fec_Nac_Ben, ID_Genero_Ben, Padecimiento_Ben, Necesidad_Ben)" +
                "Values (@Nombre_Ben, @Fec_Nac_Ben, @ID_Genero_Ben, @Padecimiento_Ben, @Necesidad_Ben)";

            comando.Parameters.AddWithValue("@Nombre_Ben", B.Nombre_Ben);
            comando.Parameters.AddWithValue("@Fec_Nac_Ben", B.Fec_Nac_Ben);
            comando.Parameters.AddWithValue("@ID_Genero_Ben", B.Genero_Ben);
            comando.Parameters.AddWithValue("@Padecimiento_Ben", B.Padecimiento_Ben);
            comando.Parameters.AddWithValue("@Necesidad_Ben", B.Necesidad_Ben);

            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }
        
        internal void NuevoDonante(O_Donante D)
        {
            comando = new SqlCommand();
            comando.Connection = A_AConexion.ObtenerConexion();

            comando.CommandText =
                "Insert into Donante(Nombre_Don, ID_Tipo_Don, Direccion_Don, RFC_Don, Info_Don, ID_Estatus )" +
                "Values (@Nombre_Don, @ID_Tipo_Don, @Direccion_Don, @RFC_Don, @Info_Don, @ID_Estatus)";

            comando.Parameters.AddWithValue("@Nombre_Don", D.Nom_Don);
            comando.Parameters.AddWithValue("@ID_Tipo_Don", D.ID_Tipo_Don);
            comando.Parameters.AddWithValue("@Direccion_Don", D.Direccion_Don);
            comando.Parameters.AddWithValue("@RFC_Don", D.RFC_Don);
            comando.Parameters.AddWithValue("@Info_Don", D.Info_Don);
            comando.Parameters.AddWithValue("@ID_Estatus", D.Estatus_Don);

            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }

        internal void NuevoContacto(O_Contacto C)
        {
            comando = new SqlCommand();
            comando.Connection = A_AConexion.ObtenerConexion();

            comando.CommandText =
                "Insert into Contacto(Nombre_Con, Tel_Con, Correo_Con, Puesto_Con, Cumpleaños_Con, Hora_Atencion, Info_Con, ID_Donante )" +
                "Values (@Nombre_Con, @Tel_Con, @Correo_Con, @Puesto_Con, @Cumpleaños_Con, @Hora_Atencion, @Info_Con, @ID_Donante)";

            comando.Parameters.AddWithValue("@Nombre_Con", C.Nombre_Con);
            comando.Parameters.AddWithValue("@Tel_Con", C.Tel_Con);
            comando.Parameters.AddWithValue("@Correo_Con", C.Correo_Con);
            comando.Parameters.AddWithValue("@Puesto_Con", C.Puesto_Con);
            comando.Parameters.AddWithValue("@Cumpleaños_Con", C.Cumpleaños_Con);
            comando.Parameters.AddWithValue("@Hora_Atencion", C.Hora_Atencion);
            comando.Parameters.AddWithValue("@Info_Con", C.Info_Con);
            comando.Parameters.AddWithValue("@ID_Donante", C.ID_Donante);

            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }

        internal void NuevoDatosDonativo(O_Donativo D)
        {
            comando = new SqlCommand();
            comando.Connection = A_AConexion.ObtenerConexion();

            comando.CommandText =
                "Insert into Donativo(ID_Donante, ID_Tipo_Donativo, Fecha_inicio, Periodicidad, Don_monetario, Forma_pago, ID_Beneficiario, UsoDon, Estado )" +
                "Values (@ID_Donante, @ID_Tipo_Donativo, @Fecha_inicio, @Periodicidad, @Don_monetario, @Forma_pago, @ID_Beneficiario, @UsoDon, @Estado)";

            comando.Parameters.AddWithValue("@ID_Donante", D.ID_Donante);
            comando.Parameters.AddWithValue("@ID_Tipo_Donativo", D.ID_Tipo_Donativo);
            comando.Parameters.AddWithValue("@Fecha_inicio", D.Fecha_inicio);
            comando.Parameters.AddWithValue("@Periodicidad", D.Periodicidad);
            comando.Parameters.AddWithValue("@Don_monetario", D.Don_monetario);
            comando.Parameters.AddWithValue("@Forma_pago", D.Forma_pago);
            comando.Parameters.AddWithValue("@ID_Beneficiario", D.ID_beneficiario);
            comando.Parameters.AddWithValue("@UsoDon", D.UsoDon);
            comando.Parameters.AddWithValue("@Estado", D.Estado);

            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }
// //////
        internal void NuevoTutor(O_Tutor T)
        {
            comando = new SqlCommand();
            comando.Connection = A_AConexion.ObtenerConexion();

            comando.CommandText =
                "Insert into Tutor(Nombre_Tut,Direccion_Tut, Telefono_Tut, Parentesco_tut, FecNac_Tut) " +
                "Values (@Nombre_Tut,@Direccion_Tut, @Telefono_Tut, @Parentesco_tut, @FecNac_Tut) ";

            // comando.Parameters.AddWithValue("@ID", ID);
            comando.Parameters.AddWithValue("@Nombre_Tut", T.Nombre_Tut);
            comando.Parameters.AddWithValue("@Direccion_Tut", T.Direccion_Tut);
            comando.Parameters.AddWithValue("@Telefono_Tut", T.Telefono_Tut);
            comando.Parameters.AddWithValue("@Parentesco_tut", T.Parentesco_Tut);
            comando.Parameters.AddWithValue("@FecNac_Tut", T.FecNac_Tut);
            
            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }


        // COMBO BOX //////////////////////////////////////////////////////////
        internal DataTable ConsultaGenero()
        {
            comando = new SqlCommand();
            dTable = new DataTable();

            comando.Connection = A_AConexion.ObtenerConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select ID_Genero, Genero From Genero";

            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dTable);
            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
            return dTable;
        }

        internal DataTable ConsultaEstatusDon()
        {
            comando = new SqlCommand();
            dTable = new DataTable();

            comando.Connection = A_AConexion.ObtenerConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select ID_Estatus, Estatus From EstatusDonante";

            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dTable);
            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
            return dTable;
        }

        internal DataTable ConsultaTipoDon()
        {
            comando = new SqlCommand();
            dTable = new DataTable();

            comando.Connection = A_AConexion.ObtenerConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select ID_Tipo_Don, TipoDon From TipoDonante";

            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dTable);
            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
            return dTable;
        }

        internal DataTable ConsultaBeneficiarioCB()
        {
            comando = new SqlCommand();
            dTable = new DataTable();

            comando.Connection = A_AConexion.ObtenerConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select ID_Beneficiario, Nombre_Ben From Beneficiario";

            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dTable);
            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
            return dTable;
        }

        internal DataTable ConsultaDonanteCB()
        {
            comando = new SqlCommand();
            dTable = new DataTable();

            comando.Connection = A_AConexion.ObtenerConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select ID_Donante, Nombre_Don From Donante";

            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dTable);
            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
            return dTable;
        }

        internal DataTable ConsultaTipoDonCB()
        {
            comando = new SqlCommand();
            dTable = new DataTable();

            comando.Connection = A_AConexion.ObtenerConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select ID_Tipo_Donativo, TipoDonativo From TipoDonativo";

            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dTable);
            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
            return dTable;
        }

        // CONSULTAS //////////////////////////////////////////////////////////

        internal int ConsultaIDDonante()
        {
            comando = new SqlCommand();
            dTable = new DataTable();
            int x;
            comando.Connection = A_AConexion.ObtenerConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT MAX(ID_Donante) FROM Donante";
            
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dTable);


            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();

            return x=Int16.Parse(dTable.Rows[0][0].ToString());
        }

        internal DataTable ConsultaBeneficiarioMos()
        {
            comando = new SqlCommand();
            dTable = new DataTable();

            comando.Connection = A_AConexion.ObtenerConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = " Select b.ID_Beneficiario,b.Nombre_Ben,b.Fec_Nac_Ben,g.Genero,b.Padecimiento_Ben,b.Necesidad_Ben From Beneficiario b "+
                                  "join Genero g on b.ID_Genero_Ben=g.ID_Genero";
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dTable);

            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();


            return dTable;
        }

        internal DataTable ConsultaContactoMos()
        {
            comando = new SqlCommand();
            dTable = new DataTable();

            comando.Connection = A_AConexion.ObtenerConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "  select d.Nombre_Don,c.ID_Contacto,c.Nombre_Con,c.Tel_Con,c.Correo_Con,c.Puesto_Con,c.Hora_Atencion,c.Info_Con,c.Cumpleaños_Con from Contacto c "+
                                    "inner join Donante d on d.ID_Donante=c.ID_Donante";
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dTable);

            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();


            return dTable;
        }

        internal DataTable ConsultarContatoPorDonanteID(int ID)
        {
            comando = new SqlCommand();
            dTable = new DataTable();

            comando.Connection = A_AConexion.ObtenerConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "  select d.Nombre_Don,c.ID_Contacto,c.Nombre_Con,c.Tel_Con,c.Correo_Con,c.Puesto_Con,c.Hora_Atencion,c.Info_Con,c.Cumpleaños_Con from Contacto c " +
                                    "inner join Donante d on d.ID_Donante=c.ID_Donante where @ID_Donante=d.ID_Donante";
            comando.Parameters.AddWithValue("@ID_Donante",ID);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dTable);

            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();


            return dTable;
        }

        internal DataTable ConsultaAspirantes_a_Donantes()
        {
            comando = new SqlCommand();
            dTable = new DataTable();

            comando.Connection = A_AConexion.ObtenerConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "  select d.ID_Donante,d.Nombre_Don,t.TipoDon,d.Direccion_Don,d.RFC_Don,d.Info_Don From Donante d join TipoDonante t on t.ID_Tipo_Don=d.ID_Tipo_Don where ID_Estatus=2";
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dTable);

            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();


            return dTable;
        }

        internal DataTable ConsultaDonantes()
        {
            comando = new SqlCommand();
            dTable = new DataTable();

            comando.Connection = A_AConexion.ObtenerConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "  select d.ID_Donante,d.Nombre_Don,t.TipoDon,d.Direccion_Don,d.RFC_Don,d.Info_Don From Donante d join TipoDonante t on t.ID_Tipo_Don=d.ID_Tipo_Don where ID_Estatus=1";
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dTable);

            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();


            return dTable;
        }

        internal DataTable ConsultaBusquedaDonante(int ID)
        {
            comando = new SqlCommand();
            dTable = new DataTable();

            comando.Connection = A_AConexion.ObtenerConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = " select * from Donante where ID_Donante=@ID";

            SqlDataAdapter da = new SqlDataAdapter(comando);

            comando.Parameters.AddWithValue("@ID", ID);
            da.Fill(dTable);
            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
            return dTable;
        }

        internal void ActualizarDonante(O_Donante D, int ID)
        {
            comando = new SqlCommand();
            comando.Connection = A_AConexion.ObtenerConexion();
            //comando.CommandType = CommandType.StoredProcedure;

            comando.CommandText =
                "Update Donante Set Nombre_Don=@Nombre_Don, ID_Tipo_Don=@ID_Tipo_Don, Direccion_Don=@Direccion_Don, RFC_Don=@RFC_Don, Info_Don=@Info_Don, ID_Estatus=@ID_Estatus  where ID_Donante=@ID";

            comando.Parameters.AddWithValue("@ID", ID);
            comando.Parameters.AddWithValue("@Nombre_Don", D.Nom_Don);
            comando.Parameters.AddWithValue("@ID_Tipo_Don", D.ID_Tipo_Don);
            comando.Parameters.AddWithValue("@Direccion_Don", D.Direccion_Don);
            comando.Parameters.AddWithValue("@RFC_Don", D.RFC_Don);
            comando.Parameters.AddWithValue("@Info_Don", D.Info_Don);
            comando.Parameters.AddWithValue("@ID_Estatus", D.Estatus_Don);

            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }

        internal DataTable ConsultaBusquedaContacto(int ID)
        {
            comando = new SqlCommand();
            dTable = new DataTable();

            comando.Connection = A_AConexion.ObtenerConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = " select * from Contacto where ID_Contacto=@ID";

            SqlDataAdapter da = new SqlDataAdapter(comando);

            comando.Parameters.AddWithValue("@ID", ID);
            da.Fill(dTable);
            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
            return dTable;
        }
        internal void EliminarDonante(int ID)
        {
            comando = new SqlCommand();
            comando.Connection = A_AConexion.ObtenerConexion();
            //comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "Delete From Contacto Where ID_Donante = @ID_Donante  " + 
                "Delete From Donante Where ID_Donante = @ID_Donante ";

            comando.Parameters.AddWithValue("@ID_Donante", ID);

            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }

        internal void EliminarContacto(int ID)
        {
            comando = new SqlCommand();
            comando.Connection = A_AConexion.ObtenerConexion();
            //comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "Delete From Contacto Where ID_Contacto = @ID_Contacto ";

            comando.Parameters.AddWithValue("@ID_Contacto", ID);

            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }

        internal void ActualizarContacto(O_Contacto C, int ID)
        {
            comando = new SqlCommand();
            comando.Connection = A_AConexion.ObtenerConexion();
            //comando.CommandType = CommandType.StoredProcedure;

            comando.CommandText =
                "Update Contacto Set Nombre_Con=@Nombre_Con, Tel_Con=@Tel_Con, Correo_Con=@Correo_Con, Puesto_Con=@Puesto_Con, Cumpleaños_Con=@Cumpleaños_Con, Hora_Atencion=@Hora_Atencion,Info_Con=@Info_Con  where ID_Contacto=@ID";

            comando.Parameters.AddWithValue("@ID", ID);
            comando.Parameters.AddWithValue("@Nombre_Con", C.Nombre_Con);
            comando.Parameters.AddWithValue("@Tel_Con",C.Tel_Con);
            comando.Parameters.AddWithValue("@Correo_Con",C.Correo_Con);
            comando.Parameters.AddWithValue("@Puesto_Con", C.Puesto_Con);
            comando.Parameters.AddWithValue("@Cumpleaños_Con", C.Cumpleaños_Con);
            comando.Parameters.AddWithValue("@Hora_Atencion",C.Hora_Atencion );
            comando.Parameters.AddWithValue("@Info_Con", C.Info_Con);

            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }

        internal void CambiarDeAspirante_a_Donante(int ID)
        {
            comando = new SqlCommand();
            comando.Connection = A_AConexion.ObtenerConexion();
            //comando.CommandType = CommandType.StoredProcedure;

            comando.CommandText =
                "Update Donante Set ID_Estatus=@ID_Estatus  where ID_Donante=@ID";

            comando.Parameters.AddWithValue("@ID", ID);

            comando.Parameters.AddWithValue("@ID_Estatus", 1);

            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }

        internal int  ConsultaIDBeneficiario()
        {
            comando = new SqlCommand();
            dTable = new DataTable();
            int x;
            comando.Connection = A_AConexion.ObtenerConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT MAX(ID_Beneficiario) FROM Beneficiario";

            SqlDataAdapter da = new SqlDataAdapter(comando);

            da.Fill(dTable);
            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
          
            return x = Int16.Parse(dTable.Rows[0][0].ToString());
        }

        internal DataTable ConsultarTutorporIDBeneficiario(int ID)
        {
            comando = new SqlCommand();
            dTable = new DataTable();

            comando.Connection = A_AConexion.ObtenerConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = " SELECT T.ID_Tutor,T.Nombre_Tut,T.Direccion_Tut,T.Telefono_Tut,T.Parentesco_Tut,T.FecNac_Tut FROM Tutor T "+
                                    "JOIN RELACIONTUTOR R ON T.ID_Tutor=R.ID_Tutor "+
                                    "JOIN Beneficiario B ON R.ID_Benefiario=B.ID_Beneficiario "+
                                    "WHERE B.ID_Beneficiario=@ID";

            SqlDataAdapter da = new SqlDataAdapter(comando);

            comando.Parameters.AddWithValue("@ID", ID);
            da.Fill(dTable);
            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
            return dTable;
        }





        

        internal int ConsultaIDTutor()
        {
            comando = new SqlCommand();
            dTable = new DataTable();
            int x;
            comando.Connection = A_AConexion.ObtenerConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT MAX(ID_Tutor) FROM Tutor";

            SqlDataAdapter da = new SqlDataAdapter(comando);

            da.Fill(dTable);
            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();

            return x = Int16.Parse(dTable.Rows[0][0].ToString());
        }

        internal void RelacionTutor(int Id_ben, int Id_Tut)
        {
            comando = new SqlCommand();
            comando.Connection = A_AConexion.ObtenerConexion();

            comando.CommandText =
                "Insert into RelacionTutor(ID_Benefiario,ID_Tutor) " +
                "Values (@ID_Benefiario,@ID_Tutor)";


            comando.Parameters.AddWithValue("@ID_Benefiario", Id_ben);
            comando.Parameters.AddWithValue("@ID_Tutor", Id_Tut);


            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }

        internal void Eliminarbeneficiario(int ID_Ben,int ID_tut)
        {
            comando = new SqlCommand();
            comando.Connection = A_AConexion.ObtenerConexion();
            //comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "Delete from relaciontutor where ID_Benefiario=@ID_Ben " +
                                  "Delete from Tutor where ID_Tutor=@ID_Tut "+
                "Delete From Beneficiario Where ID_Beneficiario = @ID_Ben ";

            comando.Parameters.AddWithValue("@ID_Ben", ID_Ben);
            comando.Parameters.AddWithValue("@ID_Tut", ID_tut);

            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();

        }

        internal int ConsultaIDTutor2(int ID)
        {
          
            comando = new SqlCommand();
            dTable = new DataTable();
            int x;
            comando.Connection = A_AConexion.ObtenerConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = " SELECT b.ID_Beneficiario,b.Nombre_Ben,b.Fec_Nac_Ben,g.Genero,b.Padecimiento_Ben,b.Necesidad_Ben,* FROM Tutor T " +
                                   " JOIN RELACIONTUTOR R ON T.ID_Tutor=R.ID_Tutor " +
                                   " JOIN Beneficiario B ON R.ID_Benefiario=B.ID_Beneficiario " +
                                   " join genero g on g.ID_Genero=b.ID_Genero_Ben " +
                                   " WHERE B.ID_Beneficiario=@ID ";

            SqlDataAdapter da = new SqlDataAdapter(comando);

            comando.Parameters.AddWithValue("@ID", ID);
            da.Fill(dTable);
            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
            return x = Int16.Parse(dTable.Rows[0][0].ToString());
        
        }

        internal void Eliminarbeneficiario2(int ID)
        {
            comando = new SqlCommand();
            comando.Connection = A_AConexion.ObtenerConexion();
            //comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText =
                "Delete From Beneficiario Where ID_Beneficiario = @ID_Ben";

            comando.Parameters.AddWithValue("@ID_Ben", ID);


            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }

        internal DataTable ConsultaBusquedaBeneficiario_tutor(int ID)
        {
            comando = new SqlCommand();
            dTable = new DataTable();
           
            comando.Connection = A_AConexion.ObtenerConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = " SELECT b.ID_Beneficiario,b.Nombre_Ben,b.Fec_Nac_Ben,g.Genero,b.Padecimiento_Ben,b.Necesidad_Ben,* FROM Tutor T " +
                                   " JOIN RELACIONTUTOR R ON T.ID_Tutor=R.ID_Tutor " +
                                   " JOIN Beneficiario B ON R.ID_Benefiario=B.ID_Beneficiario " +
                                   " join genero g on g.ID_Genero=b.ID_Genero_Ben " +
                                   " WHERE B.ID_Beneficiario=@ID ";

            SqlDataAdapter da = new SqlDataAdapter(comando);

            comando.Parameters.AddWithValue("@ID", ID);
            da.Fill(dTable);
            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
            return dTable;
        }

        internal void ActualizarBeneficiario(O_Beneficiario B, int ID)
        {
          
            comando = new SqlCommand();
            comando.Connection = A_AConexion.ObtenerConexion();
            //comando.CommandType = CommandType.StoredProcedure;

            comando.CommandText =
                "Update Beneficiario Set Nombre_Ben=@Nombre_Ben, Fec_Nac_Ben=@Fec_Nac_Ben, ID_Genero_Ben=@ID_Genero_Ben, Padecimiento_Ben=@Padecimiento_Ben, Necesidad_Ben=@Necesidad_Ben where ID_Beneficiario=@ID";
            
            comando.Parameters.AddWithValue("@ID", ID);
            comando.Parameters.AddWithValue("@Nombre_Ben", B.Nombre_Ben);
            comando.Parameters.AddWithValue("@Fec_Nac_Ben", B.Fec_Nac_Ben);
            comando.Parameters.AddWithValue("@ID_Genero_Ben", B.Genero_Ben);
            comando.Parameters.AddWithValue("@Padecimiento_Ben", B.Padecimiento_Ben);
            comando.Parameters.AddWithValue("@Necesidad_Ben", B.Necesidad_Ben);

            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        
        }

        internal int ConsultaRelacionTutorBeneficiario(int ID)
        {
            comando = new SqlCommand();
            dTable = new DataTable();

            comando.Connection = A_AConexion.ObtenerConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = " select ID_Tutor from RelacionTutor where ID_Benefiario=@ID_Benefiario ";

            SqlDataAdapter da = new SqlDataAdapter(comando);

            comando.Parameters.AddWithValue("@ID_Benefiario", ID);
            da.Fill(dTable);
            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
            return int.Parse(dTable.Rows[0][0].ToString());
          
        }

        internal void ActualizarTutor(O_Tutor T, int ID)
        {
            comando = new SqlCommand();
            comando.Connection = A_AConexion.ObtenerConexion();
            //comando.CommandType = CommandType.StoredProcedure;

            comando.CommandText =
                "Update Tutor Set Nombre_Tut=@Nombre_Tut, Direccion_Tut=@Direccion_Tut, Telefono_Tut=@Telefono_Tut, Parentesco_tut=@Parentesco_tut, FecNac_Tut=@FecNac_Tut where ID_Tutor=@ID";

            comando.Parameters.AddWithValue("@ID", ID);
            comando.Parameters.AddWithValue("@Nombre_Tut", T.Nombre_Tut);
            comando.Parameters.AddWithValue("@Direccion_Tut", T.Direccion_Tut);
            comando.Parameters.AddWithValue("@Telefono_Tut", T.Telefono_Tut);
            comando.Parameters.AddWithValue("@Parentesco_tut", T.Parentesco_Tut);
            comando.Parameters.AddWithValue("@FecNac_Tut", T.FecNac_Tut);

            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }
    }
}
