using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace TestApplication
{
    public class PatientRepository
    {
        SQLiteConnection database;
        public PatientRepository(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Patient>();
        }
        public IEnumerable<Patient> GetItems()
        {
            return database.Table<Patient>().ToList();
        }
        public Patient GetItem(int id)
        {
            return database.Get<Patient>(id);
        }
        public int DeleteItem(int id)
        {
            return database.Delete<Patient>(id);
        }
        public int SaveItem(Patient item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}
