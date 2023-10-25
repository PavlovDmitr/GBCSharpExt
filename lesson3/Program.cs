using System.Reflection;

namespace lesson3
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    //internal class FamilyMember2
    //{
    //    FamilyMember2 Mother { get; set; }
    //    FamilyMember2 Father { get; set; }
    //    string Name { get; set; }
    //    bool IsHaveChild { get; set; }
    //    uint Age { get; set; }
    //    gender Gender { get; set; }

    //    internal string GetAncestor()
    //    {
    //        return Mother.Name + "." + Father.Name;
    //    }
    //}






    //public enum Gender
    //{
    //    Male,
    //    Female
    //}

    //public class FamilyMember
    //{
    //    //public FamilyMember[] Parents { get; set; }
    //    public FamilyMember Mother { get; set; }
    //    public FamilyMember Father { get; set; }
    //    public string Name { get; set; }
    //    public Gender Sex { get; set; }

    //    public void ShowParents()
    //    {

    //    }
    //}

    //public class AdultFamilyMember : FamilyMember
    //{
    //    public FamilyMember[] Children { get; set; }
    //}
}