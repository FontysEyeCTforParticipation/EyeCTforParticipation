using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCTforParticipation
{
    class ReviewModel
    {
        //fields
        private string title;
        private string content;

        //property accessor
        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }
        public string Content
        {
            get
            {
                return content;
            }

            set
            {
                content = value;
            }
        }

        //constructor
        public ReviewModel(string title, string content)
        {
            Title = title;
            Content = content;
        }
    }
}
