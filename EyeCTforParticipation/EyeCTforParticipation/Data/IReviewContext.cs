using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeCTforParticipation.Models;

namespace EyeCTforParticipation.Data
{
    interface IReviewContext
    {
        List<ReviewModel> GetFromHelpSeeker(int id);
        List<ReviewModel> GetFromVolunteer(int id);
        int create(ReviewModel review);
        void update(ReviewModel review);
        void delete(ReviewModel review);
    }
}
