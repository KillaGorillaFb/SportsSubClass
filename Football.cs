using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamsLib;

namespace SportSubClass
{
    class Football : Team
    {
        #region Private Class Fields
        private string reqTurfType;
        private string teamLocation;
        private int reqPlayerWeight;
        #endregion Private Class Fields
        
        #region Public Properties
        public string ReqTurfType { get => reqTurfType; set => reqTurfType = value; }
        public string TeamLocation { get => teamLocation; set => teamLocation = value; }
        public int ReqPlayerWeight { get => reqPlayerWeight; set => reqPlayerWeight = value; }
        #endregion Public Properties

        #region Constructors
        /// <summary>
        /// Default No-Arg
        /// </summary>
        public Football()
            : base ()
        {
        }

        /// <summary>
        /// Creates Complete Football Team
        /// </summary>
        /// <param name="tName"></param>
        /// <param name="sName"></param>
        /// <param name="cName"></param>
        /// <param name="rTurf"></param>
        /// <param name="tLoc"></param>
        /// <param name="rPlyrWt"></param>
        public Football(string tName, string sName, string cName, string rTurf, string tLoc, int rPlyrWt)
            : base (tName, sName, cName)
        {
            reqTurfType = rTurf;
            teamLocation = tLoc;
            reqPlayerWeight = rPlyrWt;
        }
        #endregion Constructors

        #region Methods
        public override string ToString()
        {
            return base.ToString() + " " + reqTurfType;
        }

        public override int reqPlayers()
        {
            return 11;
        }
        #endregion Methods
    }
}
