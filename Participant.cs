using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOPAssignment_G12
{
    internal class Participant
    {
        private int _competitionId;
        private string _username;
        private string _results;

        public int CompetitionId { get => _competitionId; set => _competitionId = value; }
        public string Username { get => _username; set => _username = value; }
        public string Results { get => _results; set => _results = value; }

        public Participant(int competitionId, string username, string results)
        {
            _competitionId = competitionId;
            _username = username;
            _results = results;
        }
    }
}
