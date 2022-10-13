namespace Kohde.Assessment
{
    public class Cat : CombinedAnima
    {
        public string Food { get; set; }

        public override string GetDetails()
        {
            return this.ToString();
        }

        public override string ToString()
        {
            return "Name: " + this.Name + " Age: " + this.Age + " Food: " + this.Food;
        }
    }
}