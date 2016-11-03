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
        int createReply(ReviewReplyModel reviewreplymodel);
        void update(ReviewModel review);
        void updateReply(ReviewReplyModel reviewreplymodel);
        void delete(int Id);
    }
}
