using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamsLib;

namespace SportSubClass
{
    class Tennis : Team
    {
        #region Private Class Fields
        private string reqEquipment;
        private string playingField;
        private int pointsToWin;
        #endregion Private Class Fields

        #region Public Properties
        public string ReqEquipment { get => reqEquipment; set => reqEquipment = value; }
        public string PlayingField { get => playingField; set => playingField = value; }
        public int PointsToWin { get => pointsToWin; set => pointsToWin = value; }
        #endregion Public Properties

        #region Constructors
        /// <summary>
        /// Default No-Arg
        /// </summary>
        public Tennis()
            : base()
        {
        }

        /// <summary>
        /// Builds Complete Tennis Team
        /// </summary>
        /// <param name="tName"></param>
        /// <param name="sName"></param>
        /// <param name="cName"></param>
        /// <param name="reqEquip"></param>
        /// <param name="plyField"></param>
        /// <param name="ptsToWin"></param>
        public Tennis(string tName, string sName, string cName, string reqEquip,
            string plyField, int ptsToWin)
            : base(tName, sName, cName)
        {
            reqEquipment = reqEquip;
            playingField = plyField;
            pointsToWin = ptsToWin;
        }
        #endregion Constructors

        #region Methods
        public override string ToString()
        {
            return base.ToString() + " " + reqEquipment;
        }

        public override int reqPlayers()
        {
            return 2;
        }
        #endregion Methods
    }

}
