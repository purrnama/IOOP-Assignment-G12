using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOPAssignment_G12
{
    internal class Recommendation
    {
        private string _memberUsername;
        private string _coachUsername;

        public string MemberUsername { get => _memberUsername; set => _memberUsername = value; }
        public string CoachUsername { get => _coachUsername; set => _coachUsername = value; }

        public Recommendation(string memberUsername, string coachUsername)
        {
            _memberUsername = memberUsername;
            _coachUsername = coachUsername;
        }
    }
}
