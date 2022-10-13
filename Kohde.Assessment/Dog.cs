using System.Xml.Linq;

namespace Kohde.Assessment
{
    public class Dog : CombinedAnima
    {
        public string Food { get; set; }

        public override string GetDetails()
        {
            return this.ToString();
        }

        public override string ToString()
        {
            return "Name: " + Name + "Age: " + Age + " Food: " + Food;
        }
    }
}