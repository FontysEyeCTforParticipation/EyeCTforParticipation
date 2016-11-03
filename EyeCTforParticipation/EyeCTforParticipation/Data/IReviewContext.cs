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
        //List<ReviewModel> Search(HelpSeeker helpSeeker);
        //List<ReviewModel> Search(Volunteer volunteer);
        ReviewModel get(int id);
        int create(ReviewModel review);
        void update(ReviewModel review);
        void delete(ReviewModel review);
    }
}
