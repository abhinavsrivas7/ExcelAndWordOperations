using CsvHelper;
using Mrinmoy.Models.CSV;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mrinmoy
{
    public class CsvUtils
    {
        public static List<RawCsv> GetRawDataFromCSV(string path)
        {
            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                return csv.GetRecords<RawCsv>().ToList();
            }
        }

        public static List<Student> GetStudentsFromRawData(List<RawCsv> rawData)
        {
            List<Student> students = new List<Student>();
            
            foreach(RawCsv raw in rawData)
            {
                students.Add(new Student()
                {
                    Name = raw.Name,
                    ApplicationFormNo = raw.ApplicationFormNo,
                    FacultyOfStudy = raw.FacultyOfStudy,
                    DateOfBirth = raw.DateOfBirth,
                    Qualifications = GetQualificationsFromRawData(raw),
                    LabPreferences = GetLabPreferencesFromRawData(raw),
                    Fellowships = GetFellowshipsFromRawData(raw)
                });
            }

            return students;    
        }

        private static List<string> GetFellowshipsFromRawData(RawCsv rawData)
        {
            var fellowships = new List<string>();

            fellowships.Add(rawData.Fellowship1);
            fellowships.Add(rawData.Fellowship2);
            fellowships.Add(rawData.Fellowship3);
            fellowships.Add(rawData.Fellowship4);
            fellowships.Add(rawData.Fellowship5);
            fellowships.Add(rawData.Fellowship6);
            fellowships.Add(rawData.Fellowship7);
            fellowships.Add(rawData.Fellowship8);
            fellowships.Add(rawData.Fellowship9);
            fellowships.Add(rawData.Fellowship10);
            fellowships.Add(rawData.Fellowship11);
            fellowships.Add(rawData.Fellowship12);
            fellowships.Add(rawData.Fellowship13);
            fellowships.Add(rawData.Fellowship14);
            fellowships.Add(rawData.Fellowship15);
            fellowships.Add(rawData.Fellowship16);
            fellowships.Add(rawData.Fellowship17);

            return fellowships;
        }

        private static List<string> GetLabPreferencesFromRawData(RawCsv rawData)
        {
            var labPreferences = new List<string>();

            labPreferences.Add(rawData.LabPreferences1);
            labPreferences.Add(rawData.LabPreferences2);
            labPreferences.Add(rawData.LabPreferences3);

            return labPreferences;
        }

        private static List<Qualification> GetQualificationsFromRawData(RawCsv rawData)
        {
            var qualifications = new List<Qualification>();

            qualifications.Add(new Qualification()
            {
                QualificationName = rawData.Qualification1,
                Board = rawData.Board1,
                CGPA = rawData.CGPA1,
                YearOfPassing = rawData.YearOfPassing1,
            });

            qualifications.Add(new Qualification()
            {
                QualificationName = rawData.Qualification2,
                Board = rawData.Board2,
                CGPA = rawData.CGPA2,
                YearOfPassing = rawData.YearOfPassing2,
            });

            qualifications.Add(new Qualification()
            {
                QualificationName = rawData.Qualification3,
                Board = rawData.Board3,
                CGPA = rawData.CGPA3,
                YearOfPassing = rawData.YearOfPassing3,
            });

            qualifications.Add(new Qualification()
            {
                QualificationName = rawData.Qualification4,
                Board = rawData.Board4,
                CGPA = rawData.CGPA4,
                YearOfPassing = rawData.YearOfPassing4,
            });

            return qualifications;
        }
    }
}
