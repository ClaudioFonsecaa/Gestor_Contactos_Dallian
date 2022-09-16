using Gestor_Contactos_Dallian.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Gestor_Contactos_Dallian
{
    public class SQLiteHelper
    {
        private readonly SQLiteAsyncConnection db;

        public SQLiteHelper(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath); //Criar as tabelas da base de dados
            db.CreateTableAsync<Festivais>();
            db.CreateTableAsync<Locais>();
            db.CreateTableAsync<Promotores>();
        }

                //Funções para adicionar -----------------------------------------------
                public Task<int> AdicionarFestival(Festivais festival)
                {
                    return db.InsertAsync(festival);
                }

                public Task<int> AdicionarLocal(Locais local)
                {
                    return db.InsertAsync(local);
                }

                public Task<int> AdicionarPromotor(Promotores promotor)
                {
                    return db.InsertAsync(promotor);
                }

                //Funções para ler -----------------------------------------------


                public Task<List<Festivais>> VerFestivais()
                {
                    return db.Table<Festivais>().ToListAsync();
                }

                public Task<List<Locais>> VerLocais()
                {
                    return db.Table<Locais>().ToListAsync();
                }

                public Task<List<Promotores>> VerPromotores()
                {
                    return db.Table<Promotores>().ToListAsync();
                }

                //Funções para remover -----------------------------------------------

                public Task<int> ApagarFestival(Festivais festival)
                {
                    return db.DeleteAsync(festival);
                }

                public Task<int> ApagarLocal(Locais local)
                {
                    return db.DeleteAsync(local);
                }

                public Task<int> ApagarPromotor(Promotores promotor)
                {
                    return db.DeleteAsync(promotor);
                }


                //Funções para atualizar -----------------------------------------------

                public Task<int> atualizarFestival(Festivais festival)
                {
                    return db.UpdateAsync(festival);
                }

                public Task<int> atualizarLocal(Locais local)
                {
                    return db.UpdateAsync(local);
                }

                public Task<int> atualizarPromotor(Promotores promotor)
                {
                    return db.UpdateAsync(promotor);
                }

                //Funções para procurar por nome -----------------------------------------------

                public Task<List<Festivais>> ProcurarFestivais(string search)
                {
                    return db.Table<Festivais>().Where(p => p.Name.StartsWith(search)).ToListAsync();
                }

                public Task<List<Locais>> ProcurarLocais(string search)
                {
                    return db.Table<Locais>().Where(p => p.Name.StartsWith(search)).ToListAsync();
                }

                public Task<List<Promotores>> ProcurarPromotores(string search)
                {
                    return db.Table<Promotores>().Where(p => p.Name.StartsWith(search)).ToListAsync();
                }

                //Funções para procurar por pais -----------------------------------------------

                public Task<List<Festivais>> ProcurarPaisFestivais(string pais)
                {
                    return db.Table<Festivais>().Where(p => p.Pais.Equals(pais)).ToListAsync();
                }

                public Task<List<Locais>> ProcurarPaisLocais(string pais)
                {
                    return db.Table<Locais>().Where(p => p.Pais.Equals(pais)).ToListAsync();
                }

                public Task<List<Promotores>> ProcurarPaisPromotores(string pais)
                {
                    return db.Table<Promotores>().Where(p => p.Pais.Equals(pais)).ToListAsync();
                }

                //Funções para procurar por ID -----------------------------------------------


                public Task<List<Festivais>> ProcurarIDFestivais(int id)
                {
                    return db.Table<Festivais>().Where(p => p.Id.Equals(id)).ToListAsync();
                }

                public Task<List<Locais>> ProcurarIDLocais(int id)
                {
                    return db.Table<Locais>().Where(p => p.Id.Equals(id)).ToListAsync();
                }

                public Task<List<Promotores>> ProcurarIDPromotores(int id)
                {
                     return db.Table<Promotores>().Where(p => p.Id.Equals(id)).ToListAsync();
                }
    }
}