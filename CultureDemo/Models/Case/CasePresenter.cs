namespace CultureDemo.Models.Case
{
    public class CasePresenter
    {
        public List<CaseBO> GeneratedCaseList()
        {
            var rnd = new Random();
            var generatedCaseList = new List<CaseBO>();

            for (int i = 1; i < Convert.ToInt32(rnd.Next(20, 30)); i++)
            {
                generatedCaseList.Add(new CaseBO()
                {
                    Case_Name = Faker.Company.Name(),
                    Case_Description = Faker.Lorem.Paragraph(),
                    Case_Status = StatusGenerator(),
                    Case_CreatedDateT = DateTGenerator(),
                    Case_ModifiedDateT = DateTGenerator(),
                    User_CreatedBy = Faker.Name.FullName(),
                    User_ModifiedBy = Faker.Name.FullName()
                });
            }

            return generatedCaseList;
        }

        public string DateTGenerator()
        {
            var rndYear = new Random();
            var year = rndYear.Next(2020, 2022);

            var rndMonth = new Random();
            var month = rndMonth.Next(1, 12);

            var rndDay = new Random();
            var day = rndDay.Next(1, 28);

            var rndHour = new Random();
            var hour = rndHour.Next(1, 13);

            var rndMinute = new Random();
            var minute = rndMinute.Next(1, 60);

            var rndSecond = new Random();
            var second = rndSecond.Next(1, 60);

            return new DateTime(year, month, day, hour, minute, second).ToShortDateString();
        }
        public string StatusGenerator()
        {
            var rnd = new Random();

            return rnd.Next(1, 6) switch
            {
                1 => "New",
                2 => "Active",
                3 => "Pending",
                4 => "Denied",
                5 => "Resolved",
                _ => "Active",
            };
        }
        public string FullNameGenerator()
        {
            return Faker.Name.FullName();
        }

        public bool IsCaseValid(CaseBO caseDetails)
        {
            string[] stringArray =
            {
                caseDetails.Case_Name,
                caseDetails.Case_Description,
                caseDetails.User_LastName,
                caseDetails.User_FirstName,
            };

            return stringArray != null || stringArray.Length != 0;
        }

        public bool HasValue(string toCheck)
        {
            return !string.IsNullOrWhiteSpace(toCheck);
        }

        public CaseBO PopulateCreateDummyData(CaseBO caseDetails)
        {
            caseDetails.Case_Status = "New";
            caseDetails.Case_CreatedDateT = DateTime.Now.ToShortDateString();
            caseDetails.User_CreatedBy = $"{caseDetails.User_FirstName} {caseDetails.User_LastName}";

            return caseDetails;
        }
    }
}
