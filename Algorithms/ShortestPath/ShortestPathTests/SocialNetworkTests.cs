using ShortestPath.SocialNetwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ShortestPathTests
{
    public class SocialNetworkTests
    {
        [Fact]
        public void TestShortestPathToFriend()
        {
            var batman = new PersonVertex("Batman");
            var superMan = new PersonVertex("Superman");
            var wonderWoman = new PersonVertex("Wonder Woman");
            var aquaman = new PersonVertex("Aquaman");
            var flash = new PersonVertex("Flash");
            var wonderTwins = new PersonVertex("Wonder Twins");

            batman.AddFriend(superMan);
            batman.AddFriend(wonderWoman);

            superMan.AddFriend(batman);
            superMan.AddFriend(aquaman);
            superMan.AddFriend(wonderWoman);

            aquaman.AddFriend(superMan);
            aquaman.AddFriend(wonderTwins);
            aquaman.AddFriend(flash);

            flash.AddFriend(wonderWoman);

            wonderWoman.AddFriend(batman);
            wonderWoman.AddFriend(flash);
            wonderWoman.AddFriend(wonderTwins);

            wonderTwins.AddFriend(wonderWoman);

            var friendPath = SocialNetwork.GetShortestPathToFriend(batman, aquaman);
            Assert.Collection(friendPath, new Action<string>[]
            {
                (s) => Assert.Equal(batman.Name, s),
                (s) => Assert.Equal(superMan.Name, s),
                (s) => Assert.Equal(aquaman.Name, s)
            });
        }
    }
}
