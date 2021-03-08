using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetBound.Player
{
    public class Avatar
    {
        private byte[] avatarImg;
        private string code;

        public byte[] AvatarImg
        {
            get { return avatarImg; }
            private set { avatarImg = value; }
        }

        public string Code
        {
            get { return code; }
            private set { code = value; }
        }

        public Avatar()
        {
            Code = "default";
        }

        public Avatar(byte[] img, string username)
        {
            AvatarImg = img;
            Code = username + DateTime.Now.ToString("en-US");
        }

        public void Update(Avatar a)
        {
            if (a.Code != Code)
            {
                Code = a.Code;
                AvatarImg = a.AvatarImg;
            }
        }
    }
}
