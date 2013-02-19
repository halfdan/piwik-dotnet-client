using System;
using System.Text;


namespace Piwik
{
    public class Tracker
    {        
        public const int Version = 1;
        private const int visitorIDLength = 16;

        private Uri apiUri = new Uri("http://demo.piwik.org");

        #region Constructors
        /// <summary>
        /// Creates a new Tracker instance.
        /// </summary>
        /// <param name="siteID">The ID of the website to track for (siteId)</param>
        /// <param name="apiUri">URL of the Piwik installation</param>
        public Tracker(uint siteID, String apiUri)
        {
            this.SiteID = siteID;
            this.apiUri = new Uri(apiUri);
            this.PageCharset = Encoding.UTF8;
        }

        /// <summary>
        /// Creates a new Tracker instance.
        /// </summary>
        /// <param name="siteID">The ID of the website to track for (siteId)</param>
        /// <param name="apiUri">URL of the Piwik installation</param>
        public Tracker(uint siteID, Uri apiUri)
        {
            this.SiteID = siteID;
            this.apiUri = apiUri;
            this.PageCharset = Encoding.UTF8;
        }
        #endregion

        public void SetNewVisitorID()
        {

        }


        public void TrackPageView(String title)
        {
        }

        public void TrackGoal(int goalID, double revenue)
        {
        }

        #region Properties

        /// <summary>
        /// Gets or sets the ID of the website to track for (siteId)
        /// </summary>
        public uint SiteID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the PageCharset used to transmit data to Piwik. Default: UTF-8
        /// </summary>
        public Encoding PageCharset
        {
            get;
            set;
        }

        public String TokenAuth
        {
            get;
            set
            {
                if (value.Length != 32)
                {
                    throw new ArgumentException("Token must be 32 characters long", "token");
                }
            }
        }

        #endregion
    }
}
