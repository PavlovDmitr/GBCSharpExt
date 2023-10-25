using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Спроектируйте программу для построения генеалогического дерева.
//Учтите что у нас есть члены семьи у кого нет детей(дет).
//Есть члены семьи у кого дети есть (взрослые).
//Есть мужчины и женщины.

namespace lesson3
{
    enum Gender
    {
        Male,
        Female,
        nonSelect

    }
    public class FamilyMember
    {
        FamilyMember Father { get; set; }
        FamilyMember Mather { get; set; }
        FamilyMember[] Childs { get; set; }
        private int childsCount;
        Gender Gender { get; set; }
        string Name { get; set; }

        void GetInfo()
        {
            Console.WriteLine($"Name - {this.Name}");
        }


        public virtual void Print(int indent = 0)
        {
            GetInfo();
        }

        public void setChilds(FamilyMember child) 
        {
            this.Childs.Append(child);
            childsCount++;
        }
            

    }

    public class AdultFamilyMember : FamilyMember
    {
        public FamilyMember[] Children { get; set; }
        public override void Print(int indent = 0)
        {
            base.Print(indent);

            foreach (var child in Children)
                child.Print(indent * 2);
        }

    }
}
