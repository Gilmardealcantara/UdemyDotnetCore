using System;
using System.Linq;
using System.Reflection;

namespace ITDeveloper.Mvc.Extencions.ExtencionsMethods {
    public static class EnumExtension {
        public static string GetDescription(this Enum _enum) {
            Type generEnumType = _enum.GetType();
            MemberInfo[] memberInfo = generEnumType.GetMember(_enum.ToString());
            if (memberInfo.Length <= 0)return _enum.ToString();
            var attrs = memberInfo[0].GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), inherit : false);
            return attrs.Any() ? ((System.ComponentModel.DescriptionAttribute)attrs.ElementAt(0)).Description : _enum.ToString();
        }
    }
}