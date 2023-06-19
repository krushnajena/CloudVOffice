using CloudVOffice.Data.DTO.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Users
{
    public interface ITokenService
    {
        public string CreateNewRefreshToken(TokenDTO tokenDTO);
        public string GetRefreshToken(RefreshTokenDTO tokenDTO);
    }
}
