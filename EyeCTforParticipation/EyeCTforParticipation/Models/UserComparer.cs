using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCTforParticipation.Models
{
    public class UserComparer : IComparer<UserModel>
    {
        public int Compare(UserModel x, UserModel y)
        {
            return x.Name.CompareTo(y.Name);
        }

        public int CompareDESC(UserModel x, UserModel y)
        {
            return y.Name.CompareTo(x.Name);
        }

        public int CompareRoll(UserModel x, UserModel y)
        {
            return x.Role.CompareTo(y.Role);
        }

        public int CompareRollDESC(UserModel x, UserModel y)
        {
            return y.Role.CompareTo(x.Role);
        }
    }
}
