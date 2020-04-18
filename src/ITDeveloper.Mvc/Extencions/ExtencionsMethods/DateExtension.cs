using System;
namespace ITDeveloper.Mvc.Extensions.ExtensionsMethods {
    public static class DateExtension {
        public static string ToBrazilianDate(this DateTime value) {
            return value.ToString(format: "dd/MM/yyyy");
        }

        public static string ToBrazilianDateTime(this DateTime value) {
            return value.ToString(format: "dd/MM/yyyy hh:MM:ss");
        }
    }
}