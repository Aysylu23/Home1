using Home1;
using System.Reflection;

namespace Home1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var grandMother = new FamilyMember() { Mother = null, Father = null, Name = "Мария", Sex = Gender.Female };
            var grandFather = new FamilyMember() { Mother = null, Father = null, Name = "Георгий", Sex = Gender.Male };
            var father = new FamilyMember() { Mother = null, Father = null, Name = "Александр", Sex = Gender.Male };
            var mother = new FamilyMember() { Mother = grandMother, Father = grandFather, Name = "Евгения", Sex = Gender.Female };
            grandMother.AddChild(mother);
            grandFather.AddChild(mother);
            var son = new FamilyMember() { Mother = mother, Father = father, Name = "Артем", Sex = Gender.Male };
            var daughter = new FamilyMember() { Mother = mother, Father = father, Name = "Алина", Sex = Gender.Female };

            mother.AddChild(son);
            father.AddChild(son);
            father.AddChild(daughter);
            mother.AddChild(daughter);

            //daughter.MothersLine();
            son.Relation();
        }
    }
}

