using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch
{
    public class Calculate
    {
        public static int CalculateDepth(BranchClass branch)
        {
            if (branch.branches.Count == 0)
            {
                // base case: no child branches
                return 1;
            }
            else
            {
                // recursive case: find the maximum depth of the child branches
                int maxChildDepth = 0;
                foreach (BranchClass child in branch.branches)
                {
                    int childDepth = CalculateDepth(child);
                    if (childDepth > maxChildDepth)
                    {
                        maxChildDepth = childDepth;
                    }
                }
                // add 1 to account for the current branch
                return maxChildDepth + 1;
            }
        }
    }
}
