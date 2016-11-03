using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeCTforParticipation.Models;

namespace EyeCTforParticipation.Data
{
    class ReviewSQLContext : IReviewContext
    {
        public int create(ReviewModel review)
        {
            throw new NotImplementedException();
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ReviewModel> GetFromHelpSeeker(int id)
        {
            throw new NotImplementedException();
        }

        public List<ReviewModel> GetFromVolunteer(int id)
        {
            throw new NotImplementedException();
        }

        public void update(ReviewModel review)
        {
            throw new NotImplementedException();
        }
    }
}
