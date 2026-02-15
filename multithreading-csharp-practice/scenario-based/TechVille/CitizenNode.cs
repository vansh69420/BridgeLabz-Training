namespace TechVille
{
    public class CitizenNode
    {
        public Citizen Data;
        public CitizenNode Next;
        public CitizenNode Previous;

        public CitizenNode(Citizen citizen)
        {
            Data = citizen;
            Next = null;
            Previous = null;
        }
    }
}
