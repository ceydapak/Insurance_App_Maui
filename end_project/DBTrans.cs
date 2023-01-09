using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace end_project
{
    public class DBTrans
    {
        public string path;
        private SQLiteConnection con;

        public DBTrans(string _dbpath)
        {
            path = _dbpath;
        }
        public void Init()
        {
            con = new SQLiteConnection(path);
            con.CreateTable<Doctor>();
            con.CreateTable<Claim>();
            con.CreateTable<Visit>();
            con.CreateTable<Patient>();
            con.CreateTable<InsuranceCompany>();

        }

       
        public List<Patient> GetPatients()
        {
            Init();
            return con.Table<Patient>().ToList();

        }
       
        public List<InsuranceCompany> GetCompany()
        {
            Init();
            //Company();
            return con.Table<InsuranceCompany>().ToList();

        }
        public List<Doctor> GetDoctors()
        {
            Init();
            //Doctor();
            return con.Table<Doctor>().ToList();

        }

        public List<Visit> GetVisits()
        {
            Init();
            //Visit();
            return con.Table<Visit>().ToList();

        }

        public List<Claim> GetClaims()
        {
            Init();
            return con.Table<Claim>().ToList();

        }


        //Inserting

        public void InsertPatient(Patient patient)
        {
            con = new SQLiteConnection(path);
            con.Insert(patient);

        }
        public void InsertClaim(Claim claim)
        {
            con = new SQLiteConnection(path);
            con.Insert(claim);

        }
        public void InsertVisit(Visit visit)
        {
            con = new SQLiteConnection(path);
            con.Insert(visit);

        }

        public void InsertDoctor(Doctor doctor)
        {
            con = new SQLiteConnection(path);
            con.Insert(doctor);
          
        }


        public void InsertCompany(InsuranceCompany com)
        {
            con = new SQLiteConnection(path);
            con.Insert(com);

        }
        //Delete

        //public void DeletePatient(int id)
        //{
        //    con = new SQLiteConnection(path);
        //    con.Delete(new Patient { PatientId = id });

        //}
        //public void DeleteClaim(int id)
        //{
        //    con = new SQLiteConnection(path);
        //    con.Delete(new Claim { ClaimId = id });

        //}

        //Creating Manuelly

        public void Doctor()
        {
            var doctor = new Doctor();
            doctor.DEmail = "ismail@gmail.com";
            doctor.DName = "Ismail Okan";
            doctor.DImg = "doctor1.jpg";

            var doctor2 = new Doctor();
            doctor2.DEmail = "cevdet@gmail.com";
            doctor2.DName = "Cevdet Uzun";
            doctor2.DImg = "doctor3.jpeg";

            var doctor3 = new Doctor();
            doctor3.DEmail = "ayse@gmail.com";
            doctor3.DName = "Ayse Uzun";
            doctor3.DImg = "doctor2.jpeg";


            InsertDoctor(doctor);
            InsertDoctor(doctor2);
            InsertDoctor(doctor3);
           
        }

      
      

        public void Company()
        {
            var com1 = new InsuranceCompany();
            var com2 = new InsuranceCompany();

            com1.Code = "A15";
            com1.CompanyName = "Security Insurance Company";
            com1.CompanyAddress = "Istanbul/Turkey";
            com1.CompanyPhone = "5555555555";
            com1.RepresentiveName = "Ceyda Pak";


            com2.Code = "C18";
            com2.CompanyName = "Desert Insurance Company";
            com2.CompanyAddress = "Ankara/Turkey";
            com2.CompanyPhone = "5555557775";
            com2.RepresentiveName = "Ceyda Ateş";

            InsertCompany(com1);
            InsertCompany(com2);
        }

        public void Visit()
        {
            var vis1 = new Visit();
            var vis2 = new Visit();
            var vis3 = new Visit();

            vis1.DoctorName = "Ismail Okan";
            vis2.DoctorName = "Ismail Okan";
            vis3.DoctorName = "Ismail Okan";

            vis1.VisitDate = DateTime.Today;
            vis2.VisitDate = new DateTime(2022, 3, 1, 08, 30, 0);
            vis3.VisitDate = new DateTime(2022, 7, 8, 10, 0, 0);


            vis1.VisitResult = "FEELING THIRSTY";
            vis2.VisitResult = "DIARRHEA";
            vis3.VisitResult = "COUGH";

            vis1.VisitCost = 120;
            vis2.VisitCost = 120;
            vis2.VisitCost = 160;

            
            InsertVisit(vis1);
            InsertVisit(vis2);
            InsertVisit(vis3);

        }
    }
}
