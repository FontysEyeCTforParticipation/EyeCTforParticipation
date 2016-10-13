using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeCTforParticipation.Logic;
using EyeCTforParticipation.Data;
using EyeCTforParticipation.Models;

namespace EyeCTforParticipation.Controls
{
    public partial class SearchControl : UserControl
    {
        HelprequestRepository helpRequestRepository = new HelprequestRepository(new HelprequestSQLContext());
        List<HelprequestModel> results;
        public event EventHandler Search;

        public SearchControl()
        {
            InitializeComponent();
        }

        private void SearchControl_Load(object sender, EventArgs e)
        {
            //Get initial search results
            results = helpRequestRepository.Search();

            //Trigger search event
            if (Search != null)
            {
                Search(this, EventArgs.Empty);
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            //Get values
            string keywords = tbSearch.Text;
            string postalCode = tbPostalCode.Text;
            //int distance = Convert.ToInt32(cbDistance.Text);
            int distance = 0;

            //Check if values are valid as search filter
            bool keywordsValue = keywords.Length > 0;
            bool locationValue = postalCode.Length == 6 && distance > 0;

            //Call search method depending on search filters
            if (keywordsValue && locationValue)
            {
                results = helpRequestRepository.Search(keywords, postalCode, distance);
            } else if(keywordsValue)
            {
                results = helpRequestRepository.Search(keywords);
            } else if(locationValue)
            {
                results = helpRequestRepository.Search(postalCode, distance);
            } else
            {
                results = helpRequestRepository.Search();
            }
            
            //Trigger search event
            if (Search != null)
            {
                Search(this, EventArgs.Empty);
            }
        }

        public List<HelprequestModel> Results
        {
            get
            {
                return results;
            }

            set
            {
                results = value;
            }
        }
    }
}
