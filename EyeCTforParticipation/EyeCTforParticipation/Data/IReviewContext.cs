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
        int Create(ReviewModel review);
        int CreateReply(ReviewReplyModel reviewreplymodel);
        void Update(ReviewModel review);
        void UpdateReply(ReviewReplyModel reviewreplymodel);
        void Delete(int Id);
    }
}
