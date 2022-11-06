using Mrinmoy;

DocxUtils.WriteFile(@"C:\personal\Skills.docx");

var rawData = CsvUtils.GetRawDataFromCSV(@"C:\personal\Jugaad.csv");

var students = CsvUtils.GetStudentsFromRawData(rawData);

Console.WriteLine("Hello");




