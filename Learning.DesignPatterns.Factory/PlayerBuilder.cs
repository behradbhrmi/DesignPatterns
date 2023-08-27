using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPatterns.Factory
{
    public class PlayerBuilder
    {
        private Player _player;
        private PlayerBuilderWithIdentityInfo _identityInfoBuilder;
        public PlayerBuilder()
        {
            _player = new Player();
            _identityInfoBuilder = new PlayerBuilderWithIdentityInfo(_player, this);
        }
        // builder.WithIdentityInfo(...).WithContactInfo(...).Build()
        public PlayerBuilderWithIdentityInfo WithIdentityInfo(string name, string lastName, string username)
        {
            _player.Name = name;
            _player.LastName = lastName;
            _player.UserName = username;
            //return this; //return playerBuilderWithIdentityInfo
            return _identityInfoBuilder;
        }
       
        public Player Build()
        {
            return _player;
        }
    }
}
