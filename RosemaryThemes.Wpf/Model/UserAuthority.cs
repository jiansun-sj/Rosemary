using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosemaryThemes.Wpf.Model
{
    public enum UserAuthority
    {
        /// <summary>
        /// 未授权用户
        /// </summary>
        UnAuthorized = 0,

        /// <summary>
        /// 访客
        /// </summary>
        Visitor = 1,

        /// <summary>
        /// 可以查看并修改
        /// </summary>
        Operator = 2,

        /// <summary>
        /// 管理员，可以修改帐号密码
        /// </summary>
        Administrator = 3
    }
}
