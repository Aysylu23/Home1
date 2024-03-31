using Home1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home1
{
    enum Gender { Male, Female };
    internal class FamilyMember
    {
        public FamilyMember Mother { get { return mother; } set { mother = value; } }
        public FamilyMember Father { get { return father; } set { father = value; } }
        public string Name { get { return name; } set { name = value; } }
        public Gender Sex { get { return sex; } set { sex = value; } }
        public ListT<FamilyMember> Children { get; }



        FamilyMember mother;
        FamilyMember father;
        string name;
        Gender sex;
        ListT<FamilyMember> children;

        public void MothersLine()
        {
            if (sex == Gender.Female)
                Console.WriteLine(name);
            MothersLinePrivate();
        }
        private void MothersLinePrivate()
        {
            if (mother != null)
            {
                Console.WriteLine(mother.name);
                mother.MothersLinePrivate();
            }
        }

        public void Relation()
        {
            Console.WriteLine($" - Я: {this.Name}");
            if (father != null) Console.WriteLine($" - Папа: {father.Name}");
            if (mother != null) Console.WriteLine($" - Мама: {mother.Name}");
            if (father != null && mother != null)
            {
                if (father != null)
                {
                    foreach (var child in father.children)
                    {
                        if (child.mother.Equals(this.mother))
                        {
                            if (!this.Equals(child))
                            {
                                if (child.Sex == Gender.Female)
                                {
                                    Console.WriteLine($" - Сестра: {child.Name}");
                                }
                                else
                                {
                                    Console.WriteLine($" - Брат: {child.Name}");
                                }

                            }
                        }
                    }

                }
                if (mother != null)
                {
                    foreach (var child in mother.children)
                    {
                        if (child.Sex == Gender.Female)
                        {
                            Console.WriteLine($" - Сестра: {child.Name}");
                        }
                        else
                        {
                            Console.WriteLine($" - Брат: {child.Name}");
                        }
                    }


                }

            }
            if (this.children != null)
            {
                foreach (var child in this.children)
                {
                    if (child.Sex == Gender.Female)
                    {
                        Console.WriteLine($" - Дочь: {child.Name}");
                    }
                    else
                    {
                        Console.WriteLine($" - Сын: {child.Name}");
                    }
                }
            }
        }

        public void AddChild(FamilyMember child)
        {
            if (child != null)
                children.Add(child);
        }

        public FamilyMember()
        {
            children = new ListT<FamilyMember>();
        }

        public FamilyMember(FamilyMember Mother, FamilyMember Father, string Name, Gender Sex)
        {
            children = new ListT<FamilyMember>();
            this.mother = Mother;
            this.father = Father;
            this.name = Name;
            this.sex = Sex;
        }
    }

}
























































