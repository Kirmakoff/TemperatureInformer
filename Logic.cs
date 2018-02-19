using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Data.Entity.Infrastructure;
using TemperatureInformer;

namespace TemperatureInformer
{
    class Logic
    {
        private string FilesDirectory;
        private DataBaseLogic _dbLogic;

        public Logic()
        {
            Initialize();
        }

        private void Initialize()
        {
            FilesDirectory = Properties.Settings.Default.FilesDirectory;
            _dbLogic = new DataBaseLogic();
            SimpleLogger.Initialize();
        }

    }


    class DataBaseLogic
    {
        SQLiteConnection _connection;
        SQLiteConnectionStringBuilder _connectionSB;
        DbContext _dbContext;

        public void Init()
        {
            _connection = new SQLiteConnection(
@"data source=C:\test\new\TemperatureInformerDB.sqlite3");
        }


        public DateTime? GetLastMessageDate()
        {
            using (var context = new DataBaseDataContext())
            {
                //context.
            }
            return null;
        }
    }

    public class DataBaseDataContext : DbContext
    {
        //public DataBaseDataContext() : base() //("TemperatureInformerDb")
        //{ }

        //public DbSet<Interval> Intervals { get; set; }
    }


}
