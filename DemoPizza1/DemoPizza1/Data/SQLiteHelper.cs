using System;
using System.Collections.Generic;
using System.Text;

using SQLite;
using DemoPizza1.Registro;
using System.Threading.Tasks;

namespace DemoPizza1.Data
{
    public class SQLiteHelper
    {
        SQLiteAsyncConnection db;
        public SQLiteHelper(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<TablaRegistro>().Wait();
        }

        // Funcion Registrar 
        public Task<int> SaveRegistro(TablaRegistro oRegistro)
        {
            if (oRegistro.ID_Usurio == 0)
            {
                return db.InsertAsync(oRegistro);
            }
            else
            {
                return null;
            }
        }

        // Consultar Tabla Usuario 
        public Task<List<TablaRegistro>> ConsultarUsuario()
        {
            return db.Table<TablaRegistro>().ToListAsync();
        }
       
        // COnsultanto registros segun el ID ingresado
        public Task<TablaRegistro> ConsultarUsuaruioById(string T_Correo, string T_Contraseña)
        {
            return db.Table<TablaRegistro>().Where(a => a.T_NomUsuario == T_Correo).Where(b => b.T_Contraseña == T_Contraseña ).FirstOrDefaultAsync();
        }      
    }///
}
