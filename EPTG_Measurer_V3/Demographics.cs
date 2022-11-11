using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPTG_Measurer_V3
{
    internal partial class DemographicsGetter
    {
        private List<Demographic> demographics = new List<Demographic>();

        public DemographicsGetter(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                var lineParts = line.Split('\t');

                Gender gender;
                if (lineParts[2] == "Female")
                {
                    gender = Gender.Female;
                }
                else if (lineParts[2] == "Male")
                {
                    gender = Gender.Male;
                }
                else { gender = Gender.NotApplicable; }

                try
                {
                    bool dysplastic = false;
                    if(lineParts[3] == "1")
                    {
                        dysplastic = true;
                    }
                    demographics.Add(new Demographic(lineParts[0], int.Parse(lineParts[1]), gender, dysplastic));
                }
                catch (Exception ex)
                {

                }
            }
        }

        internal Demographic GetDemographic(string identifier)
        {
            return demographics.First(x => identifier.Contains(x.Identifier)); 
        }

    }

    public enum Gender
    {
        Female = 0,
        Male = 1,
        NotApplicable = 2,
    }

    internal class Demographic
    {
        internal string Identifier;
        internal int Age;
        internal Gender Gender;
        internal bool Dysplastic;

        public Demographic(string identifier, int age, Gender gender, bool dysplastic)
        {
            Identifier = identifier;
            Age = age;
            Gender = gender;
            Dysplastic = dysplastic;
        }
    }
}
