using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPatterns.Factory
{
    public class PlayerBuilderWithIdentityInfo
    {
        private readonly Player _player;
        private readonly PlayerBuilder _playerBuilder;

        public PlayerBuilderWithIdentityInfo(Player player, PlayerBuilder playerBuilder)
        {
            this._player = player;
            this._playerBuilder = playerBuilder;
        }
        public PlayerBuilder WithContactInfo(string address, string phoneNumber, string postalCode)
        {
            _player.Address = address;
            _player.PhoneNumber = phoneNumber;
            _player.PostalCode = postalCode;
            //return this; //return new playerBuilder() ?
            return _playerBuilder;
        }
    }
}
