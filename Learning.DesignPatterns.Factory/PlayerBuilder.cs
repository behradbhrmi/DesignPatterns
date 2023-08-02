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
        public PlayerBuilder()
        {
            _player = new Player();
        }
        public PlayerBuilder WithIdentityInfo(string name, string lastName, string username)
        {
            _player.Name = name;
            _player.LastName = lastName;
            _player.UserName = username;
            return this;
        }
        public PlayerBuilder WithContactInfo(string address, string phoneNumber, string postalCode)
        {
            _player.Address = address;
            _player.PhoneNumber = phoneNumber;
            _player.PostalCode = postalCode;
            return this;
        }
        public Player Build()
        {
            return _player;
        }
    }
}
