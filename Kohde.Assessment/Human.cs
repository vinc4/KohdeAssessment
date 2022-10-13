namespace Kohde.Assessment
{
    public class Human : CombinedAnima
    {
        public string Gender { get; set; }

        public override string ToString()
        {
            return "Name: " + Name + "Age: " + Age + " Gender" + Gender;
        }

        public override string GetDetails()
        {
            return this.ToString();
        }
    }
}