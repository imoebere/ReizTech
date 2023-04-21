using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch
{
    public class AddBranch
    {
        public void BranchMethod()
        {
            var root = new BranchClass();

            // create some child branches
            var child1 = new BranchClass();
            var child2 = new BranchClass();
            var child3 = new BranchClass();


            // add the child branches to the root branch
            root.branches.Add(child1);
            root.branches.Add(child2);
            root.branches.Add(child3);

            // create some grandchild branches
            var grandchild1 = new BranchClass();
            var grandchild2 = new BranchClass();


            // add the grandchild branches to the first child branch
            child1.branches.Add(grandchild1);
            child1.branches.Add(grandchild2);

            int depth = Calculate.CalculateDepth(root);
            Console.WriteLine($"The depth of the structure is {depth}");
        }
    }
}
