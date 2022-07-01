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
            database.CreateTable<ScoreMFI20>();
            database.CreateTable<TestCorrectionBourdon>();
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

                database.Update(item.scoreMFI20);
                database.Update(item.scoreBourdon);

                return item.Id;
            }
            else
            {
                database.Insert(item);

                item.scoreMFI20.IdPatient = item.Id;
                item.scoreBourdon.IdPatient = item.Id;

                database.Insert(item.scoreMFI20);
                database.Insert(item.scoreBourdon);

                return item.Id;
            }
        }
    }
}