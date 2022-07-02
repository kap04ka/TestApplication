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
            //создание таблиц в бд
            database.CreateTable<Patient>();
            database.CreateTable<ScoreMFI20>();
            database.CreateTable<TestCorrectionBourdon>();
            database.CreateTable<ResultMOSA>();
            database.CreateTable<ResultPraxisAndGnosis>();
            database.CreateTable<ResultVasserman>();
            database.CreateTable<ResultAnxietyAndDepression>();
            database.CreateTable<ResultLocus>();
            database.CreateTable<ResultLifeQuality>();
            database.CreateTable<CovidTest>();
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
            //обновление данных в одном сеансе 
            if (item.Id != 0)
            {
                database.Update(item);
                
                database.Update(item.scoreMFI20);
                database.Update(item.scoreBourdon);
                database.Update(item.resultMOSA);
                database.Update(item.resultPraxisAndGnosis);
                database.Update(item.resultVasserman);
                database.Update(item.resultAnxietyAndDepression);
                database.Update(item.resultLocus);
                database.Update(item.resultLifeQuality);
                database.Update(item.resultCovidTest);

                return item.Id;
            }
            //заносим данные впервые
            else
            {
                database.Insert(item);

                item.scoreMFI20.IdPatient = item.Id;
                item.scoreBourdon.IdPatient = item.Id;
                item.resultMOSA.IdPatient = item.Id;
                item.resultPraxisAndGnosis.IdPatient = item.Id;
                item.resultVasserman.IdPatient = item.Id;
                item.resultAnxietyAndDepression.IdPatient = item.Id;
                item.resultLocus.IdPatient = item.Id;
                item.resultLifeQuality.IdPatient = item.Id;
                item.resultCovidTest.IdPatient = item.Id;

                database.Insert(item.scoreMFI20);
                database.Insert(item.scoreBourdon);
                database.Insert(item.resultMOSA);
                database.Insert(item.resultPraxisAndGnosis);
                database.Insert(item.resultVasserman);
                database.Insert(item.resultAnxietyAndDepression);
                database.Insert(item.resultLocus);
                database.Insert(item.resultLifeQuality);
                database.Insert(item.resultCovidTest);

                return item.Id;
            }
        }
    }
}