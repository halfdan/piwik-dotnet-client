using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Piwik;

namespace PiwikTest
{
    [TestClass]
    public class TrackerTest
    {
        [TestMethod]
        public void ConstructorTest()
        {
            uint SiteID = 1;
            String apiUri = "http://demo.piwik.org";

            Tracker TrackerOne = new Tracker(SiteID, apiUri);
            Tracker TrackerTwo = new Tracker(SiteID, new System.Uri(apiUri));

            Assert.AreEqual(SiteID, TrackerOne.SiteID);
            Assert.AreEqual(SiteID, TrackerTwo.SiteID);
        }

        [TestMethod]
        [ExpectedException(typeof(UriFormatException),
            "An invalid URL was inappropriately allowed.")]
        public void InvalidURLInConstructor()
        {
            Tracker T = new Tracker(1, "foo");
        }
    }
}
