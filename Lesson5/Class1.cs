using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson5
{
    class Employee
    {
        public static int CURRENT_YEAR = 2021;

            public string surName { get; set; }
            public string secondName { get; set; }
            public string name { get; set; }
             public string phon { get; set; }
            public int birthYear { get; set; }

            public Employee (string name,
                string secondName,
                string surName,
                string phon,
                int birthYear)
        {
            this.birthYear = birthYear;
            this.name = name;
            this.secondName = secondName;
            this.surName = surName;
            this.phon = phon;

        }
        public int getAge()
        {
            return CURRENT_YEAR - birthYear;
        }
        public string GetFullInfo()
        {
            return
                this.name + "  " +
                this.secondName + " " +
                this.surName + " ," +
                this.getAge() + "  лет" +
                this.phon + "  тедефон";
        }

    }
}
